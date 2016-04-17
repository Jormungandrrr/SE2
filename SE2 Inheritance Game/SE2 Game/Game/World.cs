using System;
using System.Diagnostics;
using System.Drawing;
using SE2_Game.Game.Map;
using SE2_Game.Entity;
using System.Collections.Generic;

namespace SE2_Game.Game
{
    public class World
    {
        public Grid Grid { get; private set; }
        public Player Player { get; private set; }
        public List<Item> ItemList = new List<Item>();
        public List<Enemy> EnemyList = new List<Enemy>();
        public List<ICarryable> Items = new List<ICarryable>();

        public static bool Exists = false;
        public static int borderSize = 1;
        public static Pen pen = new Pen(Color.Black, borderSize);
        public static Font font = new Font("Arial", 8);
        public static StringFormat stringFormat = new StringFormat();
        public bool GameWon
        {
            get
            {
                return this.Player.Position.Equals(this.Grid.GoalPosition);
            }
        }
        public bool GameOver
        {
            get
            {
                return this.Player.HitPoints == 0;
            }
        }


        /// <summary>
        /// The only existing world instance.
        /// </summary>
        public static World Instance
        {
            get
            {
                if (World.instance == null)
                {
                    World.instance = new World();
                }
                return World.instance;
            }
        }
        private static World instance;

        /// <summary>
        /// Get the time since the game is started. Use this value to time
        /// actions based on intervals, such as doing something every n seconds.
        /// </summary>
        public long Time { get { return this.stopwatch.ElapsedMilliseconds; } }
        private Stopwatch stopwatch = new Stopwatch();

        /// <summary>
        /// Private constructor to be able to ensure that only a single
        /// instance of this class is ever created.
        /// </summary>
        private World()
        {
        }

        /// <summary>
        /// Recreate the world with the given map and cell size.
        /// </summary>
        /// <param name="mapSize">The size of the map in pixels.</param>
        /// <param name="cellCount">The number of cells (width and height).</param>
        /// <param name="wallProbability">The chance that a cell will become
        /// a wall cell, expressed in a range from 0 to 100.</param>
        public void Create(Size mapSize, Size cellCount, int wallProbability, int enemycount)
        {
            this.Grid = new Grid(mapSize, cellCount, wallProbability);
            this.Player = new Player();
            for (int i = 0; i < enemycount; i++)
            {
                this.EnemyList.Add(new Enemy(World.Instance.Grid.FreePosition()));
            }
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Spikes(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new HealthPotion(World.Instance.Grid.FreePosition()));
            Exists = true;
            this.stopwatch.Start();   
        }
        public void Create(Size mapSize, int enemycount, List<string> map)
        {
            this.Grid = new Grid(map, mapSize);
            this.Player = new Player();
            for (int i = 0; i < enemycount; i++)
            {
                this.EnemyList.Add(new Enemy(World.Instance.Grid.FreePosition()));
            }
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Armour(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new Spikes(World.Instance.Grid.FreePosition()));
            this.ItemList.Add(new HealthPotion(World.Instance.Grid.FreePosition()));
            Exists = true;
            this.stopwatch.Start();
        }


        public void Update()
        {
            this.Player.Update();
            foreach (Enemy e in EnemyList)
            {
                e.Update();
                if (this.Player.Position.Equals(e.Position))
                {
                    this.Player.HitPoints -= 5;
                }
            }
            foreach (Item i in ItemList)
            {
                if (this.Player.Position.Equals(i.Position))
                {
                    switch (i.ItemType)
                    {
                        case Item.Type.Heal:
                            this.Player.HitPoints += i.Amount;
                            ItemList.Remove(i);
                            break;
                        case Item.Type.PDamage:
                            this.Player.HitPoints -= i.Amount;
                            break;
                        case Item.Type.Damage:
                            this.Player.HitPoints -= i.Amount;
                            ItemList.Remove(i);
                            break;
                        case Item.Type.Armour:
                            if ((GetWeight(Player) + i.Weight) <= Player.backpackSpace)
                            {
                                this.Player.Items.Add(i);
                                ItemList.Remove(i);
                            }
                            break;
                        default:
                            break;
                    }
                    return;
                }
                foreach (Enemy e in EnemyList)
                {
                    if (e.Position.Equals(i.Position))
                    {
                        switch (i.ItemType)
                        {
                            case Item.Type.Heal:
                                e.HitPoints += i.Amount;
                                ItemList.Remove(i);
                                break;
                            case Item.Type.PDamage:
                                e.HitPoints -= i.Amount;
                                break;
                            case Item.Type.Damage:
                                e.HitPoints -= i.Amount;
                                ItemList.Remove(i);
                                break;
                            case Item.Type.Armour:
                                if (GetWeight(e) >= e.backpackSpace)
                                {
                                    e.Items.Add(i);
                                    ItemList.Remove(i);
                                }
                                break;
                            default:
                                break;
                        }
                        if (e.hitPoints == 0) { EnemyList.Remove(e); }
                        return;
                    }
                }
                
            }
        }

        private int GetWeight(Character c)
        {
            int weight = 0;
            foreach (Item i in c.Items)
            {
                weight += i.Weight;
            }
            return weight;
        }

        public void Draw(Graphics g)
        {
            this.Grid.Draw(g);
            foreach (Enemy e in EnemyList)
            {
                e.Draw(g);
            }
            foreach (Item i in ItemList)
            {
                i.Draw(g);
            }
            this.Player.Draw(g);
        }
    }
}

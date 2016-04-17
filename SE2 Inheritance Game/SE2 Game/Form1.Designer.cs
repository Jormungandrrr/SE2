namespace SE2_Game
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.picGame = new System.Windows.Forms.PictureBox();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.btnSaveMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).BeginInit();
            this.SuspendLayout();
            // 
            // picGame
            // 
            this.picGame.Location = new System.Drawing.Point(12, 12);
            this.picGame.Name = "picGame";
            this.picGame.Size = new System.Drawing.Size(300, 300);
            this.picGame.TabIndex = 0;
            this.picGame.TabStop = false;
            this.picGame.Paint += new System.Windows.Forms.PaintEventHandler(this.picGame_Paint);
            // 
            // timerAnimation
            // 
            this.timerAnimation.Enabled = true;
            this.timerAnimation.Interval = 33;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // btnSaveMap
            // 
            this.btnSaveMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveMap.Location = new System.Drawing.Point(215, 318);
            this.btnSaveMap.Name = "btnSaveMap";
            this.btnSaveMap.Size = new System.Drawing.Size(88, 23);
            this.btnSaveMap.TabIndex = 1;
            this.btnSaveMap.Text = "Map Opslaan";
            this.btnSaveMap.UseVisualStyleBackColor = true;
            this.btnSaveMap.Click += new System.EventHandler(this.btnSaveMap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 348);
            this.Controls.Add(this.btnSaveMap);
            this.Controls.Add(this.picGame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picGame)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerAnimation;
        private System.Windows.Forms.Button btnSaveMap;
        public  System.Windows.Forms.PictureBox picGame;
    }
}


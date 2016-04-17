namespace SE2_Game
{
    partial class Inputbox
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
            this.BtnValidate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.nudEnemies = new System.Windows.Forms.NumericUpDown();
            this.btnLoadMap = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemies)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnValidate
            // 
            this.BtnValidate.Location = new System.Drawing.Point(149, 121);
            this.BtnValidate.Name = "BtnValidate";
            this.BtnValidate.Size = new System.Drawing.Size(75, 23);
            this.BtnValidate.TabIndex = 0;
            this.BtnValidate.Text = "Oke";
            this.BtnValidate.UseVisualStyleBackColor = true;
            this.BtnValidate.Click += new System.EventHandler(this.BtnValidate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many enemys do you want?";
            // 
            // nudEnemies
            // 
            this.nudEnemies.Location = new System.Drawing.Point(166, 45);
            this.nudEnemies.Name = "nudEnemies";
            this.nudEnemies.Size = new System.Drawing.Size(41, 20);
            this.nudEnemies.TabIndex = 3;
            // 
            // btnLoadMap
            // 
            this.btnLoadMap.Location = new System.Drawing.Point(149, 87);
            this.btnLoadMap.Name = "btnLoadMap";
            this.btnLoadMap.Size = new System.Drawing.Size(75, 23);
            this.btnLoadMap.TabIndex = 4;
            this.btnLoadMap.Text = "Map inladen";
            this.btnLoadMap.UseVisualStyleBackColor = true;
            this.btnLoadMap.Click += new System.EventHandler(this.btnLoadMap_Click);
            // 
            // Inputbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 156);
            this.Controls.Add(this.btnLoadMap);
            this.Controls.Add(this.nudEnemies);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnValidate);
            this.Name = "Inputbox";
            this.Text = "Inputbox";
            ((System.ComponentModel.ISupportInitialize)(this.nudEnemies)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnValidate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudEnemies;
        private System.Windows.Forms.Button btnLoadMap;
    }
}
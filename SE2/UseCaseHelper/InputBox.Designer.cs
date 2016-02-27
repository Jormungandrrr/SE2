namespace UseCaseHelper
{
    partial class InputBox
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
            this.tbActorName = new System.Windows.Forms.TextBox();
            this.BtnOke = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbQuestion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbActorName
            // 
            this.tbActorName.Location = new System.Drawing.Point(12, 54);
            this.tbActorName.Name = "tbActorName";
            this.tbActorName.Size = new System.Drawing.Size(285, 20);
            this.tbActorName.TabIndex = 0;
            // 
            // BtnOke
            // 
            this.BtnOke.Location = new System.Drawing.Point(12, 80);
            this.BtnOke.Name = "BtnOke";
            this.BtnOke.Size = new System.Drawing.Size(121, 44);
            this.BtnOke.TabIndex = 1;
            this.BtnOke.Text = "Oke";
            this.BtnOke.UseVisualStyleBackColor = true;
            this.BtnOke.Click += new System.EventHandler(this.BtnOke_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(176, 80);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(121, 44);
            this.btnCancel.TabIndex = 2;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbQuestion
            // 
            this.lbQuestion.AutoSize = true;
            this.lbQuestion.Location = new System.Drawing.Point(68, 22);
            this.lbQuestion.Name = "lbQuestion";
            this.lbQuestion.Size = new System.Drawing.Size(0, 13);
            this.lbQuestion.TabIndex = 3;
            // 
            // InputBox
            // 
            this.AcceptButton = this.BtnOke;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(304, 136);
            this.Controls.Add(this.lbQuestion);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.BtnOke);
            this.Controls.Add(this.tbActorName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "InputBox";
            this.Text = "InputBox";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbActorName;
        private System.Windows.Forms.Button BtnOke;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbQuestion;
    }
}
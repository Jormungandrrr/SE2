namespace UseCaseHelper
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
            this.gbElements = new System.Windows.Forms.GroupBox();
            this.rbLine = new System.Windows.Forms.RadioButton();
            this.rbUseCase = new System.Windows.Forms.RadioButton();
            this.rbActor = new System.Windows.Forms.RadioButton();
            this.gbMode = new System.Windows.Forms.GroupBox();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.pbUseCase = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.BtnRemove = new System.Windows.Forms.Button();
            this.gbElements.SuspendLayout();
            this.gbMode.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUseCase)).BeginInit();
            this.SuspendLayout();
            // 
            // gbElements
            // 
            this.gbElements.Controls.Add(this.rbLine);
            this.gbElements.Controls.Add(this.rbUseCase);
            this.gbElements.Controls.Add(this.rbActor);
            this.gbElements.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbElements.Location = new System.Drawing.Point(12, 12);
            this.gbElements.Name = "gbElements";
            this.gbElements.Size = new System.Drawing.Size(138, 100);
            this.gbElements.TabIndex = 0;
            this.gbElements.TabStop = false;
            this.gbElements.Text = "Elementen";
            // 
            // rbLine
            // 
            this.rbLine.AutoSize = true;
            this.rbLine.Enabled = false;
            this.rbLine.Location = new System.Drawing.Point(6, 65);
            this.rbLine.Name = "rbLine";
            this.rbLine.Size = new System.Drawing.Size(45, 17);
            this.rbLine.TabIndex = 2;
            this.rbLine.TabStop = true;
            this.rbLine.Text = "Line";
            this.rbLine.UseVisualStyleBackColor = true;
            // 
            // rbUseCase
            // 
            this.rbUseCase.AutoSize = true;
            this.rbUseCase.Enabled = false;
            this.rbUseCase.Location = new System.Drawing.Point(6, 42);
            this.rbUseCase.Name = "rbUseCase";
            this.rbUseCase.Size = new System.Drawing.Size(71, 17);
            this.rbUseCase.TabIndex = 1;
            this.rbUseCase.TabStop = true;
            this.rbUseCase.Text = "Use Case";
            this.rbUseCase.UseVisualStyleBackColor = true;
            // 
            // rbActor
            // 
            this.rbActor.AutoSize = true;
            this.rbActor.Enabled = false;
            this.rbActor.Location = new System.Drawing.Point(6, 19);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 0;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbSelect);
            this.gbMode.Controls.Add(this.rbCreate);
            this.gbMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbMode.Location = new System.Drawing.Point(156, 12);
            this.gbMode.Name = "gbMode";
            this.gbMode.Size = new System.Drawing.Size(136, 100);
            this.gbMode.TabIndex = 1;
            this.gbMode.TabStop = false;
            this.gbMode.Text = "Mode";
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Enabled = false;
            this.rbSelect.Location = new System.Drawing.Point(6, 42);
            this.rbSelect.Name = "rbSelect";
            this.rbSelect.Size = new System.Drawing.Size(55, 17);
            this.rbSelect.TabIndex = 4;
            this.rbSelect.TabStop = true;
            this.rbSelect.Text = "Select";
            this.rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbCreate
            // 
            this.rbCreate.AutoSize = true;
            this.rbCreate.Enabled = false;
            this.rbCreate.Location = new System.Drawing.Point(6, 19);
            this.rbCreate.Name = "rbCreate";
            this.rbCreate.Size = new System.Drawing.Size(56, 17);
            this.rbCreate.TabIndex = 3;
            this.rbCreate.TabStop = true;
            this.rbCreate.Text = "Create";
            this.rbCreate.UseVisualStyleBackColor = true;
            // 
            // pbUseCase
            // 
            this.pbUseCase.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbUseCase.Location = new System.Drawing.Point(12, 118);
            this.pbUseCase.Name = "pbUseCase";
            this.pbUseCase.Size = new System.Drawing.Size(598, 355);
            this.pbUseCase.TabIndex = 2;
            this.pbUseCase.TabStop = false;
            this.pbUseCase.Click += new System.EventHandler(this.pbUseCase_Click);
            this.pbUseCase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbUseCase_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(519, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(91, 36);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // BtnRemove
            // 
            this.BtnRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemove.Location = new System.Drawing.Point(519, 54);
            this.BtnRemove.Name = "BtnRemove";
            this.BtnRemove.Size = new System.Drawing.Size(91, 40);
            this.BtnRemove.TabIndex = 4;
            this.BtnRemove.Text = "Remove";
            this.BtnRemove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 480);
            this.Controls.Add(this.BtnRemove);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.pbUseCase);
            this.Controls.Add(this.gbMode);
            this.Controls.Add(this.gbElements);
            this.Name = "Form1";
            this.Text = "Use Case Helper";
            this.gbElements.ResumeLayout(false);
            this.gbElements.PerformLayout();
            this.gbMode.ResumeLayout(false);
            this.gbMode.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUseCase)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbElements;
        private System.Windows.Forms.RadioButton rbLine;
        private System.Windows.Forms.RadioButton rbUseCase;
        private System.Windows.Forms.RadioButton rbActor;
        private System.Windows.Forms.GroupBox gbMode;
        private System.Windows.Forms.RadioButton rbSelect;
        private System.Windows.Forms.RadioButton rbCreate;
        private System.Windows.Forms.PictureBox pbUseCase;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button BtnRemove;
    }
}


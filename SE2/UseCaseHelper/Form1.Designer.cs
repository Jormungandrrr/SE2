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
            this.rbRemove = new System.Windows.Forms.RadioButton();
            this.rbRename = new System.Windows.Forms.RadioButton();
            this.rbSelect = new System.Windows.Forms.RadioButton();
            this.rbCreate = new System.Windows.Forms.RadioButton();
            this.pbUseCase = new System.Windows.Forms.PictureBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
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
            this.rbActor.Location = new System.Drawing.Point(6, 19);
            this.rbActor.Name = "rbActor";
            this.rbActor.Size = new System.Drawing.Size(50, 17);
            this.rbActor.TabIndex = 0;
            this.rbActor.Text = "Actor";
            this.rbActor.UseVisualStyleBackColor = true;
            // 
            // gbMode
            // 
            this.gbMode.Controls.Add(this.rbRemove);
            this.gbMode.Controls.Add(this.rbRename);
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
            // rbRemove
            // 
            this.rbRemove.AutoSize = true;
            this.rbRemove.Location = new System.Drawing.Point(6, 71);
            this.rbRemove.Name = "rbRemove";
            this.rbRemove.Size = new System.Drawing.Size(65, 17);
            this.rbRemove.TabIndex = 6;
            this.rbRemove.TabStop = true;
            this.rbRemove.Text = "Remove";
            this.rbRemove.UseVisualStyleBackColor = true;
            // 
            // rbRename
            // 
            this.rbRename.AutoSize = true;
            this.rbRename.Location = new System.Drawing.Point(6, 54);
            this.rbRename.Name = "rbRename";
            this.rbRename.Size = new System.Drawing.Size(65, 17);
            this.rbRename.TabIndex = 5;
            this.rbRename.TabStop = true;
            this.rbRename.Text = "Rename";
            this.rbRename.UseVisualStyleBackColor = true;
            // 
            // rbSelect
            // 
            this.rbSelect.AutoSize = true;
            this.rbSelect.Location = new System.Drawing.Point(6, 37);
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
            this.pbUseCase.Size = new System.Drawing.Size(598, 589);
            this.pbUseCase.TabIndex = 2;
            this.pbUseCase.TabStop = false;
            this.pbUseCase.Click += new System.EventHandler(this.pbUseCase_Click);
            this.pbUseCase.Paint += new System.Windows.Forms.PaintEventHandler(this.pbUseCase_Paint);
            this.pbUseCase.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pbUseCase_MouseClick);
            // 
            // btnClear
            // 
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Location = new System.Drawing.Point(497, 12);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(113, 48);
            this.btnClear.TabIndex = 3;
            this.btnClear.Text = "Clear All";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Location = new System.Drawing.Point(497, 66);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(113, 50);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Opslaan";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 719);
            this.Controls.Add(this.btnSave);
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
        private System.Windows.Forms.RadioButton rbRename;
        private System.Windows.Forms.RadioButton rbRemove;
        private System.Windows.Forms.Button btnSave;
    }
}


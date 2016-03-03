namespace UseCaseHelper
{
    partial class UseCaseProperties
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
            this.lbName = new System.Windows.Forms.Label();
            this.lbSamenvatting = new System.Windows.Forms.Label();
            this.lbActoren = new System.Windows.Forms.Label();
            this.lbAannamen = new System.Windows.Forms.Label();
            this.lbBeschrijving = new System.Windows.Forms.Label();
            this.lbUitzondering = new System.Windows.Forms.Label();
            this.lbResultaat = new System.Windows.Forms.Label();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbSamenvatting = new System.Windows.Forms.TextBox();
            this.tbActoren = new System.Windows.Forms.TextBox();
            this.tbAannamen = new System.Windows.Forms.TextBox();
            this.rtbBeschrijving = new System.Windows.Forms.RichTextBox();
            this.rtbUitzonderingen = new System.Windows.Forms.RichTextBox();
            this.tbResultaat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(15, 32);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(38, 13);
            this.lbName.TabIndex = 0;
            this.lbName.Text = "Naam:";
            // 
            // lbSamenvatting
            // 
            this.lbSamenvatting.AutoSize = true;
            this.lbSamenvatting.Location = new System.Drawing.Point(15, 58);
            this.lbSamenvatting.Name = "lbSamenvatting";
            this.lbSamenvatting.Size = new System.Drawing.Size(75, 13);
            this.lbSamenvatting.TabIndex = 1;
            this.lbSamenvatting.Text = "Samenvatting:";
            // 
            // lbActoren
            // 
            this.lbActoren.AutoSize = true;
            this.lbActoren.Location = new System.Drawing.Point(15, 84);
            this.lbActoren.Name = "lbActoren";
            this.lbActoren.Size = new System.Drawing.Size(47, 13);
            this.lbActoren.TabIndex = 2;
            this.lbActoren.Text = "Actoren:";
            // 
            // lbAannamen
            // 
            this.lbAannamen.AutoSize = true;
            this.lbAannamen.Location = new System.Drawing.Point(15, 109);
            this.lbAannamen.Name = "lbAannamen";
            this.lbAannamen.Size = new System.Drawing.Size(61, 13);
            this.lbAannamen.TabIndex = 3;
            this.lbAannamen.Text = "Aannamen:";
            // 
            // lbBeschrijving
            // 
            this.lbBeschrijving.AutoSize = true;
            this.lbBeschrijving.Location = new System.Drawing.Point(15, 135);
            this.lbBeschrijving.Name = "lbBeschrijving";
            this.lbBeschrijving.Size = new System.Drawing.Size(67, 13);
            this.lbBeschrijving.TabIndex = 4;
            this.lbBeschrijving.Text = "Beschrijving:";
            // 
            // lbUitzondering
            // 
            this.lbUitzondering.AutoSize = true;
            this.lbUitzondering.Location = new System.Drawing.Point(9, 263);
            this.lbUitzondering.Name = "lbUitzondering";
            this.lbUitzondering.Size = new System.Drawing.Size(81, 13);
            this.lbUitzondering.TabIndex = 5;
            this.lbUitzondering.Text = "Uitzonderingen:";
            // 
            // lbResultaat
            // 
            this.lbResultaat.AutoSize = true;
            this.lbResultaat.Location = new System.Drawing.Point(18, 393);
            this.lbResultaat.Name = "lbResultaat";
            this.lbResultaat.Size = new System.Drawing.Size(55, 13);
            this.lbResultaat.TabIndex = 6;
            this.lbResultaat.Text = "Resultaat:";
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(93, 29);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(366, 20);
            this.tbNaam.TabIndex = 7;
            // 
            // tbSamenvatting
            // 
            this.tbSamenvatting.Location = new System.Drawing.Point(92, 55);
            this.tbSamenvatting.Name = "tbSamenvatting";
            this.tbSamenvatting.Size = new System.Drawing.Size(366, 20);
            this.tbSamenvatting.TabIndex = 8;
            this.tbSamenvatting.Validating += new System.ComponentModel.CancelEventHandler(this.tbSamenvatting_Validating);
            // 
            // tbActoren
            // 
            this.tbActoren.Enabled = false;
            this.tbActoren.Location = new System.Drawing.Point(93, 81);
            this.tbActoren.Name = "tbActoren";
            this.tbActoren.Size = new System.Drawing.Size(366, 20);
            this.tbActoren.TabIndex = 9;
            // 
            // tbAannamen
            // 
            this.tbAannamen.Location = new System.Drawing.Point(93, 106);
            this.tbAannamen.Name = "tbAannamen";
            this.tbAannamen.Size = new System.Drawing.Size(366, 20);
            this.tbAannamen.TabIndex = 10;
            this.tbAannamen.Validating += new System.ComponentModel.CancelEventHandler(this.tbAannamen_Validating);
            // 
            // rtbBeschrijving
            // 
            this.rtbBeschrijving.Location = new System.Drawing.Point(92, 132);
            this.rtbBeschrijving.Name = "rtbBeschrijving";
            this.rtbBeschrijving.Size = new System.Drawing.Size(366, 117);
            this.rtbBeschrijving.TabIndex = 11;
            this.rtbBeschrijving.Text = "";
            this.rtbBeschrijving.Validating += new System.ComponentModel.CancelEventHandler(this.rtbBeschrijving_Validating);
            // 
            // rtbUitzonderingen
            // 
            this.rtbUitzonderingen.Location = new System.Drawing.Point(93, 260);
            this.rtbUitzonderingen.Name = "rtbUitzonderingen";
            this.rtbUitzonderingen.Size = new System.Drawing.Size(366, 117);
            this.rtbUitzonderingen.TabIndex = 12;
            this.rtbUitzonderingen.Text = "";
            this.rtbUitzonderingen.Validating += new System.ComponentModel.CancelEventHandler(this.rtbUitzonderingen_Validating);
            // 
            // tbResultaat
            // 
            this.tbResultaat.Location = new System.Drawing.Point(92, 390);
            this.tbResultaat.Name = "tbResultaat";
            this.tbResultaat.Size = new System.Drawing.Size(366, 20);
            this.tbResultaat.TabIndex = 13;
            this.tbResultaat.Validating += new System.ComponentModel.CancelEventHandler(this.tbResultaat_Validating);
            // 
            // UseCaseProperties
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 432);
            this.Controls.Add(this.tbResultaat);
            this.Controls.Add(this.rtbUitzonderingen);
            this.Controls.Add(this.rtbBeschrijving);
            this.Controls.Add(this.tbAannamen);
            this.Controls.Add(this.tbActoren);
            this.Controls.Add(this.tbSamenvatting);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.lbResultaat);
            this.Controls.Add(this.lbUitzondering);
            this.Controls.Add(this.lbBeschrijving);
            this.Controls.Add(this.lbAannamen);
            this.Controls.Add(this.lbActoren);
            this.Controls.Add(this.lbSamenvatting);
            this.Controls.Add(this.lbName);
            this.Name = "UseCaseProperties";
            this.Text = "Properties";
            this.Load += new System.EventHandler(this.UseCaseProperties_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Label lbSamenvatting;
        private System.Windows.Forms.Label lbActoren;
        private System.Windows.Forms.Label lbAannamen;
        private System.Windows.Forms.Label lbBeschrijving;
        private System.Windows.Forms.Label lbUitzondering;
        private System.Windows.Forms.Label lbResultaat;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbSamenvatting;
        private System.Windows.Forms.TextBox tbActoren;
        private System.Windows.Forms.TextBox tbAannamen;
        private System.Windows.Forms.RichTextBox rtbBeschrijving;
        private System.Windows.Forms.RichTextBox rtbUitzonderingen;
        private System.Windows.Forms.TextBox tbResultaat;
    }
}
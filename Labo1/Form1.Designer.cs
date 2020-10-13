namespace Labo1
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.BtnTheme = new System.Windows.Forms.Button();
            this.GrpBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl3 = new System.Windows.Forms.Label();
            this.Lbl2 = new System.Windows.Forms.Label();
            this.Lbl1 = new System.Windows.Forms.Label();
            this.Pnl3 = new System.Windows.Forms.Panel();
            this.BtnAj3 = new System.Windows.Forms.Button();
            this.ComboBox1 = new System.Windows.Forms.ComboBox();
            this.Pnl2 = new System.Windows.Forms.Panel();
            this.BtnAj2 = new System.Windows.Forms.Button();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.Pnl1 = new System.Windows.Forms.Panel();
            this.BtnAj1 = new System.Windows.Forms.Button();
            this.TxtBox4 = new System.Windows.Forms.TextBox();
            this.TxtBox3 = new System.Windows.Forms.TextBox();
            this.TxtBox2 = new System.Windows.Forms.TextBox();
            this.TxtBox1 = new System.Windows.Forms.TextBox();
            this.GrpBox2 = new System.Windows.Forms.GroupBox();
            this.CheckedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.BtnSupp = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.MenuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.MenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.aideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnComm = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.GrpBox1.SuspendLayout();
            this.Pnl3.SuspendLayout();
            this.Pnl2.SuspendLayout();
            this.Pnl1.SuspendLayout();
            this.GrpBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.MenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnTheme
            // 
            this.BtnTheme.Location = new System.Drawing.Point(609, 30);
            this.BtnTheme.Name = "BtnTheme";
            this.BtnTheme.Size = new System.Drawing.Size(63, 65);
            this.BtnTheme.TabIndex = 0;
            this.BtnTheme.Text = "Changer le thème";
            this.BtnTheme.UseVisualStyleBackColor = true;
            this.BtnTheme.Click += new System.EventHandler(this.BtnTheme_Click);
            // 
            // GrpBox1
            // 
            this.GrpBox1.Controls.Add(this.Lbl3);
            this.GrpBox1.Controls.Add(this.Lbl2);
            this.GrpBox1.Controls.Add(this.Lbl1);
            this.GrpBox1.Controls.Add(this.Pnl3);
            this.GrpBox1.Controls.Add(this.Pnl2);
            this.GrpBox1.Controls.Add(this.Pnl1);
            this.GrpBox1.Location = new System.Drawing.Point(13, 135);
            this.GrpBox1.Name = "GrpBox1";
            this.GrpBox1.Size = new System.Drawing.Size(659, 285);
            this.GrpBox1.TabIndex = 1;
            this.GrpBox1.TabStop = false;
            this.GrpBox1.Text = "Saisir votre commande :";
            // 
            // Lbl3
            // 
            this.Lbl3.AutoSize = true;
            this.Lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl3.Location = new System.Drawing.Point(504, 43);
            this.Lbl3.Name = "Lbl3";
            this.Lbl3.Size = new System.Drawing.Size(69, 13);
            this.Lbl3.TabIndex = 4;
            this.Lbl3.Text = "Breuvage :";
            // 
            // Lbl2
            // 
            this.Lbl2.AutoSize = true;
            this.Lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl2.Location = new System.Drawing.Point(269, 43);
            this.Lbl2.Name = "Lbl2";
            this.Lbl2.Size = new System.Drawing.Size(121, 13);
            this.Lbl2.TabIndex = 2;
            this.Lbl2.Text = "Accompagnements :";
            // 
            // Lbl1
            // 
            this.Lbl1.AutoSize = true;
            this.Lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl1.Location = new System.Drawing.Point(31, 43);
            this.Lbl1.Name = "Lbl1";
            this.Lbl1.Size = new System.Drawing.Size(156, 13);
            this.Lbl1.TabIndex = 0;
            this.Lbl1.Text = "Modifications au BigWac :";
            // 
            // Pnl3
            // 
            this.Pnl3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl3.Controls.Add(this.BtnAj3);
            this.Pnl3.Controls.Add(this.ComboBox1);
            this.Pnl3.Location = new System.Drawing.Point(438, 59);
            this.Pnl3.Name = "Pnl3";
            this.Pnl3.Size = new System.Drawing.Size(210, 220);
            this.Pnl3.TabIndex = 2;
            // 
            // BtnAj3
            // 
            this.BtnAj3.Location = new System.Drawing.Point(123, 185);
            this.BtnAj3.Name = "BtnAj3";
            this.BtnAj3.Size = new System.Drawing.Size(75, 23);
            this.BtnAj3.TabIndex = 1;
            this.BtnAj3.Text = "Ajouter";
            this.BtnAj3.UseVisualStyleBackColor = true;
            this.BtnAj3.Click += new System.EventHandler(this.BtnAj3_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox1.FormattingEnabled = true;
            this.ComboBox1.Items.AddRange(new object[] {
            "7up",
            "Sprite",
            "Coca-Cola",
            "Nestea",
            "Fruitopia",
            "Fanta",
            "Crush",
            "Eau",
            "Pepsi",
            "Schweppes",
            "Orangina",
            "Canada Dry",
            "Mountain Dew",
            "Ice",
            "Mug",
            "Hawaï",
            "Poms"});
            this.ComboBox1.Location = new System.Drawing.Point(19, 20);
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(179, 21);
            this.ComboBox1.TabIndex = 0;
            // 
            // Pnl2
            // 
            this.Pnl2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl2.Controls.Add(this.BtnAj2);
            this.Pnl2.Controls.Add(this.ListBox1);
            this.Pnl2.Location = new System.Drawing.Point(222, 59);
            this.Pnl2.Name = "Pnl2";
            this.Pnl2.Size = new System.Drawing.Size(210, 220);
            this.Pnl2.TabIndex = 1;
            // 
            // BtnAj2
            // 
            this.BtnAj2.Location = new System.Drawing.Point(122, 185);
            this.BtnAj2.Name = "BtnAj2";
            this.BtnAj2.Size = new System.Drawing.Size(75, 23);
            this.BtnAj2.TabIndex = 1;
            this.BtnAj2.Text = "Ajouter";
            this.BtnAj2.UseVisualStyleBackColor = true;
            this.BtnAj2.Click += new System.EventHandler(this.BtnAj2_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.Items.AddRange(new object[] {
            "Frites",
            "Grosse Frite",
            "Poutine",
            "Petite salade",
            "Salade"});
            this.ListBox1.Location = new System.Drawing.Point(13, 22);
            this.ListBox1.Name = "ListBox1";
            this.ListBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.ListBox1.Size = new System.Drawing.Size(184, 134);
            this.ListBox1.TabIndex = 0;
            // 
            // Pnl1
            // 
            this.Pnl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Pnl1.Controls.Add(this.BtnAj1);
            this.Pnl1.Controls.Add(this.TxtBox4);
            this.Pnl1.Controls.Add(this.TxtBox3);
            this.Pnl1.Controls.Add(this.TxtBox2);
            this.Pnl1.Controls.Add(this.TxtBox1);
            this.Pnl1.Location = new System.Drawing.Point(6, 59);
            this.Pnl1.Name = "Pnl1";
            this.Pnl1.Size = new System.Drawing.Size(210, 220);
            this.Pnl1.TabIndex = 0;
            // 
            // BtnAj1
            // 
            this.BtnAj1.Location = new System.Drawing.Point(122, 185);
            this.BtnAj1.Name = "BtnAj1";
            this.BtnAj1.Size = new System.Drawing.Size(75, 23);
            this.BtnAj1.TabIndex = 4;
            this.BtnAj1.Text = "Ajouter";
            this.BtnAj1.UseVisualStyleBackColor = true;
            this.BtnAj1.Click += new System.EventHandler(this.BtnAj1_Click);
            // 
            // TxtBox4
            // 
            this.TxtBox4.Location = new System.Drawing.Point(15, 138);
            this.TxtBox4.Name = "TxtBox4";
            this.TxtBox4.Size = new System.Drawing.Size(182, 20);
            this.TxtBox4.TabIndex = 3;
            // 
            // TxtBox3
            // 
            this.TxtBox3.Location = new System.Drawing.Point(15, 101);
            this.TxtBox3.Name = "TxtBox3";
            this.TxtBox3.Size = new System.Drawing.Size(182, 20);
            this.TxtBox3.TabIndex = 2;
            // 
            // TxtBox2
            // 
            this.TxtBox2.Location = new System.Drawing.Point(15, 60);
            this.TxtBox2.Name = "TxtBox2";
            this.TxtBox2.Size = new System.Drawing.Size(182, 20);
            this.TxtBox2.TabIndex = 1;
            // 
            // TxtBox1
            // 
            this.TxtBox1.Location = new System.Drawing.Point(15, 22);
            this.TxtBox1.Name = "TxtBox1";
            this.TxtBox1.Size = new System.Drawing.Size(182, 20);
            this.TxtBox1.TabIndex = 0;
            // 
            // GrpBox2
            // 
            this.GrpBox2.Controls.Add(this.CheckedListBox1);
            this.GrpBox2.Controls.Add(this.BtnSupp);
            this.GrpBox2.Controls.Add(this.pictureBox2);
            this.GrpBox2.Location = new System.Drawing.Point(13, 442);
            this.GrpBox2.Name = "GrpBox2";
            this.GrpBox2.Size = new System.Drawing.Size(659, 236);
            this.GrpBox2.TabIndex = 2;
            this.GrpBox2.TabStop = false;
            this.GrpBox2.Text = "Confirmer votre commande :";
            // 
            // CheckedListBox1
            // 
            this.CheckedListBox1.FormattingEnabled = true;
            this.CheckedListBox1.Location = new System.Drawing.Point(222, 19);
            this.CheckedListBox1.Name = "CheckedListBox1";
            this.CheckedListBox1.Size = new System.Drawing.Size(426, 184);
            this.CheckedListBox1.Sorted = true;
            this.CheckedListBox1.TabIndex = 0;
            this.CheckedListBox1.SelectedIndexChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            this.CheckedListBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CheckedListBox1_KeyPress);
            this.CheckedListBox1.MouseCaptureChanged += new System.EventHandler(this.CheckedListBox1_SelectedIndexChanged);
            // 
            // BtnSupp
            // 
            this.BtnSupp.Enabled = false;
            this.BtnSupp.Location = new System.Drawing.Point(517, 213);
            this.BtnSupp.Name = "BtnSupp";
            this.BtnSupp.Size = new System.Drawing.Size(131, 23);
            this.BtnSupp.TabIndex = 1;
            this.BtnSupp.Text = "Supprimer si coché(s)";
            this.BtnSupp.UseVisualStyleBackColor = true;
            this.BtnSupp.Click += new System.EventHandler(this.BtnSupp_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 35);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(197, 125);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // MenuStrip1
            // 
            this.MenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fichierToolStripMenuItem,
            this.aideToolStripMenuItem});
            this.MenuStrip1.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip1.Name = "MenuStrip1";
            this.MenuStrip1.Size = new System.Drawing.Size(684, 24);
            this.MenuStrip1.TabIndex = 4;
            // 
            // fichierToolStripMenuItem
            // 
            this.fichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItem1,
            this.MenuItem2,
            this.MenuItem3});
            this.fichierToolStripMenuItem.Name = "fichierToolStripMenuItem";
            this.fichierToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.fichierToolStripMenuItem.Text = "&Fichier";
            // 
            // MenuItem1
            // 
            this.MenuItem1.Name = "MenuItem1";
            this.MenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.MenuItem1.Size = new System.Drawing.Size(172, 22);
            this.MenuItem1.Text = "Rénitialiser";
            this.MenuItem1.Click += new System.EventHandler(this.MenuItem1_Click);
            // 
            // MenuItem2
            // 
            this.MenuItem2.Name = "MenuItem2";
            this.MenuItem2.Size = new System.Drawing.Size(169, 6);
            // 
            // MenuItem3
            // 
            this.MenuItem3.Name = "MenuItem3";
            this.MenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.MenuItem3.Size = new System.Drawing.Size(172, 22);
            this.MenuItem3.Text = "Quitter";
            this.MenuItem3.Click += new System.EventHandler(this.MenuItem3_Click);
            // 
            // aideToolStripMenuItem
            // 
            this.aideToolStripMenuItem.Name = "aideToolStripMenuItem";
            this.aideToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.aideToolStripMenuItem.Text = "&Aide";
            this.aideToolStripMenuItem.Click += new System.EventHandler(this.aideToolStripMenuItem_Click);
            // 
            // BtnComm
            // 
            this.BtnComm.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.BtnComm.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnComm.Location = new System.Drawing.Point(530, 684);
            this.BtnComm.Name = "BtnComm";
            this.BtnComm.Size = new System.Drawing.Size(131, 23);
            this.BtnComm.TabIndex = 3;
            this.BtnComm.Text = "Commander";
            this.BtnComm.UseVisualStyleBackColor = false;
            this.BtnComm.Click += new System.EventHandler(this.BtnComm_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(291, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 99);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(684, 719);
            this.Controls.Add(this.BtnComm);
            this.Controls.Add(this.GrpBox2);
            this.Controls.Add(this.GrpBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnTheme);
            this.Controls.Add(this.MenuStrip1);
            this.MainMenuStrip = this.MenuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bienvenue chez WtDonald !";
            this.GrpBox1.ResumeLayout(false);
            this.GrpBox1.PerformLayout();
            this.Pnl3.ResumeLayout(false);
            this.Pnl2.ResumeLayout(false);
            this.Pnl1.ResumeLayout(false);
            this.Pnl1.PerformLayout();
            this.GrpBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.MenuStrip1.ResumeLayout(false);
            this.MenuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnTheme;
        private System.Windows.Forms.GroupBox GrpBox1;
        private System.Windows.Forms.Panel Pnl3;
        private System.Windows.Forms.Panel Pnl2;
        private System.Windows.Forms.Panel Pnl1;
        private System.Windows.Forms.GroupBox GrpBox2;
        private System.Windows.Forms.Button BtnSupp;
        private System.Windows.Forms.MenuStrip MenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aideToolStripMenuItem;
        private System.Windows.Forms.Button BtnComm;
        private System.Windows.Forms.CheckedListBox CheckedListBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Lbl3;
        private System.Windows.Forms.Label Lbl2;
        private System.Windows.Forms.Label Lbl1;
        private System.Windows.Forms.Button BtnAj3;
        private System.Windows.Forms.Button BtnAj2;
        private System.Windows.Forms.TextBox TxtBox4;
        private System.Windows.Forms.TextBox TxtBox3;
        private System.Windows.Forms.TextBox TxtBox1;
        private System.Windows.Forms.Button BtnAj1;
        private System.Windows.Forms.ComboBox ComboBox1;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem1;
        private System.Windows.Forms.ToolStripMenuItem MenuItem3;
        private System.Windows.Forms.ToolStripSeparator MenuItem2;
        private System.Windows.Forms.TextBox TxtBox2;
    }
}


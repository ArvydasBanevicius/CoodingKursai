namespace WindowsFormsApp1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.veiksmaiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.baigtiDarbąSuProgramaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.veiksmaiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // veiksmaiToolStripMenuItem
            // 
            this.veiksmaiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem,
            this.baigtiDarbąSuProgramaToolStripMenuItem});
            this.veiksmaiToolStripMenuItem.Name = "veiksmaiToolStripMenuItem";
            this.veiksmaiToolStripMenuItem.Size = new System.Drawing.Size(79, 24);
            this.veiksmaiToolStripMenuItem.Text = "Veiksmai";
            // 
            // nuskaitytiPrekiųSąrašąToolStripMenuItem
            // 
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem.Name = "nuskaitytiPrekiųSąrašąToolStripMenuItem";
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem.Text = "Nuskaityti prekių sąrašą";
            this.nuskaitytiPrekiųSąrašąToolStripMenuItem.Click += new System.EventHandler(this.nuskaitytiPrekiųSąrašąToolStripMenuItem_Click);
            // 
            // baigtiDarbąSuProgramaToolStripMenuItem
            // 
            this.baigtiDarbąSuProgramaToolStripMenuItem.Name = "baigtiDarbąSuProgramaToolStripMenuItem";
            this.baigtiDarbąSuProgramaToolStripMenuItem.ShortcutKeyDisplayString = "";
            this.baigtiDarbąSuProgramaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.X)));
            this.baigtiDarbąSuProgramaToolStripMenuItem.Size = new System.Drawing.Size(301, 26);
            this.baigtiDarbąSuProgramaToolStripMenuItem.Text = "Baigti darbą su programa";
            this.baigtiDarbąSuProgramaToolStripMenuItem.Click += new System.EventHandler(this.baigtiDarbąSuProgramaToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(874, 524);
            this.dataGridView1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Parduotuvė";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem veiksmaiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuskaitytiPrekiųSąrašąToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem baigtiDarbąSuProgramaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}


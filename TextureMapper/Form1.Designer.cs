namespace TextureMapper
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblXScale = new System.Windows.Forms.Label();
            this.numXScale = new System.Windows.Forms.NumericUpDown();
            this.numYScale = new System.Windows.Forms.NumericUpDown();
            this.lblYScale = new System.Windows.Forms.Label();
            this.numYPosition = new System.Windows.Forms.NumericUpDown();
            this.lblYPosition = new System.Windows.Forms.Label();
            this.numXPosition = new System.Windows.Forms.NumericUpDown();
            this.lblXPosition = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPosition)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(860, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // lblXScale
            // 
            this.lblXScale.AutoSize = true;
            this.lblXScale.Location = new System.Drawing.Point(530, 27);
            this.lblXScale.Name = "lblXScale";
            this.lblXScale.Size = new System.Drawing.Size(47, 13);
            this.lblXScale.TabIndex = 2;
            this.lblXScale.Text = "X Scale:";
            this.lblXScale.Visible = false;
            // 
            // numXScale
            // 
            this.numXScale.Location = new System.Drawing.Point(593, 25);
            this.numXScale.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numXScale.Name = "numXScale";
            this.numXScale.Size = new System.Drawing.Size(86, 20);
            this.numXScale.TabIndex = 3;
            this.numXScale.Visible = false;
            // 
            // numYScale
            // 
            this.numYScale.Location = new System.Drawing.Point(766, 25);
            this.numYScale.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numYScale.Name = "numYScale";
            this.numYScale.Size = new System.Drawing.Size(86, 20);
            this.numYScale.TabIndex = 5;
            this.numYScale.Visible = false;
            // 
            // lblYScale
            // 
            this.lblYScale.AutoSize = true;
            this.lblYScale.Location = new System.Drawing.Point(703, 27);
            this.lblYScale.Name = "lblYScale";
            this.lblYScale.Size = new System.Drawing.Size(47, 13);
            this.lblYScale.TabIndex = 4;
            this.lblYScale.Text = "Y Scale:";
            this.lblYScale.Visible = false;
            // 
            // numYPosition
            // 
            this.numYPosition.Location = new System.Drawing.Point(766, 62);
            this.numYPosition.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numYPosition.Name = "numYPosition";
            this.numYPosition.Size = new System.Drawing.Size(86, 20);
            this.numYPosition.TabIndex = 9;
            this.numYPosition.Visible = false;
            // 
            // lblYPosition
            // 
            this.lblYPosition.AutoSize = true;
            this.lblYPosition.Location = new System.Drawing.Point(703, 64);
            this.lblYPosition.Name = "lblYPosition";
            this.lblYPosition.Size = new System.Drawing.Size(57, 13);
            this.lblYPosition.TabIndex = 8;
            this.lblYPosition.Text = "Y Position:";
            this.lblYPosition.Visible = false;
            // 
            // numXPosition
            // 
            this.numXPosition.Location = new System.Drawing.Point(593, 62);
            this.numXPosition.Maximum = new decimal(new int[] {
            512,
            0,
            0,
            0});
            this.numXPosition.Name = "numXPosition";
            this.numXPosition.Size = new System.Drawing.Size(86, 20);
            this.numXPosition.TabIndex = 7;
            this.numXPosition.Visible = false;
            // 
            // lblXPosition
            // 
            this.lblXPosition.AutoSize = true;
            this.lblXPosition.Location = new System.Drawing.Point(530, 64);
            this.lblXPosition.Name = "lblXPosition";
            this.lblXPosition.Size = new System.Drawing.Size(57, 13);
            this.lblXPosition.TabIndex = 6;
            this.lblXPosition.Text = "X Position:";
            this.lblXPosition.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 512);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(731, 0);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 10;
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 545);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numYPosition);
            this.Controls.Add(this.lblYPosition);
            this.Controls.Add(this.numXPosition);
            this.Controls.Add(this.lblXPosition);
            this.Controls.Add(this.numYScale);
            this.Controls.Add(this.lblYScale);
            this.Controls.Add(this.numXScale);
            this.Controls.Add(this.lblXScale);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "GenericTextureMapper";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numXScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numYPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXPosition)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Label lblXScale;
        private System.Windows.Forms.NumericUpDown numXScale;
        private System.Windows.Forms.NumericUpDown numYScale;
        private System.Windows.Forms.Label lblYScale;
        private System.Windows.Forms.NumericUpDown numYPosition;
        private System.Windows.Forms.Label lblYPosition;
        private System.Windows.Forms.NumericUpDown numXPosition;
        private System.Windows.Forms.Label lblXPosition;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}


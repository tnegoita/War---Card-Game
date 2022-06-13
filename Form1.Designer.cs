namespace ProiectIP
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
            this.startButton = new System.Windows.Forms.Button();
            this.computerCardPictureBox = new System.Windows.Forms.PictureBox();
            this.playerCardPictureBox = new System.Windows.Forms.PictureBox();
            this.playerDeckPictureBox = new System.Windows.Forms.PictureBox();
            this.computerDeckPictureBox = new System.Windows.Forms.PictureBox();
            this.resetButton = new System.Windows.Forms.Button();
            this.TakeCards = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ajutorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualDeUtilizareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.computerCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeckPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDeckPictureBox)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(728, 299);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 0;
            this.startButton.Text = "Joaca";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // computerCardPictureBox
            // 
            this.computerCardPictureBox.Location = new System.Drawing.Point(388, 224);
            this.computerCardPictureBox.Name = "computerCardPictureBox";
            this.computerCardPictureBox.Size = new System.Drawing.Size(100, 134);
            this.computerCardPictureBox.TabIndex = 1;
            this.computerCardPictureBox.TabStop = false;
            this.computerCardPictureBox.Click += new System.EventHandler(this.computerCardPictureBox_Click);
            // 
            // playerCardPictureBox
            // 
            this.playerCardPictureBox.Location = new System.Drawing.Point(388, 419);
            this.playerCardPictureBox.Name = "playerCardPictureBox";
            this.playerCardPictureBox.Size = new System.Drawing.Size(100, 134);
            this.playerCardPictureBox.TabIndex = 2;
            this.playerCardPictureBox.TabStop = false;
            this.playerCardPictureBox.Click += new System.EventHandler(this.playerCardPictureBox_Click);
            // 
            // playerDeckPictureBox
            // 
            this.playerDeckPictureBox.Location = new System.Drawing.Point(388, 570);
            this.playerDeckPictureBox.Name = "playerDeckPictureBox";
            this.playerDeckPictureBox.Size = new System.Drawing.Size(100, 134);
            this.playerDeckPictureBox.TabIndex = 3;
            this.playerDeckPictureBox.TabStop = false;
            // 
            // computerDeckPictureBox
            // 
            this.computerDeckPictureBox.Location = new System.Drawing.Point(388, 72);
            this.computerDeckPictureBox.Name = "computerDeckPictureBox";
            this.computerDeckPictureBox.Size = new System.Drawing.Size(100, 134);
            this.computerDeckPictureBox.TabIndex = 4;
            this.computerDeckPictureBox.TabStop = false;
            this.computerDeckPictureBox.Click += new System.EventHandler(this.computerDeckPictureBox_Click);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(728, 400);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 5;
            this.resetButton.Text = "Restart";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // TakeCards
            // 
            this.TakeCards.Location = new System.Drawing.Point(728, 351);
            this.TakeCards.Name = "TakeCards";
            this.TakeCards.Size = new System.Drawing.Size(75, 23);
            this.TakeCards.TabIndex = 6;
            this.TakeCards.Text = "Ia Cartea";
            this.TakeCards.UseVisualStyleBackColor = true;
            this.TakeCards.Click += new System.EventHandler(this.TakeCards_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajutorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(936, 28);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ajutorToolStripMenuItem
            // 
            this.ajutorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualDeUtilizareToolStripMenuItem});
            this.ajutorToolStripMenuItem.Name = "ajutorToolStripMenuItem";
            this.ajutorToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.ajutorToolStripMenuItem.Text = "Ajutor";
            this.ajutorToolStripMenuItem.Click += new System.EventHandler(this.ajutorToolStripMenuItem_Click);
            // 
            // manualDeUtilizareToolStripMenuItem
            // 
            this.manualDeUtilizareToolStripMenuItem.Name = "manualDeUtilizareToolStripMenuItem";
            this.manualDeUtilizareToolStripMenuItem.Size = new System.Drawing.Size(219, 26);
            this.manualDeUtilizareToolStripMenuItem.Text = "Manual de utilizare";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(936, 716);
            this.Controls.Add(this.TakeCards);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.computerDeckPictureBox);
            this.Controls.Add(this.playerDeckPictureBox);
            this.Controls.Add(this.playerCardPictureBox);
            this.Controls.Add(this.computerCardPictureBox);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.computerCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerCardPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playerDeckPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computerDeckPictureBox)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.PictureBox computerCardPictureBox;
        private System.Windows.Forms.PictureBox playerCardPictureBox;
        private System.Windows.Forms.PictureBox playerDeckPictureBox;
        private System.Windows.Forms.PictureBox computerDeckPictureBox;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button TakeCards;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajutorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualDeUtilizareToolStripMenuItem;
    }
}


namespace TouchMPC
{
    partial class NowPlaying
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.lblArtist = new System.Windows.Forms.Label();
            this.lblAlbum = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.albumArt = new System.Windows.Forms.PictureBox();
            this.pnlStatic = new System.Windows.Forms.Panel();
            this.pnlScroll = new System.Windows.Forms.Panel();
            this.lLyrics = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).BeginInit();
            this.pnlStatic.SuspendLayout();
            this.pnlScroll.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(30, 13);
            label1.TabIndex = 0;
            label1.Text = "Artist";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new System.Drawing.Point(-3, 25);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(36, 13);
            label2.TabIndex = 1;
            label2.Text = "Album";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(3, 50);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(27, 13);
            label3.TabIndex = 2;
            label3.Text = "Title";
            // 
            // lblArtist
            // 
            this.lblArtist.AutoSize = true;
            this.lblArtist.Location = new System.Drawing.Point(42, 0);
            this.lblArtist.Name = "lblArtist";
            this.lblArtist.Size = new System.Drawing.Size(35, 13);
            this.lblArtist.TabIndex = 3;
            this.lblArtist.Text = "label4";
            // 
            // lblAlbum
            // 
            this.lblAlbum.AutoSize = true;
            this.lblAlbum.Location = new System.Drawing.Point(42, 25);
            this.lblAlbum.Name = "lblAlbum";
            this.lblAlbum.Size = new System.Drawing.Size(35, 13);
            this.lblAlbum.TabIndex = 4;
            this.lblAlbum.Text = "label5";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(42, 50);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(35, 13);
            this.lblTitle.TabIndex = 5;
            this.lblTitle.Text = "label6";
            // 
            // albumArt
            // 
            this.albumArt.Dock = System.Windows.Forms.DockStyle.Right;
            this.albumArt.Location = new System.Drawing.Point(362, 0);
            this.albumArt.Name = "albumArt";
            this.albumArt.Size = new System.Drawing.Size(99, 100);
            this.albumArt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.albumArt.TabIndex = 7;
            this.albumArt.TabStop = false;
            // 
            // pnlStatic
            // 
            this.pnlStatic.Controls.Add(label1);
            this.pnlStatic.Controls.Add(label2);
            this.pnlStatic.Controls.Add(this.albumArt);
            this.pnlStatic.Controls.Add(label3);
            this.pnlStatic.Controls.Add(this.lblTitle);
            this.pnlStatic.Controls.Add(this.lblArtist);
            this.pnlStatic.Controls.Add(this.lblAlbum);
            this.pnlStatic.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlStatic.Location = new System.Drawing.Point(0, 0);
            this.pnlStatic.Name = "pnlStatic";
            this.pnlStatic.Size = new System.Drawing.Size(461, 100);
            this.pnlStatic.TabIndex = 10;
            // 
            // pnlScroll
            // 
            this.pnlScroll.AutoScroll = true;
            this.pnlScroll.Controls.Add(this.lLyrics);
            this.pnlScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlScroll.Location = new System.Drawing.Point(0, 100);
            this.pnlScroll.Name = "pnlScroll";
            this.pnlScroll.Size = new System.Drawing.Size(461, 242);
            this.pnlScroll.TabIndex = 11;
            this.pnlScroll.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseDown);
            this.pnlScroll.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseMove);
            this.pnlScroll.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseUp);
            // 
            // lLyrics
            // 
            this.lLyrics.AutoSize = true;
            this.lLyrics.Location = new System.Drawing.Point(-3, 0);
            this.lLyrics.Name = "lLyrics";
            this.lLyrics.Size = new System.Drawing.Size(35, 13);
            this.lLyrics.TabIndex = 8;
            this.lLyrics.Text = "label4";
            this.lLyrics.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseDown);
            this.lLyrics.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseMove);
            this.lLyrics.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lLyrics_MouseUp);
            // 
            // NowPlaying
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlScroll);
            this.Controls.Add(this.pnlStatic);
            this.Name = "NowPlaying";
            this.Size = new System.Drawing.Size(461, 342);
            this.Resize += new System.EventHandler(this.NowPlaying_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.albumArt)).EndInit();
            this.pnlStatic.ResumeLayout(false);
            this.pnlStatic.PerformLayout();
            this.pnlScroll.ResumeLayout(false);
            this.pnlScroll.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblArtist;
        private System.Windows.Forms.Label lblAlbum;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.PictureBox albumArt;
        private System.Windows.Forms.Panel pnlStatic;
        private System.Windows.Forms.Panel pnlScroll;
        private System.Windows.Forms.Label lLyrics;
    }
}

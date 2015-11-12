namespace TouchMPC
{
    partial class MainWindow
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
            System.Windows.Forms.Button btnNowPlaying;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            System.Windows.Forms.Panel globalControls;
            System.Windows.Forms.Button btnNext;
            System.Windows.Forms.Button btnPlay;
            System.Windows.Forms.Button btnStop;
            System.Windows.Forms.Button btnPrev;
            this.viewControls = new System.Windows.Forms.Panel();
            this.modeSelector = new System.Windows.Forms.Panel();
            this.btnLibrary = new System.Windows.Forms.Button();
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.viewUi = new System.Windows.Forms.Panel();
            btnNowPlaying = new System.Windows.Forms.Button();
            globalControls = new System.Windows.Forms.Panel();
            btnNext = new System.Windows.Forms.Button();
            btnPlay = new System.Windows.Forms.Button();
            btnStop = new System.Windows.Forms.Button();
            btnPrev = new System.Windows.Forms.Button();
            globalControls.SuspendLayout();
            this.modeSelector.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNowPlaying
            // 
            resources.ApplyResources(btnNowPlaying, "btnNowPlaying");
            btnNowPlaying.Name = "btnNowPlaying";
            btnNowPlaying.UseVisualStyleBackColor = true;
            btnNowPlaying.Click += new System.EventHandler(this.NowPlaying_Click);
            // 
            // globalControls
            // 
            globalControls.Controls.Add(this.viewControls);
            globalControls.Controls.Add(btnNext);
            globalControls.Controls.Add(btnPlay);
            globalControls.Controls.Add(btnStop);
            globalControls.Controls.Add(btnPrev);
            resources.ApplyResources(globalControls, "globalControls");
            globalControls.Name = "globalControls";
            // 
            // viewControls
            // 
            resources.ApplyResources(this.viewControls, "viewControls");
            this.viewControls.Name = "viewControls";
            // 
            // btnNext
            // 
            resources.ApplyResources(btnNext, "btnNext");
            btnNext.Name = "btnNext";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += new System.EventHandler(this.Next_Click);
            // 
            // btnPlay
            // 
            resources.ApplyResources(btnPlay, "btnPlay");
            btnPlay.Name = "btnPlay";
            btnPlay.UseVisualStyleBackColor = true;
            btnPlay.Click += new System.EventHandler(this.PlayPause_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(btnStop, "btnStop");
            btnStop.Name = "btnStop";
            btnStop.UseVisualStyleBackColor = true;
            btnStop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // btnPrev
            // 
            resources.ApplyResources(btnPrev, "btnPrev");
            btnPrev.Name = "btnPrev";
            btnPrev.UseVisualStyleBackColor = true;
            btnPrev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // modeSelector
            // 
            this.modeSelector.Controls.Add(btnNowPlaying);
            this.modeSelector.Controls.Add(this.btnLibrary);
            this.modeSelector.Controls.Add(this.btnPlaylist);
            resources.ApplyResources(this.modeSelector, "modeSelector");
            this.modeSelector.Name = "modeSelector";
            // 
            // btnLibrary
            // 
            resources.ApplyResources(this.btnLibrary, "btnLibrary");
            this.btnLibrary.Name = "btnLibrary";
            this.btnLibrary.UseVisualStyleBackColor = true;
            this.btnLibrary.Click += new System.EventHandler(this.Database_Click);
            // 
            // btnPlaylist
            // 
            resources.ApplyResources(this.btnPlaylist, "btnPlaylist");
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.UseVisualStyleBackColor = true;
            this.btnPlaylist.Click += new System.EventHandler(this.Playlist_Click);
            // 
            // viewUi
            // 
            resources.ApplyResources(this.viewUi, "viewUi");
            this.viewUi.Name = "viewUi";
            // 
            // MainWindow
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.viewUi);
            this.Controls.Add(globalControls);
            this.Controls.Add(this.modeSelector);
            this.Name = "MainWindow";
            this.Shown += new System.EventHandler(this.MainWindow_Shown);
            globalControls.ResumeLayout(false);
            this.modeSelector.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel modeSelector;
        private System.Windows.Forms.Button btnLibrary;
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.Panel viewUi;
        private System.Windows.Forms.Panel viewControls;
    }
}


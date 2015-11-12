namespace TouchMPC
{
    partial class Playlist
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
            System.Windows.Forms.Button button2;
            System.Windows.Forms.Button button1;
            this.detachableControls = new System.Windows.Forms.Panel();
            this.listView = new System.Windows.Forms.ListView();
            this.cStatus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cArtist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cAlbum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cLength = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            button2 = new System.Windows.Forms.Button();
            button1 = new System.Windows.Forms.Button();
            this.detachableControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Left;
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 60);
            button2.TabIndex = 1;
            button2.Text = "Remove item";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.RemoveItem_Click);
            // 
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Left;
            button1.Location = new System.Drawing.Point(100, 0);
            button1.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 60);
            button1.TabIndex = 2;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            // 
            // detachableControls
            // 
            this.detachableControls.Controls.Add(button1);
            this.detachableControls.Controls.Add(button2);
            this.detachableControls.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.detachableControls.Location = new System.Drawing.Point(0, 343);
            this.detachableControls.Name = "detachableControls";
            this.detachableControls.Size = new System.Drawing.Size(622, 60);
            this.detachableControls.TabIndex = 0;
            // 
            // listView
            // 
            this.listView.CheckBoxes = true;
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cStatus,
            this.cArtist,
            this.cAlbum,
            this.cTitle,
            this.cLength});
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.FullRowSelect = true;
            this.listView.HideSelection = false;
            this.listView.Location = new System.Drawing.Point(0, 0);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(622, 343);
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.Click += new System.EventHandler(this.listView_Click);
            this.listView.Resize += new System.EventHandler(this.listView_Resize);
            // 
            // cStatus
            // 
            this.cStatus.Text = "";
            // 
            // cArtist
            // 
            this.cArtist.Text = "Artist";
            // 
            // cAlbum
            // 
            this.cAlbum.Text = "Album";
            // 
            // cTitle
            // 
            this.cTitle.Text = "Title";
            // 
            // cLength
            // 
            this.cLength.Text = "Length";
            // 
            // Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.detachableControls);
            this.Name = "Playlist";
            this.Size = new System.Drawing.Size(622, 403);
            this.detachableControls.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel detachableControls;
        private System.Windows.Forms.ColumnHeader cStatus;
        private System.Windows.Forms.ColumnHeader cArtist;
        private System.Windows.Forms.ColumnHeader cAlbum;
        private System.Windows.Forms.ColumnHeader cTitle;
        private System.Windows.Forms.ColumnHeader cLength;
    }
}

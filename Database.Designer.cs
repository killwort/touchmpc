namespace TouchMPC
{
    partial class Database
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.ImageList imageList1;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Database));
            System.Windows.Forms.Button button1;
            System.Windows.Forms.Button button2;
            this.listView = new System.Windows.Forms.ListView();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.detachableControls = new System.Windows.Forms.Panel();
            imageList1 = new System.Windows.Forms.ImageList(this.components);
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            this.detachableControls.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            imageList1.TransparentColor = System.Drawing.Color.Transparent;
            imageList1.Images.SetKeyName(0, "directory");
            imageList1.Images.SetKeyName(1, "song");
            imageList1.Images.SetKeyName(2, "_parent");
            // 
            // listView
            // 
            this.listView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView.HideSelection = false;
            this.listView.LargeImageList = imageList1;
            this.listView.Location = new System.Drawing.Point(0, 13);
            this.listView.Margin = new System.Windows.Forms.Padding(3, 8, 3, 8);
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(622, 330);
            this.listView.SmallImageList = imageList1;
            this.listView.TabIndex = 3;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Tile;
            this.listView.ItemActivate += new System.EventHandler(this.listView_ItemActivate);
            this.listView.Resize += new System.EventHandler(this.listView_Resize);
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblCurrentPath.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(35, 13);
            this.lblCurrentPath.TabIndex = 2;
            this.lblCurrentPath.Text = "label1";
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
            // button1
            // 
            button1.Dock = System.Windows.Forms.DockStyle.Left;
            button1.Location = new System.Drawing.Point(100, 0);
            button1.Margin = new System.Windows.Forms.Padding(8, 3, 3, 3);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(100, 60);
            button1.TabIndex = 0;
            button1.Text = "Add selection to current playlist";
            button1.UseVisualStyleBackColor = true;
            button1.Click += new System.EventHandler(this.AddToPlaylist_Click);
            // 
            // button2
            // 
            button2.Dock = System.Windows.Forms.DockStyle.Left;
            button2.Location = new System.Drawing.Point(0, 0);
            button2.Margin = new System.Windows.Forms.Padding(3, 3, 8, 3);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(100, 60);
            button2.TabIndex = 1;
            button2.Text = "Clear current playlist";
            button2.UseVisualStyleBackColor = true;
            button2.Click += new System.EventHandler(this.ClearPlaylist_Click);
            // 
            // Database
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.listView);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.detachableControls);
            this.Name = "Database";
            this.Size = new System.Drawing.Size(622, 403);
            this.detachableControls.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Panel detachableControls;
    }
}

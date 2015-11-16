namespace TouchMPC
{
    partial class SettingsWindow
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
            System.Windows.Forms.Button bConnect;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsWindow));
            System.Windows.Forms.Button bExit;
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            this.txHost = new System.Windows.Forms.TextBox();
            this.nPort = new System.Windows.Forms.NumericUpDown();
            this.lblError = new System.Windows.Forms.Label();
            bConnect = new System.Windows.Forms.Button();
            bExit = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).BeginInit();
            this.SuspendLayout();
            // 
            // bConnect
            // 
            resources.ApplyResources(bConnect, "bConnect");
            bConnect.Name = "bConnect";
            bConnect.UseVisualStyleBackColor = true;
            bConnect.Click += new System.EventHandler(this.bConnect_Click);
            // 
            // bExit
            // 
            resources.ApplyResources(bExit, "bExit");
            bExit.Name = "bExit";
            bExit.UseVisualStyleBackColor = true;
            bExit.Click += new System.EventHandler(this.bExit_Click);
            // 
            // label1
            // 
            resources.ApplyResources(label1, "label1");
            label1.Name = "label1";
            // 
            // label2
            // 
            resources.ApplyResources(label2, "label2");
            label2.Name = "label2";
            // 
            // label3
            // 
            resources.ApplyResources(label3, "label3");
            label3.Name = "label3";
            // 
            // txHost
            // 
            resources.ApplyResources(this.txHost, "txHost");
            this.txHost.Name = "txHost";
            // 
            // nPort
            // 
            resources.ApplyResources(this.nPort, "nPort");
            this.nPort.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.nPort.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nPort.Name = "nPort";
            this.nPort.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblError
            // 
            resources.ApplyResources(this.lblError, "lblError");
            this.lblError.Name = "lblError";
            // 
            // SettingsWindow
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblError);
            this.Controls.Add(label3);
            this.Controls.Add(this.nPort);
            this.Controls.Add(label2);
            this.Controls.Add(this.txHost);
            this.Controls.Add(label1);
            this.Controls.Add(bExit);
            this.Controls.Add(bConnect);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "SettingsWindow";
            ((System.ComponentModel.ISupportInitialize)(this.nPort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txHost;
        private System.Windows.Forms.NumericUpDown nPort;
        private System.Windows.Forms.Label lblError;
    }
}
namespace ContAux.view
{
    partial class frmSplashScreen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplashScreen));
            this.picWelcome = new System.Windows.Forms.PictureBox();
            this.lblInfo = new System.Windows.Forms.Label();
            this.prgBar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // picWelcome
            // 
            this.picWelcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.picWelcome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.picWelcome.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picWelcome.Image = ((System.Drawing.Image)(resources.GetObject("picWelcome.Image")));
            this.picWelcome.Location = new System.Drawing.Point(-1, -12);
            this.picWelcome.Name = "picWelcome";
            this.picWelcome.Size = new System.Drawing.Size(665, 370);
            this.picWelcome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picWelcome.TabIndex = 0;
            this.picWelcome.TabStop = false;
            // 
            // lblInfo
            // 
            this.lblInfo.AllowDrop = true;
            this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.ForeColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(220, 420);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(243, 32);
            this.lblInfo.TabIndex = 2;
            this.lblInfo.Text = "Todos los derechos reservados © 2018\r\nVersion 1.0 By Ing. Antonio Olvera";
            this.lblInfo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lblInfo.UseCompatibleTextRendering = true;
            // 
            // prgBar
            // 
            this.prgBar.Location = new System.Drawing.Point(-1, 364);
            this.prgBar.Margin = new System.Windows.Forms.Padding(0);
            this.prgBar.MarqueeAnimationSpeed = 28;
            this.prgBar.Name = "prgBar";
            this.prgBar.Size = new System.Drawing.Size(665, 35);
            this.prgBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.prgBar.TabIndex = 2;
     
            // 
            // timer1
            // 
            this.timer1.Interval = 70;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmSplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(664, 471);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.prgBar);
            this.Controls.Add(this.picWelcome);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmSplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSplashScreen";
            ((System.ComponentModel.ISupportInitialize)(this.picWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picWelcome;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.ProgressBar prgBar;
        private System.Windows.Forms.Timer timer1;
    }
}
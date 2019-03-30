namespace ContAux.view
{
    partial class frmUsers
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
            this.pnUsersContent = new System.Windows.Forms.Panel();
            this.layUsersPane = new System.Windows.Forms.TableLayoutPanel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pnUsersContent.SuspendLayout();
            this.layUsersPane.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnUsersContent
            // 
            this.pnUsersContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnUsersContent.BackColor = System.Drawing.SystemColors.Control;
            this.pnUsersContent.Controls.Add(this.layUsersPane);
            this.pnUsersContent.Location = new System.Drawing.Point(-1, 0);
            this.pnUsersContent.Name = "pnUsersContent";
            this.pnUsersContent.Size = new System.Drawing.Size(980, 715);
            this.pnUsersContent.TabIndex = 0;
            // 
            // layUsersPane
            // 
            this.layUsersPane.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.layUsersPane.ColumnCount = 3;
            this.layUsersPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layUsersPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.layUsersPane.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.layUsersPane.Controls.Add(this.lblTitle, 1, 0);
            this.layUsersPane.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.layUsersPane.Location = new System.Drawing.Point(0, 0);
            this.layUsersPane.Name = "layUsersPane";
            this.layUsersPane.RowCount = 3;
            this.layUsersPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.12089F));
            this.layUsersPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.84116F));
            this.layUsersPane.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.03795F));
            this.layUsersPane.Size = new System.Drawing.Size(980, 712);
            this.layUsersPane.TabIndex = 0;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(350, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(279, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Control de usuarios";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // frmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 713);
            this.Controls.Add(this.pnUsersContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmUsers";
            this.Text = "frmUsers";
            this.pnUsersContent.ResumeLayout(false);
            this.layUsersPane.ResumeLayout(false);
            this.layUsersPane.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnUsersContent;
        private System.Windows.Forms.TableLayoutPanel layUsersPane;
        private System.Windows.Forms.Label lblTitle;
    }
}
namespace AnimeTracker
{
    partial class uctHome
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
            this.lblAmount = new System.Windows.Forms.Label();
            this.klblWelcomeUser = new Krypton.Toolkit.KryptonLabel();
            this.klblTrackingPretext = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // lblAmount
            // 
            this.lblAmount.AccessibleName = "tstlable";
            this.lblAmount.AutoSize = true;
            this.lblAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmount.Location = new System.Drawing.Point(363, 107);
            this.lblAmount.Name = "lblAmount";
            this.lblAmount.Size = new System.Drawing.Size(70, 25);
            this.lblAmount.TabIndex = 1;
            this.lblAmount.Text = "label1";
            // 
            // klblWelcomeUser
            // 
            this.klblWelcomeUser.Location = new System.Drawing.Point(278, 50);
            this.klblWelcomeUser.Name = "klblWelcomeUser";
            this.klblWelcomeUser.Size = new System.Drawing.Size(73, 33);
            this.klblWelcomeUser.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblWelcomeUser.TabIndex = 2;
            this.klblWelcomeUser.Values.Text = "Hello,";
            // 
            // klblTrackingPretext
            // 
            this.klblTrackingPretext.Location = new System.Drawing.Point(72, 102);
            this.klblTrackingPretext.Name = "klblTrackingPretext";
            this.klblTrackingPretext.Size = new System.Drawing.Size(284, 33);
            this.klblTrackingPretext.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTrackingPretext.TabIndex = 3;
            this.klblTrackingPretext.Values.Text = "You are currently tracking: ";
            // 
            // uctHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.klblTrackingPretext);
            this.Controls.Add(this.klblWelcomeUser);
            this.Controls.Add(this.lblAmount);
            this.Name = "uctHome";
            this.Size = new System.Drawing.Size(738, 506);
            this.Load += new System.EventHandler(this.uctHome_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblAmount;
        private Krypton.Toolkit.KryptonLabel klblWelcomeUser;
        private Krypton.Toolkit.KryptonLabel klblTrackingPretext;
    }
}

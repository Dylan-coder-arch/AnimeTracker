namespace AnimeTracker
{
    partial class frmSignup
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
            this.kbtnSignup = new Krypton.Toolkit.KryptonButton();
            this.klblName = new Krypton.Toolkit.KryptonLabel();
            this.klblEmail = new Krypton.Toolkit.KryptonLabel();
            this.klblPassword = new Krypton.Toolkit.KryptonLabel();
            this.klblConfirmPass = new Krypton.Toolkit.KryptonLabel();
            this.ktbxName = new Krypton.Toolkit.KryptonTextBox();
            this.ktbxEmail = new Krypton.Toolkit.KryptonTextBox();
            this.ktbxPassword = new Krypton.Toolkit.KryptonTextBox();
            this.ktbxConfirmPass = new Krypton.Toolkit.KryptonTextBox();
            this.SuspendLayout();
            // 
            // kbtnSignup
            // 
            this.kbtnSignup.CornerRoundingRadius = 25F;
            this.kbtnSignup.Location = new System.Drawing.Point(94, 319);
            this.kbtnSignup.Name = "kbtnSignup";
            this.kbtnSignup.Size = new System.Drawing.Size(123, 42);
            this.kbtnSignup.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnSignup.StateCommon.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnSignup.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtnSignup.StateCommon.Border.Rounding = 25F;
            this.kbtnSignup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kbtnSignup.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kbtnSignup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSignup.TabIndex = 5;
            this.kbtnSignup.Values.Text = "Sign up";
            this.kbtnSignup.Click += new System.EventHandler(this.kbtnSignup_Click);
            // 
            // klblName
            // 
            this.klblName.Location = new System.Drawing.Point(127, 26);
            this.klblName.Name = "klblName";
            this.klblName.Size = new System.Drawing.Size(43, 20);
            this.klblName.TabIndex = 6;
            this.klblName.Values.Text = "Name";
            // 
            // klblEmail
            // 
            this.klblEmail.Location = new System.Drawing.Point(127, 82);
            this.klblEmail.Name = "klblEmail";
            this.klblEmail.Size = new System.Drawing.Size(40, 20);
            this.klblEmail.TabIndex = 7;
            this.klblEmail.Values.Text = "Email";
            // 
            // klblPassword
            // 
            this.klblPassword.Location = new System.Drawing.Point(122, 143);
            this.klblPassword.Name = "klblPassword";
            this.klblPassword.Size = new System.Drawing.Size(62, 20);
            this.klblPassword.TabIndex = 8;
            this.klblPassword.Values.Text = "Password";
            // 
            // klblConfirmPass
            // 
            this.klblConfirmPass.Location = new System.Drawing.Point(108, 220);
            this.klblConfirmPass.Name = "klblConfirmPass";
            this.klblConfirmPass.Size = new System.Drawing.Size(109, 20);
            this.klblConfirmPass.TabIndex = 9;
            this.klblConfirmPass.Values.Text = "Confirm Password";
            // 
            // ktbxName
            // 
            this.ktbxName.Location = new System.Drawing.Point(107, 52);
            this.ktbxName.Name = "ktbxName";
            this.ktbxName.Size = new System.Drawing.Size(100, 23);
            this.ktbxName.TabIndex = 1;
            // 
            // ktbxEmail
            // 
            this.ktbxEmail.Location = new System.Drawing.Point(107, 108);
            this.ktbxEmail.Name = "ktbxEmail";
            this.ktbxEmail.Size = new System.Drawing.Size(100, 23);
            this.ktbxEmail.TabIndex = 2;
            // 
            // ktbxPassword
            // 
            this.ktbxPassword.Location = new System.Drawing.Point(107, 169);
            this.ktbxPassword.Name = "ktbxPassword";
            this.ktbxPassword.Size = new System.Drawing.Size(100, 23);
            this.ktbxPassword.TabIndex = 3;
            // 
            // ktbxConfirmPass
            // 
            this.ktbxConfirmPass.Location = new System.Drawing.Point(107, 246);
            this.ktbxConfirmPass.Name = "ktbxConfirmPass";
            this.ktbxConfirmPass.Size = new System.Drawing.Size(100, 23);
            this.ktbxConfirmPass.TabIndex = 4;
            // 
            // frmSignup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 411);
            this.Controls.Add(this.ktbxConfirmPass);
            this.Controls.Add(this.ktbxPassword);
            this.Controls.Add(this.ktbxEmail);
            this.Controls.Add(this.ktbxName);
            this.Controls.Add(this.klblConfirmPass);
            this.Controls.Add(this.klblPassword);
            this.Controls.Add(this.klblEmail);
            this.Controls.Add(this.klblName);
            this.Controls.Add(this.kbtnSignup);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmSignup";
            this.Text = "Anime Tracker Signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonButton kbtnSignup;
        private Krypton.Toolkit.KryptonLabel klblName;
        private Krypton.Toolkit.KryptonLabel klblEmail;
        private Krypton.Toolkit.KryptonLabel klblPassword;
        private Krypton.Toolkit.KryptonLabel klblConfirmPass;
        private Krypton.Toolkit.KryptonTextBox ktbxName;
        private Krypton.Toolkit.KryptonTextBox ktbxEmail;
        private Krypton.Toolkit.KryptonTextBox ktbxPassword;
        private Krypton.Toolkit.KryptonTextBox ktbxConfirmPass;
    }
}
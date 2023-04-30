namespace AnimeTracker
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
            this.components = new System.ComponentModel.Container();
            this.kryptonPalette1 = new Krypton.Toolkit.KryptonPalette(this.components);
            this.kgrpContainer = new Krypton.Toolkit.KryptonGroup();
            this.kbtnSignup = new Krypton.Toolkit.KryptonButton();
            this.kbtnLogin = new Krypton.Toolkit.KryptonButton();
            this.ktbxUsername = new Krypton.Toolkit.KryptonTextBox();
            this.ktbxPassword = new Krypton.Toolkit.KryptonTextBox();
            this.klblPasswordHeader = new Krypton.Toolkit.KryptonLabel();
            this.klblUsernameHeader = new Krypton.Toolkit.KryptonLabel();
            this.klblTitle = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpContainer.Panel)).BeginInit();
            this.kgrpContainer.Panel.SuspendLayout();
            this.kgrpContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // kryptonPalette1
            // 
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.kryptonPalette1.FormStyles.FormCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            // 
            // kgrpContainer
            // 
            this.kgrpContainer.Location = new System.Drawing.Point(142, 55);
            this.kgrpContainer.Name = "kgrpContainer";
            // 
            // kgrpContainer.Panel
            // 
            this.kgrpContainer.Panel.Controls.Add(this.kbtnSignup);
            this.kgrpContainer.Panel.Controls.Add(this.kbtnLogin);
            this.kgrpContainer.Panel.Controls.Add(this.ktbxUsername);
            this.kgrpContainer.Panel.Controls.Add(this.ktbxPassword);
            this.kgrpContainer.Panel.Controls.Add(this.klblPasswordHeader);
            this.kgrpContainer.Panel.Controls.Add(this.klblUsernameHeader);
            this.kgrpContainer.Panel.MinimumSize = new System.Drawing.Size(450, 350);
            this.kgrpContainer.Size = new System.Drawing.Size(500, 400);
            this.kgrpContainer.StateCommon.Back.Color1 = System.Drawing.Color.Silver;
            this.kgrpContainer.StateCommon.Back.Color2 = System.Drawing.Color.Silver;
            this.kgrpContainer.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpContainer.StateCommon.Border.Rounding = 25F;
            this.kgrpContainer.TabIndex = 1;
            // 
            // kbtnSignup
            // 
            this.kbtnSignup.CornerRoundingRadius = 25F;
            this.kbtnSignup.Location = new System.Drawing.Point(170, 317);
            this.kbtnSignup.Name = "kbtnSignup";
            this.kbtnSignup.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kbtnSignup.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kbtnSignup.Size = new System.Drawing.Size(143, 34);
            this.kbtnSignup.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnSignup.StateCommon.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnSignup.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtnSignup.StateCommon.Border.Rounding = 25F;
            this.kbtnSignup.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kbtnSignup.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kbtnSignup.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnSignup.TabIndex = 4;
            this.kbtnSignup.Values.Text = "Sign up";
            this.kbtnSignup.Click += new System.EventHandler(this.kbtnSignup_Click);
            // 
            // kbtnLogin
            // 
            this.kbtnLogin.CornerRoundingRadius = 25F;
            this.kbtnLogin.Location = new System.Drawing.Point(170, 264);
            this.kbtnLogin.Name = "kbtnLogin";
            this.kbtnLogin.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.kbtnLogin.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.kbtnLogin.Size = new System.Drawing.Size(143, 34);
            this.kbtnLogin.StateCommon.Back.Color1 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnLogin.StateCommon.Back.Color2 = System.Drawing.Color.DeepSkyBlue;
            this.kbtnLogin.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kbtnLogin.StateCommon.Border.Rounding = 25F;
            this.kbtnLogin.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kbtnLogin.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.White;
            this.kbtnLogin.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kbtnLogin.TabIndex = 3;
            this.kbtnLogin.Values.Text = "Log in";
            this.kbtnLogin.Click += new System.EventHandler(this.kbtnLogin_Click);
            // 
            // ktbxUsername
            // 
            this.ktbxUsername.CueHint.Color1 = System.Drawing.Color.Gray;
            this.ktbxUsername.CueHint.CueHintText = "email@gmail.com";
            this.ktbxUsername.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.ktbxUsername.Location = new System.Drawing.Point(144, 58);
            this.ktbxUsername.Name = "ktbxUsername";
            this.ktbxUsername.Size = new System.Drawing.Size(194, 39);
            this.ktbxUsername.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktbxUsername.StateCommon.Border.Rounding = 25F;
            this.ktbxUsername.TabIndex = 1;
            // 
            // ktbxPassword
            // 
            this.ktbxPassword.CueHint.Color1 = System.Drawing.Color.Gray;
            this.ktbxPassword.CueHint.CueHintText = "password...";
            this.ktbxPassword.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.ktbxPassword.Location = new System.Drawing.Point(144, 203);
            this.ktbxPassword.Name = "ktbxPassword";
            this.ktbxPassword.PasswordChar = '*';
            this.ktbxPassword.Size = new System.Drawing.Size(194, 39);
            this.ktbxPassword.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktbxPassword.StateCommon.Border.Rounding = 25F;
            this.ktbxPassword.TabIndex = 2;
            // 
            // klblPasswordHeader
            // 
            this.klblPasswordHeader.Location = new System.Drawing.Point(209, 168);
            this.klblPasswordHeader.Name = "klblPasswordHeader";
            this.klblPasswordHeader.Size = new System.Drawing.Size(62, 20);
            this.klblPasswordHeader.TabIndex = 1;
            this.klblPasswordHeader.Values.Text = "Password";
            // 
            // klblUsernameHeader
            // 
            this.klblUsernameHeader.Location = new System.Drawing.Point(209, 32);
            this.klblUsernameHeader.Name = "klblUsernameHeader";
            this.klblUsernameHeader.Size = new System.Drawing.Size(65, 20);
            this.klblUsernameHeader.TabIndex = 0;
            this.klblUsernameHeader.Values.Text = "Username\r\n";
            // 
            // klblTitle
            // 
            this.klblTitle.Location = new System.Drawing.Point(301, 12);
            this.klblTitle.Name = "klblTitle";
            this.klblTitle.Size = new System.Drawing.Size(183, 37);
            this.klblTitle.StateCommon.ShortText.Color1 = System.Drawing.Color.Black;
            this.klblTitle.StateCommon.ShortText.Color2 = System.Drawing.Color.Black;
            this.klblTitle.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblTitle.TabIndex = 2;
            this.klblTitle.Values.Text = "Anime Tracker";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.klblTitle);
            this.Controls.Add(this.kgrpContainer);
            this.CornerRoundingRadius = 25F;
            this.ForeColor = System.Drawing.Color.FloralWhite;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Back.Color1 = System.Drawing.Color.White;
            this.StateCommon.Back.Color2 = System.Drawing.Color.White;
            this.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 25F;
            this.Text = "Anime Tracker Software";
            this.TextExtra = "";
            ((System.ComponentModel.ISupportInitialize)(this.kgrpContainer.Panel)).EndInit();
            this.kgrpContainer.Panel.ResumeLayout(false);
            this.kgrpContainer.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpContainer)).EndInit();
            this.kgrpContainer.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Krypton.Toolkit.KryptonPalette kryptonPalette1;
        private Krypton.Toolkit.KryptonGroup kgrpContainer;
        private Krypton.Toolkit.KryptonTextBox ktbxPassword;
        private Krypton.Toolkit.KryptonLabel klblPasswordHeader;
        private Krypton.Toolkit.KryptonLabel klblUsernameHeader;
        private Krypton.Toolkit.KryptonButton kbtnLogin;
        private Krypton.Toolkit.KryptonTextBox ktbxUsername;
        private Krypton.Toolkit.KryptonButton kbtnSignup;
        private Krypton.Toolkit.KryptonLabel klblTitle;
    }
}


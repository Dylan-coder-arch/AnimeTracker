namespace AnimeTracker
{
    partial class uctAdd
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
            this.ktxbName = new Krypton.Toolkit.KryptonTextBox();
            this.klblName = new Krypton.Toolkit.KryptonLabel();
            this.klblStartDate = new Krypton.Toolkit.KryptonLabel();
            this.klblEndDate = new Krypton.Toolkit.KryptonLabel();
            this.klblRating = new Krypton.Toolkit.KryptonLabel();
            this.kdtpStartDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.kdtpEndDate = new Krypton.Toolkit.KryptonDateTimePicker();
            this.knudRating = new Krypton.Toolkit.KryptonNumericUpDown();
            this.kbtnAdd = new Krypton.Toolkit.KryptonButton();
            this.klblHeader = new Krypton.Toolkit.KryptonLabel();
            this.SuspendLayout();
            // 
            // ktxbName
            // 
            this.ktxbName.Location = new System.Drawing.Point(333, 136);
            this.ktxbName.Name = "ktxbName";
            this.ktxbName.Size = new System.Drawing.Size(259, 39);
            this.ktxbName.StateCommon.Border.DrawBorders = ((Krypton.Toolkit.PaletteDrawBorders)((((Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | Krypton.Toolkit.PaletteDrawBorders.Left) 
            | Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.ktxbName.StateCommon.Border.Rounding = 25F;
            this.ktxbName.TabIndex = 0;
            // 
            // klblName
            // 
            this.klblName.Location = new System.Drawing.Point(158, 136);
            this.klblName.Name = "klblName";
            this.klblName.Size = new System.Drawing.Size(79, 29);
            this.klblName.StateCommon.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblName.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblName.TabIndex = 1;
            this.klblName.Values.Text = "Name:";
            // 
            // klblStartDate
            // 
            this.klblStartDate.Location = new System.Drawing.Point(147, 213);
            this.klblStartDate.Name = "klblStartDate";
            this.klblStartDate.Size = new System.Drawing.Size(114, 29);
            this.klblStartDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblStartDate.TabIndex = 2;
            this.klblStartDate.Values.Text = "Start Date";
            // 
            // klblEndDate
            // 
            this.klblEndDate.Location = new System.Drawing.Point(155, 278);
            this.klblEndDate.Name = "klblEndDate";
            this.klblEndDate.Size = new System.Drawing.Size(106, 29);
            this.klblEndDate.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblEndDate.TabIndex = 3;
            this.klblEndDate.Values.Text = "End Date";
            // 
            // klblRating
            // 
            this.klblRating.Location = new System.Drawing.Point(158, 341);
            this.klblRating.Name = "klblRating";
            this.klblRating.Size = new System.Drawing.Size(79, 29);
            this.klblRating.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblRating.TabIndex = 4;
            this.klblRating.Values.Text = "Rating";
            // 
            // kdtpStartDate
            // 
            this.kdtpStartDate.CornerRoundingRadius = -1F;
            this.kdtpStartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kdtpStartDate.Location = new System.Drawing.Point(333, 221);
            this.kdtpStartDate.Name = "kdtpStartDate";
            this.kdtpStartDate.Size = new System.Drawing.Size(160, 21);
            this.kdtpStartDate.TabIndex = 6;
            // 
            // kdtpEndDate
            // 
            this.kdtpEndDate.CornerRoundingRadius = -1F;
            this.kdtpEndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.kdtpEndDate.Location = new System.Drawing.Point(333, 286);
            this.kdtpEndDate.Name = "kdtpEndDate";
            this.kdtpEndDate.Size = new System.Drawing.Size(160, 21);
            this.kdtpEndDate.TabIndex = 7;
            // 
            // knudRating
            // 
            this.knudRating.Location = new System.Drawing.Point(333, 348);
            this.knudRating.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.knudRating.Name = "knudRating";
            this.knudRating.Size = new System.Drawing.Size(120, 22);
            this.knudRating.TabIndex = 9;
            // 
            // kbtnAdd
            // 
            this.kbtnAdd.CornerRoundingRadius = -1F;
            this.kbtnAdd.Location = new System.Drawing.Point(302, 421);
            this.kbtnAdd.Name = "kbtnAdd";
            this.kbtnAdd.Size = new System.Drawing.Size(90, 25);
            this.kbtnAdd.TabIndex = 11;
            this.kbtnAdd.Values.Text = "Add";
            this.kbtnAdd.Click += new System.EventHandler(this.kbtnAdd_Click);
            // 
            // klblHeader
            // 
            this.klblHeader.Location = new System.Drawing.Point(198, 28);
            this.klblHeader.Name = "klblHeader";
            this.klblHeader.Size = new System.Drawing.Size(362, 49);
            this.klblHeader.StateCommon.ShortText.Color1 = System.Drawing.Color.DimGray;
            this.klblHeader.StateCommon.ShortText.Color2 = System.Drawing.Color.DimGray;
            this.klblHeader.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblHeader.TabIndex = 13;
            this.klblHeader.Values.Text = "General Tracking Add:";
            // 
            // uctAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.klblHeader);
            this.Controls.Add(this.kbtnAdd);
            this.Controls.Add(this.knudRating);
            this.Controls.Add(this.kdtpEndDate);
            this.Controls.Add(this.kdtpStartDate);
            this.Controls.Add(this.klblRating);
            this.Controls.Add(this.klblEndDate);
            this.Controls.Add(this.klblStartDate);
            this.Controls.Add(this.klblName);
            this.Controls.Add(this.ktxbName);
            this.Name = "uctAdd";
            this.Size = new System.Drawing.Size(738, 506);
            this.Load += new System.EventHandler(this.uctAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonTextBox ktxbName;
        private Krypton.Toolkit.KryptonLabel klblName;
        private Krypton.Toolkit.KryptonLabel klblStartDate;
        private Krypton.Toolkit.KryptonLabel klblEndDate;
        private Krypton.Toolkit.KryptonLabel klblRating;
        private Krypton.Toolkit.KryptonDateTimePicker kdtpStartDate;
        private Krypton.Toolkit.KryptonDateTimePicker kdtpEndDate;
        private Krypton.Toolkit.KryptonNumericUpDown knudRating;
        private Krypton.Toolkit.KryptonButton kbtnAdd;
        private Krypton.Toolkit.KryptonLabel klblHeader;
    }
}

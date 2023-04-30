namespace AnimeTracker
{
    partial class uctDash
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
            this.kdgvAnime = new Krypton.Toolkit.KryptonDataGridView();
            this.ktbxSearch = new Krypton.Toolkit.KryptonTextBox();
            this.klblSearchText = new Krypton.Toolkit.KryptonLabel();
            ((System.ComponentModel.ISupportInitialize)(this.kdgvAnime)).BeginInit();
            this.SuspendLayout();
            // 
            // kdgvAnime
            // 
            this.kdgvAnime.AllowUserToAddRows = false;
            this.kdgvAnime.AllowUserToDeleteRows = false;
            this.kdgvAnime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.kdgvAnime.Location = new System.Drawing.Point(31, 135);
            this.kdgvAnime.Name = "kdgvAnime";
            this.kdgvAnime.Size = new System.Drawing.Size(669, 290);
            this.kdgvAnime.TabIndex = 0;
            // 
            // ktbxSearch
            // 
            this.ktbxSearch.Location = new System.Drawing.Point(280, 96);
            this.ktbxSearch.Name = "ktbxSearch";
            this.ktbxSearch.Size = new System.Drawing.Size(279, 23);
            this.ktbxSearch.TabIndex = 1;
            this.ktbxSearch.TextChanged += new System.EventHandler(this.ktbxSearch_TextChanged);
            // 
            // klblSearchText
            // 
            this.klblSearchText.Location = new System.Drawing.Point(51, 93);
            this.klblSearchText.Name = "klblSearchText";
            this.klblSearchText.Size = new System.Drawing.Size(64, 26);
            this.klblSearchText.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.klblSearchText.TabIndex = 2;
            this.klblSearchText.Values.Text = "Search:";
            // 
            // uctDash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.klblSearchText);
            this.Controls.Add(this.ktbxSearch);
            this.Controls.Add(this.kdgvAnime);
            this.Name = "uctDash";
            this.Size = new System.Drawing.Size(738, 506);
            this.Load += new System.EventHandler(this.uctDash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kdgvAnime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView kdgvAnime;
        private Krypton.Toolkit.KryptonTextBox ktbxSearch;
        private Krypton.Toolkit.KryptonLabel klblSearchText;
    }
}

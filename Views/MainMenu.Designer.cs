
namespace TheHighestLevel.Views
{
    partial class MainMenu
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
            this.scoreTable = new System.Windows.Forms.DataGridView();
            this.btn_keluar = new System.Windows.Forms.Button();
            this.btn_mulai = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).BeginInit();
            this.SuspendLayout();
            // 
            // scoreTable
            // 
            this.scoreTable.AllowUserToAddRows = false;
            this.scoreTable.AllowUserToDeleteRows = false;
            this.scoreTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.scoreTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scoreTable.Cursor = System.Windows.Forms.Cursors.Default;
            this.scoreTable.Location = new System.Drawing.Point(230, 168);
            this.scoreTable.Name = "scoreTable";
            this.scoreTable.ReadOnly = true;
            this.scoreTable.RowHeadersWidth = 40;
            this.scoreTable.RowTemplate.Height = 25;
            this.scoreTable.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.scoreTable.Size = new System.Drawing.Size(340, 164);
            this.scoreTable.TabIndex = 1;
            // 
            // btn_keluar
            // 
            this.btn_keluar.Location = new System.Drawing.Point(450, 358);
            this.btn_keluar.Name = "btn_keluar";
            this.btn_keluar.Size = new System.Drawing.Size(100, 34);
            this.btn_keluar.TabIndex = 7;
            this.btn_keluar.Text = "Keluar";
            this.btn_keluar.UseVisualStyleBackColor = true;
            this.btn_keluar.Click += new System.EventHandler(this.btn_keluar_Click);
            // 
            // btn_mulai
            // 
            this.btn_mulai.Location = new System.Drawing.Point(250, 358);
            this.btn_mulai.Name = "btn_mulai";
            this.btn_mulai.Size = new System.Drawing.Size(100, 34);
            this.btn_mulai.TabIndex = 8;
            this.btn_mulai.Text = "Mulai";
            this.btn_mulai.UseVisualStyleBackColor = true;
            this.btn_mulai.Click += new System.EventHandler(this.btn_mulai_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(295, 42);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(211, 30);
            this.lbl_title.TabIndex = 6;
            this.lbl_title.Text = "THE HIGHEST LEVEL";
            // 
            // tb_username
            // 
            this.tb_username.Location = new System.Drawing.Point(310, 118);
            this.tb_username.MaxLength = 10;
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(180, 23);
            this.tb_username.TabIndex = 5;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_mulai);
            this.Controls.Add(this.btn_keluar);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.scoreTable);
            this.Name = "MainMenu";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.VisibleChanged += new System.EventHandler(this.MainMenu_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.scoreTable)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView scoreTable;
        private System.Windows.Forms.Button btn_keluar;
        private System.Windows.Forms.Button btn_mulai;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TextBox tb_username;
    }
}

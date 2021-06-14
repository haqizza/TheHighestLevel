
namespace TheHighestLevel.Views
{
    partial class GamePlay
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.floor0 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_title.Location = new System.Drawing.Point(350, 126);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(116, 30);
            this.lbl_title.TabIndex = 7;
            this.lbl_title.Text = "Game Play";
            this.lbl_title.Click += new System.EventHandler(this.lbl_title_Click);
            // 
            // floor0
            // 
            this.floor0.BackgroundImage = global::TheHighestLevel.Properties.Resources._1;
            this.floor0.Location = new System.Drawing.Point(0, 475);
            this.floor0.Name = "floor0";
            this.floor0.Size = new System.Drawing.Size(800, 25);
            this.floor0.TabIndex = 8;
            this.floor0.TabStop = false;
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.floor0);
            this.Controls.Add(this.lbl_title);
            this.Name = "GamePlay";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.GamePlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.PictureBox floor0;
    }
}

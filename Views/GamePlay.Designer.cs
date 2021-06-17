
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
            this.components = new System.ComponentModel.Container();
            this.floor0 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.lbl_Success = new System.Windows.Forms.Label();
            this.lbl_Fail = new System.Windows.Forms.Label();
            this.lbl_SuccessScore = new System.Windows.Forms.Label();
            this.lbl_FailScore = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.timer4 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // floor0
            // 
            this.floor0.ErrorImage = null;
            this.floor0.InitialImage = null;
            this.floor0.Location = new System.Drawing.Point(0, 470);
            this.floor0.Margin = new System.Windows.Forms.Padding(0);
            this.floor0.Name = "floor0";
            this.floor0.Size = new System.Drawing.Size(800, 30);
            this.floor0.TabIndex = 8;
            this.floor0.TabStop = false;
            this.floor0.Tag = "brick";
            // 
            // player
            // 
            this.player.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.ErrorImage = null;
            this.player.Image = global::TheHighestLevel.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(396, 420);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 50);
            this.player.TabIndex = 10;
            this.player.TabStop = false;
            this.player.Tag = "player";
            // 
            // lbl_Success
            // 
            this.lbl_Success.AutoSize = true;
            this.lbl_Success.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Success.Location = new System.Drawing.Point(3, 0);
            this.lbl_Success.Name = "lbl_Success";
            this.lbl_Success.Size = new System.Drawing.Size(65, 19);
            this.lbl_Success.TabIndex = 11;
            this.lbl_Success.Text = "Success :";
            // 
            // lbl_Fail
            // 
            this.lbl_Fail.AutoSize = true;
            this.lbl_Fail.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Fail.Location = new System.Drawing.Point(3, 20);
            this.lbl_Fail.Name = "lbl_Fail";
            this.lbl_Fail.Size = new System.Drawing.Size(34, 19);
            this.lbl_Fail.TabIndex = 12;
            this.lbl_Fail.Text = "Fail:";
            // 
            // lbl_SuccessScore
            // 
            this.lbl_SuccessScore.AutoSize = true;
            this.lbl_SuccessScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbl_SuccessScore.Location = new System.Drawing.Point(74, 0);
            this.lbl_SuccessScore.Name = "lbl_SuccessScore";
            this.lbl_SuccessScore.Size = new System.Drawing.Size(17, 19);
            this.lbl_SuccessScore.TabIndex = 13;
            this.lbl_SuccessScore.Text = "0";
            // 
            // lbl_FailScore
            // 
            this.lbl_FailScore.AutoSize = true;
            this.lbl_FailScore.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_FailScore.Location = new System.Drawing.Point(74, 20);
            this.lbl_FailScore.Name = "lbl_FailScore";
            this.lbl_FailScore.Size = new System.Drawing.Size(17, 19);
            this.lbl_FailScore.TabIndex = 14;
            this.lbl_FailScore.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 57.72358F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 42.27642F));
            this.tableLayoutPanel1.Controls.Add(this.lbl_Success, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbl_Fail, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_FailScore, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbl_SuccessScore, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.21951F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.78049F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(123, 41);
            this.tableLayoutPanel1.TabIndex = 15;
            // 
            // timer3
            // 
            this.timer3.Enabled = true;
            this.timer3.Interval = 10000;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // timer4
            // 
            this.timer4.Enabled = true;
            this.timer4.Interval = 20000;
            this.timer4.Tick += new System.EventHandler(this.timer4_Tick);
            // 
            // GamePlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.floor0);
            this.Controls.Add(this.player);
            this.Name = "GamePlay";
            this.Size = new System.Drawing.Size(800, 500);
            this.Load += new System.EventHandler(this.GamePlay_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GamePlay_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.floor0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox floor0;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label lbl_Success;
        private System.Windows.Forms.Label lbl_Fail;
        private System.Windows.Forms.Label lbl_SuccessScore;
        private System.Windows.Forms.Label lbl_FailScore;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.Timer timer4;
    }
}

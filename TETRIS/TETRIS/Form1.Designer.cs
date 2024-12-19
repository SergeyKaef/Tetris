namespace TETRIS
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnDown;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.btnRotate = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(320, 123);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(76, 16);
            this.lblLevel.TabIndex = 2;
            this.lblLevel.Text = "Уровень: 1";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(320, 158);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(52, 16);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Счет: 0";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(323, 204);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 30);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Начать";
            //this.btnStart.Click += new System.EventHandler(this.btnStart_Click_1);
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(323, 240);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(100, 30);
            this.btnPause.TabIndex = 5;
            this.btnPause.Text = "Пауза";
            //this.btnPause.Click += new System.EventHandler(this.btnPause_Click_1);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(323, 276);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(100, 30);
            this.btnReset.TabIndex = 6;
            this.btnReset.Text = "Сброс";
            //this.btnReset.Click += new System.EventHandler(this.btnReset_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Следующая фигура";
            // 
            // btnLeft
            // 
          
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(544, 600);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.btnRotate);
            this.Controls.Add(this.btnRight);
            this.Controls.Add(this.btnLeft);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblLevel);
            this.Name = "Form1";
            this.Text = "Tetris Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}

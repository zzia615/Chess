namespace Chess
{
    partial class Chess
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chess));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fivechess = new System.Windows.Forms.NotifyIcon(this.components);
            this.chessstatus = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.chesstime = new System.Windows.Forms.ToolStripStatusLabel();
            this.chesstip = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.xpoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.ypoint = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picturenext = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.菜单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.重新开始ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑棋先下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.白棋先下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.黑棋悔棋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.帮助ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.关于ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.chessstatus.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturenext)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(12, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(491, 491);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // fivechess
            // 
            this.fivechess.Icon = ((System.Drawing.Icon)(resources.GetObject("fivechess.Icon")));
            this.fivechess.Text = "五子棋";
            this.fivechess.Visible = true;
            // 
            // chessstatus
            // 
            this.chessstatus.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel3,
            this.chesstime,
            this.chesstip,
            this.toolStripStatusLabel1,
            this.xpoint,
            this.toolStripStatusLabel2,
            this.ypoint});
            this.chessstatus.Location = new System.Drawing.Point(0, 540);
            this.chessstatus.Name = "chessstatus";
            this.chessstatus.Size = new System.Drawing.Size(784, 22);
            this.chessstatus.TabIndex = 1;
            this.chessstatus.Text = "statusStrip1";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(59, 17);
            this.toolStripStatusLabel3.Text = "当前时间:";
            // 
            // chesstime
            // 
            this.chesstime.Name = "chesstime";
            this.chesstime.Size = new System.Drawing.Size(0, 17);
            // 
            // chesstip
            // 
            this.chesstip.Name = "chesstip";
            this.chesstip.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(19, 17);
            this.toolStripStatusLabel1.Text = "X:";
            // 
            // xpoint
            // 
            this.xpoint.Name = "xpoint";
            this.xpoint.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(18, 17);
            this.toolStripStatusLabel2.Text = "Y:";
            // 
            // ypoint
            // 
            this.ypoint.Name = "ypoint";
            this.ypoint.Size = new System.Drawing.Size(0, 17);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // picturenext
            // 
            this.picturenext.Location = new System.Drawing.Point(483, 541);
            this.picturenext.Name = "picturenext";
            this.picturenext.Size = new System.Drawing.Size(20, 20);
            this.picturenext.TabIndex = 2;
            this.picturenext.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.菜单ToolStripMenuItem,
            this.帮助ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 25);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 菜单ToolStripMenuItem
            // 
            this.菜单ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.重新开始ToolStripMenuItem,
            this.黑棋先下ToolStripMenuItem,
            this.白棋先下ToolStripMenuItem,
            this.黑棋悔棋ToolStripMenuItem,
            this.退出ToolStripMenuItem});
            this.菜单ToolStripMenuItem.Name = "菜单ToolStripMenuItem";
            this.菜单ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.菜单ToolStripMenuItem.Text = "菜单";
            // 
            // 重新开始ToolStripMenuItem
            // 
            this.重新开始ToolStripMenuItem.Name = "重新开始ToolStripMenuItem";
            this.重新开始ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.重新开始ToolStripMenuItem.Text = "重新开始";
            this.重新开始ToolStripMenuItem.Click += new System.EventHandler(this.重新开始ToolStripMenuItem_Click);
            // 
            // 黑棋先下ToolStripMenuItem
            // 
            this.黑棋先下ToolStripMenuItem.Name = "黑棋先下ToolStripMenuItem";
            this.黑棋先下ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.黑棋先下ToolStripMenuItem.Text = "黑棋先下";
            this.黑棋先下ToolStripMenuItem.Click += new System.EventHandler(this.黑棋先下ToolStripMenuItem_Click);
            // 
            // 白棋先下ToolStripMenuItem
            // 
            this.白棋先下ToolStripMenuItem.Name = "白棋先下ToolStripMenuItem";
            this.白棋先下ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.白棋先下ToolStripMenuItem.Text = "白棋先下";
            this.白棋先下ToolStripMenuItem.Click += new System.EventHandler(this.白棋先下ToolStripMenuItem_Click);
            // 
            // 黑棋悔棋ToolStripMenuItem
            // 
            this.黑棋悔棋ToolStripMenuItem.Name = "黑棋悔棋ToolStripMenuItem";
            this.黑棋悔棋ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.黑棋悔棋ToolStripMenuItem.Text = "退一步棋";
            this.黑棋悔棋ToolStripMenuItem.Click += new System.EventHandler(this.退一步棋ToolStripMenuItem_Click);
            // 
            // 退出ToolStripMenuItem
            // 
            this.退出ToolStripMenuItem.Name = "退出ToolStripMenuItem";
            this.退出ToolStripMenuItem.Size = new System.Drawing.Size(124, 22);
            this.退出ToolStripMenuItem.Text = "退出";
            this.退出ToolStripMenuItem.Click += new System.EventHandler(this.退出ToolStripMenuItem_Click);
            // 
            // 帮助ToolStripMenuItem
            // 
            this.帮助ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.关于ToolStripMenuItem});
            this.帮助ToolStripMenuItem.Name = "帮助ToolStripMenuItem";
            this.帮助ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.帮助ToolStripMenuItem.Text = "帮助";
            // 
            // 关于ToolStripMenuItem
            // 
            this.关于ToolStripMenuItem.Name = "关于ToolStripMenuItem";
            this.关于ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.关于ToolStripMenuItem.Text = "关于";
            this.关于ToolStripMenuItem.Click += new System.EventHandler(this.关于ToolStripMenuItem_Click);
            // 
            // Chess
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.picturenext);
            this.Controls.Add(this.chessstatus);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(800, 600);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "Chess";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "五子棋";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.chessstatus.ResumeLayout(false);
            this.chessstatus.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picturenext)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NotifyIcon fivechess;
        private System.Windows.Forms.StatusStrip chessstatus;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel xpoint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel ypoint;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel chesstime;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ToolStripStatusLabel chesstip;
        private System.Windows.Forms.PictureBox picturenext;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 菜单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 重新开始ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑棋先下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 白棋先下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 黑棋悔棋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 帮助ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 关于ToolStripMenuItem;
    }
}


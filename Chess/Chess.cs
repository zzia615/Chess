using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Chess
{
    public partial class Chess : Form
    {
        ChessBroad cb = new ChessBroad();
        Bitmap chess;
        int count;
        bool Blocate;
        bool BSuccess;


        #region 重新开始游戏
        public void reset()
        {
            
        }
        #endregion


        public Chess()
        {
            InitializeComponent();
            chesstime.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
            #region 友情提示
            if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour < 3)
                chesstip.Text = "亲,很晚了！要早点休息哟！！！";
            else if (DateTime.Now.Hour < 19 && DateTime.Now.Hour >= 17)
                chesstip.Text = "亲,下班了！没事的话就早点回去吧！！！";
            else if (DateTime.Now.Hour < 22 && DateTime.Now.Hour >= 19)
                chesstip.Text = "亲,吃饭的时候！可别玩游戏哟！！！";
            else if (DateTime.Now.Hour < 17 && DateTime.Now.Hour >= 14)
                chesstip.Text = "亲,上班的时候要认真哟！！！";
            else if (DateTime.Now.Hour < 14 && DateTime.Now.Hour >= 12)
                chesstip.Text = "亲,中午想好要吃什么了么！！！";
            else if (DateTime.Now.Hour < 12 && DateTime.Now.Hour >= 9)
                chesstip.Text = "亲,早上上班的时候可别打瞌睡哟！！！";
            else if (DateTime.Now.Hour < 9 && DateTime.Now.Hour >= 7)
                chesstip.Text = "亲,早上好啊！上班的时候别迟到了哟！！！";
            else if (DateTime.Now.Hour < 7 && DateTime.Now.Hour >= 3)
                chesstip.Text = "亲,凌晨是不是应该小睡一下呢！！！";
            #endregion
            
            #region 绘制画板
            chess = cb.drawBoard();
            this.pictureBox1.BackgroundImage = chess;
            #endregion
            cb.Cor = Color.Black;
       
            picturenext.BackgroundImage= cb.PictureNext();

        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            #region 在这个区间才记录X轴 Y轴
            if ((e.Y >= 35 && e.Y <= 455) && (e.X >= 35 && e.X <= 455))
            {
                if (cb.getXY(e.Y) == -1 || cb.getXY(e.X) == -1) { Blocate = false; }
                else
                    Blocate = true;
                    ypoint.Text = cb.getXY(e.Y).ToString();
                    xpoint.Text = cb.getXY(e.X).ToString();
                
                
            }
            else
            {
                Blocate = false;
            }
            #endregion

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region 友情提示
            if (DateTime.Now.Hour >= 22 || DateTime.Now.Hour<3)
                chesstip.Text = "亲,很晚了！要早点休息哟！！！";
            else if (DateTime.Now.Hour<19&&DateTime.Now.Hour>=17)
                chesstip.Text = "亲,下班了！没事的话就早点回去吧！！！";
            else if (DateTime.Now.Hour < 22 && DateTime.Now.Hour >= 19)
                chesstip.Text = "亲,吃饭的时候！可别玩游戏哟！！！";
            else if (DateTime.Now.Hour < 17 && DateTime.Now.Hour >= 14)
                chesstip.Text = "亲,上班的时候要认真哟！！！";
            else if (DateTime.Now.Hour < 14 && DateTime.Now.Hour >= 12)
                chesstip.Text = "亲,中午想好要吃什么了么！！！";
            else if (DateTime.Now.Hour < 12 && DateTime.Now.Hour >= 9)
                chesstip.Text = "亲,早上上班的时候可别打瞌睡哟！！！";
            else if (DateTime.Now.Hour < 9 && DateTime.Now.Hour >= 7)
                chesstip.Text = "亲,早上好啊！上班的时候别迟到了哟！！！";
            else if (DateTime.Now.Hour < 7 && DateTime.Now.Hour >= 3)
                chesstip.Text = "亲,凌晨是不是应该小睡一下呢！！！";
            #endregion

            #region 计时
            chesstime.Text = DateTime.Now.ToString("yyyy.MM.dd HH:mm:ss");
            #endregion
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            #region 如果鼠标点击的地方在棋盘上面时,每点击一下改变颜色
            if (BSuccess == true) { MessageBox.Show("游戏已结束，请重新开始游戏"); return; }
            if (Blocate == true)       
            {
                
                 
                 
                 if (count == 0)
                 {
                     cb.ChangNextColor();
                     picturenext.BackgroundImage = cb.PictureNext();
                     count = 1;
                     pictureBox1.BackgroundImage = cb.pieceDown(chess, Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text));//在棋盘上没添加
                     cb.Record(new Point(Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text)));
                     Refresh();
                     if (cb.Check(new Point(Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text))) == 1)
                     {
                         //MessageBox.Show("你赢了");

                     }
                 }
                 else
                 {
                     if (cb.Find(new Point(Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text))) == 1)
                     {
                         cb.ChangNextColor();
                         picturenext.BackgroundImage = cb.PictureNext();
                         pictureBox1.BackgroundImage = cb.pieceDown(chess, Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text));//在棋盘上没添加
                         cb.Record(new Point(Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text)));
                         Refresh();
                         int ireturn=cb.Check(new Point(Convert.ToInt32(xpoint.Text), Convert.ToInt32(ypoint.Text)));
                         if (ireturn == 1)
                         {
                             MessageBox.Show("黑棋赢了");
                             BSuccess = true;
                         
                         }
                         else if (ireturn == 2) 
                         {
                             MessageBox.Show("白棋赢了");
                             BSuccess = true;
                         }
                         
                     }
                 }

            }
            #endregion
        }

        private void 重新开始ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb = new ChessBroad();
            chess=null;
            count=0;
            Blocate=false;
            BSuccess = false;
        
            chess = cb.drawBoard();
            pictureBox1.BackgroundImage = chess;
            this.Refresh();
            cb.Cor = Color.Black;
   
            picturenext.BackgroundImage = cb.PictureNext();
        }

        private void 黑棋先下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb = new ChessBroad();
            chess = null;
            count = 0;
            Blocate = false;
            BSuccess = false;
            chess = cb.drawBoard();
            pictureBox1.BackgroundImage = chess;
            this.Refresh();
            cb.Cor = Color.Black;
      
            picturenext.BackgroundImage = cb.PictureNext();
        }

        private void 白棋先下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            cb = new ChessBroad();
            chess = null;
            count = 0;
            Blocate = false;
            BSuccess = false;
            chess = cb.drawBoard();
            pictureBox1.BackgroundImage = chess;
            this.Refresh();
            cb.Cor = Color.White;
           
            picturenext.BackgroundImage = cb.PictureNext();
        }

        private void 退出ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 退一步棋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            chess = cb.drawBoard();
            
            pictureBox1.BackgroundImage = chess;
          
            pictureBox1.BackgroundImage = cb.BackStep(chess);
            picturenext.BackgroundImage = cb.PictureNext();
        }

        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("2020 五子棋");
        }
    }
}

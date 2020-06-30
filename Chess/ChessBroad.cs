using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Collections;
namespace Chess
{
    class ChessBroad
    {
        private ArrayList list = new ArrayList();
        private ArrayList Blist=new ArrayList();
        private ArrayList Wlist = new ArrayList();
        
        int Count = 0;
        private Color color;
        public Color Cor { get { return color; } set { color = value; } }
        public ArrayList List { get { return list; } set { list = value; } }
        #region 生成初始棋盘位图
        /// <summary>
        /// 生成初始棋盘位图
        /// </summary>
        /// <returns>初始棋盘位图</returns>
        public Bitmap drawBoard()
        {
            Bitmap broadPaper = new Bitmap(490, 490);
            Graphics myGraphic = Graphics.FromImage(broadPaper);

            //黑色画笔
            Pen blackPen = new Pen(Color.Black);
            //SolidBrush yellowBrush = new SolidBrush(Color.Yellow);
            //myGraphic.FillRectangle(yellowBrush, 0, 0, 490, 490);
            //画棋盘外框
            myGraphic.FillRectangle(new SolidBrush(Color.SandyBrown), 0, 0, 491, 491);
            myGraphic.DrawLine(blackPen, 5, 5, 5, 485);
            myGraphic.DrawLine(blackPen, 5, 485, 485, 485);
            myGraphic.DrawLine(blackPen, 485, 485, 485, 5);
            myGraphic.DrawLine(blackPen, 485, 5, 5, 5);
            myGraphic.DrawLine(blackPen, 10, 10, 10, 480);
            myGraphic.DrawLine(blackPen, 10, 480, 480, 480);
            myGraphic.DrawLine(blackPen, 480, 480, 480, 10);
            myGraphic.DrawLine(blackPen, 480, 10, 10, 10);
            //划格线
            int x = 35;
            for (int i = 0; i < 15; i++)
            {
                myGraphic.DrawLine(blackPen, 35, x, 455, x);
                myGraphic.DrawLine(blackPen, x, 35, x, 455);
                x += 30;
            }
            
            return broadPaper;
        }
        #endregion

        #region 下一步棋子
        public Bitmap PictureNext()
        {
            Bitmap chessnext = new Bitmap(20, 20);
            Graphics g = Graphics.FromImage(chessnext);
            SolidBrush b = new SolidBrush(color);
            g.FillEllipse(b,0,0,20,20);
            return chessnext;
        
        }
        #endregion

        #region 下一步棋的颜色
        public void ChangNextColor()
        {
            
            if (color == Color.Black)
            {
                color = Color.White;
                   
            }
            else
            {
                color = Color.Black;
            }

        }
        #endregion

        public int getXY(int xy)
        {
            xy -= 35;
            int shang = xy / 30;
            int yushu = xy - shang * 30;
            if (yushu < 10)
            {
                return shang;
            }
            else if (yushu > 20)
            {
                return ++shang;
            }
            return -1;
        }

        public Bitmap pieceDown(Bitmap chessBoard, int x, int y)
        {
            
                Graphics myGraphic = Graphics.FromImage(chessBoard);
                //计算坐标
                int xCoordinate = x * 30 + 20;
                int yCoordinate = y * 30 + 20;
                //画棋子
                if (color == Color.Black)
                {
                    myGraphic.FillEllipse(new SolidBrush(Color.White), xCoordinate, yCoordinate, 30, 30);
                }
                else
                {
                    myGraphic.FillEllipse(new SolidBrush(Color.Black), xCoordinate, yCoordinate, 30, 30);
                }
            
            return chessBoard;
        }

        public void Record(Point p)
        {
            list.Add(p);
            if (color == Color.Black)
            {
                Wlist.Add(p);
                
            }
            else
            {
                Blist.Add(p);
                
            }
        }

        public int Find(Point p)
        {
            if(list.Contains(p))
            {
                return -1;
            }
            return 1;
        }

        public int Check(Point p)
        {


            if (color == Color.White)
            {

                //计算各个方向相同的棋子
                #region 计算竖线的相邻棋子数
                //计算上方有的棋子数
                Count = 0;
                for (int i = p.Y - 1; i > -1; i--)
                {
                    if (Blist.Contains(new Point(p.X, i)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }


                }

                //计算下方有的棋子数

                for (int i = p.Y + 1; i < 15; i++)
                {
                    if (Blist.Contains(new Point(p.X, i)))
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region 计算横线相邻的棋子数
                Count = 0;
                //左边部分
                for (int i = p.X - 1; i > -1; i--)
                {
                    if (Blist.Contains(new Point(i, p.Y)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }


                }

                //右边棋子

                for (int i = p.X + 1; i < 15; i++)
                {
                    if (Blist.Contains(new Point(i, p.Y)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }
                }
                #endregion

                #region 计算45度角的棋子数
                Count = 0;
                //左上边部分
                int px, py;
                px = p.X;
                py = p.Y;
                for (int i = p.X - 1; i > -1; i--)
                {

                    py--;
                    if (Blist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }




                }

                //右下边棋子
                px = p.X;
                py = p.Y;
                for (int i = p.X + 1; i < 15; i++)
                {
                    py++;
                    if (Blist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }
                }

                #endregion

                #region 计算135度角的棋子数
                Count = 0;
                //左下边部分
                px = p.X;
                py = p.Y;
                for (int i = p.X - 1; i > -1; i--)
                {

                    py++;
                    if (Blist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }




                }

                //右上边棋子
                px = p.X;
                py = p.Y;
                for (int i = p.X + 1; i < 15; i++)
                {
                    py--;
                    if (Blist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 1;

                    }
                    else
                    {

                        break;
                    }
                }
                #endregion



            }
            else
            {
                //计算各个方向相同的棋子
                #region 计算竖线的相邻棋子数
                //计算上方有的棋子数
                Count = 0;
                for (int i = p.Y - 1; i > -1; i--)
                {
                    if (Wlist.Contains(new Point(p.X, i)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }


                }

                //计算下方有的棋子数

                for (int i = p.Y + 1; i < 15; i++)
                {
                    if (Wlist.Contains(new Point(p.X, i)))
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {
                        break;
                    }
                }
                #endregion

                #region 计算横线相邻的棋子数
                Count = 0;
                //左边部分
                for (int i = p.X - 1; i > -1; i--)
                {
                    if (Wlist.Contains(new Point(i, p.Y)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }


                }

                //右边棋子

                for (int i = p.X + 1; i < 15; i++)
                {
                    if (Wlist.Contains(new Point(i, p.Y)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }
                }
                #endregion

                #region 计算45度角的棋子数
                Count = 0;
                //左上边部分
                int px, py;
                px = p.X;
                py = p.Y;
                for (int i = p.X - 1; i > -1; i--)
                {

                    py--;
                    if (Wlist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }




                }

                //右下边棋子
                px = p.X;
                py = p.Y;
                for (int i = p.X + 1; i < 15; i++)
                {
                    py++;
                    if (Wlist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }
                }

                #endregion

                #region 计算135度角的棋子数
                Count = 0;
                //左下边部分
                px = p.X;
                py = p.Y;
                for (int i = p.X - 1; i > -1; i--)
                {

                    py++;
                    if (Wlist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }




                }

                //右上边棋子
                px = p.X;
                py = p.Y;
                for (int i = p.X + 1; i < 15; i++)
                {
                    py--;
                    if (Wlist.Contains(new Point(i, py)))  //黑棋的判断
                    {

                        Count++;
                        if (Count > 3)
                            return 2;

                    }
                    else
                    {

                        break;
                    }
                }
                #endregion
            
            }
            return 0;
        }

        public Bitmap BackStep(Bitmap chess)
        {

            if (list.Count < 1) { return chess; }
            if (color == Color.Black)   //如果这一步是白棋 下一步是黑棋
            {
                Wlist.RemoveAt(Wlist.Count - 1);
                color = Color.White;
              
                list.RemoveAt(list.Count - 1);
                goto lb;
            }
            else
            {
                Blist.RemoveAt(Blist.Count - 1);
                color = Color.Black;
                
                list.RemoveAt(list.Count - 1);
                goto lb;
            }
            lb:
            int i, j;
            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if (Blist.Contains(new Point(i, j)))
                    {
                        Graphics myGraphic = Graphics.FromImage(chess);
                        //计算坐标
                        int xCoordinate = i * 30 + 20;
                        int yCoordinate = j * 30 + 20;
                        //画棋子
                        myGraphic.FillEllipse(new SolidBrush(Color.Black), xCoordinate, yCoordinate, 30, 30);
                    }
                }
       
            }

            for (i = 0; i < 15; i++)
            {
                for (j = 0; j < 15; j++)
                {
                    if (Wlist.Contains(new Point(i, j)))
                    {
                        Graphics myGraphic = Graphics.FromImage(chess);
                        //计算坐标
                        int xCoordinate = i * 30 + 20;
                        int yCoordinate = j * 30 + 20;
                        //画棋子
                        myGraphic.FillEllipse(new SolidBrush(Color.White), xCoordinate, yCoordinate, 30, 30);
                    }
                }

            }

            return chess;



        }
    }
}

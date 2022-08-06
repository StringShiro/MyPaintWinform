using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyPaint
{
    public partial class MyPaint : Form
    {
        public MyPaint()
        {
            InitializeComponent();
            this.Width = 1280;
            this.Height = 720;
            bm = new Bitmap(pic.Width, pic.Height);
            g = Graphics.FromImage(bm);
            g.Clear(Color.White);
            pic.Image = bm;
        }

        Bitmap bm;
        Graphics g;
        bool paint = false;
        Point px, py;

        //making a pen
        Pen p = new Pen(Color.Black, 1);
        //making eraser
        Pen eraser = new Pen(Color.White, 50);
        //making a brush
        //SolidBrush b = new SolidBrush(Color.Black);

        int index;
        int x, y, sX, sY, cX, cY;

        ColorDialog cd = new ColorDialog();
        Color new_color;

        private void button1_Click(object sender, EventArgs e)
        {
            index = 1;
        }
        
        private void btn_eraser_Click(object sender, EventArgs e)
        {
            index = 2;
        }
        private void btn_brush_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btn_shape_Click(object sender, EventArgs e)
        {
            index = 6;
        }

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {

                if (index == 1)
                {
                    px = e.Location;
                    g.DrawLine(p, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    g.DrawLine(eraser, px, py);
                    py = px;
                }
                //if (index == 3)
                //{
                //    px = e.Location;
                //    g.DrawLine(eraser, px, py);
                //    py = px;
                //}
            }
            pic.Refresh();
            //set start and end point for cursor to get height and width
            x = e.X;
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;
        }

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X;
            cY = e.Y;
        }

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;
            sX = x - cX;
            sY = y - cY;

            //method to draw elise shape and rectangle shape if button is pressed
            if (index == 6)
            {
                g.DrawEllipse(p, cX, cY, sX, sY);
            }
            //if(index == 4)
            //{
            //    g.DrawRectangle(p, cX, cY, sX, sY);
            //}
        }
        private void pic_Paint(object sender, PaintEventArgs e)
        {
            //method to draw selected index and display current drawing position
            Graphics g = e.Graphics;
            if (paint) { 
                if (index == 6)
                {
                    g.DrawEllipse(p, cX, cY, sX, sY);
                }
                //if (index == 4)
                //{
                //    g.DrawRectangle(p, cX, cY, sX, sY);
                //}
            }
        }
        private void btn_palette_Click(object sender, EventArgs e)
        {
            //get color for pen
            cd.ShowDialog();
            new_color = cd.Color;
            //pic_color.BackColor = cd.Color;
            p.Color = cd.Color;
        }

        //static Point set_point(PictureBox pb, Point pt)
        //{ 
        //    //method to set and return color palette point
        //    float pX = 1f *pb.Image.Width / pb.Width;
        //    float pY = 1f *pb.Image.Height / pb.Height;
        //    return new Point((int)(pt.X * pX), (int)(pt.Y * pY));
        //}

        //private void btn_colorpicker_MouseClicked(object sender, MouseEventArgs e) 
        //{
        //    Point point = set_point(btn_colorpicker, e.Location);
        //    pic_color.BackColor = ((Bitmap)btn_colorpicker.Image).GetPixel(point.X, point.Y);
        //    new_color = pic_color.BackColor;
        //    p.Color = pic_color.BackColor;
        //}
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MyPaint_Load(object sender, EventArgs e)
        {

        }

        private void Tool_Strip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void btn_pencil_MouseDown(object sender, MouseEventArgs e)
        {

        }
        private void btn_pencil_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void btn_pencil_MouseUp(object sender, MouseEventArgs e)
        {

        }
    }
}

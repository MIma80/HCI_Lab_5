using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HCI_Lab_5
{
    
    public partial class Form1 : Form
    {
        Graphics graphicsObj;
        Bitmap myBitmap;
        PaintEventArgs paintEventArgs;



        public Form1()
        {
            InitializeComponent();
            
            panel1.Height = panel1.Width;
            myBitmap = new Bitmap(panel1.Width, panel1.Height, System.Drawing.Imaging.PixelFormat.Format24bppRgb);

            //Pen pen = new Pen(CurrentDrawing.currentColour, CurrentDrawing.currentTool);

            //graphicsObj = Graphics.FromImage(myBitmap);
            //graphicsObj.DrawLine(pen, panel1.Location.X, panel1.Location.Y, panel1.Location.X + panel1.Width - 50, panel1.Location.Y + panel1.Width - 50);

            //graphicsObj.Dispose();

            CurrentDrawing.SetDrawing(1, 1, Color.Black);
            Draw();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphicsObj = e.Graphics;
            graphicsObj.DrawImage(myBitmap, panel1.DisplayRectangle);
            graphicsObj.Dispose();
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
        
        private void Draw()
        {
            graphicsObj = Graphics.FromImage(myBitmap);
            graphicsObj.Clear(Color.Gray);
            Pen pen = new Pen(CurrentDrawing.currentColour, CurrentDrawing.currentTool);

            switch (CurrentDrawing.currentTool)
            {
                case 1:
                    pen.Width = 4;
                    break;
                case 2:
                    pen.Width = 2;
                    break;
                case 3:
                    throw new Exception();
                default:
                    break;
            }
            switch (CurrentDrawing.currentShape)
            {
                case 1:
                    graphicsObj.DrawLine(pen, panel1.Location.X, panel1.Location.Y, panel1.Location.X + panel1.Width - 50, panel1.Location.Y + panel1.Width - 50);
                    break;
                case 2:
                    graphicsObj.DrawEllipse(pen, panel1.DisplayRectangle);
                    break;
                case 3:
                    graphicsObj.DrawRectangle(pen, panel1.DisplayRectangle);
                    break;
                default:
                    break;
            }

            //paintEventArgs = new PaintEventArgs(graphicsObj, panel1.DisplayRectangle);
            //(graphicsObj, paintEventArgs);

            graphicsObj.DrawImage(myBitmap, panel1.DisplayRectangle);
            panel1.Refresh();
            graphicsObj.Dispose();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton_Pen.Checked)
            {
                CurrentDrawing.currentTool = 1;
                Draw();
            }
        }
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                CurrentDrawing.currentTool = 2;
                Draw();
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                pictureBox1.Visible = true;
            }
            else
            {
                pictureBox1.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                CurrentDrawing.currentShape = 1;
                Draw();
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                CurrentDrawing.currentShape = 2;
                Draw();
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                CurrentDrawing.currentShape = 3;
                Draw();
            }
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                CurrentDrawing.currentColour = Color.Black;
                Draw();
            }
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                CurrentDrawing.currentColour = Color.Blue;
                Draw();
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                CurrentDrawing.currentColour = Color.Green;
                Draw();
            }
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton10.Checked)
            {
                CurrentDrawing.currentColour = Color.Cyan;
                Draw();
            }
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton14.Checked)
            {
                CurrentDrawing.currentColour = Color.Red;
                Draw();
            }
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton13.Checked)
            {
                CurrentDrawing.currentColour = Color.Magenta;
                Draw();
            }
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton12.Checked)
            {
                CurrentDrawing.currentColour = Color.Yellow;
                Draw();
            }
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton11.Checked)
            {
                CurrentDrawing.currentColour = Color.White;
                Draw();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {           
            System.Drawing.Graphics graphicsObj = panel1.CreateGraphics();

            graphicsObj.Clear(Color.FromArgb(224, 224, 224));

            var blue_color = new Blue();
            var red_color = new Red();

            Square square;
            Circle circle;

            if (radioButton1.Checked == true && radioButton3.Checked == true)
            {
                square = new Square { color = red_color };
                square.drawShape(graphicsObj);
            }
            else if (radioButton1.Checked == true && radioButton4.Checked == true)
            {
                square = new Square { color = blue_color };
                square.drawShape(graphicsObj);
            }
            else if (radioButton2.Checked == true && radioButton3.Checked == true)
            {
                circle = new Circle { color = red_color };
                circle.drawShape(graphicsObj);
            }
            else if (radioButton2.Checked == true && radioButton4.Checked == true)
            {
                circle = new Circle { color = blue_color };
                circle.drawShape(graphicsObj);
            }
        }
    }

    interface IColor
    {
        Color GetColor();
    }

    class Blue : IColor
    {
        public Color GetColor()
        {
            return Color.Blue;
        }
    }

    class Red : IColor
    {
        public Color GetColor()
        {
            return Color.Red;
        }
    }

    abstract class Shape
    {
        public IColor color { get; set; }

        public Color GetColor()
        {
            return color.GetColor();
        }

        public abstract void drawShape(Graphics graphics);
    }

    class Square : Shape
    {
        public override void drawShape(Graphics graphics)
        {
            Pen myPen = new Pen(color.GetColor(), 5);

            Rectangle myRectangle = new Rectangle(100, 100, 100, 100);

            graphics.DrawRectangle(myPen, myRectangle);
        }
    }

    class Circle : Shape
    {
        public override void drawShape(Graphics graphics)
        {
            Pen myPen = new Pen(color.GetColor(), 5);

            Rectangle myRectangle = new Rectangle(100, 100, 100, 100);

            graphics.DrawEllipse(myPen, myRectangle);           
        }
    }
}

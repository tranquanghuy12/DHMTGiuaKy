using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SharpGL;
using SharpGL.WinForms;
using System.Text.RegularExpressions;

namespace FirstSharpGLProject
{

    public partial class Form1 : Form
    {

       

        public class Shape
        {   public Color ShapeColor { get; set; }
            public float Size { get; set; } // Size of the edge (pixel)
            public virtual void draw(OpenGL gl)
            {
                gl.Color(ShapeColor.R / 255.0, ShapeColor.G / 255.0, ShapeColor.B / 255.0, 0);   
            }
        }

        public class Line : Shape
        {
            public Point Start { get; set; }
            public Point End { get; set; }

            public override void draw(OpenGL gl)
            {
                base.draw(gl);
                gl.LineWidth(Size);
                gl.Begin(OpenGL.GL_LINES);
                gl.Vertex(Start.X, gl.RenderContextProvider.Height - Start.Y);
                gl.Vertex(End.X, gl.RenderContextProvider.Height - End.Y);
                gl.End();
                gl.Flush();// Thực hiện lệnh vẽ ngay lập tức thay vì đợi sau 1 khoảng thời gian
            }
        }
        
        public class Rectangle : Shape
        {
            public Point Start { get; set; }
            public Point End { get; set; }
            
            
            public override void draw(OpenGL gl)
            {
                base.draw(gl);
                gl.Begin(OpenGL.GL_LINE_LOOP);
               
                gl.Vertex(Start.X, gl.RenderContextProvider.Height - Start.Y);//top left
                gl.Vertex(Start.X, gl.RenderContextProvider.Height - End.Y);//bottom left

                gl.Vertex(End.X, gl.RenderContextProvider.Height - End.Y);//top right
                gl.Vertex(End.X, gl.RenderContextProvider.Height - Start.Y);//bottom right
               
                gl.End();
                gl.Flush();// Thực hiện lệnh vẽ ngay lập tức thay vì đợi sau 1 khoảng thời gian
            }
        }

        /*Phần vẽ Ellipse cho bạn nào làm tham khảo*/

        //public class Ellipse : Shape
        //{
        //    public Point Start { get; set; }
        //    public Point End { get; set; }

        //    public override void draw(OpenGL gl)
        //    {
        //        base.draw(gl);
        //        gl.PointSize(Size);
        //        int rx = Math.Abs(Start.X - End.X) / 2;
        //        int ry = Math.Abs(Start.Y - End.Y) / 2;

        //        // Coordinate of the center
        //        int xc = (Start.X + End.X) / 2;
        //        int yc = (Start.Y + End.Y) / 2; 
        //        List<Point> points = new List<Point>();

        //        float dx, dy, d1, d2;
        //        int x, y;
        //        x = 0;
        //        y = ry;

        //        // Initial decision parameter of region 1 
        //        d1 = (ry * ry) - (rx * rx * ry) +
        //                         (float)(0.25 * rx * rx);
        //        dx = 2 * ry * ry * x;
        //        dy = 2 * rx * rx * y;

        //        // For region 1 
        //        while (dx < dy)
        //        {

        //            // Add points based on 4-way symmetry
        //            List<Point> newPoints = new List<Point>
        //            {
        //                new Point(x + xc, y + yc),
        //                new Point(-x + xc, y + yc),
        //                new Point(x + xc, -y + yc),
        //                new Point(-x + xc, -y + yc)
        //            };
        //            points.AddRange(newPoints);
                    

        //            // Checking and updating value of 
        //            // decision parameter based on algorithm 
        //            if (d1 < 0)
        //            {
        //                x++;
        //                dx = dx + (2 * ry * ry);
        //                d1 = d1 + dx + (ry * ry);
        //            }
        //            else
        //            {
        //                x++;
        //                y--;
        //                dx = dx + (2 * ry * ry);
        //                dy = dy - (2 * rx * rx);
        //                d1 = d1 + dx - dy + (ry * ry);
        //            }
        //        }

        //        // Decision parameter of region 2 
        //        d2 = ((ry * ry) * ((float)(x + 0.5) * (float)(x + 0.5))) +
        //             ((rx * rx) * ((y - 1) * (y - 1))) -
        //              (rx * rx * ry * ry);

        //        // Plotting points of region 2 
        //        while (y >= 0)
        //        {

                   
        //            // Add points based on 4-way symmetry
        //            List<Point> newPoints = new List<Point>
        //            {
        //                new Point(x + xc, y + yc),
        //                new Point(-x + xc, y + yc),
        //                new Point(x + xc, -y + yc),
        //                new Point(-x + xc, -y + yc)
        //            };
        //            points.AddRange(newPoints);

        //            // Checking and updating parameter 
        //            // value based on algorithm 
        //            if (d2 > 0)
        //            {
        //                y--;
        //                dy = dy - (2 * rx * rx);
        //                d2 = d2 + (rx * rx) - dy;
        //            }
        //            else
        //            {
        //                y--;
        //                x++;
        //                dx = dx + (2 * ry * ry);
        //                dy = dy - (2 * rx * rx);
        //                d2 = d2 + dx - dy + (rx * rx);
        //            }
        //        }


        //        gl.Begin(OpenGL.GL_POINTS);
        //        foreach (Point point in points)
        //        {
        //            gl.Vertex(point.X, gl.RenderContextProvider.Height - point.Y);
        //        }
                
        //        gl.End();
        //        gl.Flush();
        //    }
        //}

       
        private float ConvertValueComboBoxToFloat(string valueCbo)
        {
            string resultString = Regex.Match(valueCbo, @"\d+").Value;
            return float.Parse(resultString);
        }

        Color userColor;
        int shShape;
        float shSize;
        Point pStart, pEnd;
        int drawing = 0; // 'drawing' variable helps drawing in mouse move event 
        List<Shape> shapes = new List<Shape>();

        public Form1()
        {
            InitializeComponent();
            userColor = Color.Black;
            shShape = 0;
            cboSize.SelectedIndex = 0;
            shSize = 1;
        }

        private void RedrawScreen(OpenGL gl)
        {
            foreach (Shape shape in shapes)
                shape.draw(gl);
        }

        private void openGLControl_OpenGLInitialized(object sender, EventArgs e)
        {

            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the clear color.
            gl.ClearColor(1, 1, 1, 0);
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
        }

        private void openGLControl_Resized(object sender, EventArgs e)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Set the projection matrix.
            gl.MatrixMode(OpenGL.GL_PROJECTION);
            // Load the identity.
            gl.LoadIdentity();
            // Create a perspective transformation.
            gl.Viewport(0, 0, openGLControl.Width, openGLControl.Height);
            gl.Ortho2D(0, openGLControl.Width, 0, openGLControl.Height);
        }

        private void openGLControl_OpenGLDraw(object sender, RenderEventArgs args)
        {
            // Get the OpenGL object.
            OpenGL gl = openGLControl.OpenGL;
            // Clear the color and depth buffer.
            gl.Clear(OpenGL.GL_COLOR_BUFFER_BIT | OpenGL.GL_DEPTH_BUFFER_BIT);
           
            RedrawScreen(gl);

            if (drawing != 0)
            {
                switch(shShape)
                {
                    case 0:
                        Line newLine = new Line
                        {
                            Start = pStart,
                            End = pEnd,
                            ShapeColor = userColor,
                            Size = shSize
                        };
                        newLine.draw(gl);
                        if (drawing == 2)
                        {
                            shapes.Add(newLine);
                            drawing = 0;
                        }
                        break;
                    case 1: // Vẽ hình tròn ở đây
                        if (drawing == 2)
                        {
                            drawing = 0;
                        }
                        break;
                    case 2: // Vẽ hình ellipse
                        //Ellipse ellipse = new Ellipse
                        //{
                        //    Start = pStart,
                        //    End = pEnd,
                        //    ShapeColor = userColor,
                        //    Size = shSize
                        //};
                        //ellipse.draw(gl);
                        //if (drawing == 2)
                        //{
                        //    shapes.Add(ellipse);
                        //    drawing = 0;
                        //}
                        //break;
                    case 3: // Vẽ hình chữ nhật ở đây
                        Rectangle newRect = new Rectangle
                        {
                            Start = pStart,
                            End = pEnd,
                            ShapeColor = userColor,
                            Size = shSize
                        };
                        newRect.draw(gl);
                        if (drawing == 2)
                        {
                            shapes.Add(newRect);
                            drawing = 0;
                        }
                        break;
                    case 4: // Vẽ hình tam giác đều ở đây
                        break;
                    case 5: // Vẽ hình ngũ giác đều ở đây
                        break;
                    case 6: // Vẽ hình lục giác đều ở đây
                        break;

                }
            }
        }

        private void btnColorChart_Click(object sender, EventArgs e)
        {
            // Nếu người dùng chọn xong và bấm ok
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                userColor = colorDialog1.Color;
            }
        }

        private void btnDrawLine_Click(object sender, EventArgs e)
        {
            shShape = 0;
        }

        private void openGLControl_MouseUp(object sender, MouseEventArgs e)
        {
            pEnd = e.Location;
            drawing = 2;
        }

        private void openGLControl_MouseMove(object sender, MouseEventArgs e)
        {
            pEnd = e.Location;
        }   

        private void cboSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            string size = comboBox.SelectedItem.ToString();
            shSize = ConvertValueComboBoxToFloat(size);
        }

        private void btnDrawCircle_Click(object sender, EventArgs e)
        {
            shShape = 1;
        }

        private void btnEllipse_Click(object sender, EventArgs e)
        {
            shShape = 2;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            shShape = 3;
        }

        private void btnTriangle_Click(object sender, EventArgs e)
        {
            shShape = 4;
        }

        private void btnPentagon_Click(object sender, EventArgs e)
        {
            shShape = 5;
        }

        private void btnHexagon_Click(object sender, EventArgs e)
        {
            shShape = 6;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            // Empty the shapes list
            shapes.Clear();
        }

        private void openGLControl_MouseDown(object sender, MouseEventArgs e)
        {
            pStart = e.Location;
            pEnd = pStart;
            drawing = 1;
        }
    }
}

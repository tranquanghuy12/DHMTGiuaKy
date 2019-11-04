namespace FirstSharpGLProject
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openGLControl = new SharpGL.OpenGLControl();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnColorChart = new System.Windows.Forms.Button();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.gbShape = new System.Windows.Forms.GroupBox();
            this.gbEquiangular = new System.Windows.Forms.GroupBox();
            this.btnHexagon = new System.Windows.Forms.Button();
            this.btnPentagon = new System.Windows.Forms.Button();
            this.btnTriangle = new System.Windows.Forms.Button();
            this.btnEllipse = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.pnToolbar = new System.Windows.Forms.Panel();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.btnClear = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).BeginInit();
            this.gbShape.SuspendLayout();
            this.gbEquiangular.SuspendLayout();
            this.pnToolbar.SuspendLayout();
            this.gbSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // openGLControl
            // 
            this.openGLControl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.openGLControl.DrawFPS = false;
            this.openGLControl.Location = new System.Drawing.Point(12, 176);
            this.openGLControl.Name = "openGLControl";
            this.openGLControl.OpenGLVersion = SharpGL.Version.OpenGLVersion.OpenGL2_1;
            this.openGLControl.RenderContextType = SharpGL.RenderContextType.DIBSection;
            this.openGLControl.RenderTrigger = SharpGL.RenderTrigger.TimerBased;
            this.openGLControl.Size = new System.Drawing.Size(739, 310);
            this.openGLControl.TabIndex = 0;
            this.openGLControl.OpenGLInitialized += new System.EventHandler(this.openGLControl_OpenGLInitialized);
            this.openGLControl.OpenGLDraw += new SharpGL.RenderEventHandler(this.openGLControl_OpenGLDraw);
            this.openGLControl.Resized += new System.EventHandler(this.openGLControl_Resized);
            this.openGLControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseDown);
            this.openGLControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseMove);
            this.openGLControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.openGLControl_MouseUp);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.Location = new System.Drawing.Point(6, 19);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(69, 39);
            this.btnDrawLine.TabIndex = 1;
            this.btnDrawLine.Text = "Line";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.Location = new System.Drawing.Point(78, 19);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(69, 39);
            this.btnDrawCircle.TabIndex = 2;
            this.btnDrawCircle.Text = "Circle";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            // 
            // btnColorChart
            // 
            this.btnColorChart.Location = new System.Drawing.Point(311, 29);
            this.btnColorChart.Name = "btnColorChart";
            this.btnColorChart.Size = new System.Drawing.Size(78, 39);
            this.btnColorChart.TabIndex = 3;
            this.btnColorChart.Text = "Color Chart";
            this.btnColorChart.UseVisualStyleBackColor = true;
            this.btnColorChart.Click += new System.EventHandler(this.btnColorChart_Click);
            // 
            // cboSize
            // 
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "1px",
            "3px",
            "5px",
            "8px"});
            this.cboSize.Location = new System.Drawing.Point(6, 20);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(121, 21);
            this.cboSize.TabIndex = 4;
            this.cboSize.Text = "Size";
            this.cboSize.SelectedIndexChanged += new System.EventHandler(this.cboSize_SelectedIndexChanged);
            // 
            // gbShape
            // 
            this.gbShape.Controls.Add(this.gbEquiangular);
            this.gbShape.Controls.Add(this.btnEllipse);
            this.gbShape.Controls.Add(this.btnRectangle);
            this.gbShape.Controls.Add(this.btnDrawLine);
            this.gbShape.Controls.Add(this.btnDrawCircle);
            this.gbShape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbShape.Location = new System.Drawing.Point(3, 10);
            this.gbShape.Name = "gbShape";
            this.gbShape.Size = new System.Drawing.Size(302, 135);
            this.gbShape.TabIndex = 5;
            this.gbShape.TabStop = false;
            this.gbShape.Text = "Shape";
            // 
            // gbEquiangular
            // 
            this.gbEquiangular.Controls.Add(this.btnHexagon);
            this.gbEquiangular.Controls.Add(this.btnPentagon);
            this.gbEquiangular.Controls.Add(this.btnTriangle);
            this.gbEquiangular.Location = new System.Drawing.Point(6, 64);
            this.gbEquiangular.Name = "gbEquiangular";
            this.gbEquiangular.Size = new System.Drawing.Size(285, 65);
            this.gbEquiangular.TabIndex = 6;
            this.gbEquiangular.TabStop = false;
            this.gbEquiangular.Text = "Equiangular";
            // 
            // btnHexagon
            // 
            this.btnHexagon.Location = new System.Drawing.Point(188, 20);
            this.btnHexagon.Name = "btnHexagon";
            this.btnHexagon.Size = new System.Drawing.Size(80, 39);
            this.btnHexagon.TabIndex = 7;
            this.btnHexagon.Text = "Hexagon";
            this.btnHexagon.UseVisualStyleBackColor = true;
            this.btnHexagon.Click += new System.EventHandler(this.btnHexagon_Click);
            // 
            // btnPentagon
            // 
            this.btnPentagon.Location = new System.Drawing.Point(97, 21);
            this.btnPentagon.Name = "btnPentagon";
            this.btnPentagon.Size = new System.Drawing.Size(80, 39);
            this.btnPentagon.TabIndex = 6;
            this.btnPentagon.Text = "Pentagon";
            this.btnPentagon.UseVisualStyleBackColor = true;
            this.btnPentagon.Click += new System.EventHandler(this.btnPentagon_Click);
            // 
            // btnTriangle
            // 
            this.btnTriangle.Location = new System.Drawing.Point(6, 20);
            this.btnTriangle.Name = "btnTriangle";
            this.btnTriangle.Size = new System.Drawing.Size(80, 39);
            this.btnTriangle.TabIndex = 5;
            this.btnTriangle.Text = "Triangle";
            this.btnTriangle.UseVisualStyleBackColor = true;
            this.btnTriangle.Click += new System.EventHandler(this.btnTriangle_Click);
            // 
            // btnEllipse
            // 
            this.btnEllipse.Location = new System.Drawing.Point(150, 19);
            this.btnEllipse.Name = "btnEllipse";
            this.btnEllipse.Size = new System.Drawing.Size(69, 39);
            this.btnEllipse.TabIndex = 4;
            this.btnEllipse.Text = "Ellipse";
            this.btnEllipse.UseVisualStyleBackColor = true;
            this.btnEllipse.Click += new System.EventHandler(this.btnEllipse_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.Location = new System.Drawing.Point(222, 19);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(69, 39);
            this.btnRectangle.TabIndex = 3;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.UseVisualStyleBackColor = true;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // pnToolbar
            // 
            this.pnToolbar.BackColor = System.Drawing.SystemColors.Control;
            this.pnToolbar.Controls.Add(this.btnClear);
            this.pnToolbar.Controls.Add(this.gbSize);
            this.pnToolbar.Controls.Add(this.gbShape);
            this.pnToolbar.Controls.Add(this.btnColorChart);
            this.pnToolbar.Location = new System.Drawing.Point(12, 2);
            this.pnToolbar.Name = "pnToolbar";
            this.pnToolbar.Size = new System.Drawing.Size(739, 168);
            this.pnToolbar.TabIndex = 6;
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.cboSize);
            this.gbSize.Location = new System.Drawing.Point(405, 17);
            this.gbSize.Name = "gbSize";
            this.gbSize.Size = new System.Drawing.Size(136, 51);
            this.gbSize.TabIndex = 6;
            this.gbSize.TabStop = false;
            this.gbSize.Text = "Size";
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(311, 94);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(78, 39);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 498);
            this.Controls.Add(this.pnToolbar);
            this.Controls.Add(this.openGLControl);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.openGLControl)).EndInit();
            this.gbShape.ResumeLayout(false);
            this.gbEquiangular.ResumeLayout(false);
            this.pnToolbar.ResumeLayout(false);
            this.gbSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private SharpGL.OpenGLControl openGLControl;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnColorChart;
        private System.Windows.Forms.ComboBox cboSize;
        private System.Windows.Forms.GroupBox gbShape;
        private System.Windows.Forms.Button btnEllipse;
        private System.Windows.Forms.Button btnRectangle;
        private System.Windows.Forms.Panel pnToolbar;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.GroupBox gbEquiangular;
        private System.Windows.Forms.Button btnHexagon;
        private System.Windows.Forms.Button btnPentagon;
        private System.Windows.Forms.Button btnTriangle;
        private System.Windows.Forms.Button btnClear;
    }
}


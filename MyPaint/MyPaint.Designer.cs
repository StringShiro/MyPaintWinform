namespace MyPaint
{
    partial class MyPaint
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyPaint));
            this.Tool_Strip = new System.Windows.Forms.ToolStrip();
            this.btncontainer_panel = new System.Windows.Forms.Panel();
            this.btn_pencil = new System.Windows.Forms.Button();
            this.toolStrip_save = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_home = new System.Windows.Forms.ToolStripButton();
            this.toolStrip_view = new System.Windows.Forms.ToolStripButton();
            this.pic = new System.Windows.Forms.PictureBox();
            this.btn_eraser = new System.Windows.Forms.Button();
            this.btn_brush = new System.Windows.Forms.Button();
            this.btn_palette = new System.Windows.Forms.Button();
            this.btn_colorpicker = new System.Windows.Forms.Button();
            this.btn_shape = new System.Windows.Forms.Button();
            this.Tool_Strip.SuspendLayout();
            this.btncontainer_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            this.SuspendLayout();
            // 
            // Tool_Strip
            // 
            this.Tool_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStrip_save,
            this.toolStrip_home,
            this.toolStrip_view});
            this.Tool_Strip.Location = new System.Drawing.Point(0, 0);
            this.Tool_Strip.Name = "Tool_Strip";
            this.Tool_Strip.Size = new System.Drawing.Size(1264, 25);
            this.Tool_Strip.TabIndex = 1;
            this.Tool_Strip.Text = "toolStrip1";
            this.Tool_Strip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.Tool_Strip_ItemClicked);
            // 
            // btncontainer_panel
            // 
            this.btncontainer_panel.BackColor = System.Drawing.SystemColors.Control;
            this.btncontainer_panel.Controls.Add(this.btn_shape);
            this.btncontainer_panel.Controls.Add(this.btn_colorpicker);
            this.btncontainer_panel.Controls.Add(this.btn_palette);
            this.btncontainer_panel.Controls.Add(this.btn_brush);
            this.btncontainer_panel.Controls.Add(this.btn_eraser);
            this.btncontainer_panel.Controls.Add(this.btn_pencil);
            this.btncontainer_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.btncontainer_panel.Location = new System.Drawing.Point(0, 25);
            this.btncontainer_panel.Name = "btncontainer_panel";
            this.btncontainer_panel.Size = new System.Drawing.Size(1264, 100);
            this.btncontainer_panel.TabIndex = 2;
            // 
            // btn_pencil
            // 
            this.btn_pencil.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_pencil.BackgroundImage = global::MyPaint.Properties.Resources.pencil;
            this.btn_pencil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_pencil.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btn_pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_pencil.Location = new System.Drawing.Point(3, 3);
            this.btn_pencil.Name = "btn_pencil";
            this.btn_pencil.Size = new System.Drawing.Size(110, 95);
            this.btn_pencil.TabIndex = 0;
            this.btn_pencil.Text = "Pencil";
            this.btn_pencil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_pencil.UseVisualStyleBackColor = false;
            this.btn_pencil.Click += new System.EventHandler(this.button1_Click);
            this.btn_pencil.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btn_pencil_MouseDown);
            this.btn_pencil.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btn_pencil_MouseMove);
            this.btn_pencil.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btn_pencil_MouseUp);
            // 
            // toolStrip_save
            // 
            this.toolStrip_save.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_save.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_save.Image")));
            this.toolStrip_save.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_save.Name = "toolStrip_save";
            this.toolStrip_save.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_save.Text = "Save";
            // 
            // toolStrip_home
            // 
            this.toolStrip_home.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_home.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_home.Image")));
            this.toolStrip_home.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_home.Name = "toolStrip_home";
            this.toolStrip_home.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_home.Text = "Home";
            // 
            // toolStrip_view
            // 
            this.toolStrip_view.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStrip_view.Image = ((System.Drawing.Image)(resources.GetObject("toolStrip_view.Image")));
            this.toolStrip_view.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStrip_view.Name = "toolStrip_view";
            this.toolStrip_view.Size = new System.Drawing.Size(23, 22);
            this.toolStrip_view.Text = "View";
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.Color.White;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 125);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1264, 556);
            this.pic.TabIndex = 1;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // btn_eraser
            // 
            this.btn_eraser.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_eraser.BackgroundImage = global::MyPaint.Properties.Resources.eraser;
            this.btn_eraser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_eraser.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_eraser.Location = new System.Drawing.Point(115, 3);
            this.btn_eraser.Name = "btn_eraser";
            this.btn_eraser.Size = new System.Drawing.Size(110, 95);
            this.btn_eraser.TabIndex = 3;
            this.btn_eraser.Text = "Eraser";
            this.btn_eraser.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eraser.UseVisualStyleBackColor = false;
            this.btn_eraser.Click += new System.EventHandler(this.btn_eraser_Click);
            // 
            // btn_brush
            // 
            this.btn_brush.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_brush.BackgroundImage = global::MyPaint.Properties.Resources.brush;
            this.btn_brush.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_brush.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_brush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_brush.Location = new System.Drawing.Point(227, 3);
            this.btn_brush.Name = "btn_brush";
            this.btn_brush.Size = new System.Drawing.Size(110, 95);
            this.btn_brush.TabIndex = 3;
            this.btn_brush.Text = "Brush";
            this.btn_brush.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_brush.UseVisualStyleBackColor = false;
            this.btn_brush.Click += new System.EventHandler(this.btn_brush_Click);
            // 
            // btn_palette
            // 
            this.btn_palette.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_palette.BackgroundImage = global::MyPaint.Properties.Resources.palette;
            this.btn_palette.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_palette.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_palette.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_palette.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_palette.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_palette.Location = new System.Drawing.Point(339, 3);
            this.btn_palette.Name = "btn_palette";
            this.btn_palette.Size = new System.Drawing.Size(110, 95);
            this.btn_palette.TabIndex = 3;
            this.btn_palette.Text = "Palette";
            this.btn_palette.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_palette.UseVisualStyleBackColor = false;
            this.btn_palette.Click += new System.EventHandler(this.btn_palette_Click);
            // 
            // btn_colorpicker
            // 
            this.btn_colorpicker.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_colorpicker.BackgroundImage = global::MyPaint.Properties.Resources.color_picker;
            this.btn_colorpicker.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_colorpicker.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_colorpicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_colorpicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_colorpicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_colorpicker.Location = new System.Drawing.Point(451, 3);
            this.btn_colorpicker.Name = "btn_colorpicker";
            this.btn_colorpicker.Size = new System.Drawing.Size(110, 95);
            this.btn_colorpicker.TabIndex = 3;
            this.btn_colorpicker.Text = "Color Picker";
            this.btn_colorpicker.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_colorpicker.UseVisualStyleBackColor = false;
            // 
            // btn_shape
            // 
            this.btn_shape.BackColor = System.Drawing.SystemColors.Menu;
            this.btn_shape.BackgroundImage = global::MyPaint.Properties.Resources.aperture;
            this.btn_shape.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_shape.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_shape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_shape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_shape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_shape.Location = new System.Drawing.Point(563, 3);
            this.btn_shape.Name = "btn_shape";
            this.btn_shape.Size = new System.Drawing.Size(110, 95);
            this.btn_shape.TabIndex = 3;
            this.btn_shape.Text = "Shapes";
            this.btn_shape.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_shape.UseVisualStyleBackColor = false;
            this.btn_shape.Click += new System.EventHandler(this.btn_shape_Click);
            // 
            // MyPaint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.btncontainer_panel);
            this.Controls.Add(this.Tool_Strip);
            this.Name = "MyPaint";
            this.Text = "MyPaint";
            this.Load += new System.EventHandler(this.MyPaint_Load);
            this.Tool_Strip.ResumeLayout(false);
            this.Tool_Strip.PerformLayout();
            this.btncontainer_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip Tool_Strip;
        private System.Windows.Forms.ToolStripButton toolStrip_save;
        private System.Windows.Forms.ToolStripButton toolStrip_home;
        private System.Windows.Forms.ToolStripButton toolStrip_view;
        private System.Windows.Forms.Panel btncontainer_panel;
        private System.Windows.Forms.Button btn_pencil;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button btn_eraser;
        private System.Windows.Forms.Button btn_palette;
        private System.Windows.Forms.Button btn_brush;
        private System.Windows.Forms.Button btn_shape;
        private System.Windows.Forms.Button btn_colorpicker;
    }
}


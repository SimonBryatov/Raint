namespace Raint
{
    partial class MainWindow
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_Redo = new System.Windows.Forms.Button();
            this.NewImage = new System.Windows.Forms.Button();
            this.ClearLayer = new System.Windows.Forms.Button();
            this.Undo = new System.Windows.Forms.Button();
            this.Open = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.trackBar_brushSize = new System.Windows.Forms.TrackBar();
            this.button_Pencil = new System.Windows.Forms.Button();
            this.button_Rectangle = new System.Windows.Forms.Button();
            this.button_Brush = new System.Windows.Forms.Button();
            this.button_Eraser = new System.Windows.Forms.Button();
            this.button_Circle = new System.Windows.Forms.Button();
            this.button_Line = new System.Windows.Forms.Button();
            this.button_ColorPicker = new System.Windows.Forms.Button();
            this.button_Fill = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button_LayerUp = new System.Windows.Forms.Button();
            this.button_LayerDown = new System.Windows.Forms.Button();
            this.label_X = new System.Windows.Forms.Label();
            this.label_Y = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label_Time = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button_DeleteLayer = new System.Windows.Forms.Button();
            this.button_AddLayer = new System.Windows.Forms.Button();
            this.ListView = new System.Windows.Forms.ListView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Brightness = new System.Windows.Forms.TrackBar();
            this.Saturation = new System.Windows.Forms.TrackBar();
            this.pictureBox_CurrentColor = new System.Windows.Forms.PictureBox();
            this.Hue = new System.Windows.Forms.TrackBar();
            this.pictureBox_ColorPalette = new System.Windows.Forms.PictureBox();
            this.label_Hue = new System.Windows.Forms.Label();
            this.ImageList = new System.Windows.Forms.ImageList(this.components);
            this.TrialTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_ForeGroundBlend = new System.Windows.Forms.PictureBox();
            this.pictureBox_LayerDrawArea = new System.Windows.Forms.PictureBox();
            this.pictureBox_BackGroundBlend = new System.Windows.Forms.PictureBox();
            this.Smoothing_Timer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brushSize)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CurrentColor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPalette)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForeGroundBlend)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LayerDrawArea)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGroundBlend)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel1.Controls.Add(this.button_Redo);
            this.panel1.Controls.Add(this.NewImage);
            this.panel1.Controls.Add(this.ClearLayer);
            this.panel1.Controls.Add(this.Undo);
            this.panel1.Controls.Add(this.Open);
            this.panel1.Controls.Add(this.Save);
            this.panel1.Controls.Add(this.trackBar_brushSize);
            this.panel1.Controls.Add(this.button_Pencil);
            this.panel1.Controls.Add(this.button_Rectangle);
            this.panel1.Controls.Add(this.button_Brush);
            this.panel1.Controls.Add(this.button_Eraser);
            this.panel1.Controls.Add(this.button_Circle);
            this.panel1.Controls.Add(this.button_Line);
            this.panel1.Controls.Add(this.button_ColorPicker);
            this.panel1.Controls.Add(this.button_Fill);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 32);
            this.panel1.TabIndex = 0;
            // 
            // button_Redo
            // 
            this.button_Redo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Redo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Redo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Redo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Redo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Redo.Image = global::Raint.Properties.Resources._1482731721_redo;
            this.button_Redo.Location = new System.Drawing.Point(378, 0);
            this.button_Redo.Margin = new System.Windows.Forms.Padding(0);
            this.button_Redo.Name = "button_Redo";
            this.button_Redo.Size = new System.Drawing.Size(32, 32);
            this.button_Redo.TabIndex = 40;
            this.button_Redo.UseVisualStyleBackColor = false;
            this.button_Redo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Redo_MouseClick);
            // 
            // NewImage
            // 
            this.NewImage.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.NewImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewImage.Image = global::Raint.Properties.Resources._new;
            this.NewImage.Location = new System.Drawing.Point(0, 0);
            this.NewImage.Name = "NewImage";
            this.NewImage.Size = new System.Drawing.Size(32, 32);
            this.NewImage.TabIndex = 39;
            this.NewImage.UseVisualStyleBackColor = false;
            this.NewImage.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Blank_MouseClick);
            // 
            // ClearLayer
            // 
            this.ClearLayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClearLayer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.ClearLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClearLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.ClearLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ClearLayer.Image = global::Raint.Properties.Resources.Clear_Layer;
            this.ClearLayer.Location = new System.Drawing.Point(314, 0);
            this.ClearLayer.Margin = new System.Windows.Forms.Padding(0);
            this.ClearLayer.Name = "ClearLayer";
            this.ClearLayer.Size = new System.Drawing.Size(32, 32);
            this.ClearLayer.TabIndex = 15;
            this.ClearLayer.UseVisualStyleBackColor = false;
            this.ClearLayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ClearLayer_MouseClick);
            // 
            // Undo
            // 
            this.Undo.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Undo.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.Undo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Undo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.Undo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Undo.Image = global::Raint.Properties.Resources._1482731716_undo;
            this.Undo.Location = new System.Drawing.Point(346, 0);
            this.Undo.Margin = new System.Windows.Forms.Padding(0);
            this.Undo.Name = "Undo";
            this.Undo.Size = new System.Drawing.Size(32, 32);
            this.Undo.TabIndex = 13;
            this.Undo.UseVisualStyleBackColor = false;
            this.Undo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Undo_MouseClick);
            // 
            // Open
            // 
            this.Open.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Open.Image = global::Raint.Properties.Resources._1480220405_BT_folder_blanc_open;
            this.Open.Location = new System.Drawing.Point(32, 0);
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(32, 32);
            this.Open.TabIndex = 11;
            this.Open.UseVisualStyleBackColor = false;
            this.Open.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Open_MouseClick);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Save.Image = global::Raint.Properties.Resources._1480220494_save;
            this.Save.Location = new System.Drawing.Point(64, 0);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(32, 32);
            this.Save.TabIndex = 12;
            this.Save.UseVisualStyleBackColor = false;
            this.Save.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Save_MouseClick);
            // 
            // trackBar_brushSize
            // 
            this.trackBar_brushSize.Location = new System.Drawing.Point(110, 0);
            this.trackBar_brushSize.Name = "trackBar_brushSize";
            this.trackBar_brushSize.Size = new System.Drawing.Size(165, 45);
            this.trackBar_brushSize.TabIndex = 10;
            this.trackBar_brushSize.Scroll += new System.EventHandler(this.trackBar_brushSize_Scroll);
            // 
            // button_Pencil
            // 
            this.button_Pencil.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Pencil.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Pencil.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Pencil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Pencil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Pencil.Image = global::Raint.Properties.Resources._1480220533_16_Pen;
            this.button_Pencil.Location = new System.Drawing.Point(1022, 0);
            this.button_Pencil.Margin = new System.Windows.Forms.Padding(0);
            this.button_Pencil.Name = "button_Pencil";
            this.button_Pencil.Size = new System.Drawing.Size(32, 32);
            this.button_Pencil.TabIndex = 6;
            this.button_Pencil.UseVisualStyleBackColor = false;
            this.button_Pencil.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Pencil_MouseClick);
            // 
            // button_Rectangle
            // 
            this.button_Rectangle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Rectangle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Rectangle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Rectangle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Rectangle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Rectangle.Image = global::Raint.Properties.Resources._1480220657_184_FormRectangleBorder;
            this.button_Rectangle.Location = new System.Drawing.Point(1118, 0);
            this.button_Rectangle.Margin = new System.Windows.Forms.Padding(0);
            this.button_Rectangle.Name = "button_Rectangle";
            this.button_Rectangle.Size = new System.Drawing.Size(32, 32);
            this.button_Rectangle.TabIndex = 5;
            this.button_Rectangle.UseVisualStyleBackColor = false;
            this.button_Rectangle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Rectangle_MouseClick);
            // 
            // button_Brush
            // 
            this.button_Brush.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Brush.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Brush.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Brush.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Brush.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Brush.Image = global::Raint.Properties.Resources._1480220550_brush_medium;
            this.button_Brush.Location = new System.Drawing.Point(1054, 0);
            this.button_Brush.Margin = new System.Windows.Forms.Padding(0);
            this.button_Brush.Name = "button_Brush";
            this.button_Brush.Size = new System.Drawing.Size(32, 32);
            this.button_Brush.TabIndex = 7;
            this.button_Brush.UseVisualStyleBackColor = false;
            this.button_Brush.Click += new System.EventHandler(this.button_Brush_Click);
            // 
            // button_Eraser
            // 
            this.button_Eraser.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Eraser.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Eraser.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Eraser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Eraser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Eraser.Image = global::Raint.Properties.Resources._1480220777_eraser;
            this.button_Eraser.Location = new System.Drawing.Point(1182, 0);
            this.button_Eraser.Margin = new System.Windows.Forms.Padding(0);
            this.button_Eraser.Name = "button_Eraser";
            this.button_Eraser.Size = new System.Drawing.Size(32, 32);
            this.button_Eraser.TabIndex = 8;
            this.button_Eraser.UseVisualStyleBackColor = false;
            this.button_Eraser.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Eraser_MouseClick);
            // 
            // button_Circle
            // 
            this.button_Circle.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Circle.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Circle.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Circle.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Circle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Circle.Image = global::Raint.Properties.Resources._1480220719_check_circle_outline_blank;
            this.button_Circle.Location = new System.Drawing.Point(1150, 0);
            this.button_Circle.Margin = new System.Windows.Forms.Padding(0);
            this.button_Circle.Name = "button_Circle";
            this.button_Circle.Size = new System.Drawing.Size(32, 32);
            this.button_Circle.TabIndex = 5;
            this.button_Circle.UseVisualStyleBackColor = false;
            this.button_Circle.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Ellipse_MouseClick);
            // 
            // button_Line
            // 
            this.button_Line.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Line.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Line.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Line.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Line.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Line.Image = global::Raint.Properties.Resources._1480220564_button_shape_line;
            this.button_Line.Location = new System.Drawing.Point(1086, 0);
            this.button_Line.Margin = new System.Windows.Forms.Padding(0);
            this.button_Line.Name = "button_Line";
            this.button_Line.Size = new System.Drawing.Size(32, 32);
            this.button_Line.TabIndex = 9;
            this.button_Line.UseVisualStyleBackColor = false;
            this.button_Line.Click += new System.EventHandler(this.button_Line_Click);
            // 
            // button_ColorPicker
            // 
            this.button_ColorPicker.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_ColorPicker.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_ColorPicker.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_ColorPicker.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_ColorPicker.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ColorPicker.Image = global::Raint.Properties.Resources._1480220749_miscellaneous_60;
            this.button_ColorPicker.Location = new System.Drawing.Point(1246, 0);
            this.button_ColorPicker.Margin = new System.Windows.Forms.Padding(0);
            this.button_ColorPicker.Name = "button_ColorPicker";
            this.button_ColorPicker.Size = new System.Drawing.Size(32, 32);
            this.button_ColorPicker.TabIndex = 5;
            this.button_ColorPicker.UseVisualStyleBackColor = false;
            this.button_ColorPicker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_ColorPicker_MouseClick);
            // 
            // button_Fill
            // 
            this.button_Fill.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_Fill.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_Fill.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_Fill.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_Fill.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Fill.Image = global::Raint.Properties.Resources._1480220340_ic_format_color_fill_48px;
            this.button_Fill.Location = new System.Drawing.Point(1214, 0);
            this.button_Fill.Margin = new System.Windows.Forms.Padding(0);
            this.button_Fill.Name = "button_Fill";
            this.button_Fill.Size = new System.Drawing.Size(32, 32);
            this.button_Fill.TabIndex = 5;
            this.button_Fill.UseVisualStyleBackColor = false;
            this.button_Fill.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_Fill_MouseClick);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel3.Controls.Add(this.button_LayerUp);
            this.panel3.Controls.Add(this.button_LayerDown);
            this.panel3.Controls.Add(this.label_X);
            this.panel3.Controls.Add(this.label_Y);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label_Time);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.button_DeleteLayer);
            this.panel3.Controls.Add(this.button_AddLayer);
            this.panel3.Controls.Add(this.ListView);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.Brightness);
            this.panel3.Controls.Add(this.Saturation);
            this.panel3.Controls.Add(this.pictureBox_CurrentColor);
            this.panel3.Controls.Add(this.Hue);
            this.panel3.Controls.Add(this.pictureBox_ColorPalette);
            this.panel3.Controls.Add(this.label_Hue);
            this.panel3.Location = new System.Drawing.Point(1281, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(267, 755);
            this.panel3.TabIndex = 2;
            // 
            // button_LayerUp
            // 
            this.button_LayerUp.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_LayerUp.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_LayerUp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_LayerUp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_LayerUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LayerUp.Image = global::Raint.Properties.Resources.Layer_Down;
            this.button_LayerUp.Location = new System.Drawing.Point(228, 368);
            this.button_LayerUp.Margin = new System.Windows.Forms.Padding(0);
            this.button_LayerUp.Name = "button_LayerUp";
            this.button_LayerUp.Size = new System.Drawing.Size(32, 32);
            this.button_LayerUp.TabIndex = 46;
            this.button_LayerUp.UseVisualStyleBackColor = false;
            this.button_LayerUp.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_LayerUp_MouseClick);
            // 
            // button_LayerDown
            // 
            this.button_LayerDown.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_LayerDown.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_LayerDown.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_LayerDown.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_LayerDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_LayerDown.Image = global::Raint.Properties.Resources.Layer_Up;
            this.button_LayerDown.Location = new System.Drawing.Point(228, 336);
            this.button_LayerDown.Margin = new System.Windows.Forms.Padding(0);
            this.button_LayerDown.Name = "button_LayerDown";
            this.button_LayerDown.Size = new System.Drawing.Size(32, 32);
            this.button_LayerDown.TabIndex = 45;
            this.button_LayerDown.UseVisualStyleBackColor = false;
            this.button_LayerDown.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_LayerDown_MouseClick);
            // 
            // label_X
            // 
            this.label_X.AutoSize = true;
            this.label_X.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_X.Location = new System.Drawing.Point(32, 738);
            this.label_X.Name = "label_X";
            this.label_X.Size = new System.Drawing.Size(35, 13);
            this.label_X.TabIndex = 44;
            this.label_X.Text = "label6";
            // 
            // label_Y
            // 
            this.label_Y.AutoSize = true;
            this.label_Y.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label_Y.Location = new System.Drawing.Point(83, 738);
            this.label_Y.Name = "label_Y";
            this.label_Y.Size = new System.Drawing.Size(35, 13);
            this.label_Y.TabIndex = 43;
            this.label_Y.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(67, 738);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Y:";
            // 
            // label_Time
            // 
            this.label_Time.AutoSize = true;
            this.label_Time.Location = new System.Drawing.Point(7, 393);
            this.label_Time.Name = "label_Time";
            this.label_Time.Size = new System.Drawing.Size(35, 13);
            this.label_Time.TabIndex = 40;
            this.label_Time.Text = "label4";
            this.label_Time.Visible = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(3, 301);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(80, 17);
            this.checkBox1.TabIndex = 39;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // button_DeleteLayer
            // 
            this.button_DeleteLayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_DeleteLayer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_DeleteLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_DeleteLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_DeleteLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_DeleteLayer.Image = global::Raint.Properties.Resources.delete_layer;
            this.button_DeleteLayer.Location = new System.Drawing.Point(192, 301);
            this.button_DeleteLayer.Margin = new System.Windows.Forms.Padding(0);
            this.button_DeleteLayer.Name = "button_DeleteLayer";
            this.button_DeleteLayer.Size = new System.Drawing.Size(32, 32);
            this.button_DeleteLayer.TabIndex = 38;
            this.button_DeleteLayer.UseVisualStyleBackColor = false;
            this.button_DeleteLayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_DeleteLayer_MouseClick);
            // 
            // button_AddLayer
            // 
            this.button_AddLayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button_AddLayer.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.button_AddLayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.button_AddLayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.button_AddLayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_AddLayer.Image = global::Raint.Properties.Resources.add_layer;
            this.button_AddLayer.Location = new System.Drawing.Point(160, 301);
            this.button_AddLayer.Margin = new System.Windows.Forms.Padding(0);
            this.button_AddLayer.Name = "button_AddLayer";
            this.button_AddLayer.Size = new System.Drawing.Size(32, 32);
            this.button_AddLayer.TabIndex = 37;
            this.button_AddLayer.UseVisualStyleBackColor = false;
            this.button_AddLayer.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button_AddLayer_MouseClick);
            // 
            // ListView
            // 
            this.ListView.BackColor = System.Drawing.Color.DarkGray;
            this.ListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ListView.Location = new System.Drawing.Point(55, 336);
            this.ListView.Name = "ListView";
            this.ListView.Size = new System.Drawing.Size(170, 395);
            this.ListView.TabIndex = 36;
            this.ListView.UseCompatibleStateImageBehavior = false;
            this.ListView.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListView_MouseClick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Location = new System.Drawing.Point(3, 324);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 66);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(17, 738);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 35;
            this.label3.Text = "X:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 255);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 32;
            this.label2.Text = "B:";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 230);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 31;
            this.label1.Text = "S:";
            // 
            // Brightness
            // 
            this.Brightness.AutoSize = false;
            this.Brightness.LargeChange = 250;
            this.Brightness.Location = new System.Drawing.Point(28, 253);
            this.Brightness.Maximum = 1000;
            this.Brightness.Minimum = 5;
            this.Brightness.Name = "Brightness";
            this.Brightness.Size = new System.Drawing.Size(215, 25);
            this.Brightness.TabIndex = 29;
            this.Brightness.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Brightness.Value = 5;
            this.Brightness.Scroll += new System.EventHandler(this.Brightness_Scroll);
            // 
            // Saturation
            // 
            this.Saturation.AutoSize = false;
            this.Saturation.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.Saturation.LargeChange = 250;
            this.Saturation.Location = new System.Drawing.Point(28, 227);
            this.Saturation.Maximum = 1000;
            this.Saturation.Minimum = 10;
            this.Saturation.Name = "Saturation";
            this.Saturation.Size = new System.Drawing.Size(215, 25);
            this.Saturation.TabIndex = 28;
            this.Saturation.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Saturation.Value = 10;
            this.Saturation.Scroll += new System.EventHandler(this.Saturation_Scroll);
            // 
            // pictureBox_CurrentColor
            // 
            this.pictureBox_CurrentColor.Location = new System.Drawing.Point(3, 170);
            this.pictureBox_CurrentColor.Name = "pictureBox_CurrentColor";
            this.pictureBox_CurrentColor.Size = new System.Drawing.Size(261, 25);
            this.pictureBox_CurrentColor.TabIndex = 27;
            this.pictureBox_CurrentColor.TabStop = false;
            // 
            // Hue
            // 
            this.Hue.AutoSize = false;
            this.Hue.Location = new System.Drawing.Point(28, 201);
            this.Hue.Maximum = 1000;
            this.Hue.Name = "Hue";
            this.Hue.Size = new System.Drawing.Size(215, 25);
            this.Hue.TabIndex = 26;
            this.Hue.TickStyle = System.Windows.Forms.TickStyle.None;
            this.Hue.Scroll += new System.EventHandler(this.Hue_Scroll);
            // 
            // pictureBox_ColorPalette
            // 
            this.pictureBox_ColorPalette.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox_ColorPalette.Image = global::Raint.Properties.Resources.HSLColors;
            this.pictureBox_ColorPalette.InitialImage = global::Raint.Properties.Resources.HSLColors;
            this.pictureBox_ColorPalette.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_ColorPalette.Name = "pictureBox_ColorPalette";
            this.pictureBox_ColorPalette.Size = new System.Drawing.Size(261, 161);
            this.pictureBox_ColorPalette.TabIndex = 14;
            this.pictureBox_ColorPalette.TabStop = false;
            this.pictureBox_ColorPalette.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ColorPalette_MouseClick);
            this.pictureBox_ColorPalette.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ColorPalette_MouseDown);
            this.pictureBox_ColorPalette.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ColorPalette_MouseMove);
            this.pictureBox_ColorPalette.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox2_MouseUp);
            // 
            // label_Hue
            // 
            this.label_Hue.Location = new System.Drawing.Point(12, 206);
            this.label_Hue.Name = "label_Hue";
            this.label_Hue.Size = new System.Drawing.Size(18, 20);
            this.label_Hue.TabIndex = 18;
            this.label_Hue.Text = "H:";
            this.label_Hue.Click += new System.EventHandler(this.label_Alpha_Click);
            // 
            // ImageList
            // 
            this.ImageList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.ImageList.ImageSize = new System.Drawing.Size(32, 32);
            this.ImageList.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // TrialTimer
            // 
            this.TrialTimer.Interval = 1000;
            this.TrialTimer.Tick += new System.EventHandler(this.TrialTimer_Tick);
            // 
            // pictureBox_ForeGroundBlend
            // 
            this.pictureBox_ForeGroundBlend.BackColor = System.Drawing.Color.White;
            this.pictureBox_ForeGroundBlend.Location = new System.Drawing.Point(0, 35);
            this.pictureBox_ForeGroundBlend.Name = "pictureBox_ForeGroundBlend";
            this.pictureBox_ForeGroundBlend.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_ForeGroundBlend.TabIndex = 3;
            this.pictureBox_ForeGroundBlend.TabStop = false;
            this.pictureBox_ForeGroundBlend.Click += new System.EventHandler(this.pictureBox_ForeGroundBlend_Click);
            this.pictureBox_ForeGroundBlend.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ForeGroundBlend_MouseDown);
            this.pictureBox_ForeGroundBlend.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ForeGroundBlend_MouseMove);
            this.pictureBox_ForeGroundBlend.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_ForeGroundBlend_MouseUp);
            // 
            // pictureBox_LayerDrawArea
            // 
            this.pictureBox_LayerDrawArea.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_LayerDrawArea.Location = new System.Drawing.Point(0, 35);
            this.pictureBox_LayerDrawArea.Name = "pictureBox_LayerDrawArea";
            this.pictureBox_LayerDrawArea.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_LayerDrawArea.TabIndex = 4;
            this.pictureBox_LayerDrawArea.TabStop = false;
            this.pictureBox_LayerDrawArea.Click += new System.EventHandler(this.pictureBox_LayerDrawArea_Click);
            this.pictureBox_LayerDrawArea.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox_LayerDrawArea_MouseDown);
            this.pictureBox_LayerDrawArea.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_LayerDrawArea_MouseMove);
            this.pictureBox_LayerDrawArea.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox_LayerDrawArea_MouseUp);
            // 
            // pictureBox_BackGroundBlend
            // 
            this.pictureBox_BackGroundBlend.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_BackGroundBlend.Location = new System.Drawing.Point(0, 35);
            this.pictureBox_BackGroundBlend.Name = "pictureBox_BackGroundBlend";
            this.pictureBox_BackGroundBlend.Size = new System.Drawing.Size(1280, 720);
            this.pictureBox_BackGroundBlend.TabIndex = 5;
            this.pictureBox_BackGroundBlend.TabStop = false;
            // 
            // Smoothing_Timer
            // 
            this.Smoothing_Timer.Enabled = true;
            this.Smoothing_Timer.Tick += new System.EventHandler(this.Smoothing_Timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1548, 756);
            this.Controls.Add(this.pictureBox_ForeGroundBlend);
            this.Controls.Add(this.pictureBox_LayerDrawArea);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox_BackGroundBlend);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindow";
            this.Text = "Raint";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_brushSize)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Brightness)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Saturation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_CurrentColor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Hue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ColorPalette)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ForeGroundBlend)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LayerDrawArea)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_BackGroundBlend)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox_CurrentColor;
        private System.Windows.Forms.TrackBar Hue;
        private System.Windows.Forms.Label label_Hue;
        private System.Windows.Forms.PictureBox pictureBox_ColorPalette;
        private System.Windows.Forms.Button button_Fill;
        private System.Windows.Forms.Button button_Rectangle;
        private System.Windows.Forms.Button button_Circle;
        private System.Windows.Forms.Button button_ColorPicker;
        private System.Windows.Forms.Button button_Pencil;
        private System.Windows.Forms.Button button_Brush;
        private System.Windows.Forms.Button button_Eraser;
        private System.Windows.Forms.Button button_Line;
        public  System.Windows.Forms.PictureBox pictureBox_ForeGroundBlend;
        private System.Windows.Forms.TrackBar trackBar_brushSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar Brightness; 
        private System.Windows.Forms.TrackBar Saturation;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Open;
        private System.Windows.Forms.PictureBox pictureBox_LayerDrawArea;
        private System.Windows.Forms.PictureBox pictureBox_BackGroundBlend;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ListView ListView;
        private System.Windows.Forms.ImageList ImageList;
        private System.Windows.Forms.Button button_DeleteLayer;
        private System.Windows.Forms.Button button_AddLayer;
        private System.Windows.Forms.Button ClearLayer;
        private System.Windows.Forms.Button Undo;
        private System.Windows.Forms.Button NewImage;
        private System.Windows.Forms.CheckBox checkBox1;
        public System.Windows.Forms.Timer TrialTimer;
        private System.Windows.Forms.Label label_Time;
        private System.Windows.Forms.Label label_X;
        private System.Windows.Forms.Label label_Y;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_LayerUp;
        private System.Windows.Forms.Button button_LayerDown;
        private System.Windows.Forms.Button button_Redo;
        private System.Windows.Forms.Timer Smoothing_Timer;
    }
}
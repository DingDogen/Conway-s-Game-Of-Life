namespace Conway_s_Game_Of_Life
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button_pxColor = new System.Windows.Forms.Button();
            this.button_bgrColor = new System.Windows.Forms.Button();
            this.nud_SPS = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.button_Stop = new System.Windows.Forms.Button();
            this.button_Start = new System.Windows.Forms.Button();
            this.nud_MaxNeighboursForSurvival = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.nud_MinNeighboursForSurvival = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.nud_NeighboursToBorn = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.nud_Density = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.nud_Resolution = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.button_RandomСhange = new System.Windows.Forms.Button();
            this.timer_random = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_SPS)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxNeighboursForSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinNeighboursForSurvival)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NeighboursToBorn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Density)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Resolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button_pxColor);
            this.splitContainer1.Panel1.Controls.Add(this.button_bgrColor);
            this.splitContainer1.Panel1.Controls.Add(this.nud_SPS);
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Controls.Add(this.nud_MaxNeighboursForSurvival);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            this.splitContainer1.Panel1.Controls.Add(this.nud_MinNeighboursForSurvival);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            this.splitContainer1.Panel1.Controls.Add(this.nud_NeighboursToBorn);
            this.splitContainer1.Panel1.Controls.Add(this.label3);
            this.splitContainer1.Panel1.Controls.Add(this.nud_Density);
            this.splitContainer1.Panel1.Controls.Add(this.label2);
            this.splitContainer1.Panel1.Controls.Add(this.nud_Resolution);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.panel2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pictureBox);
            this.splitContainer1.Size = new System.Drawing.Size(1368, 624);
            this.splitContainer1.SplitterDistance = 179;
            this.splitContainer1.TabIndex = 0;
            // 
            // button_pxColor
            // 
            this.button_pxColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_pxColor.Location = new System.Drawing.Point(91, 405);
            this.button_pxColor.Name = "button_pxColor";
            this.button_pxColor.Size = new System.Drawing.Size(81, 48);
            this.button_pxColor.TabIndex = 15;
            this.button_pxColor.Text = "Pixels Color ";
            this.button_pxColor.UseVisualStyleBackColor = true;
            this.button_pxColor.Click += new System.EventHandler(this.button_pxColor_Click);
            // 
            // button_bgrColor
            // 
            this.button_bgrColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_bgrColor.Location = new System.Drawing.Point(7, 405);
            this.button_bgrColor.Name = "button_bgrColor";
            this.button_bgrColor.Size = new System.Drawing.Size(81, 48);
            this.button_bgrColor.TabIndex = 7;
            this.button_bgrColor.Text = "Back Color ";
            this.button_bgrColor.UseVisualStyleBackColor = true;
            this.button_bgrColor.Click += new System.EventHandler(this.button_bgrColor_Click);
            // 
            // nud_SPS
            // 
            this.nud_SPS.Location = new System.Drawing.Point(7, 379);
            this.nud_SPS.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nud_SPS.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SPS.Name = "nud_SPS";
            this.nud_SPS.Size = new System.Drawing.Size(126, 20);
            this.nud_SPS.TabIndex = 14;
            this.nud_SPS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_SPS.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_SPS.ValueChanged += new System.EventHandler(this.nud_SPS_ValueChanged);
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(3, 333);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 43);
            this.label6.TabIndex = 13;
            this.label6.Text = "Simulations per second";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button_RandomСhange);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button_Stop);
            this.panel1.Controls.Add(this.button_Start);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 459);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(175, 161);
            this.panel1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(3, 81);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(169, 33);
            this.button1.TabIndex = 6;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button_Refresh_Click);
            // 
            // button_Stop
            // 
            this.button_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Stop.Location = new System.Drawing.Point(3, 42);
            this.button_Stop.Name = "button_Stop";
            this.button_Stop.Size = new System.Drawing.Size(169, 33);
            this.button_Stop.TabIndex = 5;
            this.button_Stop.Text = "Stop";
            this.button_Stop.UseVisualStyleBackColor = true;
            this.button_Stop.Click += new System.EventHandler(this.button_Stop_Click);
            // 
            // button_Start
            // 
            this.button_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_Start.Location = new System.Drawing.Point(3, 3);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(169, 33);
            this.button_Start.TabIndex = 4;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // nud_MaxNeighboursForSurvival
            // 
            this.nud_MaxNeighboursForSurvival.Location = new System.Drawing.Point(7, 300);
            this.nud_MaxNeighboursForSurvival.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_MaxNeighboursForSurvival.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MaxNeighboursForSurvival.Name = "nud_MaxNeighboursForSurvival";
            this.nud_MaxNeighboursForSurvival.Size = new System.Drawing.Size(126, 20);
            this.nud_MaxNeighboursForSurvival.TabIndex = 11;
            this.nud_MaxNeighboursForSurvival.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_MaxNeighboursForSurvival.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 254);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 43);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maximum of neighbours for survival";
            // 
            // nud_MinNeighboursForSurvival
            // 
            this.nud_MinNeighboursForSurvival.Location = new System.Drawing.Point(7, 222);
            this.nud_MinNeighboursForSurvival.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_MinNeighboursForSurvival.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_MinNeighboursForSurvival.Name = "nud_MinNeighboursForSurvival";
            this.nud_MinNeighboursForSurvival.Size = new System.Drawing.Size(127, 20);
            this.nud_MinNeighboursForSurvival.TabIndex = 9;
            this.nud_MinNeighboursForSurvival.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_MinNeighboursForSurvival.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 176);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 43);
            this.label4.TabIndex = 8;
            this.label4.Text = "Minimum of neighbours for survival";
            // 
            // nud_NeighboursToBorn
            // 
            this.nud_NeighboursToBorn.Location = new System.Drawing.Point(7, 144);
            this.nud_NeighboursToBorn.Maximum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.nud_NeighboursToBorn.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_NeighboursToBorn.Name = "nud_NeighboursToBorn";
            this.nud_NeighboursToBorn.Size = new System.Drawing.Size(119, 20);
            this.nud_NeighboursToBorn.TabIndex = 7;
            this.nud_NeighboursToBorn.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_NeighboursToBorn.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(144, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Neighbours to born";
            // 
            // nud_Density
            // 
            this.nud_Density.Location = new System.Drawing.Point(7, 89);
            this.nud_Density.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nud_Density.Name = "nud_Density";
            this.nud_Density.Size = new System.Drawing.Size(119, 20);
            this.nud_Density.TabIndex = 3;
            this.nud_Density.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Density.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Emptiness";
            // 
            // nud_Resolution
            // 
            this.nud_Resolution.Location = new System.Drawing.Point(7, 34);
            this.nud_Resolution.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nud_Resolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nud_Resolution.Name = "nud_Resolution";
            this.nud_Resolution.Size = new System.Drawing.Size(119, 20);
            this.nud_Resolution.TabIndex = 1;
            this.nud_Resolution.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.nud_Resolution.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pixels size";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(175, 620);
            this.panel2.TabIndex = 16;
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.Color.Black;
            this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox.Location = new System.Drawing.Point(0, 0);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1181, 620);
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox_MouseMove);
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // button_RandomСhange
            // 
            this.button_RandomСhange.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button_RandomСhange.Location = new System.Drawing.Point(3, 120);
            this.button_RandomСhange.Name = "button_RandomСhange";
            this.button_RandomСhange.Size = new System.Drawing.Size(169, 33);
            this.button_RandomСhange.TabIndex = 7;
            this.button_RandomСhange.Text = "Random change";
            this.button_RandomСhange.UseVisualStyleBackColor = true;
            this.button_RandomСhange.Click += new System.EventHandler(this.button_RandomChange_Click);
            // 
            // timer_random
            // 
            this.timer_random.Interval = 5000;
            this.timer_random.Tick += new System.EventHandler(this.timer_random_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 624);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "Conway\'s Game of Life";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_SPS)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nud_MaxNeighboursForSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_MinNeighboursForSurvival)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_NeighboursToBorn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Density)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Resolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button_Stop;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.NumericUpDown nud_Density;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nud_Resolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.NumericUpDown nud_MaxNeighboursForSurvival;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nud_MinNeighboursForSurvival;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nud_NeighboursToBorn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown nud_SPS;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button_pxColor;
        private System.Windows.Forms.Button button_bgrColor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_RandomСhange;
        private System.Windows.Forms.Timer timer_random;
    }
}


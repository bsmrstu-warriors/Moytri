namespace Moytri
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btn_load = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.web = new System.Windows.Forms.WebBrowser();
            this.btn_terrain = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_electric = new System.Windows.Forms.Button();
            this.btn_vegetation = new System.Windows.Forms.Button();
            this.btn_no_fly = new System.Windows.Forms.Button();
            this.btn_weather = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 24);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(687, 537);
            this.splitter1.TabIndex = 0;
            this.splitter1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal Map",
            "Sattelite Map",
            "Terrain Map",
            "Hybrid Map"});
            this.comboBox1.Location = new System.Drawing.Point(693, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(106, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.Text = "Select Map";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // btn_load
            // 
            this.btn_load.Location = new System.Drawing.Point(805, 25);
            this.btn_load.Name = "btn_load";
            this.btn_load.Size = new System.Drawing.Size(75, 23);
            this.btn_load.TabIndex = 2;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = true;
            this.btn_load.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(884, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.openToolStripMenuItem,
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.openToolStripMenuItem.Text = "Open";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(103, 22);
            this.saveToolStripMenuItem.Text = "Save";
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "View";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 24);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 31);
            this.button2.TabIndex = 5;
            this.button2.Text = "MAP";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(90, 24);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(100, 31);
            this.button3.TabIndex = 6;
            this.button3.Text = "RADAR";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // web
            // 
            this.web.Location = new System.Drawing.Point(0, 53);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(687, 510);
            this.web.TabIndex = 9;
            // 
            // btn_terrain
            // 
            this.btn_terrain.Location = new System.Drawing.Point(787, 64);
            this.btn_terrain.Name = "btn_terrain";
            this.btn_terrain.Size = new System.Drawing.Size(75, 71);
            this.btn_terrain.TabIndex = 13;
            this.btn_terrain.Text = "Terrain";
            this.btn_terrain.UseVisualStyleBackColor = true;
            this.btn_terrain.Click += new System.EventHandler(this.btn_terrain_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::Moytri.Properties.Resources.yaw;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(690, 344);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(194, 217);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // btn_electric
            // 
            this.btn_electric.BackgroundImage = global::Moytri.Properties.Resources.antena;
            this.btn_electric.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_electric.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn_electric.Location = new System.Drawing.Point(693, 233);
            this.btn_electric.Name = "btn_electric";
            this.btn_electric.Size = new System.Drawing.Size(75, 71);
            this.btn_electric.TabIndex = 16;
            this.btn_electric.UseVisualStyleBackColor = true;
            this.btn_electric.Click += new System.EventHandler(this.btn_electric_Click);
            // 
            // btn_vegetation
            // 
            this.btn_vegetation.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_vegetation.BackgroundImage")));
            this.btn_vegetation.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_vegetation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_vegetation.ForeColor = System.Drawing.Color.Black;
            this.btn_vegetation.Location = new System.Drawing.Point(693, 147);
            this.btn_vegetation.Name = "btn_vegetation";
            this.btn_vegetation.Size = new System.Drawing.Size(75, 71);
            this.btn_vegetation.TabIndex = 15;
            this.btn_vegetation.UseVisualStyleBackColor = true;
            this.btn_vegetation.Click += new System.EventHandler(this.btn_vegetation_Click);
            // 
            // btn_no_fly
            // 
            this.btn_no_fly.BackgroundImage = global::Moytri.Properties.Resources.nofly;
            this.btn_no_fly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_no_fly.Location = new System.Drawing.Point(787, 148);
            this.btn_no_fly.Name = "btn_no_fly";
            this.btn_no_fly.Size = new System.Drawing.Size(75, 71);
            this.btn_no_fly.TabIndex = 14;
            this.btn_no_fly.UseVisualStyleBackColor = true;
            this.btn_no_fly.Click += new System.EventHandler(this.btn_no_fly_Click);
            // 
            // btn_weather
            // 
            this.btn_weather.BackgroundImage = global::Moytri.Properties.Resources.weather;
            this.btn_weather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_weather.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_weather.Location = new System.Drawing.Point(693, 64);
            this.btn_weather.Name = "btn_weather";
            this.btn_weather.Size = new System.Drawing.Size(75, 71);
            this.btn_weather.TabIndex = 10;
            this.btn_weather.Text = "Weather";
            this.btn_weather.UseVisualStyleBackColor = true;
            this.btn_weather.Click += new System.EventHandler(this.btn_weather_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_electric);
            this.Controls.Add(this.btn_vegetation);
            this.Controls.Add(this.btn_no_fly);
            this.Controls.Add(this.btn_terrain);
            this.Controls.Add(this.btn_weather);
            this.Controls.Add(this.web);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Black;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.Button btn_weather;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_electric;
        private System.Windows.Forms.Button btn_vegetation;
        private System.Windows.Forms.Button btn_no_fly;
        private System.Windows.Forms.Button btn_terrain;
    }
}


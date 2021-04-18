
namespace UI_Framework
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnWeather = new System.Windows.Forms.Button();
            this.btnNews = new System.Windows.Forms.Button();
            this.btnCrops = new System.Windows.Forms.Button();
            this.userControlCrops1 = new UI_Framework.userControlCrops();
            this.userControlNews1 = new UI_Framework.userControlNews();
            this.userControlWeather1 = new UI_Framework.userControlWeather();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(548, 19);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(75, 52);
            this.btnWeather.TabIndex = 2;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(97, 19);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(75, 52);
            this.btnNews.TabIndex = 1;
            this.btnNews.Text = "News";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click_1);
            // 
            // btnCrops
            // 
            this.btnCrops.Location = new System.Drawing.Point(305, 19);
            this.btnCrops.Name = "btnCrops";
            this.btnCrops.Size = new System.Drawing.Size(75, 52);
            this.btnCrops.TabIndex = 0;
            this.btnCrops.Text = "Crops";
            this.btnCrops.UseVisualStyleBackColor = true;
            this.btnCrops.Click += new System.EventHandler(this.btnCrops_Click_1);
            // 
            // userControlCrops1
            // 
            this.userControlCrops1.BackColor = System.Drawing.Color.Transparent;
            this.userControlCrops1.Location = new System.Drawing.Point(1, -5);
            this.userControlCrops1.Name = "userControlCrops1";
            this.userControlCrops1.Size = new System.Drawing.Size(777, 360);
            this.userControlCrops1.TabIndex = 1;
            // 
            // userControlNews1
            // 
            this.userControlNews1.Location = new System.Drawing.Point(1, -5);
            this.userControlNews1.Name = "userControlNews1";
            this.userControlNews1.Size = new System.Drawing.Size(755, 351);
            this.userControlNews1.TabIndex = 2;
            // 
            // userControlWeather1
            // 
            this.userControlWeather1.Location = new System.Drawing.Point(-10, -5);
            this.userControlWeather1.Name = "userControlWeather1";
            this.userControlWeather1.Size = new System.Drawing.Size(766, 360);
            this.userControlWeather1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNews);
            this.panel1.Controls.Add(this.btnWeather);
            this.panel1.Controls.Add(this.btnCrops);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 342);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(755, 100);
            this.panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::UI_Framework.Properties.Resources.wall_2423822_960_720;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(755, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::UI_Framework.Properties.Resources._194445;
            this.pictureBox2.Location = new System.Drawing.Point(1, -5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(755, 351);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.userControlWeather1);
            this.Controls.Add(this.userControlNews1);
            this.Controls.Add(this.userControlCrops1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnCrops;
        private userControlCrops userControlCrops1;
        private userControlNews userControlNews1;
        private userControlWeather userControlWeather1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}


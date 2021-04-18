
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
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWeather
            // 
            this.btnWeather.Location = new System.Drawing.Point(420, 37);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(75, 23);
            this.btnWeather.TabIndex = 2;
            this.btnWeather.Text = "button3";
            this.btnWeather.UseVisualStyleBackColor = true;
            this.btnWeather.Click += new System.EventHandler(this.btnWeather_Click);
            // 
            // btnNews
            // 
            this.btnNews.Location = new System.Drawing.Point(65, 37);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(75, 23);
            this.btnNews.TabIndex = 1;
            this.btnNews.Text = "button2";
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click_1);
            // 
            // btnCrops
            // 
            this.btnCrops.Location = new System.Drawing.Point(228, 37);
            this.btnCrops.Name = "btnCrops";
            this.btnCrops.Size = new System.Drawing.Size(75, 23);
            this.btnCrops.TabIndex = 0;
            this.btnCrops.Text = "button1";
            this.btnCrops.UseVisualStyleBackColor = true;
            this.btnCrops.Click += new System.EventHandler(this.btnCrops_Click_1);
            // 
            // userControlCrops1
            // 
            this.userControlCrops1.Location = new System.Drawing.Point(15, 12);
            this.userControlCrops1.Name = "userControlCrops1";
            this.userControlCrops1.Size = new System.Drawing.Size(729, 301);
            this.userControlCrops1.TabIndex = 1;
            // 
            // userControlNews1
            // 
            this.userControlNews1.Location = new System.Drawing.Point(15, 12);
            this.userControlNews1.Name = "userControlNews1";
            this.userControlNews1.Size = new System.Drawing.Size(729, 301);
            this.userControlNews1.TabIndex = 2;
            // 
            // userControlWeather1
            // 
            this.userControlWeather1.Location = new System.Drawing.Point(12, 4);
            this.userControlWeather1.Name = "userControlWeather1";
            this.userControlWeather1.Size = new System.Drawing.Size(732, 321);
            this.userControlWeather1.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNews);
            this.panel1.Controls.Add(this.btnWeather);
            this.panel1.Controls.Add(this.btnCrops);
            this.panel1.Location = new System.Drawing.Point(12, 319);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(729, 100);
            this.panel1.TabIndex = 4;
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
            this.Name = "Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
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
    }
}


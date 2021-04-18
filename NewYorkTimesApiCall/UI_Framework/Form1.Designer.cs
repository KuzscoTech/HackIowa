
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.btnNews = new System.Windows.Forms.Button();
            this.btnWeather = new System.Windows.Forms.Button();
            this.btnCrops = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNews
            // 
            this.btnNews.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNews.BackgroundImage")));
            this.btnNews.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNews.Location = new System.Drawing.Point(84, 12);
            this.btnNews.Name = "btnNews";
            this.btnNews.Size = new System.Drawing.Size(124, 80);
            this.btnNews.TabIndex = 0;
            this.btnNews.UseVisualStyleBackColor = true;
            this.btnNews.Click += new System.EventHandler(this.btnNews_Click);
            // 
            // btnWeather
            // 
            this.btnWeather.BackgroundImage = global::UI_Framework.Properties.Resources.istockphoto_1125612041_612x612;
            this.btnWeather.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWeather.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnWeather.ForeColor = System.Drawing.Color.White;
            this.btnWeather.Location = new System.Drawing.Point(314, 13);
            this.btnWeather.Name = "btnWeather";
            this.btnWeather.Size = new System.Drawing.Size(133, 80);
            this.btnWeather.TabIndex = 1;
            this.btnWeather.Text = "Weather";
            this.btnWeather.UseVisualStyleBackColor = true;
            // 
            // btnCrops
            // 
            this.btnCrops.BackgroundImage = global::UI_Framework.Properties.Resources.gettyimages_471500644;
            this.btnCrops.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrops.Location = new System.Drawing.Point(555, 12);
            this.btnCrops.Name = "btnCrops";
            this.btnCrops.Size = new System.Drawing.Size(129, 80);
            this.btnCrops.TabIndex = 2;
            this.btnCrops.Text = "Crops";
            this.btnCrops.UseVisualStyleBackColor = true;
            this.btnCrops.Click += new System.EventHandler(this.btnCrops_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnNews);
            this.panel1.Controls.Add(this.btnCrops);
            this.panel1.Controls.Add(this.btnWeather);
            this.panel1.Location = new System.Drawing.Point(1, 356);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(804, 104);
            this.panel1.TabIndex = 3;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(805, 459);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "Main";
            this.Text = "Agriculture Center - Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNews;
        private System.Windows.Forms.Button btnWeather;
        private System.Windows.Forms.Button btnCrops;
        private System.Windows.Forms.Panel panel1;
        private userControlCrops crops1;
        private userControlNews news1;
        private userControlWeather weather1;
    }
}


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using NewYorkTimesCall;


namespace UI_Framework
{
    public partial class userControlNews : UserControl
    {
        Label articleTitle;
        LinkLabel articleURL;
        Panel articleTemplate;
        PictureBox articlePicture;
        public userControlNews()
        {
            InitializeComponent();
        }

        private void userControlNews_Load(object sender, EventArgs e)
        {
            generateArticle();
        }

        private void generateArticle()
        {
            var response = NYInfo.GetArticles();
            var articles = response.Articles;
            var position_X = 200;
            var position_Y = 20;


            foreach (var r in articles)
            {
                articleTemplate = new Panel();
                articlePicture = new PictureBox();
                articleTitle = new Label();
                articleURL = new LinkLabel();
                articleTemplate.Width = 557;
                articleTemplate.Height = 136;
                if (r.Multimedia != null)
                {
                    articlePicture.ImageLocation = r.Multimedia[3].URL;
                    articlePicture.Width = r.Multimedia[3].Width;
                    articlePicture.Height = r.Multimedia[3].Height;
                }
                articleTitle.Text = r.Title;
                articleTitle.Location = new Point(position_X + articleTemplate.Location.X, position_Y + articleTemplate.Location.Y);
                articleTitle.AutoSize = true;
                articleURL.AutoSize = true;
                articleURL.Text = r.URL;
                articleURL.Location = new Point(position_X, position_Y + 60);
                articleURL.Width = 300;
                articleTemplate.Controls.Add(articleTitle);
                articleTemplate.Controls.Add(articlePicture);
                articleTemplate.Controls.Add(articleURL);
                flowLayoutPanel1.Controls.Add(articleTemplate);
                flowLayoutPanel1.Height = articles.Length * 141;
            }
        }
    }
}

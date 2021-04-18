
namespace UI_Framework
{
    partial class userControlCrops
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnRice = new System.Windows.Forms.Button();
            this.btnWheat = new System.Windows.Forms.Button();
            this.btnCotton = new System.Windows.Forms.Button();
            this.btnCorn = new System.Windows.Forms.Button();
            this.lblInfo = new System.Windows.Forms.Label();
            this.lblPlantInfo = new System.Windows.Forms.Label();
            this.txtCrop = new System.Windows.Forms.TextBox();
            this.lblCrop = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAcres = new System.Windows.Forms.TextBox();
            this.btnCost = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblReturn = new System.Windows.Forms.Label();
            this.lblCost = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.White;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Black;
            this.lblTitle.Location = new System.Drawing.Point(470, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(75, 32);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Crops";
            // 
            // btnRice
            // 
            this.btnRice.Location = new System.Drawing.Point(13, 15);
            this.btnRice.Name = "btnRice";
            this.btnRice.Size = new System.Drawing.Size(81, 23);
            this.btnRice.TabIndex = 2;
            this.btnRice.Text = "Rice Info";
            this.btnRice.UseVisualStyleBackColor = true;
            this.btnRice.Click += new System.EventHandler(this.btnRice_Click);
            // 
            // btnWheat
            // 
            this.btnWheat.Location = new System.Drawing.Point(13, 54);
            this.btnWheat.Name = "btnWheat";
            this.btnWheat.Size = new System.Drawing.Size(81, 23);
            this.btnWheat.TabIndex = 3;
            this.btnWheat.Text = "Wheat info";
            this.btnWheat.UseVisualStyleBackColor = true;
            this.btnWheat.Click += new System.EventHandler(this.btnWheat_Click);
            // 
            // btnCotton
            // 
            this.btnCotton.Location = new System.Drawing.Point(13, 94);
            this.btnCotton.Name = "btnCotton";
            this.btnCotton.Size = new System.Drawing.Size(81, 23);
            this.btnCotton.TabIndex = 4;
            this.btnCotton.Text = "Cotton info";
            this.btnCotton.UseVisualStyleBackColor = true;
            this.btnCotton.Click += new System.EventHandler(this.btnCotton_Click);
            // 
            // btnCorn
            // 
            this.btnCorn.Location = new System.Drawing.Point(13, 133);
            this.btnCorn.Name = "btnCorn";
            this.btnCorn.Size = new System.Drawing.Size(81, 23);
            this.btnCorn.TabIndex = 5;
            this.btnCorn.Text = "Corn info";
            this.btnCorn.UseVisualStyleBackColor = true;
            this.btnCorn.Click += new System.EventHandler(this.btnCorn_Click);
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.White;
            this.lblInfo.Location = new System.Drawing.Point(213, 112);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(57, 15);
            this.lblInfo.TabIndex = 6;
            this.lblInfo.Text = "Econ Info";
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // lblPlantInfo
            // 
            this.lblPlantInfo.AutoSize = true;
            this.lblPlantInfo.BackColor = System.Drawing.Color.White;
            this.lblPlantInfo.Location = new System.Drawing.Point(213, 37);
            this.lblPlantInfo.Name = "lblPlantInfo";
            this.lblPlantInfo.Size = new System.Drawing.Size(58, 15);
            this.lblPlantInfo.TabIndex = 7;
            this.lblPlantInfo.Text = "Plant Info";
            // 
            // txtCrop
            // 
            this.txtCrop.Location = new System.Drawing.Point(146, 178);
            this.txtCrop.Name = "txtCrop";
            this.txtCrop.Size = new System.Drawing.Size(100, 23);
            this.txtCrop.TabIndex = 8;
            // 
            // lblCrop
            // 
            this.lblCrop.AutoSize = true;
            this.lblCrop.BackColor = System.Drawing.Color.White;
            this.lblCrop.Location = new System.Drawing.Point(13, 181);
            this.lblCrop.Name = "lblCrop";
            this.lblCrop.Size = new System.Drawing.Size(94, 15);
            this.lblCrop.TabIndex = 9;
            this.lblCrop.Text = "Enter crop name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(13, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter amount of acres";
            // 
            // txtAcres
            // 
            this.txtAcres.Location = new System.Drawing.Point(146, 204);
            this.txtAcres.Name = "txtAcres";
            this.txtAcres.Size = new System.Drawing.Size(100, 23);
            this.txtAcres.TabIndex = 11;
            this.txtAcres.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnCost
            // 
            this.btnCost.Location = new System.Drawing.Point(263, 317);
            this.btnCost.Name = "btnCost";
            this.btnCost.Size = new System.Drawing.Size(75, 47);
            this.btnCost.TabIndex = 12;
            this.btnCost.Text = "Cost";
            this.btnCost.UseVisualStyleBackColor = true;
            this.btnCost.Click += new System.EventHandler(this.btnCost_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(93, 317);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(75, 45);
            this.btnReturn.TabIndex = 13;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(437, 317);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 45);
            this.btnClear.TabIndex = 16;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblReturn
            // 
            this.lblReturn.AutoSize = true;
            this.lblReturn.Location = new System.Drawing.Point(187, 332);
            this.lblReturn.Name = "lblReturn";
            this.lblReturn.Size = new System.Drawing.Size(0, 15);
            this.lblReturn.TabIndex = 19;
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Location = new System.Drawing.Point(359, 333);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(0, 15);
            this.lblCost.TabIndex = 20;
            // 
            // userControlCrops
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::UI_Framework.Properties.Resources.crops;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblReturn);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnCost);
            this.Controls.Add(this.txtAcres);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCrop);
            this.Controls.Add(this.txtCrop);
            this.Controls.Add(this.lblPlantInfo);
            this.Controls.Add(this.lblInfo);
            this.Controls.Add(this.btnCorn);
            this.Controls.Add(this.btnCotton);
            this.Controls.Add(this.btnWheat);
            this.Controls.Add(this.btnRice);
            this.Controls.Add(this.lblTitle);
            this.Name = "userControlCrops";
            this.Size = new System.Drawing.Size(755, 403);
            this.Load += new System.EventHandler(this.userControlCrops_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Button btnRice;
        private System.Windows.Forms.Button btnWheat;
        private System.Windows.Forms.Button btnCotton;
        private System.Windows.Forms.Button btnCorn;
        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.Label lblPlantInfo;
        private System.Windows.Forms.TextBox txtCrop;
        private System.Windows.Forms.Label lblCrop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAcres;
        private System.Windows.Forms.Button btnCost;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label lblReturn;
        private System.Windows.Forms.Label lblCost;
    }
}

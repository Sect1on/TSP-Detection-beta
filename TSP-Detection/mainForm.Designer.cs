namespace TSP_Detection
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picOrigin = new System.Windows.Forms.PictureBox();
            this.picROI = new System.Windows.Forms.PictureBox();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.picGrayHist = new System.Windows.Forms.PictureBox();
            this.picHist = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picROI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayHist)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).BeginInit();
            this.SuspendLayout();
            // 
            // picOrigin
            // 
            this.picOrigin.Location = new System.Drawing.Point(40, 12);
            this.picOrigin.Name = "picOrigin";
            this.picOrigin.Size = new System.Drawing.Size(428, 266);
            this.picOrigin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOrigin.TabIndex = 0;
            this.picOrigin.TabStop = false;
            // 
            // picROI
            // 
            this.picROI.Location = new System.Drawing.Point(486, 12);
            this.picROI.Name = "picROI";
            this.picROI.Size = new System.Drawing.Size(575, 50);
            this.picROI.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picROI.TabIndex = 2;
            this.picROI.TabStop = false;
            // 
            // picGray
            // 
            this.picGray.Location = new System.Drawing.Point(486, 68);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(575, 50);
            this.picGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGray.TabIndex = 3;
            this.picGray.TabStop = false;
            // 
            // picGrayHist
            // 
            this.picGrayHist.Location = new System.Drawing.Point(486, 124);
            this.picGrayHist.Name = "picGrayHist";
            this.picGrayHist.Size = new System.Drawing.Size(575, 111);
            this.picGrayHist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGrayHist.TabIndex = 6;
            this.picGrayHist.TabStop = false;
            // 
            // picHist
            // 
            this.picHist.Location = new System.Drawing.Point(486, 241);
            this.picHist.Name = "picHist";
            this.picHist.Size = new System.Drawing.Size(575, 115);
            this.picHist.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picHist.TabIndex = 7;
            this.picHist.TabStop = false;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(40, 303);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 456);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picHist);
            this.Controls.Add(this.picGrayHist);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.picROI);
            this.Controls.Add(this.picOrigin);
            this.Name = "mainForm";
            this.Text = "TSP-Detection";
            ((System.ComponentModel.ISupportInitialize)(this.picOrigin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picROI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGrayHist)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picHist)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOrigin;
        private System.Windows.Forms.PictureBox picROI;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.PictureBox picGrayHist;
        private System.Windows.Forms.PictureBox picHist;
        private System.Windows.Forms.Button btnStart;
    }
}


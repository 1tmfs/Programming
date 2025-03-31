namespace Review3
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblUSD = new System.Windows.Forms.Label();
            this.lblKRW = new System.Windows.Forms.Label();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtKRW = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblUSD
            // 
            this.lblUSD.AutoSize = true;
            this.lblUSD.Location = new System.Drawing.Point(435, 195);
            this.lblUSD.Name = "lblUSD";
            this.lblUSD.Size = new System.Drawing.Size(45, 15);
            this.lblUSD.TabIndex = 0;
            this.lblUSD.Text = "label1";
            // 
            // lblKRW
            // 
            this.lblKRW.AutoSize = true;
            this.lblKRW.Location = new System.Drawing.Point(435, 243);
            this.lblKRW.Name = "lblKRW";
            this.lblKRW.Size = new System.Drawing.Size(45, 15);
            this.lblKRW.TabIndex = 1;
            this.lblKRW.Text = "label2";
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(524, 195);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(100, 25);
            this.txtUSD.TabIndex = 2;
            // 
            // txtKRW
            // 
            this.txtKRW.Location = new System.Drawing.Point(524, 243);
            this.txtKRW.Name = "txtKRW";
            this.txtKRW.Size = new System.Drawing.Size(100, 25);
            this.txtKRW.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(524, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtKRW);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.lblKRW);
            this.Controls.Add(this.lblUSD);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUSD;
        private System.Windows.Forms.Label lblKRW;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtKRW;
        private System.Windows.Forms.Button button1;
    }
}


namespace test
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblC = new System.Windows.Forms.Label();
            this.lblF = new System.Windows.Forms.Label();
            this.txtC = new System.Windows.Forms.TextBox();
            this.txtF = new System.Windows.Forms.TextBox();
            this.btnResult = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblResult2 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(311, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "온도변환기";
            // 
            // lblC
            // 
            this.lblC.AutoSize = true;
            this.lblC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblC.Location = new System.Drawing.Point(268, 179);
            this.lblC.Name = "lblC";
            this.lblC.Size = new System.Drawing.Size(39, 20);
            this.lblC.TabIndex = 1;
            this.lblC.Text = "섭씨";
            // 
            // lblF
            // 
            this.lblF.AutoSize = true;
            this.lblF.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblF.Location = new System.Drawing.Point(547, 179);
            this.lblF.Name = "lblF";
            this.lblF.Size = new System.Drawing.Size(39, 20);
            this.lblF.TabIndex = 2;
            this.lblF.Text = "화씨";
            // 
            // txtC
            // 
            this.txtC.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtC.Location = new System.Drawing.Point(147, 176);
            this.txtC.Name = "txtC";
            this.txtC.Size = new System.Drawing.Size(100, 27);
            this.txtC.TabIndex = 3;
            // 
            // txtF
            // 
            this.txtF.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txtF.Location = new System.Drawing.Point(424, 176);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(100, 27);
            this.txtF.TabIndex = 4;
            // 
            // btnResult
            // 
            this.btnResult.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnResult.Location = new System.Drawing.Point(307, 260);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(116, 37);
            this.btnResult.TabIndex = 5;
            this.btnResult.Text = "변환하기";
            this.btnResult.UseVisualStyleBackColor = true;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(147, 321);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 15);
            this.lblResult.TabIndex = 6;
            // 
            // lblResult2
            // 
            this.lblResult2.AutoSize = true;
            this.lblResult2.Location = new System.Drawing.Point(147, 377);
            this.lblResult2.Name = "lblResult2";
            this.lblResult2.Size = new System.Drawing.Size(0, 15);
            this.lblResult2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 345);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 15);
            this.label2.TabIndex = 8;
            this.label2.Text = "섭씨 = (화씨-32) * 5 / 9";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 377);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 15);
            this.label3.TabIndex = 9;
            this.label3.Text = "화씨 = 섭씨 * 9 / 5 + 32";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblResult2);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnResult);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.txtC);
            this.Controls.Add(this.lblF);
            this.Controls.Add(this.lblC);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "온도변환기 v.0.1 by 서한슬";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblC;
        private System.Windows.Forms.Label lblF;
        private System.Windows.Forms.TextBox txtC;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.Button btnResult;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblResult2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


namespace StringMethod
{
    partial class StringAppForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblLeft3Chars = new System.Windows.Forms.Label();
            this.lblRight3Chars = new System.Windows.Forms.Label();
            this.lbl5th3chars = new System.Windows.Forms.Label();
            this.lblBlankPosition = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(102, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "입력문자열로부터 자료 추출하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "입력문자열(10자이상):";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(43, 117);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(45, 12);
            this.lblLength.TabIndex = 2;
            this.lblLength.Text = "글자수:";
            // 
            // lblLeft3Chars
            // 
            this.lblLeft3Chars.AutoSize = true;
            this.lblLeft3Chars.Location = new System.Drawing.Point(43, 148);
            this.lblLeft3Chars.Name = "lblLeft3Chars";
            this.lblLeft3Chars.Size = new System.Drawing.Size(63, 12);
            this.lblLeft3Chars.TabIndex = 3;
            this.lblLeft3Chars.Text = "처음3글자:";
            // 
            // lblRight3Chars
            // 
            this.lblRight3Chars.AutoSize = true;
            this.lblRight3Chars.Location = new System.Drawing.Point(43, 181);
            this.lblRight3Chars.Name = "lblRight3Chars";
            this.lblRight3Chars.Size = new System.Drawing.Size(75, 12);
            this.lblRight3Chars.TabIndex = 4;
            this.lblRight3Chars.Text = "마지막3글자:";
            // 
            // lbl5th3chars
            // 
            this.lbl5th3chars.AutoSize = true;
            this.lbl5th3chars.Location = new System.Drawing.Point(43, 218);
            this.lbl5th3chars.Name = "lbl5th3chars";
            this.lbl5th3chars.Size = new System.Drawing.Size(73, 12);
            this.lbl5th3chars.TabIndex = 5;
            this.lbl5th3chars.Text = "5번째 3글자:";
            // 
            // lblBlankPosition
            // 
            this.lblBlankPosition.AutoSize = true;
            this.lblBlankPosition.Location = new System.Drawing.Point(43, 250);
            this.lblBlankPosition.Name = "lblBlankPosition";
            this.lblBlankPosition.Size = new System.Drawing.Size(73, 12);
            this.lblBlankPosition.TabIndex = 6;
            this.lblBlankPosition.Text = "빈칸의 위치:";
            // 
            // txtInput
            // 
            this.txtInput.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtInput.Location = new System.Drawing.Point(183, 58);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(165, 21);
            this.txtInput.TabIndex = 7;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(86, 79);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(91, 23);
            this.btnOk.TabIndex = 8;
            this.btnOk.Text = "자료추출하기";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // StringAppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblBlankPosition);
            this.Controls.Add(this.lbl5th3chars);
            this.Controls.Add(this.lblRight3Chars);
            this.Controls.Add(this.lblLeft3Chars);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "StringAppForm";
            this.Text = "문자열 처리 메서드";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblLeft3Chars;
        private System.Windows.Forms.Label lblRight3Chars;
        private System.Windows.Forms.Label lbl5th3chars;
        private System.Windows.Forms.Label lblBlankPosition;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Button btnOk;
    }
}


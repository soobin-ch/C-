namespace _02_IncrementDecrementOperators
{
    partial class IncreDecrementForm
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
            this.txtIntNum = new System.Windows.Forms.TextBox();
            this.txtDoubNum = new System.Windows.Forms.TextBox();
            this.btnIntDec = new System.Windows.Forms.Button();
            this.btnIntInc = new System.Windows.Forms.Button();
            this.btnDoubDec = new System.Windows.Forms.Button();
            this.btnDoubInc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "정수형 자료";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(254, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "실수형 자료";
            // 
            // txtIntNum
            // 
            this.txtIntNum.Location = new System.Drawing.Point(49, 71);
            this.txtIntNum.Name = "txtIntNum";
            this.txtIntNum.Size = new System.Drawing.Size(100, 21);
            this.txtIntNum.TabIndex = 2;
            this.txtIntNum.Text = "100";
            this.txtIntNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtDoubNum
            // 
            this.txtDoubNum.Location = new System.Drawing.Point(247, 67);
            this.txtDoubNum.Name = "txtDoubNum";
            this.txtDoubNum.Size = new System.Drawing.Size(100, 21);
            this.txtDoubNum.TabIndex = 3;
            this.txtDoubNum.Text = "100.5";
            this.txtDoubNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnIntDec
            // 
            this.btnIntDec.Location = new System.Drawing.Point(12, 71);
            this.btnIntDec.Name = "btnIntDec";
            this.btnIntDec.Size = new System.Drawing.Size(31, 23);
            this.btnIntDec.TabIndex = 4;
            this.btnIntDec.Text = "<";
            this.btnIntDec.UseVisualStyleBackColor = true;
            this.btnIntDec.Click += new System.EventHandler(this.btnIntDec_Click);
            // 
            // btnIntInc
            // 
            this.btnIntInc.Location = new System.Drawing.Point(155, 71);
            this.btnIntInc.Name = "btnIntInc";
            this.btnIntInc.Size = new System.Drawing.Size(28, 23);
            this.btnIntInc.TabIndex = 5;
            this.btnIntInc.Text = ">";
            this.btnIntInc.UseVisualStyleBackColor = true;
            this.btnIntInc.Click += new System.EventHandler(this.btnIntInc_Click);
            // 
            // btnDoubDec
            // 
            this.btnDoubDec.Location = new System.Drawing.Point(206, 67);
            this.btnDoubDec.Name = "btnDoubDec";
            this.btnDoubDec.Size = new System.Drawing.Size(23, 23);
            this.btnDoubDec.TabIndex = 6;
            this.btnDoubDec.Text = "<";
            this.btnDoubDec.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoubDec.UseVisualStyleBackColor = true;
            this.btnDoubDec.Click += new System.EventHandler(this.btnDoubDec_Click);
            // 
            // btnDoubInc
            // 
            this.btnDoubInc.Location = new System.Drawing.Point(368, 67);
            this.btnDoubInc.Name = "btnDoubInc";
            this.btnDoubInc.Size = new System.Drawing.Size(27, 23);
            this.btnDoubInc.TabIndex = 7;
            this.btnDoubInc.Text = ">";
            this.btnDoubInc.UseVisualStyleBackColor = true;
            this.btnDoubInc.Click += new System.EventHandler(this.btnDoubInc_Click);
            // 
            // IncreDecrementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDoubInc);
            this.Controls.Add(this.btnDoubDec);
            this.Controls.Add(this.btnIntInc);
            this.Controls.Add(this.btnIntDec);
            this.Controls.Add(this.txtDoubNum);
            this.Controls.Add(this.txtIntNum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "IncreDecrementForm";
            this.Text = "증가/감소연산자 활용";
            this.Load += new System.EventHandler(this.IncreDecrementForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIntNum;
        private System.Windows.Forms.TextBox txtDoubNum;
        private System.Windows.Forms.Button btnIntDec;
        private System.Windows.Forms.Button btnIntInc;
        private System.Windows.Forms.Button btnDoubDec;
        private System.Windows.Forms.Button btnDoubInc;
    }
}


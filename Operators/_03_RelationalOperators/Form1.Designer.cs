namespace _03_RelationalOperators
{
    partial class RelatonalOpForm
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtEQ = new System.Windows.Forms.TextBox();
            this.txtNE = new System.Windows.Forms.TextBox();
            this.txtGT = new System.Windows.Forms.TextBox();
            this.txtLT = new System.Windows.Forms.TextBox();
            this.txtGE = new System.Windows.Forms.TextBox();
            this.txtLE = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(193, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "크기를 비교할 두 수를 입력하시오.";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(56, 53);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 21);
            this.txtNum1.TabIndex = 1;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(173, 53);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 21);
            this.txtNum2.TabIndex = 2;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(93, 89);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(137, 23);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "관계연산자 결과 확인";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Num1 ==Num2 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "Num1 != Num2 :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(61, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "Num1 > Num2 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 231);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "Num1 <Num2:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "Num1 >=Num2 :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(54, 293);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(101, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "Num1 <= Num2 :";
            // 
            // txtEQ
            // 
            this.txtEQ.Location = new System.Drawing.Point(163, 130);
            this.txtEQ.Name = "txtEQ";
            this.txtEQ.Size = new System.Drawing.Size(100, 21);
            this.txtEQ.TabIndex = 11;
            this.txtEQ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNE
            // 
            this.txtNE.Location = new System.Drawing.Point(163, 162);
            this.txtNE.Name = "txtNE";
            this.txtNE.Size = new System.Drawing.Size(100, 21);
            this.txtNE.TabIndex = 12;
            this.txtNE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGT
            // 
            this.txtGT.Location = new System.Drawing.Point(163, 195);
            this.txtGT.Name = "txtGT";
            this.txtGT.Size = new System.Drawing.Size(100, 21);
            this.txtGT.TabIndex = 13;
            this.txtGT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLT
            // 
            this.txtLT.Location = new System.Drawing.Point(163, 222);
            this.txtLT.Name = "txtLT";
            this.txtLT.Size = new System.Drawing.Size(100, 21);
            this.txtLT.TabIndex = 14;
            this.txtLT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtGE
            // 
            this.txtGE.Location = new System.Drawing.Point(163, 257);
            this.txtGE.Name = "txtGE";
            this.txtGE.Size = new System.Drawing.Size(100, 21);
            this.txtGE.TabIndex = 15;
            this.txtGE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtLE
            // 
            this.txtLE.Location = new System.Drawing.Point(163, 290);
            this.txtLE.Name = "txtLE";
            this.txtLE.Size = new System.Drawing.Size(100, 21);
            this.txtLE.TabIndex = 16;
            this.txtLE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RelatonalOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtLE);
            this.Controls.Add(this.txtGE);
            this.Controls.Add(this.txtLT);
            this.Controls.Add(this.txtGT);
            this.Controls.Add(this.txtNE);
            this.Controls.Add(this.txtEQ);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "RelatonalOpForm";
            this.Text = "관계 연산자의 활용";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtEQ;
        private System.Windows.Forms.TextBox txtNE;
        private System.Windows.Forms.TextBox txtGT;
        private System.Windows.Forms.TextBox txtLT;
        private System.Windows.Forms.TextBox txtGE;
        private System.Windows.Forms.TextBox txtLE;
    }
}


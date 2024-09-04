namespace _01_ArithmeticOperators
{
    partial class ArithmeticForm
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
            this.btnIntCalc = new System.Windows.Forms.Button();
            this.btnDoubCalc = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtlAdd = new System.Windows.Forms.TextBox();
            this.txtlMin = new System.Windows.Forms.TextBox();
            this.txtlMul = new System.Windows.Forms.TextBox();
            this.txtlDiv = new System.Windows.Forms.TextBox();
            this.txtlMod = new System.Windows.Forms.TextBox();
            this.txtDAdd = new System.Windows.Forms.TextBox();
            this.txtDMin = new System.Windows.Forms.TextBox();
            this.txtDMul = new System.Windows.Forms.TextBox();
            this.txtDDiv = new System.Windows.Forms.TextBox();
            this.txtDMod = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "2개의 수를 입력하시오";
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(39, 68);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 21);
            this.txtNum1.TabIndex = 1;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(169, 68);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 21);
            this.txtNum2.TabIndex = 2;
            // 
            // btnIntCalc
            // 
            this.btnIntCalc.Location = new System.Drawing.Point(39, 117);
            this.btnIntCalc.Name = "btnIntCalc";
            this.btnIntCalc.Size = new System.Drawing.Size(108, 23);
            this.btnIntCalc.TabIndex = 3;
            this.btnIntCalc.Text = "정수 연산결과";
            this.btnIntCalc.UseVisualStyleBackColor = true;
            this.btnIntCalc.Click += new System.EventHandler(this.btnIntCalc_Click);
            // 
            // btnDoubCalc
            // 
            this.btnDoubCalc.Location = new System.Drawing.Point(169, 117);
            this.btnDoubCalc.Name = "btnDoubCalc";
            this.btnDoubCalc.Size = new System.Drawing.Size(100, 23);
            this.btnDoubCalc.TabIndex = 4;
            this.btnDoubCalc.Text = "실수 연산 결과";
            this.btnDoubCalc.UseVisualStyleBackColor = true;
            this.btnDoubCalc.Click += new System.EventHandler(this.btnDoubCalc_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 5;
            this.label2.Text = "iNum1*iNum2=";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 281);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "iNum1/iNum2=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 12);
            this.label4.TabIndex = 7;
            this.label4.Text = "iNum1+iNum2=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "iNum1-iNum2=";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 312);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 12);
            this.label6.TabIndex = 9;
            this.label6.Text = "iNum1%iNum2=";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(193, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 12);
            this.label7.TabIndex = 10;
            this.label7.Text = "dNum1+dNum2=";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(193, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(97, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "dNum1-dNum2=";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(193, 231);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(97, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "dNum1-dNum2=";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(193, 272);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 12);
            this.label10.TabIndex = 13;
            this.label10.Text = "dNum1/dNum2=";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(193, 306);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 12);
            this.label11.TabIndex = 14;
            this.label11.Text = "dNum1%dNum2=";
            // 
            // txtlAdd
            // 
            this.txtlAdd.Location = new System.Drawing.Point(129, 164);
            this.txtlAdd.Name = "txtlAdd";
            this.txtlAdd.Size = new System.Drawing.Size(43, 21);
            this.txtlAdd.TabIndex = 15;
            // 
            // txtlMin
            // 
            this.txtlMin.Location = new System.Drawing.Point(129, 196);
            this.txtlMin.Name = "txtlMin";
            this.txtlMin.Size = new System.Drawing.Size(43, 21);
            this.txtlMin.TabIndex = 16;
            // 
            // txtlMul
            // 
            this.txtlMul.Location = new System.Drawing.Point(129, 231);
            this.txtlMul.Name = "txtlMul";
            this.txtlMul.Size = new System.Drawing.Size(43, 21);
            this.txtlMul.TabIndex = 17;
            // 
            // txtlDiv
            // 
            this.txtlDiv.Location = new System.Drawing.Point(129, 272);
            this.txtlDiv.Name = "txtlDiv";
            this.txtlDiv.Size = new System.Drawing.Size(43, 21);
            this.txtlDiv.TabIndex = 18;
            // 
            // txtlMod
            // 
            this.txtlMod.Location = new System.Drawing.Point(129, 303);
            this.txtlMod.Name = "txtlMod";
            this.txtlMod.Size = new System.Drawing.Size(43, 21);
            this.txtlMod.TabIndex = 19;
            // 
            // txtDAdd
            // 
            this.txtDAdd.Location = new System.Drawing.Point(305, 164);
            this.txtDAdd.Name = "txtDAdd";
            this.txtDAdd.Size = new System.Drawing.Size(43, 21);
            this.txtDAdd.TabIndex = 20;
            // 
            // txtDMin
            // 
            this.txtDMin.Location = new System.Drawing.Point(305, 196);
            this.txtDMin.Name = "txtDMin";
            this.txtDMin.Size = new System.Drawing.Size(43, 21);
            this.txtDMin.TabIndex = 21;
            // 
            // txtDMul
            // 
            this.txtDMul.Location = new System.Drawing.Point(305, 228);
            this.txtDMul.Name = "txtDMul";
            this.txtDMul.Size = new System.Drawing.Size(43, 21);
            this.txtDMul.TabIndex = 22;
            // 
            // txtDDiv
            // 
            this.txtDDiv.Location = new System.Drawing.Point(305, 269);
            this.txtDDiv.Name = "txtDDiv";
            this.txtDDiv.Size = new System.Drawing.Size(43, 21);
            this.txtDDiv.TabIndex = 23;
            // 
            // txtDMod
            // 
            this.txtDMod.Location = new System.Drawing.Point(305, 303);
            this.txtDMod.Name = "txtDMod";
            this.txtDMod.Size = new System.Drawing.Size(43, 21);
            this.txtDMod.TabIndex = 24;
            // 
            // ArithmeticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtDMod);
            this.Controls.Add(this.txtDDiv);
            this.Controls.Add(this.txtDMul);
            this.Controls.Add(this.txtDMin);
            this.Controls.Add(this.txtDAdd);
            this.Controls.Add(this.txtlMod);
            this.Controls.Add(this.txtlDiv);
            this.Controls.Add(this.txtlMul);
            this.Controls.Add(this.txtlMin);
            this.Controls.Add(this.txtlAdd);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnDoubCalc);
            this.Controls.Add(this.btnIntCalc);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Controls.Add(this.label1);
            this.Name = "ArithmeticForm";
            this.Text = "산술연산자 활용";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.Button btnIntCalc;
        private System.Windows.Forms.Button btnDoubCalc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtlAdd;
        private System.Windows.Forms.TextBox txtlMin;
        private System.Windows.Forms.TextBox txtlMul;
        private System.Windows.Forms.TextBox txtlDiv;
        private System.Windows.Forms.TextBox txtlMod;
        private System.Windows.Forms.TextBox txtDAdd;
        private System.Windows.Forms.TextBox txtDMin;
        private System.Windows.Forms.TextBox txtDMul;
        private System.Windows.Forms.TextBox txtDDiv;
        private System.Windows.Forms.TextBox txtDMod;
    }
}


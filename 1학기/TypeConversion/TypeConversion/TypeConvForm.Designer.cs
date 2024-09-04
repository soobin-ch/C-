namespace TypeConversion
{
    partial class TypeConvForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblStrToInt = new System.Windows.Forms.Label();
            this.lblStrToDouble = new System.Windows.Forms.Label();
            this.lblIntToDoublelmp = new System.Windows.Forms.Label();
            this.lblIntToDoubleExp = new System.Windows.Forms.Label();
            this.lblDoubleToIntExp = new System.Windows.Forms.Label();
            this.txtInt = new System.Windows.Forms.TextBox();
            this.txtDouble = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "정수입력 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "실수입력:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "문자열을  int로 변환:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "문자열을 double 로 변환:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 12);
            this.label5.TabIndex = 4;
            this.label5.Text = "int를 double로 변환(암시적):";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "int를 double로 변환(명시적):";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(12, 278);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "double을 int로 변환(명시적):";
            // 
            // lblStrToInt
            // 
            this.lblStrToInt.AutoSize = true;
            this.lblStrToInt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrToInt.Location = new System.Drawing.Point(186, 128);
            this.lblStrToInt.Name = "lblStrToInt";
            this.lblStrToInt.Size = new System.Drawing.Size(2, 14);
            this.lblStrToInt.TabIndex = 7;
            // 
            // lblStrToDouble
            // 
            this.lblStrToDouble.AutoSize = true;
            this.lblStrToDouble.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblStrToDouble.Location = new System.Drawing.Point(186, 161);
            this.lblStrToDouble.Name = "lblStrToDouble";
            this.lblStrToDouble.Size = new System.Drawing.Size(2, 14);
            this.lblStrToDouble.TabIndex = 8;
            // 
            // lblIntToDoublelmp
            // 
            this.lblIntToDoublelmp.AutoSize = true;
            this.lblIntToDoublelmp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIntToDoublelmp.Location = new System.Drawing.Point(186, 203);
            this.lblIntToDoublelmp.Name = "lblIntToDoublelmp";
            this.lblIntToDoublelmp.Size = new System.Drawing.Size(2, 14);
            this.lblIntToDoublelmp.TabIndex = 9;
            // 
            // lblIntToDoubleExp
            // 
            this.lblIntToDoubleExp.AutoSize = true;
            this.lblIntToDoubleExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblIntToDoubleExp.Location = new System.Drawing.Point(186, 238);
            this.lblIntToDoubleExp.Name = "lblIntToDoubleExp";
            this.lblIntToDoubleExp.Size = new System.Drawing.Size(2, 14);
            this.lblIntToDoubleExp.TabIndex = 10;
            // 
            // lblDoubleToIntExp
            // 
            this.lblDoubleToIntExp.AutoSize = true;
            this.lblDoubleToIntExp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDoubleToIntExp.Location = new System.Drawing.Point(186, 278);
            this.lblDoubleToIntExp.Name = "lblDoubleToIntExp";
            this.lblDoubleToIntExp.Size = new System.Drawing.Size(2, 14);
            this.lblDoubleToIntExp.TabIndex = 11;
            // 
            // txtInt
            // 
            this.txtInt.Location = new System.Drawing.Point(71, 29);
            this.txtInt.Name = "txtInt";
            this.txtInt.Size = new System.Drawing.Size(100, 21);
            this.txtInt.TabIndex = 12;
            // 
            // txtDouble
            // 
            this.txtDouble.Location = new System.Drawing.Point(241, 26);
            this.txtDouble.Name = "txtDouble";
            this.txtDouble.Size = new System.Drawing.Size(100, 21);
            this.txtDouble.TabIndex = 13;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(137, 73);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "변환하기";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // TypeConvForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtDouble);
            this.Controls.Add(this.txtInt);
            this.Controls.Add(this.lblDoubleToIntExp);
            this.Controls.Add(this.lblIntToDoubleExp);
            this.Controls.Add(this.lblIntToDoublelmp);
            this.Controls.Add(this.lblStrToDouble);
            this.Controls.Add(this.lblStrToInt);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TypeConvForm";
            this.Text = "형변환";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblStrToInt;
        private System.Windows.Forms.Label lblStrToDouble;
        private System.Windows.Forms.Label lblIntToDoublelmp;
        private System.Windows.Forms.Label lblIntToDoubleExp;
        private System.Windows.Forms.Label lblDoubleToIntExp;
        private System.Windows.Forms.TextBox txtInt;
        private System.Windows.Forms.TextBox txtDouble;
        private System.Windows.Forms.Button btnOk;
    }
}


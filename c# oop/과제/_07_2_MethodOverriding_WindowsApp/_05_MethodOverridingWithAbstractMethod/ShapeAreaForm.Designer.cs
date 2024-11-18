namespace _05_MethodOverridingWithAbstractMethod
{
    partial class ShapeAreaForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblOutputNum2 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblOutputNum1 = new System.Windows.Forms.Label();
            this.lblOutputLbl2 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.lblOutputLbl1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.lblInputNum2 = new System.Windows.Forms.Label();
            this.lblInputNum1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblOutputNum2);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblResult);
            this.groupBox2.Controls.Add(this.lblOutputNum1);
            this.groupBox2.Controls.Add(this.lblOutputLbl2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.lblOutputLbl1);
            this.groupBox2.Location = new System.Drawing.Point(12, 175);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(320, 152);
            this.groupBox2.TabIndex = 19;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "면적 출력";
            // 
            // lblOutputNum2
            // 
            this.lblOutputNum2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputNum2.Location = new System.Drawing.Point(211, 64);
            this.lblOutputNum2.Name = "lblOutputNum2";
            this.lblOutputNum2.Size = new System.Drawing.Size(76, 25);
            this.lblOutputNum2.TabIndex = 25;
            this.lblOutputNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Location = new System.Drawing.Point(61, 19);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(121, 25);
            this.lblType.TabIndex = 24;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblResult
            // 
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(61, 109);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(121, 25);
            this.lblResult.TabIndex = 23;
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputNum1
            // 
            this.lblOutputNum1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOutputNum1.Location = new System.Drawing.Point(61, 64);
            this.lblOutputNum1.Name = "lblOutputNum1";
            this.lblOutputNum1.Size = new System.Drawing.Size(72, 25);
            this.lblOutputNum1.TabIndex = 21;
            this.lblOutputNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblOutputLbl2
            // 
            this.lblOutputLbl2.AutoSize = true;
            this.lblOutputLbl2.Location = new System.Drawing.Point(158, 71);
            this.lblOutputLbl2.Name = "lblOutputLbl2";
            this.lblOutputLbl2.Size = new System.Drawing.Size(37, 12);
            this.lblOutputLbl2.TabIndex = 20;
            this.lblOutputLbl2.Text = "세로 :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 26);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 12);
            this.label17.TabIndex = 17;
            this.label17.Text = "종류 :";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(18, 115);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 12);
            this.label18.TabIndex = 16;
            this.label18.Text = "면적 :";
            // 
            // lblOutputLbl1
            // 
            this.lblOutputLbl1.AutoSize = true;
            this.lblOutputLbl1.Location = new System.Drawing.Point(18, 71);
            this.lblOutputLbl1.Name = "lblOutputLbl1";
            this.lblOutputLbl1.Size = new System.Drawing.Size(37, 12);
            this.lblOutputLbl1.TabIndex = 14;
            this.lblOutputLbl1.Text = "가로 :";
            this.lblOutputLbl1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCalculate);
            this.groupBox1.Controls.Add(this.txtNum2);
            this.groupBox1.Controls.Add(this.txtNum1);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.lblInputNum2);
            this.groupBox1.Controls.Add(this.lblInputNum1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 142);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "정보 입력";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(101, 100);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(104, 23);
            this.btnCalculate.TabIndex = 15;
            this.btnCalculate.Text = "면적 계산";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click_1);
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(211, 54);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(76, 21);
            this.txtNum2.TabIndex = 12;
            this.txtNum2.Text = "0";
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum1
            // 
            this.txtNum1.ImeMode = System.Windows.Forms.ImeMode.Hangul;
            this.txtNum1.Location = new System.Drawing.Point(61, 54);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(72, 21);
            this.txtNum1.TabIndex = 9;
            this.txtNum1.Text = "0";
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "사각형",
            "삼각형",
            "원"});
            this.cbType.Location = new System.Drawing.Point(61, 25);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(152, 20);
            this.cbType.TabIndex = 7;
            this.cbType.Text = "도형을 선택하세요.";
            this.cbType.SelectedIndexChanged += new System.EventHandler(this.cbType_SelectedIndexChanged_1);
            // 
            // lblInputNum2
            // 
            this.lblInputNum2.AutoSize = true;
            this.lblInputNum2.Location = new System.Drawing.Point(158, 57);
            this.lblInputNum2.Name = "lblInputNum2";
            this.lblInputNum2.Size = new System.Drawing.Size(37, 12);
            this.lblInputNum2.TabIndex = 5;
            this.lblInputNum2.Text = "세로 :";
            // 
            // lblInputNum1
            // 
            this.lblInputNum1.AutoSize = true;
            this.lblInputNum1.Location = new System.Drawing.Point(18, 57);
            this.lblInputNum1.Name = "lblInputNum1";
            this.lblInputNum1.Size = new System.Drawing.Size(37, 12);
            this.lblInputNum1.TabIndex = 1;
            this.lblInputNum1.Text = "가로 :";
            this.lblInputNum1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "종류 :";
            // 
            // ShapeAreaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 340);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShapeAreaForm";
            this.Text = "추상메서드 이용 예제";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblOutputNum2;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblOutputNum1;
        private System.Windows.Forms.Label lblOutputLbl2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label lblOutputLbl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label lblInputNum2;
        private System.Windows.Forms.Label lblInputNum1;
        private System.Windows.Forms.Label label1;
    }
}


namespace _04_Constructor
{
    partial class ConstructorForm
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
            this.lblCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateWithArgs = new System.Windows.Forms.Button();
            this.btnCreateNoArg = new System.Windows.Forms.Button();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblCount);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.lblSpeed);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 129);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(260, 110);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "객체결과";
            // 
            // lblCount
            // 
            this.lblCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblCount.Location = new System.Drawing.Point(116, 17);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(100, 20);
            this.lblCount.TabIndex = 9;
            this.lblCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "객체번호 :";
            // 
            // lblSpeed
            // 
            this.lblSpeed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSpeed.Location = new System.Drawing.Point(116, 80);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(100, 20);
            this.lblSpeed.TabIndex = 7;
            this.lblSpeed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Location = new System.Drawing.Point(116, 48);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(100, 20);
            this.lblType.TabIndex = 6;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "현재속도:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "차종 :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateWithArgs);
            this.groupBox1.Controls.Add(this.btnCreateNoArg);
            this.groupBox1.Controls.Add(this.txtSpeed);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 100);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력정보";
            // 
            // btnCreateWithArgs
            // 
            this.btnCreateWithArgs.Location = new System.Drawing.Point(107, 71);
            this.btnCreateWithArgs.Name = "btnCreateWithArgs";
            this.btnCreateWithArgs.Size = new System.Drawing.Size(95, 23);
            this.btnCreateWithArgs.TabIndex = 5;
            this.btnCreateWithArgs.Text = "인수전달 생성";
            this.btnCreateWithArgs.UseVisualStyleBackColor = true;
            this.btnCreateWithArgs.Click += new System.EventHandler(this.btnCreateWithArgs_Click);
            // 
            // btnCreateNoArg
            // 
            this.btnCreateNoArg.Location = new System.Drawing.Point(6, 71);
            this.btnCreateNoArg.Name = "btnCreateNoArg";
            this.btnCreateNoArg.Size = new System.Drawing.Size(95, 23);
            this.btnCreateNoArg.TabIndex = 4;
            this.btnCreateNoArg.Text = "인수없이 생성";
            this.btnCreateNoArg.UseVisualStyleBackColor = true;
            this.btnCreateNoArg.Click += new System.EventHandler(this.btnCreateNoArg_Click);
            // 
            // txtSpeed
            // 
            this.txtSpeed.Location = new System.Drawing.Point(189, 26);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(53, 21);
            this.txtSpeed.TabIndex = 3;
            this.txtSpeed.Text = "0";
            this.txtSpeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "승용차",
            "버스",
            "트럭"});
            this.cbType.Location = new System.Drawing.Point(50, 26);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(83, 20);
            this.cbType.TabIndex = 2;
            this.cbType.Text = "승용차";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(150, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "속도:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "차종:";
            // 
            // ConstructorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 255);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConstructorForm";
            this.Text = "생성자";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateWithArgs;
        private System.Windows.Forms.Button btnCreateNoArg;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}


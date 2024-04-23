namespace _05_LogicalOperators
{
    partial class LogicalOpForm
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
            this.txtA = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblAnb = new System.Windows.Forms.Label();
            this.lblAnnB = new System.Windows.Forms.Label();
            this.lblAoB = new System.Windows.Forms.Label();
            this.lblAooB = new System.Windows.Forms.Label();
            this.lblAxorB = new System.Windows.Forms.Label();
            this.lblNotA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 191);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "a&&b;";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(219, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "2게의 논리값(true/false)을 입력하시오.";
            // 
            // txtA
            // 
            this.txtA.Location = new System.Drawing.Point(49, 69);
            this.txtA.Name = "txtA";
            this.txtA.Size = new System.Drawing.Size(100, 21);
            this.txtA.TabIndex = 2;
            this.txtA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtB
            // 
            this.txtB.Location = new System.Drawing.Point(175, 69);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(100, 21);
            this.txtB.TabIndex = 3;
            this.txtB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(86, 113);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(156, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "논리연산자  결과 확인";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "a&b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "a|b :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(69, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 7;
            this.label5.Text = "a||b:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(69, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "a^b;";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 12);
            this.label7.TabIndex = 9;
            this.label7.Text = "!a:";
            // 
            // lblAnb
            // 
            this.lblAnb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnb.Location = new System.Drawing.Point(190, 155);
            this.lblAnb.Name = "lblAnb";
            this.lblAnb.Size = new System.Drawing.Size(100, 23);
            this.lblAnb.TabIndex = 11;
            // 
            // lblAnnB
            // 
            this.lblAnnB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAnnB.Location = new System.Drawing.Point(190, 182);
            this.lblAnnB.Name = "lblAnnB";
            this.lblAnnB.Size = new System.Drawing.Size(100, 23);
            this.lblAnnB.TabIndex = 12;
            // 
            // lblAoB
            // 
            this.lblAoB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAoB.Location = new System.Drawing.Point(190, 207);
            this.lblAoB.Name = "lblAoB";
            this.lblAoB.Size = new System.Drawing.Size(100, 23);
            this.lblAoB.TabIndex = 13;
            // 
            // lblAooB
            // 
            this.lblAooB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAooB.Location = new System.Drawing.Point(190, 244);
            this.lblAooB.Name = "lblAooB";
            this.lblAooB.Size = new System.Drawing.Size(100, 23);
            this.lblAooB.TabIndex = 14;
            // 
            // lblAxorB
            // 
            this.lblAxorB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAxorB.Location = new System.Drawing.Point(190, 283);
            this.lblAxorB.Name = "lblAxorB";
            this.lblAxorB.Size = new System.Drawing.Size(100, 23);
            this.lblAxorB.TabIndex = 15;
            // 
            // lblNotA
            // 
            this.lblNotA.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblNotA.Location = new System.Drawing.Point(190, 316);
            this.lblNotA.Name = "lblNotA";
            this.lblNotA.Size = new System.Drawing.Size(100, 23);
            this.lblNotA.TabIndex = 16;
            // 
            // LogicalOpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblNotA);
            this.Controls.Add(this.lblAxorB);
            this.Controls.Add(this.lblAooB);
            this.Controls.Add(this.lblAoB);
            this.Controls.Add(this.lblAnnB);
            this.Controls.Add(this.lblAnb);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "LogicalOpForm";
            this.Text = "논리연산자의 활용";
            this.Load += new System.EventHandler(this.LogicalOpForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtA;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblAnb;
        private System.Windows.Forms.Label lblAnnB;
        private System.Windows.Forms.Label lblAoB;
        private System.Windows.Forms.Label lblAooB;
        private System.Windows.Forms.Label lblAxorB;
        private System.Windows.Forms.Label lblNotA;
    }
}


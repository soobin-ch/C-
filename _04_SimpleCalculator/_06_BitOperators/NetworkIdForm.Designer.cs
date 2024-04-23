namespace _06_BitOperators
{
    partial class NetworkIdForm
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
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMask1 = new System.Windows.Forms.TextBox();
            this.txtMask2 = new System.Windows.Forms.TextBox();
            this.txtMask3 = new System.Windows.Forms.TextBox();
            this.txtMask4 = new System.Windows.Forms.TextBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNet1 = new System.Windows.Forms.TextBox();
            this.lblNet2 = new System.Windows.Forms.TextBox();
            this.lblNet3 = new System.Windows.Forms.TextBox();
            this.lblNet4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblBC1 = new System.Windows.Forms.TextBox();
            this.lblBC2 = new System.Windows.Forms.TextBox();
            this.lblBC3 = new System.Windows.Forms.TextBox();
            this.lblBC4 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(116, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "IP주소와 서브넷 마스크로 네트워크 정보 구하기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "IP주소:";
            // 
            // txtIp1
            // 
            this.txtIp1.Location = new System.Drawing.Point(139, 83);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(48, 21);
            this.txtIp1.TabIndex = 2;
            // 
            // txtIp2
            // 
            this.txtIp2.Location = new System.Drawing.Point(212, 83);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(43, 21);
            this.txtIp2.TabIndex = 3;
            // 
            // txtIp3
            // 
            this.txtIp3.Location = new System.Drawing.Point(271, 83);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(56, 21);
            this.txtIp3.TabIndex = 4;
            // 
            // txtIp4
            // 
            this.txtIp4.Location = new System.Drawing.Point(342, 83);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(54, 21);
            this.txtIp4.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "서브넷마스크:";
            // 
            // txtMask1
            // 
            this.txtMask1.Location = new System.Drawing.Point(179, 131);
            this.txtMask1.Name = "txtMask1";
            this.txtMask1.Size = new System.Drawing.Size(44, 21);
            this.txtMask1.TabIndex = 7;
            // 
            // txtMask2
            // 
            this.txtMask2.Location = new System.Drawing.Point(242, 131);
            this.txtMask2.Name = "txtMask2";
            this.txtMask2.Size = new System.Drawing.Size(48, 21);
            this.txtMask2.TabIndex = 8;
            // 
            // txtMask3
            // 
            this.txtMask3.Location = new System.Drawing.Point(306, 131);
            this.txtMask3.Name = "txtMask3";
            this.txtMask3.Size = new System.Drawing.Size(58, 21);
            this.txtMask3.TabIndex = 9;
            // 
            // txtMask4
            // 
            this.txtMask4.Location = new System.Drawing.Point(375, 131);
            this.txtMask4.Name = "txtMask4";
            this.txtMask4.Size = new System.Drawing.Size(58, 21);
            this.txtMask4.TabIndex = 10;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(242, 187);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 11;
            this.btnOk.Text = "확인";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 234);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "네트워크 아이디:";
            // 
            // lblNet1
            // 
            this.lblNet1.Location = new System.Drawing.Point(184, 231);
            this.lblNet1.Name = "lblNet1";
            this.lblNet1.Size = new System.Drawing.Size(58, 21);
            this.lblNet1.TabIndex = 13;
            // 
            // lblNet2
            // 
            this.lblNet2.Location = new System.Drawing.Point(254, 231);
            this.lblNet2.Name = "lblNet2";
            this.lblNet2.Size = new System.Drawing.Size(63, 21);
            this.lblNet2.TabIndex = 14;
            // 
            // lblNet3
            // 
            this.lblNet3.Location = new System.Drawing.Point(331, 231);
            this.lblNet3.Name = "lblNet3";
            this.lblNet3.Size = new System.Drawing.Size(65, 21);
            this.lblNet3.TabIndex = 15;
            // 
            // lblNet4
            // 
            this.lblNet4.Location = new System.Drawing.Point(411, 231);
            this.lblNet4.Name = "lblNet4";
            this.lblNet4.Size = new System.Drawing.Size(57, 21);
            this.lblNet4.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 270);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "방송주소:";
            // 
            // lblBC1
            // 
            this.lblBC1.Location = new System.Drawing.Point(179, 270);
            this.lblBC1.Name = "lblBC1";
            this.lblBC1.Size = new System.Drawing.Size(44, 21);
            this.lblBC1.TabIndex = 18;
            // 
            // lblBC2
            // 
            this.lblBC2.Location = new System.Drawing.Point(235, 270);
            this.lblBC2.Name = "lblBC2";
            this.lblBC2.Size = new System.Drawing.Size(55, 21);
            this.lblBC2.TabIndex = 19;
            // 
            // lblBC3
            // 
            this.lblBC3.Location = new System.Drawing.Point(296, 270);
            this.lblBC3.Name = "lblBC3";
            this.lblBC3.Size = new System.Drawing.Size(50, 21);
            this.lblBC3.TabIndex = 20;
            // 
            // lblBC4
            // 
            this.lblBC4.Location = new System.Drawing.Point(354, 270);
            this.lblBC4.Name = "lblBC4";
            this.lblBC4.Size = new System.Drawing.Size(47, 21);
            this.lblBC4.TabIndex = 21;
            // 
            // NetworkIdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblBC4);
            this.Controls.Add(this.lblBC3);
            this.Controls.Add(this.lblBC2);
            this.Controls.Add(this.lblBC1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblNet4);
            this.Controls.Add(this.lblNet3);
            this.Controls.Add(this.lblNet2);
            this.Controls.Add(this.lblNet1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.txtMask4);
            this.Controls.Add(this.txtMask3);
            this.Controls.Add(this.txtMask2);
            this.Controls.Add(this.txtMask1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIp4);
            this.Controls.Add(this.txtIp3);
            this.Controls.Add(this.txtIp2);
            this.Controls.Add(this.txtIp1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NetworkIdForm";
            this.Text = "비트 단위 연산자 활용";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMask1;
        private System.Windows.Forms.TextBox txtMask2;
        private System.Windows.Forms.TextBox txtMask3;
        private System.Windows.Forms.TextBox txtMask4;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox lblNet1;
        private System.Windows.Forms.TextBox lblNet2;
        private System.Windows.Forms.TextBox lblNet3;
        private System.Windows.Forms.TextBox lblNet4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblBC1;
        private System.Windows.Forms.TextBox lblBC2;
        private System.Windows.Forms.TextBox lblBC3;
        private System.Windows.Forms.TextBox lblBC4;
    }
}


namespace _02_SplitOfString
{
    partial class AddressForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.lsbAddresses = new System.Windows.Forms.ListBox();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblBuilding = new System.Windows.Forms.Label();
            this.lblRoad = new System.Windows.Forms.Label();
            this.lblElementary = new System.Windows.Forms.Label();
            this.lblProvince = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSplit = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(73, 51);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(271, 12);
            this.label7.TabIndex = 44;
            this.label7.Text = "(주소 입력시 각 영역은 빈칸으로 구분해 주세요.)";
            // 
            // lsbAddresses
            // 
            this.lsbAddresses.FormattingEnabled = true;
            this.lsbAddresses.ItemHeight = 12;
            this.lsbAddresses.Location = new System.Drawing.Point(26, 140);
            this.lsbAddresses.Name = "lsbAddresses";
            this.lsbAddresses.Size = new System.Drawing.Size(139, 124);
            this.lsbAddresses.TabIndex = 43;
            // 
            // lblDetails
            // 
            this.lblDetails.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDetails.Location = new System.Drawing.Point(273, 240);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(83, 20);
            this.lblDetails.TabIndex = 42;
            // 
            // lblBuilding
            // 
            this.lblBuilding.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblBuilding.Location = new System.Drawing.Point(273, 215);
            this.lblBuilding.Name = "lblBuilding";
            this.lblBuilding.Size = new System.Drawing.Size(83, 20);
            this.lblBuilding.TabIndex = 41;
            // 
            // lblRoad
            // 
            this.lblRoad.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblRoad.Location = new System.Drawing.Point(273, 190);
            this.lblRoad.Name = "lblRoad";
            this.lblRoad.Size = new System.Drawing.Size(83, 20);
            this.lblRoad.TabIndex = 40;
            // 
            // lblElementary
            // 
            this.lblElementary.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblElementary.Location = new System.Drawing.Point(273, 165);
            this.lblElementary.Name = "lblElementary";
            this.lblElementary.Size = new System.Drawing.Size(83, 20);
            this.lblElementary.TabIndex = 39;
            // 
            // lblProvince
            // 
            this.lblProvince.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblProvince.Location = new System.Drawing.Point(273, 140);
            this.lblProvince.Name = "lblProvince";
            this.lblProvince.Size = new System.Drawing.Size(83, 20);
            this.lblProvince.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(210, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 12);
            this.label6.TabIndex = 37;
            this.label6.Text = "상세주소 :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(206, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 36;
            this.label5.Text = "건물번호 : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(222, 191);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 12);
            this.label4.TabIndex = 35;
            this.label4.Text = "도로명 :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(186, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 12);
            this.label3.TabIndex = 34;
            this.label3.Text = "기초자치단체 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(186, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 12);
            this.label2.TabIndex = 33;
            this.label2.Text = "광역자치단체 :";
            // 
            // btnSplit
            // 
            this.btnSplit.Location = new System.Drawing.Point(165, 90);
            this.btnSplit.Name = "btnSplit";
            this.btnSplit.Size = new System.Drawing.Size(75, 23);
            this.btnSplit.TabIndex = 32;
            this.btnSplit.Text = "주소분리";
            this.btnSplit.UseVisualStyleBackColor = true;
            this.btnSplit.Click += new System.EventHandler(this.btnSplit_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(75, 17);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(303, 21);
            this.txtAddress.TabIndex = 31;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 30;
            this.label1.Text = "주소입력:";
            // 
            // AddressForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 291);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lsbAddresses);
            this.Controls.Add(this.lblDetails);
            this.Controls.Add(this.lblBuilding);
            this.Controls.Add(this.lblRoad);
            this.Controls.Add(this.lblElementary);
            this.Controls.Add(this.lblProvince);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSplit);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label1);
            this.Name = "AddressForm";
            this.Text = "s";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lsbAddresses;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblBuilding;
        private System.Windows.Forms.Label lblRoad;
        private System.Windows.Forms.Label lblElementary;
        private System.Windows.Forms.Label lblProvince;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSplit;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label label1;
    }
}


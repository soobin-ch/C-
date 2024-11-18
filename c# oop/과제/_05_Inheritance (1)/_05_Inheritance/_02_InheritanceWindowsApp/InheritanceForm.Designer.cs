namespace _02_InheritanceWindowsApp
{
    partial class InheritanceForm
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
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblAux = new System.Windows.Forms.Label();
            this.lblMaker = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.lblAuxInfo = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pcMain = new System.Windows.Forms.PictureBox();
            this.cbSelectObject = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCreateObject = new System.Windows.Forms.Button();
            this.btnInputFig = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtAux = new System.Windows.Forms.TextBox();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.cbMaker = new System.Windows.Forms.ComboBox();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.lblAuxName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPrice);
            this.groupBox2.Controls.Add(this.lblAux);
            this.groupBox2.Controls.Add(this.lblMaker);
            this.groupBox2.Controls.Add(this.lblType);
            this.groupBox2.Controls.Add(this.lblAuxInfo);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.pcMain);
            this.groupBox2.Controls.Add(this.cbSelectObject);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(15, 171);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(392, 233);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "객체 결과 보기";
            // 
            // lblPrice
            // 
            this.lblPrice.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblPrice.Location = new System.Drawing.Point(314, 191);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(60, 20);
            this.lblPrice.TabIndex = 18;
            this.lblPrice.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAux
            // 
            this.lblAux.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAux.Location = new System.Drawing.Point(314, 150);
            this.lblAux.Name = "lblAux";
            this.lblAux.Size = new System.Drawing.Size(60, 20);
            this.lblAux.TabIndex = 17;
            this.lblAux.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaker
            // 
            this.lblMaker.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblMaker.Location = new System.Drawing.Point(314, 105);
            this.lblMaker.Name = "lblMaker";
            this.lblMaker.Size = new System.Drawing.Size(60, 20);
            this.lblMaker.TabIndex = 16;
            this.lblMaker.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblType
            // 
            this.lblType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblType.Location = new System.Drawing.Point(314, 60);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(60, 20);
            this.lblType.TabIndex = 15;
            this.lblType.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblAuxInfo
            // 
            this.lblAuxInfo.AutoSize = true;
            this.lblAuxInfo.Location = new System.Drawing.Point(251, 154);
            this.lblAuxInfo.Name = "lblAuxInfo";
            this.lblAuxInfo.Size = new System.Drawing.Size(57, 12);
            this.lblAuxInfo.TabIndex = 14;
            this.lblAuxInfo.Text = "기타정보:";
            this.lblAuxInfo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(275, 199);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 12);
            this.label8.TabIndex = 13;
            this.label8.Text = "가격:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(263, 109);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 12);
            this.label9.TabIndex = 12;
            this.label9.Text = "제조사:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(251, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 12);
            this.label10.TabIndex = 11;
            this.label10.Text = "차량종류:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pcMain
            // 
            this.pcMain.Location = new System.Drawing.Point(8, 64);
            this.pcMain.Name = "pcMain";
            this.pcMain.Size = new System.Drawing.Size(226, 147);
            this.pcMain.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcMain.TabIndex = 10;
            this.pcMain.TabStop = false;
            // 
            // cbSelectObject
            // 
            this.cbSelectObject.FormattingEnabled = true;
            this.cbSelectObject.Location = new System.Drawing.Point(173, 30);
            this.cbSelectObject.Name = "cbSelectObject";
            this.cbSelectObject.Size = new System.Drawing.Size(121, 20);
            this.cbSelectObject.TabIndex = 9;
            this.cbSelectObject.SelectedIndexChanged += new System.EventHandler(this.cbSelectObject_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(161, 12);
            this.label6.TabIndex = 8;
            this.label6.Text = "생성된 차량 객체 번호 선택 :";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreateObject);
            this.groupBox1.Controls.Add(this.btnInputFig);
            this.groupBox1.Controls.Add(this.txtPrice);
            this.groupBox1.Controls.Add(this.txtAux);
            this.groupBox1.Controls.Add(this.cbType);
            this.groupBox1.Controls.Add(this.cbMaker);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.Controls.Add(this.lblAuxName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(395, 144);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "입력 정보";
            // 
            // btnCreateObject
            // 
            this.btnCreateObject.Location = new System.Drawing.Point(162, 114);
            this.btnCreateObject.Name = "btnCreateObject";
            this.btnCreateObject.Size = new System.Drawing.Size(75, 23);
            this.btnCreateObject.TabIndex = 11;
            this.btnCreateObject.Text = "객체 생성";
            this.btnCreateObject.UseVisualStyleBackColor = true;
            this.btnCreateObject.Click += new System.EventHandler(this.btnCreateObject_Click);
            // 
            // btnInputFig
            // 
            this.btnInputFig.Location = new System.Drawing.Point(211, 80);
            this.btnInputFig.Name = "btnInputFig";
            this.btnInputFig.Size = new System.Drawing.Size(166, 23);
            this.btnInputFig.TabIndex = 10;
            this.btnInputFig.Text = "그림파일 불러오기";
            this.btnInputFig.UseVisualStyleBackColor = true;
            this.btnInputFig.Click += new System.EventHandler(this.btnInputFig_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(256, 52);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(121, 21);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.Text = "0";
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAux
            // 
            this.txtAux.Location = new System.Drawing.Point(65, 82);
            this.txtAux.Name = "txtAux";
            this.txtAux.Size = new System.Drawing.Size(121, 21);
            this.txtAux.TabIndex = 8;
            this.txtAux.Text = "0";
            this.txtAux.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cbType
            // 
            this.cbType.FormattingEnabled = true;
            this.cbType.Items.AddRange(new object[] {
            "승용차",
            "버스",
            "트럭"});
            this.cbType.Location = new System.Drawing.Point(65, 22);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(121, 20);
            this.cbType.TabIndex = 7;
            this.cbType.Text = "승용차";
            // 
            // cbMaker
            // 
            this.cbMaker.FormattingEnabled = true;
            this.cbMaker.Items.AddRange(new object[] {
            "현대",
            "기아",
            "쌍용",
            "GM"});
            this.cbMaker.Location = new System.Drawing.Point(256, 22);
            this.cbMaker.Name = "cbMaker";
            this.cbMaker.Size = new System.Drawing.Size(121, 20);
            this.cbMaker.TabIndex = 6;
            this.cbMaker.Text = "현대";
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Items.AddRange(new object[] {
            "빨강",
            "노랑",
            "녹색",
            "파랑"});
            this.cbColor.Location = new System.Drawing.Point(65, 52);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(121, 20);
            this.cbColor.TabIndex = 5;
            this.cbColor.Text = "빨강";
            // 
            // lblAuxName
            // 
            this.lblAuxName.AutoSize = true;
            this.lblAuxName.Location = new System.Drawing.Point(6, 85);
            this.lblAuxName.Name = "lblAuxName";
            this.lblAuxName.Size = new System.Drawing.Size(57, 12);
            this.lblAuxName.TabIndex = 4;
            this.lblAuxName.Text = "기타정보:";
            this.lblAuxName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "가격:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "색깔:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(209, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "제조사:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "차량종류:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // InheritanceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "InheritanceForm";
            this.Text = "상속 실습 폼";
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcMain)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblAux;
        private System.Windows.Forms.Label lblMaker;
        private System.Windows.Forms.Label lblType;
        private System.Windows.Forms.Label lblAuxInfo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox pcMain;
        private System.Windows.Forms.ComboBox cbSelectObject;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Button btnInputFig;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtAux;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.ComboBox cbMaker;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblAuxName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}


namespace _05_EncapsulationWindowsApp
{
    partial class StudentInfoForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>


        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label11 = new Label();
            label12 = new Label();
            btnAddAge = new Button();
            btnModifyPic = new Button();
            btnAddCredits = new Button();
            btnModifyAddress = new Button();
            txtAddCredits = new TextBox();
            txtModAddress = new TextBox();
            cbSelectStudent1 = new ComboBox();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            groupBox3 = new GroupBox();
            lblAge = new Label();
            lblCredits = new Label();
            lblStdId = new Label();
            lblAddress = new Label();
            lblGender = new Label();
            lblName = new Label();
            lblDept = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            pcMain = new PictureBox();
            cbSelectStudent2 = new ComboBox();
            label13 = new Label();
            groupBox1 = new GroupBox();
            btnCreateObject = new Button();
            btnGetPic = new Button();
            txtId = new TextBox();
            txtCredits = new TextBox();
            txtAge = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            cbGender = new ComboBox();
            cbDept = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            openFileDialog1 = new OpenFileDialog();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pcMain).BeginInit();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label11);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(btnAddAge);
            groupBox2.Controls.Add(btnModifyPic);
            groupBox2.Controls.Add(btnAddCredits);
            groupBox2.Controls.Add(btnModifyAddress);
            groupBox2.Controls.Add(txtAddCredits);
            groupBox2.Controls.Add(txtModAddress);
            groupBox2.Controls.Add(cbSelectStudent1);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Location = new Point(12, 238);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(461, 160);
            groupBox2.TabIndex = 7;
            groupBox2.TabStop = false;
            groupBox2.Text = "정보 수정";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(327, 110);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 21;
            label11.Text = " :";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(327, 71);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 20;
            label12.Text = " :";
            // 
            // btnAddAge
            // 
            btnAddAge.Location = new Point(358, 65);
            btnAddAge.Margin = new Padding(3, 4, 3, 4);
            btnAddAge.Name = "btnAddAge";
            btnAddAge.Size = new Size(75, 29);
            btnAddAge.TabIndex = 19;
            btnAddAge.Text = "나이 추가";
            btnAddAge.UseVisualStyleBackColor = true;
            btnAddAge.Click += btnAddAge_Click;
            // 
            // btnModifyPic
            // 
            btnModifyPic.Location = new Point(358, 104);
            btnModifyPic.Margin = new Padding(3, 4, 3, 4);
            btnModifyPic.Name = "btnModifyPic";
            btnModifyPic.Size = new Size(75, 29);
            btnModifyPic.TabIndex = 18;
            btnModifyPic.Text = "사진 변경";
            btnModifyPic.UseVisualStyleBackColor = true;
            btnModifyPic.Click += btnModifyPic_Click;
            // 
            // btnAddCredits
            // 
            btnAddCredits.Location = new Point(237, 104);
            btnAddCredits.Margin = new Padding(3, 4, 3, 4);
            btnAddCredits.Name = "btnAddCredits";
            btnAddCredits.Size = new Size(75, 29);
            btnAddCredits.TabIndex = 17;
            btnAddCredits.Text = "학점 추가";
            btnAddCredits.UseVisualStyleBackColor = true;
            btnAddCredits.Click += btnAddCredits_Click;
            // 
            // btnModifyAddress
            // 
            btnModifyAddress.Location = new Point(237, 65);
            btnModifyAddress.Margin = new Padding(3, 4, 3, 4);
            btnModifyAddress.Name = "btnModifyAddress";
            btnModifyAddress.Size = new Size(75, 29);
            btnModifyAddress.TabIndex = 16;
            btnModifyAddress.Text = "주소 변경";
            btnModifyAddress.UseVisualStyleBackColor = true;
            btnModifyAddress.Click += btnModifyAddress_Click;
            // 
            // txtAddCredits
            // 
            txtAddCredits.Location = new Point(98, 106);
            txtAddCredits.Margin = new Padding(3, 4, 3, 4);
            txtAddCredits.Name = "txtAddCredits";
            txtAddCredits.Size = new Size(121, 23);
            txtAddCredits.TabIndex = 14;
            txtAddCredits.Text = "0";
            txtAddCredits.TextAlign = HorizontalAlignment.Center;
            // 
            // txtModAddress
            // 
            txtModAddress.ImeMode = ImeMode.Hangul;
            txtModAddress.Location = new Point(98, 68);
            txtModAddress.Margin = new Padding(3, 4, 3, 4);
            txtModAddress.Name = "txtModAddress";
            txtModAddress.Size = new Size(121, 23);
            txtModAddress.TabIndex = 13;
            txtModAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // cbSelectStudent1
            // 
            cbSelectStudent1.FormattingEnabled = true;
            cbSelectStudent1.Location = new Point(219, 18);
            cbSelectStudent1.Margin = new Padding(3, 4, 3, 4);
            cbSelectStudent1.Name = "cbSelectStudent1";
            cbSelectStudent1.Size = new Size(121, 23);
            cbSelectStudent1.TabIndex = 8;
            cbSelectStudent1.Text = "학생를 선택하세요.";
            cbSelectStudent1.SelectedIndexChanged += cbSelectStudent1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(15, 110);
            label10.Name = "label10";
            label10.Size = new Size(78, 15);
            label10.TabIndex = 2;
            label10.Text = "변경할 학점 :";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(15, 71);
            label9.Name = "label9";
            label9.Size = new Size(78, 15);
            label9.TabIndex = 1;
            label9.Text = "변경할 주소 :";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(92, 21);
            label8.Name = "label8";
            label8.Size = new Size(122, 15);
            label8.TabIndex = 0;
            label8.Text = "정보 수정 학생 선택 :";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(lblAge);
            groupBox3.Controls.Add(lblCredits);
            groupBox3.Controls.Add(lblStdId);
            groupBox3.Controls.Add(lblAddress);
            groupBox3.Controls.Add(lblGender);
            groupBox3.Controls.Add(lblName);
            groupBox3.Controls.Add(lblDept);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label15);
            groupBox3.Controls.Add(label16);
            groupBox3.Controls.Add(label17);
            groupBox3.Controls.Add(label18);
            groupBox3.Controls.Add(label19);
            groupBox3.Controls.Add(label20);
            groupBox3.Controls.Add(pcMain);
            groupBox3.Controls.Add(cbSelectStudent2);
            groupBox3.Controls.Add(label13);
            groupBox3.Location = new Point(12, 405);
            groupBox3.Margin = new Padding(3, 4, 3, 4);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(3, 4, 3, 4);
            groupBox3.Size = new Size(461, 211);
            groupBox3.TabIndex = 8;
            groupBox3.TabStop = false;
            groupBox3.Text = "정보 출력";
            // 
            // lblAge
            // 
            lblAge.BorderStyle = BorderStyle.FixedSingle;
            lblAge.Location = new Point(362, 128);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(74, 33);
            lblAge.TabIndex = 27;
            lblAge.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblCredits
            // 
            lblCredits.BorderStyle = BorderStyle.FixedSingle;
            lblCredits.Location = new Point(362, 91);
            lblCredits.Name = "lblCredits";
            lblCredits.Size = new Size(74, 33);
            lblCredits.TabIndex = 26;
            lblCredits.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblStdId
            // 
            lblStdId.BorderStyle = BorderStyle.FixedSingle;
            lblStdId.Location = new Point(362, 55);
            lblStdId.Name = "lblStdId";
            lblStdId.Size = new Size(74, 33);
            lblStdId.TabIndex = 25;
            lblStdId.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblAddress
            // 
            lblAddress.BorderStyle = BorderStyle.FixedSingle;
            lblAddress.Location = new Point(228, 164);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(208, 33);
            lblAddress.TabIndex = 24;
            lblAddress.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblGender
            // 
            lblGender.BorderStyle = BorderStyle.FixedSingle;
            lblGender.Location = new Point(228, 128);
            lblGender.Name = "lblGender";
            lblGender.Size = new Size(74, 33);
            lblGender.TabIndex = 23;
            lblGender.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblName
            // 
            lblName.BorderStyle = BorderStyle.FixedSingle;
            lblName.Location = new Point(228, 91);
            lblName.Name = "lblName";
            lblName.Size = new Size(74, 33);
            lblName.TabIndex = 22;
            lblName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDept
            // 
            lblDept.BorderStyle = BorderStyle.FixedSingle;
            lblDept.Location = new Point(228, 55);
            lblDept.Name = "lblDept";
            lblDept.Size = new Size(74, 33);
            lblDept.TabIndex = 21;
            lblDept.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(318, 64);
            label14.Name = "label14";
            label14.Size = new Size(38, 15);
            label14.TabIndex = 20;
            label14.Text = "학번 :";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(318, 100);
            label15.Name = "label15";
            label15.Size = new Size(38, 15);
            label15.TabIndex = 19;
            label15.Text = "학점 :";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(318, 136);
            label16.Name = "label16";
            label16.Size = new Size(38, 15);
            label16.TabIndex = 18;
            label16.Text = "나이 :";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(185, 172);
            label17.Name = "label17";
            label17.Size = new Size(38, 15);
            label17.TabIndex = 17;
            label17.Text = "주소 :";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(185, 136);
            label18.Name = "label18";
            label18.Size = new Size(38, 15);
            label18.TabIndex = 16;
            label18.Text = "성별 :";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(185, 100);
            label19.Name = "label19";
            label19.Size = new Size(38, 15);
            label19.TabIndex = 15;
            label19.Text = "성명 :";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(185, 64);
            label20.Name = "label20";
            label20.Size = new Size(38, 15);
            label20.TabIndex = 14;
            label20.Text = "학과 :";
            // 
            // pcMain
            // 
            pcMain.Location = new Point(50, 55);
            pcMain.Margin = new Padding(3, 4, 3, 4);
            pcMain.Name = "pcMain";
            pcMain.Size = new Size(95, 148);
            pcMain.SizeMode = PictureBoxSizeMode.StretchImage;
            pcMain.TabIndex = 11;
            pcMain.TabStop = false;
            // 
            // cbSelectStudent2
            // 
            cbSelectStudent2.FormattingEnabled = true;
            cbSelectStudent2.Location = new Point(194, 18);
            cbSelectStudent2.Margin = new Padding(3, 4, 3, 4);
            cbSelectStudent2.Name = "cbSelectStudent2";
            cbSelectStudent2.Size = new Size(121, 23);
            cbSelectStudent2.TabIndex = 10;
            cbSelectStudent2.Text = "학생를 선택하세요.";
            cbSelectStudent2.SelectedIndexChanged += cbSelectStudent2_SelectedIndexChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(99, 21);
            label13.Name = "label13";
            label13.Size = new Size(66, 15);
            label13.TabIndex = 9;
            label13.Text = "학생 선택 :";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCreateObject);
            groupBox1.Controls.Add(btnGetPic);
            groupBox1.Controls.Add(txtId);
            groupBox1.Controls.Add(txtCredits);
            groupBox1.Controls.Add(txtAge);
            groupBox1.Controls.Add(txtAddress);
            groupBox1.Controls.Add(txtName);
            groupBox1.Controls.Add(cbGender);
            groupBox1.Controls.Add(cbDept);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 15);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(461, 215);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "정보 입력";
            // 
            // btnCreateObject
            // 
            btnCreateObject.Location = new Point(171, 174);
            btnCreateObject.Margin = new Padding(3, 4, 3, 4);
            btnCreateObject.Name = "btnCreateObject";
            btnCreateObject.Size = new Size(104, 29);
            btnCreateObject.TabIndex = 15;
            btnCreateObject.Text = "학생 정보 입력";
            btnCreateObject.UseVisualStyleBackColor = true;
            btnCreateObject.Click += btnCreateObject_Click;
            // 
            // btnGetPic
            // 
            btnGetPic.Location = new Point(240, 138);
            btnGetPic.Margin = new Padding(3, 4, 3, 4);
            btnGetPic.Name = "btnGetPic";
            btnGetPic.Size = new Size(151, 29);
            btnGetPic.TabIndex = 14;
            btnGetPic.Text = "사진 선택";
            btnGetPic.UseVisualStyleBackColor = true;
            btnGetPic.Click += btnGetPic_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(291, 31);
            txtId.Margin = new Padding(3, 4, 3, 4);
            txtId.Name = "txtId";
            txtId.Size = new Size(100, 23);
            txtId.TabIndex = 13;
            txtId.TextAlign = HorizontalAlignment.Center;
            // 
            // txtCredits
            // 
            txtCredits.Location = new Point(291, 68);
            txtCredits.Margin = new Padding(3, 4, 3, 4);
            txtCredits.Name = "txtCredits";
            txtCredits.Size = new Size(100, 23);
            txtCredits.TabIndex = 12;
            txtCredits.Text = "0";
            txtCredits.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAge
            // 
            txtAge.Location = new Point(291, 104);
            txtAge.Margin = new Padding(3, 4, 3, 4);
            txtAge.Name = "txtAge";
            txtAge.Size = new Size(100, 23);
            txtAge.TabIndex = 11;
            txtAge.TextAlign = HorizontalAlignment.Center;
            // 
            // txtAddress
            // 
            txtAddress.ImeMode = ImeMode.Hangul;
            txtAddress.Location = new Point(61, 140);
            txtAddress.Margin = new Padding(3, 4, 3, 4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(121, 23);
            txtAddress.TabIndex = 10;
            txtAddress.TextAlign = HorizontalAlignment.Center;
            // 
            // txtName
            // 
            txtName.ImeMode = ImeMode.Hangul;
            txtName.Location = new Point(61, 68);
            txtName.Margin = new Padding(3, 4, 3, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(121, 23);
            txtName.TabIndex = 9;
            txtName.TextAlign = HorizontalAlignment.Center;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "남", "여" });
            cbGender.Location = new Point(61, 104);
            cbGender.Margin = new Padding(3, 4, 3, 4);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(121, 23);
            cbGender.TabIndex = 8;
            cbGender.Text = "성별을 선택하세요.";
            // 
            // cbDept
            // 
            cbDept.FormattingEnabled = true;
            cbDept.Items.AddRange(new object[] { "컴퓨터공학과", "뷰티아트과", "스마트IT과", "스마트자동차과" });
            cbDept.Location = new Point(61, 31);
            cbDept.Margin = new Padding(3, 4, 3, 4);
            cbDept.Name = "cbDept";
            cbDept.Size = new Size(121, 23);
            cbDept.TabIndex = 7;
            cbDept.Text = "학과를 선택하세요.";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(238, 35);
            label7.Name = "label7";
            label7.Size = new Size(38, 15);
            label7.TabIndex = 6;
            label7.Text = "학번 :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(238, 71);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 5;
            label6.Text = "학점 :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(238, 108);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 4;
            label5.Text = "나이 :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 144);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 3;
            label4.Text = "주소 :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(18, 108);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 2;
            label3.Text = "성별 :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(18, 71);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "성명 :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(18, 35);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 0;
            label1.Text = "학과 :";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // StudentInfoForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(483, 629);
            Controls.Add(groupBox2);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "StudentInfoForm";
            Text = "학생정보관리";
            Load += StudentInfoForm_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pcMain).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnAddAge;
        private System.Windows.Forms.Button btnModifyPic;
        private System.Windows.Forms.Button btnAddCredits;
        private System.Windows.Forms.Button btnModifyAddress;
        private System.Windows.Forms.TextBox txtAddCredits;
        private System.Windows.Forms.TextBox txtModAddress;
        private System.Windows.Forms.ComboBox cbSelectStudent1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label lblCredits;
        private System.Windows.Forms.Label lblStdId;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDept;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.PictureBox pcMain;
        private System.Windows.Forms.ComboBox cbSelectStudent2;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreateObject;
        private System.Windows.Forms.Button btnGetPic;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtCredits;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cbGender;
        private System.Windows.Forms.ComboBox cbDept;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private OpenFileDialog openFileDialog1;
    }
}


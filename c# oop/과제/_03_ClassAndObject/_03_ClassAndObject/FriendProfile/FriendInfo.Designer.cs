namespace FriendProfile
{
    partial class FriendInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox2 = new GroupBox();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            groupBox1 = new GroupBox();
            btnCreateWithArgs = new Button();
            btnCreateNoArg = new Button();
            label2 = new Label();
            this.lb1 = new Label();
            this.lb2 = new Label();
            lb3 = new Label();
            this.lb4 = new Label();
            lb6 = new Label();
            lb5 = new Label();
            friendName = new TextBox();
            friendAge = new TextBox();
            friendPhone = new TextBox();
            friendAddress = new RichTextBox();
            friendMajor = new TextBox();
            friendMBTI = new TextBox();
            label1 = new Label();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label3);
            groupBox2.Location = new Point(393, 163);
            groupBox2.Margin = new Padding(3, 4, 3, 4);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 4, 3, 4);
            groupBox2.Size = new Size(290, 134);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "친구목록결과";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(17, 38);
            label6.Name = "label6";
            label6.Size = new Size(55, 15);
            label6.TabIndex = 8;
            label6.Text = "친구이름";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(227, 38);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 5;
            label4.Text = "MBTI";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(90, 38);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "나이";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(friendMBTI);
            groupBox1.Controls.Add(friendMajor);
            groupBox1.Controls.Add(friendAddress);
            groupBox1.Controls.Add(friendPhone);
            groupBox1.Controls.Add(friendAge);
            groupBox1.Controls.Add(friendName);
            groupBox1.Controls.Add(lb5);
            groupBox1.Controls.Add(lb6);
            groupBox1.Controls.Add(this.lb4);
            groupBox1.Controls.Add(lb3);
            groupBox1.Controls.Add(this.lb2);
            groupBox1.Controls.Add(btnCreateWithArgs);
            groupBox1.Controls.Add(btnCreateNoArg);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(this.lb1);
            groupBox1.Location = new Point(40, 59);
            groupBox1.Margin = new Padding(3, 4, 3, 4);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 4, 3, 4);
            groupBox1.Size = new Size(307, 332);
            groupBox1.TabIndex = 12;
            groupBox1.TabStop = false;
            groupBox1.Text = "친구입력정보";
            // 
            // btnCreateWithArgs
            // 
            btnCreateWithArgs.Location = new Point(166, 284);
            btnCreateWithArgs.Margin = new Padding(3, 4, 3, 4);
            btnCreateWithArgs.Name = "btnCreateWithArgs";
            btnCreateWithArgs.Size = new Size(95, 25);
            btnCreateWithArgs.TabIndex = 5;
            btnCreateWithArgs.Text = "친구목록 삭제:";
            btnCreateWithArgs.UseVisualStyleBackColor = true;
            // 
            // btnCreateNoArg
            // 
            btnCreateNoArg.Location = new Point(39, 284);
            btnCreateNoArg.Margin = new Padding(3, 4, 3, 4);
            btnCreateNoArg.Name = "btnCreateNoArg";
            btnCreateNoArg.Size = new Size(95, 25);
            btnCreateNoArg.TabIndex = 4;
            btnCreateNoArg.Text = "친구목록 추가:";
            btnCreateNoArg.UseVisualStyleBackColor = true;
            btnCreateNoArg.Click += btnCreateNoArg_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 37);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 1;
            // 
            // lb1
            // 
            this.lb1.AutoSize = true;
            this.lb1.Location = new Point(6, 37);
            this.lb1.Name = "lb1";
            this.lb1.Size = new Size(34, 15);
            this.lb1.TabIndex = 0;
            this.lb1.Text = "이름:";
            // 
            // lb2
            // 
            this.lb2.AutoSize = true;
            this.lb2.Location = new Point(6, 69);
            this.lb2.Name = "lb2";
            this.lb2.Size = new Size(34, 15);
            this.lb2.TabIndex = 6;
            this.lb2.Text = "나이:";
            // 
            // lb3
            // 
            lb3.AutoSize = true;
            lb3.Location = new Point(6, 104);
            lb3.Name = "lb3";
            lb3.Size = new Size(34, 15);
            lb3.TabIndex = 7;
            lb3.Text = "번호:";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Location = new Point(6, 138);
            this.lb4.Name = "lb4";
            this.lb4.Size = new Size(34, 15);
            this.lb4.TabIndex = 8;
            this.lb4.Text = "주소:";
            // 
            // lb6
            // 
            lb6.AutoSize = true;
            lb6.Location = new Point(156, 37);
            lb6.Name = "lb6";
            lb6.Size = new Size(37, 15);
            lb6.TabIndex = 9;
            lb6.Text = "MBTI:";
            // 
            // lb5
            // 
            lb5.AutoSize = true;
            lb5.Location = new Point(6, 242);
            lb5.Name = "lb5";
            lb5.Size = new Size(34, 15);
            lb5.TabIndex = 10;
            lb5.Text = "전공:";
            // 
            // friendName
            // 
            friendName.Location = new Point(50, 34);
            friendName.Name = "friendName";
            friendName.Size = new Size(100, 23);
            friendName.TabIndex = 11;
            // 
            // friendAge
            // 
            friendAge.Location = new Point(50, 69);
            friendAge.Name = "friendAge";
            friendAge.Size = new Size(100, 23);
            friendAge.TabIndex = 12;
            // 
            // friendPhone
            // 
            friendPhone.Location = new Point(50, 104);
            friendPhone.Name = "friendPhone";
            friendPhone.Size = new Size(100, 23);
            friendPhone.TabIndex = 13;
            // 
            // friendAddress
            // 
            friendAddress.Location = new Point(50, 138);
            friendAddress.Name = "friendAddress";
            friendAddress.Size = new Size(100, 96);
            friendAddress.TabIndex = 14;
            friendAddress.Text = "";
            // 
            // friendMajor
            // 
            friendMajor.Location = new Point(50, 242);
            friendMajor.Name = "friendMajor";
            friendMajor.Size = new Size(100, 23);
            friendMajor.TabIndex = 15;
            // 
            // friendMBTI
            // 
            friendMBTI.Location = new Point(196, 34);
            friendMBTI.Name = "friendMBTI";
            friendMBTI.Size = new Size(100, 23);
            friendMBTI.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(153, 38);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 9;
            label1.Text = "번호";
            // 
            // FriendInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(695, 450);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FriendInfo";
            Text = "Form1";
            Load += Form1_Load;
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox2;
        private Label label6;
        private Label label4;
        private Label label3;
        private GroupBox groupBox1;
        private Button btnCreateWithArgs;
        private Button btnCreateNoArg;
        private TextBox txtSpeed;
        private ComboBox cbType;
        private Label label2;
        private Label label1;
        private Label label5;
        private Label label8;
        private Label lb3;
        public TextBox friendName;
        private Label lb5;
        private Label lb6;
        public TextBox friendPhone;
        public TextBox friendAge;
        public TextBox friendMajor;
        private RichTextBox friendAddress;
        public TextBox friendMBTI;
    }
}

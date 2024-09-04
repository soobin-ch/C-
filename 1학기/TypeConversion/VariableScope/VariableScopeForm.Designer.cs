namespace VariableScope
{
    partial class VariableScopeForm
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
            this.txtGlobal = new System.Windows.Forms.TextBox();
            this.txtLocal = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRead = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblGlobalRead = new System.Windows.Forms.Label();
            this.lblLocalRead = new System.Windows.Forms.Label();
            this.lblGlobalClick = new System.Windows.Forms.Label();
            this.lbllocalClick = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "전역/지역변수로 활용할 값을 입력하세요...";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(50, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "전역변수:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(60, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "전역변수:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(60, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "전역변수:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "지역변수:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(279, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(57, 12);
            this.label6.TabIndex = 7;
            this.label6.Text = "지역변수:";
            // 
            // txtGlobal
            // 
            this.txtGlobal.Location = new System.Drawing.Point(148, 90);
            this.txtGlobal.Name = "txtGlobal";
            this.txtGlobal.Size = new System.Drawing.Size(100, 21);
            this.txtGlobal.TabIndex = 10;
            // 
            // txtLocal
            // 
            this.txtLocal.Location = new System.Drawing.Point(342, 84);
            this.txtLocal.Name = "txtLocal";
            this.txtLocal.Size = new System.Drawing.Size(100, 21);
            this.txtLocal.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(279, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "지역변수:";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(180, 127);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(235, 23);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "btnRead.Click()메서드에서 읽은 후...";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(158, 211);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(284, 23);
            this.button2.TabIndex = 14;
            this.button2.Text = "btnOk_Click()메서드에서 변수값 읽기";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblGlobalRead
            // 
            this.lblGlobalRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGlobalRead.Location = new System.Drawing.Point(146, 175);
            this.lblGlobalRead.Name = "lblGlobalRead";
            this.lblGlobalRead.Size = new System.Drawing.Size(100, 23);
            this.lblGlobalRead.TabIndex = 15;
            // 
            // lblLocalRead
            // 
            this.lblLocalRead.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblLocalRead.Location = new System.Drawing.Point(372, 172);
            this.lblLocalRead.Name = "lblLocalRead";
            this.lblLocalRead.Size = new System.Drawing.Size(100, 23);
            this.lblLocalRead.TabIndex = 16;
            // 
            // lblGlobalClick
            // 
            this.lblGlobalClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblGlobalClick.Location = new System.Drawing.Point(146, 253);
            this.lblGlobalClick.Name = "lblGlobalClick";
            this.lblGlobalClick.Size = new System.Drawing.Size(100, 23);
            this.lblGlobalClick.TabIndex = 17;
            // 
            // lbllocalClick
            // 
            this.lbllocalClick.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbllocalClick.Location = new System.Drawing.Point(366, 250);
            this.lbllocalClick.Name = "lbllocalClick";
            this.lbllocalClick.Size = new System.Drawing.Size(115, 26);
            this.lbllocalClick.TabIndex = 18;
            // 
            // VariableScopeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbllocalClick);
            this.Controls.Add(this.lblGlobalClick);
            this.Controls.Add(this.lblLocalRead);
            this.Controls.Add(this.lblGlobalRead);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtLocal);
            this.Controls.Add(this.txtGlobal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VariableScopeForm";
            this.Text = "변수의 통용범위";
            this.Load += new System.EventHandler(this.VariableScopeForm_Load);
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
        private System.Windows.Forms.TextBox txtGlobal;
        private System.Windows.Forms.TextBox txtLocal;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblGlobalRead;
        private System.Windows.Forms.Label lblLocalRead;
        private System.Windows.Forms.Label lblGlobalClick;
        private System.Windows.Forms.Label lbllocalClick;
    }
}


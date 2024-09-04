namespace _04_SimpleCalculator
{
    partial class CalcForm
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
            this.txtNum1 = new System.Windows.Forms.TextBox();
            this.txtNum2 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.lblOp = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSubrack = new System.Windows.Forms.Button();
            this.btnMultiply = new System.Windows.Forms.Button();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnNE = new System.Windows.Forms.Button();
            this.btnModulus = new System.Windows.Forms.Button();
            this.btnEQ = new System.Windows.Forms.Button();
            this.btnGT = new System.Windows.Forms.Button();
            this.btnLT = new System.Windows.Forms.Button();
            this.btnGE = new System.Windows.Forms.Button();
            this.btnLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNum1
            // 
            this.txtNum1.Location = new System.Drawing.Point(21, 57);
            this.txtNum1.Name = "txtNum1";
            this.txtNum1.Size = new System.Drawing.Size(100, 21);
            this.txtNum1.TabIndex = 0;
            this.txtNum1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNum2
            // 
            this.txtNum2.Location = new System.Drawing.Point(171, 57);
            this.txtNum2.Name = "txtNum2";
            this.txtNum2.Size = new System.Drawing.Size(100, 21);
            this.txtNum2.TabIndex = 1;
            this.txtNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(305, 57);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 21);
            this.txtResult.TabIndex = 2;
            this.txtResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblOp
            // 
            this.lblOp.AutoSize = true;
            this.lblOp.Location = new System.Drawing.Point(127, 66);
            this.lblOp.Name = "lblOp";
            this.lblOp.Size = new System.Drawing.Size(19, 12);
            this.lblOp.TabIndex = 3;
            this.lblOp.Text = "op";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(277, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(11, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "=";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(57, 125);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(51, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnSubrack
            // 
            this.btnSubrack.Location = new System.Drawing.Point(129, 125);
            this.btnSubrack.Name = "btnSubrack";
            this.btnSubrack.Size = new System.Drawing.Size(57, 23);
            this.btnSubrack.TabIndex = 6;
            this.btnSubrack.Text = "-";
            this.btnSubrack.UseVisualStyleBackColor = true;
            this.btnSubrack.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnMultiply
            // 
            this.btnMultiply.Location = new System.Drawing.Point(211, 125);
            this.btnMultiply.Name = "btnMultiply";
            this.btnMultiply.Size = new System.Drawing.Size(60, 23);
            this.btnMultiply.TabIndex = 7;
            this.btnMultiply.Text = "*";
            this.btnMultiply.UseVisualStyleBackColor = true;
            this.btnMultiply.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnDivide
            // 
            this.btnDivide.Location = new System.Drawing.Point(294, 125);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(57, 24);
            this.btnDivide.TabIndex = 8;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = true;
            this.btnDivide.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnNE
            // 
            this.btnNE.Location = new System.Drawing.Point(129, 165);
            this.btnNE.Name = "btnNE";
            this.btnNE.Size = new System.Drawing.Size(57, 23);
            this.btnNE.TabIndex = 9;
            this.btnNE.Text = "!=";
            this.btnNE.UseVisualStyleBackColor = true;
            this.btnNE.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnModulus
            // 
            this.btnModulus.Location = new System.Drawing.Point(367, 125);
            this.btnModulus.Name = "btnModulus";
            this.btnModulus.Size = new System.Drawing.Size(51, 23);
            this.btnModulus.TabIndex = 10;
            this.btnModulus.Text = "%";
            this.btnModulus.UseVisualStyleBackColor = true;
            this.btnModulus.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnEQ
            // 
            this.btnEQ.Location = new System.Drawing.Point(57, 165);
            this.btnEQ.Name = "btnEQ";
            this.btnEQ.Size = new System.Drawing.Size(57, 23);
            this.btnEQ.TabIndex = 11;
            this.btnEQ.Text = "==";
            this.btnEQ.UseVisualStyleBackColor = true;
            this.btnEQ.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGT
            // 
            this.btnGT.Location = new System.Drawing.Point(211, 165);
            this.btnGT.Name = "btnGT";
            this.btnGT.Size = new System.Drawing.Size(60, 23);
            this.btnGT.TabIndex = 12;
            this.btnGT.Text = ">";
            this.btnGT.UseVisualStyleBackColor = true;
            this.btnGT.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLT
            // 
            this.btnLT.Location = new System.Drawing.Point(294, 165);
            this.btnLT.Name = "btnLT";
            this.btnLT.Size = new System.Drawing.Size(57, 23);
            this.btnLT.TabIndex = 13;
            this.btnLT.Text = "<";
            this.btnLT.UseVisualStyleBackColor = true;
            this.btnLT.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnGE
            // 
            this.btnGE.Location = new System.Drawing.Point(367, 165);
            this.btnGE.Name = "btnGE";
            this.btnGE.Size = new System.Drawing.Size(51, 23);
            this.btnGE.TabIndex = 14;
            this.btnGE.Text = ">=";
            this.btnGE.UseVisualStyleBackColor = true;
            this.btnGE.Click += new System.EventHandler(this.btn_Click);
            // 
            // btnLE
            // 
            this.btnLE.Location = new System.Drawing.Point(433, 165);
            this.btnLE.Name = "btnLE";
            this.btnLE.Size = new System.Drawing.Size(55, 23);
            this.btnLE.TabIndex = 15;
            this.btnLE.Text = "<=";
            this.btnLE.UseVisualStyleBackColor = true;
            this.btnLE.Click += new System.EventHandler(this.btn_Click);
            // 
            // CalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLE);
            this.Controls.Add(this.btnGE);
            this.Controls.Add(this.btnLT);
            this.Controls.Add(this.btnGT);
            this.Controls.Add(this.btnEQ);
            this.Controls.Add(this.btnModulus);
            this.Controls.Add(this.btnNE);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.btnMultiply);
            this.Controls.Add(this.btnSubrack);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOp);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtNum2);
            this.Controls.Add(this.txtNum1);
            this.Name = "CalcForm";
            this.Text = "간단한 계산기";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNum1;
        private System.Windows.Forms.TextBox txtNum2;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Label lblOp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSubrack;
        private System.Windows.Forms.Button btnMultiply;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnNE;
        private System.Windows.Forms.Button btnModulus;
        private System.Windows.Forms.Button btnEQ;
        private System.Windows.Forms.Button btnGT;
        private System.Windows.Forms.Button btnLT;
        private System.Windows.Forms.Button btnGE;
        private System.Windows.Forms.Button btnLE;
    }
}


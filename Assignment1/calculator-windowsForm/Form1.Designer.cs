namespace calculator_windowsForm
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClickThis = new System.Windows.Forms.Button();
            this.lbHelloWorld = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.numberOne = new System.Windows.Forms.Label();
            this.operand = new System.Windows.Forms.Label();
            this.numbertwo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnClickThis
            // 
            this.btnClickThis.Location = new System.Drawing.Point(494, 185);
            this.btnClickThis.Name = "btnClickThis";
            this.btnClickThis.Size = new System.Drawing.Size(120, 30);
            this.btnClickThis.TabIndex = 0;
            this.btnClickThis.Text = "clickresult";
            this.btnClickThis.UseVisualStyleBackColor = true;
            this.btnClickThis.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbHelloWorld
            // 
            this.lbHelloWorld.AutoSize = true;
            this.lbHelloWorld.Location = new System.Drawing.Point(616, 190);
            this.lbHelloWorld.Name = "lbHelloWorld";
            this.lbHelloWorld.Size = new System.Drawing.Size(62, 18);
            this.lbHelloWorld.TabIndex = 1;
            this.lbHelloWorld.Text = "result";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(99, 180);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 28);
            this.textBox1.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(361, 180);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 28);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(231, 180);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 28);
            this.textBox2.TabIndex = 4;
            // 
            // numberOne
            // 
            this.numberOne.AutoSize = true;
            this.numberOne.Location = new System.Drawing.Point(120, 239);
            this.numberOne.Name = "numberOne";
            this.numberOne.Size = new System.Drawing.Size(89, 18);
            this.numberOne.TabIndex = 5;
            this.numberOne.Text = "NumberOne";
            // 
            // operand
            // 
            this.operand.AutoSize = true;
            this.operand.Location = new System.Drawing.Point(255, 239);
            this.operand.Name = "operand";
            this.operand.Size = new System.Drawing.Size(71, 18);
            this.operand.TabIndex = 6;
            this.operand.Text = "Operand";
            // 
            // numbertwo
            // 
            this.numbertwo.AutoSize = true;
            this.numbertwo.Location = new System.Drawing.Point(387, 239);
            this.numbertwo.Name = "numbertwo";
            this.numbertwo.Size = new System.Drawing.Size(89, 18);
            this.numbertwo.TabIndex = 7;
            this.numbertwo.Text = "NumberTwo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numbertwo);
            this.Controls.Add(this.operand);
            this.Controls.Add(this.numberOne);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lbHelloWorld);
            this.Controls.Add(this.btnClickThis);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClickThis;
        private System.Windows.Forms.Label lbHelloWorld;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label numberOne;
        private System.Windows.Forms.Label operand;
        private System.Windows.Forms.Label numbertwo;
    }
}


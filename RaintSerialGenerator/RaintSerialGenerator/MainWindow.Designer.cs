namespace RaintSerialGenerator
{
    partial class MainWindow
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textbox_Serial_Id = new System.Windows.Forms.TextBox();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.textBox_UniqueKey = new System.Windows.Forms.TextBox();
            this.GenerateHash = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textbox_Serial_Id
            // 
            this.textbox_Serial_Id.Location = new System.Drawing.Point(72, 13);
            this.textbox_Serial_Id.Name = "textbox_Serial_Id";
            this.textbox_Serial_Id.Size = new System.Drawing.Size(431, 20);
            this.textbox_Serial_Id.TabIndex = 0;
            // 
            // textBox_Email
            // 
            this.textBox_Email.Location = new System.Drawing.Point(72, 56);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(431, 20);
            this.textBox_Email.TabIndex = 1;
            // 
            // textBox_UniqueKey
            // 
            this.textBox_UniqueKey.Location = new System.Drawing.Point(72, 106);
            this.textBox_UniqueKey.Name = "textBox_UniqueKey";
            this.textBox_UniqueKey.Size = new System.Drawing.Size(431, 20);
            this.textBox_UniqueKey.TabIndex = 2;
            // 
            // GenerateHash
            // 
            this.GenerateHash.Location = new System.Drawing.Point(529, 56);
            this.GenerateHash.Name = "GenerateHash";
            this.GenerateHash.Size = new System.Drawing.Size(75, 23);
            this.GenerateHash.TabIndex = 3;
            this.GenerateHash.Text = "Generate";
            this.GenerateHash.UseVisualStyleBackColor = true;
            this.GenerateHash.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GenerateHash_MouseClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Machine ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(4, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Serial Key";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(623, 156);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GenerateHash);
            this.Controls.Add(this.textBox_UniqueKey);
            this.Controls.Add(this.textBox_Email);
            this.Controls.Add(this.textbox_Serial_Id);
            this.Name = "Form1";
            this.Text = "RaintSerialGenerator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textbox_Serial_Id;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.TextBox textBox_UniqueKey;
        private System.Windows.Forms.Button GenerateHash;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}


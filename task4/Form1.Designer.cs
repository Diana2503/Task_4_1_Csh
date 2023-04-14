namespace task4
{
    partial class Form1
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
            this.nameF = new System.Windows.Forms.TextBox();
            this.lenghtF = new System.Windows.Forms.TextBox();
            this.cCF = new System.Windows.Forms.TextBox();
            this.velocityF = new System.Windows.Forms.TextBox();
            this.infoButton = new System.Windows.Forms.Button();
            this.qpButton = new System.Windows.Forms.Button();
            this.allInfF = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // nameF
            // 
            this.nameF.Location = new System.Drawing.Point(155, 16);
            this.nameF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nameF.Name = "nameF";
            this.nameF.Size = new System.Drawing.Size(135, 22);
            this.nameF.TabIndex = 0;
            // 
            // lenghtF
            // 
            this.lenghtF.Location = new System.Drawing.Point(155, 55);
            this.lenghtF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lenghtF.Name = "lenghtF";
            this.lenghtF.Size = new System.Drawing.Size(135, 22);
            this.lenghtF.TabIndex = 1;
            // 
            // cCF
            // 
            this.cCF.Location = new System.Drawing.Point(155, 95);
            this.cCF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cCF.Name = "cCF";
            this.cCF.Size = new System.Drawing.Size(135, 22);
            this.cCF.TabIndex = 2;
            // 
            // velocityF
            // 
            this.velocityF.Location = new System.Drawing.Point(155, 133);
            this.velocityF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.velocityF.Name = "velocityF";
            this.velocityF.Size = new System.Drawing.Size(135, 22);
            this.velocityF.TabIndex = 3;
            // 
            // infoButton
            // 
            this.infoButton.Location = new System.Drawing.Point(14, 201);
            this.infoButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.infoButton.Name = "infoButton";
            this.infoButton.Size = new System.Drawing.Size(97, 26);
            this.infoButton.TabIndex = 4;
            this.infoButton.Text = "Get info";
            this.infoButton.UseVisualStyleBackColor = true;
            this.infoButton.Click += new System.EventHandler(this.infoButton_Click);
            // 
            // qpButton
            // 
            this.qpButton.Location = new System.Drawing.Point(116, 201);
            this.qpButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.qpButton.Name = "qpButton";
            this.qpButton.Size = new System.Drawing.Size(98, 26);
            this.qpButton.TabIndex = 5;
            this.qpButton.Text = "Calc Qp";
            this.qpButton.UseVisualStyleBackColor = true;
            this.qpButton.Click += new System.EventHandler(this.qpButton_Click);
            // 
            // allInfF
            // 
            this.allInfF.Location = new System.Drawing.Point(324, 36);
            this.allInfF.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.allInfF.Multiline = true;
            this.allInfF.Name = "allInfF";
            this.allInfF.Size = new System.Drawing.Size(384, 191);
            this.allInfF.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Processor  name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Processor frequency";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Amount of RAM";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount of Hdd";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "Qp value:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(92, 242);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(444, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "All information about computer";
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(14, 170);
            this.saveButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(97, 26);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 306);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.allInfF);
            this.Controls.Add(this.qpButton);
            this.Controls.Add(this.infoButton);
            this.Controls.Add(this.velocityF);
            this.Controls.Add(this.cCF);
            this.Controls.Add(this.lenghtF);
            this.Controls.Add(this.nameF);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameF;
        private System.Windows.Forms.TextBox lenghtF;
        private System.Windows.Forms.TextBox cCF;
        private System.Windows.Forms.TextBox velocityF;
        private System.Windows.Forms.Button infoButton;
        private System.Windows.Forms.Button qpButton;
        private System.Windows.Forms.TextBox allInfF;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button saveButton;
    }
}


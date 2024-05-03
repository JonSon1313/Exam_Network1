namespace Examen_NetworkProgram
{
    partial class Server
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
            this.JournalBox = new System.Windows.Forms.TextBox();
            this.PortField = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddrFiled = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // JournalBox
            // 
            this.JournalBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JournalBox.Location = new System.Drawing.Point(19, 102);
            this.JournalBox.Multiline = true;
            this.JournalBox.Name = "JournalBox";
            this.JournalBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.JournalBox.Size = new System.Drawing.Size(557, 291);
            this.JournalBox.TabIndex = 5;
            // 
            // PortField
            // 
            this.PortField.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PortField.Location = new System.Drawing.Point(357, 47);
            this.PortField.Name = "PortField";
            this.PortField.Size = new System.Drawing.Size(142, 26);
            this.PortField.TabIndex = 9;
            this.PortField.Text = "9001";
            this.PortField.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(307, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 22);
            this.label2.TabIndex = 8;
            this.label2.Text = "Port:";
            // 
            // AddrFiled
            // 
            this.AddrFiled.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrFiled.Location = new System.Drawing.Point(148, 47);
            this.AddrFiled.Name = "AddrFiled";
            this.AddrFiled.Size = new System.Drawing.Size(134, 26);
            this.AddrFiled.TabIndex = 7;
            this.AddrFiled.Text = "127.0.0.1";
            this.AddrFiled.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(73, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "IP-Addr:";
            // 
            // Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(594, 416);
            this.Controls.Add(this.PortField);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddrFiled);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JournalBox);
            this.Name = "Server";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox JournalBox;
        private System.Windows.Forms.TextBox PortField;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox AddrFiled;
        private System.Windows.Forms.Label label1;
    }
}


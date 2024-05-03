namespace Client
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
            this.radio_admin = new System.Windows.Forms.RadioButton();
            this.radio_user = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Login_Field2 = new System.Windows.Forms.TextBox();
            this.Passw_Field2 = new System.Windows.Forms.TextBox();
            this.button_Entry = new System.Windows.Forms.Button();
            this.button_start = new System.Windows.Forms.Button();
            this.Box_test = new System.Windows.Forms.GroupBox();
            this.Button_answer = new System.Windows.Forms.Button();
            this.Box_answer = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.radio_math = new System.Windows.Forms.RadioButton();
            this.radio_history = new System.Windows.Forms.RadioButton();
            this.radio_chemic = new System.Windows.Forms.RadioButton();
            this.radio_physick = new System.Windows.Forms.RadioButton();
            this.Box_test.SuspendLayout();
            this.SuspendLayout();
            // 
            // radio_admin
            // 
            this.radio_admin.AutoSize = true;
            this.radio_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_admin.Location = new System.Drawing.Point(26, 23);
            this.radio_admin.Name = "radio_admin";
            this.radio_admin.Size = new System.Drawing.Size(72, 24);
            this.radio_admin.TabIndex = 0;
            this.radio_admin.TabStop = true;
            this.radio_admin.Text = "Admin";
            this.radio_admin.UseVisualStyleBackColor = true;
            // 
            // radio_user
            // 
            this.radio_user.AutoSize = true;
            this.radio_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_user.Location = new System.Drawing.Point(104, 23);
            this.radio_user.Name = "radio_user";
            this.radio_user.Size = new System.Drawing.Size(61, 24);
            this.radio_user.TabIndex = 1;
            this.radio_user.TabStop = true;
            this.radio_user.Text = "User";
            this.radio_user.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Login";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // Login_Field2
            // 
            this.Login_Field2.Location = new System.Drawing.Point(87, 65);
            this.Login_Field2.Name = "Login_Field2";
            this.Login_Field2.Size = new System.Drawing.Size(127, 20);
            this.Login_Field2.TabIndex = 4;
            // 
            // Passw_Field2
            // 
            this.Passw_Field2.Location = new System.Drawing.Point(87, 102);
            this.Passw_Field2.Name = "Passw_Field2";
            this.Passw_Field2.Size = new System.Drawing.Size(127, 20);
            this.Passw_Field2.TabIndex = 5;
            // 
            // button_Entry
            // 
            this.button_Entry.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_Entry.Location = new System.Drawing.Point(7, 128);
            this.button_Entry.Name = "button_Entry";
            this.button_Entry.Size = new System.Drawing.Size(235, 39);
            this.button_Entry.TabIndex = 6;
            this.button_Entry.Text = "Увійти";
            this.button_Entry.UseVisualStyleBackColor = true;
            this.button_Entry.Click += new System.EventHandler(this.button_Entry_Click);
            // 
            // button_start
            // 
            this.button_start.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_start.Location = new System.Drawing.Point(7, 377);
            this.button_start.Name = "button_start";
            this.button_start.Size = new System.Drawing.Size(235, 39);
            this.button_start.TabIndex = 7;
            this.button_start.Text = "Почати";
            this.button_start.UseVisualStyleBackColor = true;
            this.button_start.Click += new System.EventHandler(this.button_start_Click);
            // 
            // Box_test
            // 
            this.Box_test.Controls.Add(this.Button_answer);
            this.Box_test.Controls.Add(this.Box_answer);
            this.Box_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Box_test.Location = new System.Drawing.Point(248, 12);
            this.Box_test.Name = "Box_test";
            this.Box_test.Size = new System.Drawing.Size(302, 404);
            this.Box_test.TabIndex = 8;
            this.Box_test.TabStop = false;
            this.Box_test.Text = "Тестування";
            // 
            // Button_answer
            // 
            this.Button_answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button_answer.Location = new System.Drawing.Point(6, 365);
            this.Button_answer.Name = "Button_answer";
            this.Button_answer.Size = new System.Drawing.Size(296, 39);
            this.Button_answer.TabIndex = 1;
            this.Button_answer.Text = "Відповідь";
            this.Button_answer.UseVisualStyleBackColor = true;
            this.Button_answer.Click += new System.EventHandler(this.Button_answer_Click);
            // 
            // Box_answer
            // 
            this.Box_answer.Location = new System.Drawing.Point(6, 333);
            this.Box_answer.Name = "Box_answer";
            this.Box_answer.Size = new System.Drawing.Size(302, 26);
            this.Box_answer.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(48, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Оберіть предмет";
            // 
            // radio_math
            // 
            this.radio_math.AutoSize = true;
            this.radio_math.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_math.Location = new System.Drawing.Point(12, 243);
            this.radio_math.Name = "radio_math";
            this.radio_math.Size = new System.Drawing.Size(106, 20);
            this.radio_math.TabIndex = 0;
            this.radio_math.TabStop = true;
            this.radio_math.Text = "Математика";
            this.radio_math.UseVisualStyleBackColor = true;
            // 
            // radio_history
            // 
            this.radio_history.AutoSize = true;
            this.radio_history.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_history.Location = new System.Drawing.Point(12, 269);
            this.radio_history.Name = "radio_history";
            this.radio_history.Size = new System.Drawing.Size(68, 20);
            this.radio_history.TabIndex = 9;
            this.radio_history.TabStop = true;
            this.radio_history.Text = "Історія";
            this.radio_history.UseVisualStyleBackColor = true;
            // 
            // radio_chemic
            // 
            this.radio_chemic.AutoSize = true;
            this.radio_chemic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_chemic.Location = new System.Drawing.Point(12, 295);
            this.radio_chemic.Name = "radio_chemic";
            this.radio_chemic.Size = new System.Drawing.Size(55, 20);
            this.radio_chemic.TabIndex = 10;
            this.radio_chemic.TabStop = true;
            this.radio_chemic.Text = "Хімія";
            this.radio_chemic.UseVisualStyleBackColor = true;
            // 
            // radio_physick
            // 
            this.radio_physick.AutoSize = true;
            this.radio_physick.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radio_physick.Location = new System.Drawing.Point(12, 321);
            this.radio_physick.Name = "radio_physick";
            this.radio_physick.Size = new System.Drawing.Size(70, 20);
            this.radio_physick.TabIndex = 11;
            this.radio_physick.TabStop = true;
            this.radio_physick.Tag = "";
            this.radio_physick.Text = "Фізика";
            this.radio_physick.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(579, 421);
            this.Controls.Add(this.radio_physick);
            this.Controls.Add(this.radio_chemic);
            this.Controls.Add(this.radio_history);
            this.Controls.Add(this.radio_math);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Box_test);
            this.Controls.Add(this.button_start);
            this.Controls.Add(this.button_Entry);
            this.Controls.Add(this.Passw_Field2);
            this.Controls.Add(this.Login_Field2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.radio_user);
            this.Controls.Add(this.radio_admin);
            this.Name = "Form1";
            this.Text = "User_Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Box_test.ResumeLayout(false);
            this.Box_test.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radio_admin;
        private System.Windows.Forms.RadioButton radio_user;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Login_Field2;
        private System.Windows.Forms.TextBox Passw_Field2;
        private System.Windows.Forms.Button button_Entry;
        private System.Windows.Forms.Button button_start;
        private System.Windows.Forms.GroupBox Box_test;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radio_math;
        private System.Windows.Forms.RadioButton radio_history;
        private System.Windows.Forms.RadioButton radio_chemic;
        private System.Windows.Forms.RadioButton radio_physick;
        private System.Windows.Forms.TextBox Box_answer;
        private System.Windows.Forms.Button Button_answer;
    }
}


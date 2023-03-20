using System.ComponentModel;

namespace GreatSportEventApp.UserForms
{
    partial class UserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new Container();
            label1 = new System.Windows.Forms.Label();
            labelTitle = new System.Windows.Forms.Label();
            textViewerName = new System.Windows.Forms.TextBox();
            buttonSave = new System.Windows.Forms.Button();
            SelectViewerButton = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            comboMode = new System.Windows.Forms.ComboBox();
            label5 = new System.Windows.Forms.Label();
            textPassword = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            textLogin = new System.Windows.Forms.TextBox();
            label8 = new System.Windows.Forms.Label();
            SelectEmployeeButton = new System.Windows.Forms.Button();
            textEmployeeName = new System.Windows.Forms.TextBox();
            SelectAthleteButton = new System.Windows.Forms.Button();
            textAthleteName = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 152);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(144, 26);
            label1.TabIndex = 0;
            label1.Text = "Спортсмен:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(457, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление пользователя";
            // 
            // textViewerName
            // 
            textViewerName.Location = new System.Drawing.Point(162, 216);
            textViewerName.Name = "textViewerName";
            textViewerName.ReadOnly = true;
            textViewerName.Size = new System.Drawing.Size(342, 26);
            textViewerName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(481, 268);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // SelectViewerButton
            // 
            SelectViewerButton.Location = new System.Drawing.Point(510, 216);
            SelectViewerButton.Name = "SelectViewerButton";
            SelectViewerButton.Size = new System.Drawing.Size(100, 26);
            SelectViewerButton.TabIndex = 17;
            SelectViewerButton.Text = "Выбрать";
            SelectViewerButton.UseVisualStyleBackColor = true;
            SelectViewerButton.Click += SelectViewerButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // comboMode
            // 
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "Администратор", "Продавец", "Организатор", "Менеджер по персоналу", "Тренер" });
            comboMode.Location = new System.Drawing.Point(162, 120);
            comboMode.Name = "comboMode";
            comboMode.Size = new System.Drawing.Size(260, 26);
            comboMode.TabIndex = 28;
            // 
            // label5
            // 
            label5.Location = new System.Drawing.Point(12, 119);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(131, 26);
            label5.TabIndex = 27;
            label5.Text = "Режим доступа:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPassword
            // 
            textPassword.Location = new System.Drawing.Point(162, 88);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new System.Drawing.Size(189, 26);
            textPassword.TabIndex = 26;
            // 
            // label7
            // 
            label7.Location = new System.Drawing.Point(12, 88);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(144, 26);
            label7.TabIndex = 25;
            label7.Text = "Пароль:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLogin
            // 
            textLogin.Location = new System.Drawing.Point(162, 56);
            textLogin.Name = "textLogin";
            textLogin.Size = new System.Drawing.Size(189, 26);
            textLogin.TabIndex = 24;
            textLogin.Validating += TextLogin_Validating;
            // 
            // label8
            // 
            label8.Location = new System.Drawing.Point(12, 55);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(144, 26);
            label8.TabIndex = 23;
            label8.Text = "Логин:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectEmployeeButton
            // 
            SelectEmployeeButton.Location = new System.Drawing.Point(510, 184);
            SelectEmployeeButton.Name = "SelectEmployeeButton";
            SelectEmployeeButton.Size = new System.Drawing.Size(100, 26);
            SelectEmployeeButton.TabIndex = 30;
            SelectEmployeeButton.Text = "Выбрать";
            SelectEmployeeButton.UseVisualStyleBackColor = true;
            SelectEmployeeButton.Click += SelectEmployeeButton_Click;
            // 
            // textEmployeeName
            // 
            textEmployeeName.Location = new System.Drawing.Point(162, 184);
            textEmployeeName.Name = "textEmployeeName";
            textEmployeeName.ReadOnly = true;
            textEmployeeName.Size = new System.Drawing.Size(342, 26);
            textEmployeeName.TabIndex = 29;
            // 
            // SelectAthleteButton
            // 
            SelectAthleteButton.Location = new System.Drawing.Point(510, 152);
            SelectAthleteButton.Name = "SelectAthleteButton";
            SelectAthleteButton.Size = new System.Drawing.Size(100, 26);
            SelectAthleteButton.TabIndex = 32;
            SelectAthleteButton.Text = "Выбрать";
            SelectAthleteButton.UseVisualStyleBackColor = true;
            SelectAthleteButton.Click += SelectAthleteButton_Click;
            // 
            // textAthleteName
            // 
            textAthleteName.Location = new System.Drawing.Point(162, 152);
            textAthleteName.Name = "textAthleteName";
            textAthleteName.ReadOnly = true;
            textAthleteName.Size = new System.Drawing.Size(342, 26);
            textAthleteName.TabIndex = 31;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(12, 184);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(144, 26);
            label2.TabIndex = 33;
            label2.Text = "Сотрудник:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 216);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(144, 26);
            label3.TabIndex = 34;
            label3.Text = "Зритель:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(637, 327);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(SelectAthleteButton);
            Controls.Add(textAthleteName);
            Controls.Add(SelectEmployeeButton);
            Controls.Add(textEmployeeName);
            Controls.Add(comboMode);
            Controls.Add(label5);
            Controls.Add(textPassword);
            Controls.Add(label7);
            Controls.Add(textLogin);
            Controls.Add(label8);
            Controls.Add(SelectViewerButton);
            Controls.Add(buttonSave);
            Controls.Add(textViewerName);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление пользователя";
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textViewerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion
        private System.Windows.Forms.Button SelectViewerButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox comboMode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textPassword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textLogin;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button SelectAthleteButton;
        private System.Windows.Forms.TextBox textAthleteName;
        private System.Windows.Forms.Button SelectEmployeeButton;
        private System.Windows.Forms.TextBox textEmployeeName;
    }
}
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
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(200, 32);
            label1.TabIndex = 0;
            label1.Text = "Спортсмен:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            tableLayoutPanel2.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(641, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление пользователя";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textViewerName
            // 
            textViewerName.Dock = System.Windows.Forms.DockStyle.Fill;
            textViewerName.Location = new System.Drawing.Point(3, 67);
            textViewerName.Name = "textViewerName";
            textViewerName.ReadOnly = true;
            textViewerName.Size = new System.Drawing.Size(324, 26);
            textViewerName.TabIndex = 1;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(444, 242);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // SelectViewerButton
            // 
            SelectViewerButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectViewerButton.Location = new System.Drawing.Point(333, 67);
            SelectViewerButton.Name = "SelectViewerButton";
            SelectViewerButton.Size = new System.Drawing.Size(105, 27);
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
            comboMode.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            comboMode.FormattingEnabled = true;
            comboMode.Items.AddRange(new object[] { "Администратор", "Продавец", "Организатор", "Менеджер по персоналу", "Тренер", "Спортсмен" });
            comboMode.Location = new System.Drawing.Point(209, 113);
            comboMode.Name = "comboMode";
            comboMode.Size = new System.Drawing.Size(274, 26);
            comboMode.TabIndex = 28;
            // 
            // label5
            // 
            label5.Dock = System.Windows.Forms.DockStyle.Fill;
            label5.Location = new System.Drawing.Point(3, 110);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(200, 32);
            label5.TabIndex = 27;
            label5.Text = "Режим доступа:";
            label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textPassword
            // 
            textPassword.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textPassword.Location = new System.Drawing.Point(209, 81);
            textPassword.Name = "textPassword";
            textPassword.PasswordChar = '*';
            textPassword.Size = new System.Drawing.Size(211, 26);
            textPassword.TabIndex = 26;
            // 
            // label7
            // 
            label7.Dock = System.Windows.Forms.DockStyle.Fill;
            label7.Location = new System.Drawing.Point(3, 78);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(200, 32);
            label7.TabIndex = 25;
            label7.Text = "Пароль:";
            label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLogin
            // 
            textLogin.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            textLogin.Location = new System.Drawing.Point(209, 49);
            textLogin.Name = "textLogin";
            textLogin.Size = new System.Drawing.Size(211, 26);
            textLogin.TabIndex = 24;
            textLogin.Validating += TextLogin_Validating;
            // 
            // label8
            // 
            label8.Dock = System.Windows.Forms.DockStyle.Fill;
            label8.Location = new System.Drawing.Point(3, 46);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(200, 32);
            label8.TabIndex = 23;
            label8.Text = "Логин:";
            label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SelectEmployeeButton
            // 
            SelectEmployeeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectEmployeeButton.Location = new System.Drawing.Point(333, 35);
            SelectEmployeeButton.Name = "SelectEmployeeButton";
            SelectEmployeeButton.Size = new System.Drawing.Size(105, 26);
            SelectEmployeeButton.TabIndex = 30;
            SelectEmployeeButton.Text = "Выбрать";
            SelectEmployeeButton.UseVisualStyleBackColor = true;
            SelectEmployeeButton.Click += SelectEmployeeButton_Click;
            // 
            // textEmployeeName
            // 
            textEmployeeName.Dock = System.Windows.Forms.DockStyle.Fill;
            textEmployeeName.Location = new System.Drawing.Point(3, 35);
            textEmployeeName.Name = "textEmployeeName";
            textEmployeeName.ReadOnly = true;
            textEmployeeName.Size = new System.Drawing.Size(324, 26);
            textEmployeeName.TabIndex = 29;
            // 
            // SelectAthleteButton
            // 
            SelectAthleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectAthleteButton.Location = new System.Drawing.Point(333, 3);
            SelectAthleteButton.Name = "SelectAthleteButton";
            SelectAthleteButton.Size = new System.Drawing.Size(105, 26);
            SelectAthleteButton.TabIndex = 32;
            SelectAthleteButton.Text = "Выбрать";
            SelectAthleteButton.UseVisualStyleBackColor = true;
            SelectAthleteButton.Click += SelectAthleteButton_Click;
            // 
            // textAthleteName
            // 
            textAthleteName.Dock = System.Windows.Forms.DockStyle.Fill;
            textAthleteName.Location = new System.Drawing.Point(3, 3);
            textAthleteName.Name = "textAthleteName";
            textAthleteName.ReadOnly = true;
            textAthleteName.Size = new System.Drawing.Size(324, 26);
            textAthleteName.TabIndex = 31;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 32);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(200, 32);
            label2.TabIndex = 33;
            label2.Text = "Сотрудник:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 64);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(200, 33);
            label3.TabIndex = 34;
            label3.Text = "Зритель:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel1.Controls.Add(SelectAthleteButton, 1, 0);
            tableLayoutPanel1.Controls.Add(SelectEmployeeButton, 1, 1);
            tableLayoutPanel1.Controls.Add(SelectViewerButton, 1, 2);
            tableLayoutPanel1.Controls.Add(textEmployeeName, 0, 1);
            tableLayoutPanel1.Controls.Add(textViewerName, 0, 2);
            tableLayoutPanel1.Controls.Add(textAthleteName, 0, 0);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(206, 142);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(441, 97);
            tableLayoutPanel1.TabIndex = 35;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 0, 4);
            tableLayoutPanel2.Controls.Add(buttonSave, 1, 5);
            tableLayoutPanel2.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 1, 4);
            tableLayoutPanel2.Controls.Add(textLogin, 1, 1);
            tableLayoutPanel2.Controls.Add(label8, 0, 1);
            tableLayoutPanel2.Controls.Add(textPassword, 1, 2);
            tableLayoutPanel2.Controls.Add(label5, 0, 3);
            tableLayoutPanel2.Controls.Add(comboMode, 1, 3);
            tableLayoutPanel2.Controls.Add(label7, 0, 2);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel2.RowCount = 6;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(667, 306);
            tableLayoutPanel2.TabIndex = 36;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel3.Controls.Add(label1, 0, 0);
            tableLayoutPanel3.Controls.Add(label2, 0, 1);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(0, 142);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 3;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3333359F));
            tableLayoutPanel3.Size = new System.Drawing.Size(206, 97);
            tableLayoutPanel3.TabIndex = 37;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(677, 316);
            Controls.Add(tableLayoutPanel2);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "UserForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление пользователя";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
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
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}
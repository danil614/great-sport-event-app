using System.ComponentModel;

namespace GreatSportEventApp.TeamForms
{
    partial class TeamForm
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
            textLocationName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            textDescription = new System.Windows.Forms.TextBox();
            SelectLocationButton = new System.Windows.Forms.Button();
            textTeamName = new System.Windows.Forms.TextBox();
            textRating = new System.Windows.Forms.TextBox();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            label2 = new System.Windows.Forms.Label();
            textScore = new System.Windows.Forms.TextBox();
            ((ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(12, 88);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(159, 26);
            label1.TabIndex = 0;
            label1.Text = "Место проживания:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(12, 9);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(457, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление команды";
            // 
            // textLocationName
            // 
            textLocationName.Location = new System.Drawing.Point(177, 88);
            textLocationName.Name = "textLocationName";
            textLocationName.ReadOnly = true;
            textLocationName.Size = new System.Drawing.Size(342, 26);
            textLocationName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(12, 119);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 26);
            label3.TabIndex = 6;
            label3.Text = "Рейтинг:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(12, 55);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 26);
            label4.TabIndex = 9;
            label4.Text = "Название:";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Location = new System.Drawing.Point(13, 183);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 26);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(496, 418);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(129, 37);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textDescription
            // 
            textDescription.Location = new System.Drawing.Point(177, 183);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(448, 219);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // SelectLocationButton
            // 
            SelectLocationButton.Location = new System.Drawing.Point(525, 88);
            SelectLocationButton.Name = "SelectLocationButton";
            SelectLocationButton.Size = new System.Drawing.Size(100, 26);
            SelectLocationButton.TabIndex = 17;
            SelectLocationButton.Text = "Выбрать";
            SelectLocationButton.UseVisualStyleBackColor = true;
            SelectLocationButton.Click += SelectLocationButton_Click;
            // 
            // textTeamName
            // 
            textTeamName.Location = new System.Drawing.Point(177, 55);
            textTeamName.Name = "textTeamName";
            textTeamName.Size = new System.Drawing.Size(448, 26);
            textTeamName.TabIndex = 18;
            textTeamName.Validating += TextTeamName_Validating;
            // 
            // textRating
            // 
            textRating.Location = new System.Drawing.Point(177, 119);
            textRating.Name = "textRating";
            textRating.Size = new System.Drawing.Size(139, 26);
            textRating.TabIndex = 19;
            textRating.Validating += TextRating_Validating;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(13, 151);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 26);
            label2.TabIndex = 20;
            label2.Text = "Счет:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textScore
            // 
            textScore.Location = new System.Drawing.Point(177, 151);
            textScore.Name = "textScore";
            textScore.Size = new System.Drawing.Size(139, 26);
            textScore.TabIndex = 21;
            textScore.Validating += TextScore_Validating;
            // 
            // TeamForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(650, 477);
            Controls.Add(textScore);
            Controls.Add(label2);
            Controls.Add(textRating);
            Controls.Add(textTeamName);
            Controls.Add(SelectLocationButton);
            Controls.Add(textDescription);
            Controls.Add(buttonSave);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textLocationName);
            Controls.Add(labelTitle);
            Controls.Add(label1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TeamForm";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление команды";
            ((ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textLocationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion
        private System.Windows.Forms.Button SelectLocationButton;
        private System.Windows.Forms.TextBox textTeamName;
        private System.Windows.Forms.TextBox textRating;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox textScore;
        private System.Windows.Forms.Label label2;
    }
}
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.textLocationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.SelectLocationButton = new System.Windows.Forms.Button();
            this.textTeamName = new System.Windows.Forms.TextBox();
            this.textRating = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.textScore = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место проживания:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(457, 46);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Добавление команды";
            // 
            // textLocationName
            // 
            this.textLocationName.Location = new System.Drawing.Point(177, 88);
            this.textLocationName.Name = "textLocationName";
            this.textLocationName.ReadOnly = true;
            this.textLocationName.Size = new System.Drawing.Size(342, 26);
            this.textLocationName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Рейтинг:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Название:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 183);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Описание:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(469, 419);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 37);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(177, 183);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDescription.Size = new System.Drawing.Size(421, 219);
            this.textDescription.TabIndex = 6;
            this.textDescription.Validating += new System.ComponentModel.CancelEventHandler(this.TextDescription_Validating);
            // 
            // SelectLocationButton
            // 
            this.SelectLocationButton.Location = new System.Drawing.Point(525, 88);
            this.SelectLocationButton.Name = "SelectLocationButton";
            this.SelectLocationButton.Size = new System.Drawing.Size(100, 26);
            this.SelectLocationButton.TabIndex = 17;
            this.SelectLocationButton.Text = "Выбрать";
            this.SelectLocationButton.UseVisualStyleBackColor = true;
            this.SelectLocationButton.Click += new System.EventHandler(this.SelectLocationButton_Click);
            // 
            // textTeamName
            // 
            this.textTeamName.Location = new System.Drawing.Point(177, 55);
            this.textTeamName.Name = "textTeamName";
            this.textTeamName.Size = new System.Drawing.Size(448, 26);
            this.textTeamName.TabIndex = 18;
            this.textTeamName.Validating += new System.ComponentModel.CancelEventHandler(this.TextTeamName_Validating);
            // 
            // textRating
            // 
            this.textRating.Location = new System.Drawing.Point(177, 119);
            this.textRating.Name = "textRating";
            this.textRating.Size = new System.Drawing.Size(139, 26);
            this.textRating.TabIndex = 19;
            this.textRating.Validating += new System.ComponentModel.CancelEventHandler(this.TextRating_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 20;
            this.label2.Text = "Счет:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textScore
            // 
            this.textScore.Location = new System.Drawing.Point(177, 151);
            this.textScore.Name = "textScore";
            this.textScore.Size = new System.Drawing.Size(139, 26);
            this.textScore.TabIndex = 21;
            this.textScore.Validating += new System.ComponentModel.CancelEventHandler(this.TextScore_Validating);
            // 
            // TeamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(644, 467);
            this.Controls.Add(this.textScore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textRating);
            this.Controls.Add(this.textTeamName);
            this.Controls.Add(this.SelectLocationButton);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLocationName);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TeamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление команды";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
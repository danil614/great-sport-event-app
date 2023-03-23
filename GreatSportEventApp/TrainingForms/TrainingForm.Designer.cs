using System.ComponentModel;

namespace GreatSportEventApp.TrainingForms
{
    partial class TrainingForm
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
            label2 = new System.Windows.Forms.Label();
            textLocationName = new System.Windows.Forms.TextBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            buttonSave = new System.Windows.Forms.Button();
            textDescription = new System.Windows.Forms.TextBox();
            dateTimeEvent = new System.Windows.Forms.DateTimePicker();
            duration = new System.Windows.Forms.DateTimePicker();
            SelectLocationButton = new System.Windows.Forms.Button();
            errorProvider1 = new System.Windows.Forms.ErrorProvider(components);
            tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            textTeamName = new System.Windows.Forms.TextBox();
            SelectTeamButton = new System.Windows.Forms.Button();
            ((ISupportInitialize)errorProvider1).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Dock = System.Windows.Forms.DockStyle.Fill;
            label1.Location = new System.Drawing.Point(3, 78);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(132, 32);
            label1.TabIndex = 0;
            label1.Text = "Место:";
            label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            tableLayoutPanel1.SetColumnSpan(labelTitle, 2);
            labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            labelTitle.Location = new System.Drawing.Point(3, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new System.Drawing.Size(693, 46);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Добавление тренировки";
            labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.Dock = System.Windows.Forms.DockStyle.Fill;
            label2.Location = new System.Drawing.Point(3, 142);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(132, 32);
            label2.TabIndex = 3;
            label2.Text = "Длительность:";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLocationName
            // 
            textLocationName.Dock = System.Windows.Forms.DockStyle.Fill;
            textLocationName.Location = new System.Drawing.Point(3, 3);
            textLocationName.Name = "textLocationName";
            textLocationName.ReadOnly = true;
            textLocationName.Size = new System.Drawing.Size(414, 26);
            textLocationName.TabIndex = 1;
            // 
            // label3
            // 
            label3.Dock = System.Windows.Forms.DockStyle.Fill;
            label3.Location = new System.Drawing.Point(3, 110);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(132, 32);
            label3.TabIndex = 6;
            label3.Text = "Начало:";
            label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            label4.Dock = System.Windows.Forms.DockStyle.Fill;
            label4.Location = new System.Drawing.Point(3, 46);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(132, 32);
            label4.TabIndex = 9;
            label4.Text = "Команда";
            label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Dock = System.Windows.Forms.DockStyle.Fill;
            label6.Location = new System.Drawing.Point(3, 174);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(132, 225);
            label6.TabIndex = 13;
            label6.Text = "Описание:";
            label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            buttonSave.Location = new System.Drawing.Point(496, 402);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new System.Drawing.Size(200, 50);
            buttonSave.TabIndex = 14;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // textDescription
            // 
            textDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            textDescription.Location = new System.Drawing.Point(141, 177);
            textDescription.Multiline = true;
            textDescription.Name = "textDescription";
            textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            textDescription.Size = new System.Drawing.Size(555, 219);
            textDescription.TabIndex = 6;
            textDescription.Validating += TextDescription_Validating;
            // 
            // dateTimeEvent
            // 
            dateTimeEvent.AllowDrop = true;
            dateTimeEvent.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            dateTimeEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            dateTimeEvent.Location = new System.Drawing.Point(141, 113);
            dateTimeEvent.Name = "dateTimeEvent";
            dateTimeEvent.Size = new System.Drawing.Size(207, 26);
            dateTimeEvent.TabIndex = 15;
            dateTimeEvent.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // duration
            // 
            duration.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left;
            duration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            duration.Location = new System.Drawing.Point(141, 145);
            duration.Name = "duration";
            duration.Size = new System.Drawing.Size(125, 26);
            duration.TabIndex = 16;
            duration.Value = new System.DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // SelectLocationButton
            // 
            SelectLocationButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SelectLocationButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectLocationButton.Location = new System.Drawing.Point(423, 3);
            SelectLocationButton.Name = "SelectLocationButton";
            SelectLocationButton.Size = new System.Drawing.Size(135, 26);
            SelectLocationButton.TabIndex = 17;
            SelectLocationButton.Text = "Выбрать";
            SelectLocationButton.UseVisualStyleBackColor = true;
            SelectLocationButton.Click += SelectLocationButton_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 1, 2);
            tableLayoutPanel1.Controls.Add(textDescription, 1, 5);
            tableLayoutPanel1.Controls.Add(duration, 1, 4);
            tableLayoutPanel1.Controls.Add(label6, 0, 5);
            tableLayoutPanel1.Controls.Add(dateTimeEvent, 1, 3);
            tableLayoutPanel1.Controls.Add(label4, 0, 1);
            tableLayoutPanel1.Controls.Add(label2, 0, 4);
            tableLayoutPanel1.Controls.Add(label1, 0, 2);
            tableLayoutPanel1.Controls.Add(label3, 0, 3);
            tableLayoutPanel1.Controls.Add(labelTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(buttonSave, 1, 6);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 1, 1);
            tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel1.Location = new System.Drawing.Point(5, 5);
            tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 0, 20, 0);
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel1.Size = new System.Drawing.Size(719, 462);
            tableLayoutPanel1.TabIndex = 18;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(textLocationName, 0, 0);
            tableLayoutPanel2.Controls.Add(SelectLocationButton, 1, 0);
            tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel2.Location = new System.Drawing.Point(138, 78);
            tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel2.Size = new System.Drawing.Size(561, 32);
            tableLayoutPanel2.TabIndex = 19;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 75F));
            tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            tableLayoutPanel3.Controls.Add(textTeamName, 0, 0);
            tableLayoutPanel3.Controls.Add(SelectTeamButton, 1, 0);
            tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            tableLayoutPanel3.Location = new System.Drawing.Point(138, 46);
            tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle());
            tableLayoutPanel3.Size = new System.Drawing.Size(561, 32);
            tableLayoutPanel3.TabIndex = 20;
            // 
            // textTeamName
            // 
            textTeamName.Dock = System.Windows.Forms.DockStyle.Fill;
            textTeamName.Location = new System.Drawing.Point(3, 3);
            textTeamName.Name = "textTeamName";
            textTeamName.ReadOnly = true;
            textTeamName.Size = new System.Drawing.Size(414, 26);
            textTeamName.TabIndex = 1;
            // 
            // SelectTeamButton
            // 
            SelectTeamButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            SelectTeamButton.Dock = System.Windows.Forms.DockStyle.Fill;
            SelectTeamButton.Location = new System.Drawing.Point(423, 3);
            SelectTeamButton.Name = "SelectTeamButton";
            SelectTeamButton.Size = new System.Drawing.Size(135, 26);
            SelectTeamButton.TabIndex = 17;
            SelectTeamButton.Text = "Выбрать";
            SelectTeamButton.UseVisualStyleBackColor = true;
            SelectTeamButton.Click += SelectTeamButton_Click;
            // 
            // TrainingForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            ClientSize = new System.Drawing.Size(729, 472);
            Controls.Add(tableLayoutPanel1);
            Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            Margin = new System.Windows.Forms.Padding(4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TrainingForm";
            Padding = new System.Windows.Forms.Padding(5);
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Добавление тренировки";
            ((ISupportInitialize)errorProvider1).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textLocationName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTitle;

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimeEvent;
        private System.Windows.Forms.DateTimePicker duration;
        private System.Windows.Forms.Button SelectLocationButton;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TextBox textTeamName;
        private System.Windows.Forms.Button SelectTeamButton;
    }
}
using System.ComponentModel;

namespace GreatSportEventApp.SportEventForms
{
    partial class SportEventForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.labelTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textLocationName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.comboType = new System.Windows.Forms.ComboBox();
            this.textDescription = new System.Windows.Forms.TextBox();
            this.dateTimeEvent = new System.Windows.Forms.DateTimePicker();
            this.duration = new System.Windows.Forms.DateTimePicker();
            this.SelectLocationButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Место:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelTitle
            // 
            this.labelTitle.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle.Location = new System.Drawing.Point(12, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(457, 46);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Добавление спортивного мероприятия";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 152);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 26);
            this.label2.TabIndex = 3;
            this.label2.Text = "Длительность:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // textLocationName
            // 
            this.textLocationName.Location = new System.Drawing.Point(150, 88);
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
            this.label3.Text = "Начало:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Тип:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(13, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 26);
            this.label6.TabIndex = 13;
            this.label6.Text = "Описание:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonSave
            // 
            this.buttonSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(469, 422);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(129, 37);
            this.buttonSave.TabIndex = 14;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // comboType
            // 
            this.comboType.FormattingEnabled = true;
            this.comboType.Location = new System.Drawing.Point(150, 55);
            this.comboType.Name = "comboType";
            this.comboType.Size = new System.Drawing.Size(448, 26);
            this.comboType.TabIndex = 4;
            // 
            // textDescription
            // 
            this.textDescription.Location = new System.Drawing.Point(150, 184);
            this.textDescription.Multiline = true;
            this.textDescription.Name = "textDescription";
            this.textDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textDescription.Size = new System.Drawing.Size(448, 219);
            this.textDescription.TabIndex = 6;
            // 
            // dateTimeEvent
            // 
            this.dateTimeEvent.AllowDrop = true;
            this.dateTimeEvent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeEvent.Location = new System.Drawing.Point(150, 120);
            this.dateTimeEvent.Name = "dateTimeEvent";
            this.dateTimeEvent.Size = new System.Drawing.Size(196, 26);
            this.dateTimeEvent.TabIndex = 15;
            this.dateTimeEvent.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // duration
            // 
            this.duration.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.duration.Location = new System.Drawing.Point(150, 152);
            this.duration.Name = "duration";
            this.duration.Size = new System.Drawing.Size(123, 26);
            this.duration.TabIndex = 16;
            this.duration.Value = new System.DateTime(2023, 3, 13, 0, 0, 0, 0);
            // 
            // SelectLocationButton
            // 
            this.SelectLocationButton.Location = new System.Drawing.Point(498, 87);
            this.SelectLocationButton.Name = "SelectLocationButton";
            this.SelectLocationButton.Size = new System.Drawing.Size(100, 26);
            this.SelectLocationButton.TabIndex = 17;
            this.SelectLocationButton.Text = "Выбрать";
            this.SelectLocationButton.UseVisualStyleBackColor = true;
            this.SelectLocationButton.Click += new System.EventHandler(this.SelectLocationButton_Click);
            // 
            // SportEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 471);
            this.Controls.Add(this.SelectLocationButton);
            this.Controls.Add(this.duration);
            this.Controls.Add(this.dateTimeEvent);
            this.Controls.Add(this.textDescription);
            this.Controls.Add(this.comboType);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textLocationName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SportEventForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление спортивного мероприятия";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox textDescription;
        private System.Windows.Forms.ComboBox comboType;
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
    }
}
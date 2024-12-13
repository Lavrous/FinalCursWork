namespace FinalCursWork
{
    partial class ProfitComparisonForm
    {
        private System.ComponentModel.IContainer components = null;
        private DateTimePicker datePickerStart1;
        private DateTimePicker datePickerEnd1;
        private DateTimePicker datePickerStart2;
        private DateTimePicker datePickerEnd2;
        private Button buttonCompare;
        private Label labelPeriod1;
        private Label labelPeriod2;

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
            datePickerStart1 = new DateTimePicker();
            datePickerEnd1 = new DateTimePicker();
            datePickerStart2 = new DateTimePicker();
            datePickerEnd2 = new DateTimePicker();
            buttonCompare = new Button();
            labelPeriod1 = new Label();
            labelPeriod2 = new Label();
            SuspendLayout();
            // 
            // labelPeriod1
            // 
            labelPeriod1.AutoSize = true;
            labelPeriod1.Location = new System.Drawing.Point(20, 20);
            labelPeriod1.Name = "labelPeriod1";
            labelPeriod1.Size = new System.Drawing.Size(150, 20);
            labelPeriod1.TabIndex = 0;
            labelPeriod1.Text = "Первый период:";
            // 
            // datePickerStart1
            // 
            datePickerStart1.Location = new System.Drawing.Point(20, 50);
            datePickerStart1.Name = "datePickerStart1";
            datePickerStart1.Size = new System.Drawing.Size(200, 27);
            datePickerStart1.TabIndex = 1;
            // 
            // datePickerEnd1
            // 
            datePickerEnd1.Location = new System.Drawing.Point(230, 50);
            datePickerEnd1.Name = "datePickerEnd1";
            datePickerEnd1.Size = new System.Drawing.Size(200, 27);
            datePickerEnd1.TabIndex = 2;
            // 
            // labelPeriod2
            // 
            labelPeriod2.AutoSize = true;
            labelPeriod2.Location = new System.Drawing.Point(20, 100);
            labelPeriod2.Name = "labelPeriod2";
            labelPeriod2.Size = new System.Drawing.Size(150, 20);
            labelPeriod2.TabIndex = 3;
            labelPeriod2.Text = "Второй период:";
            // 
            // datePickerStart2
            // 
            datePickerStart2.Location = new System.Drawing.Point(20, 130);
            datePickerStart2.Name = "datePickerStart2";
            datePickerStart2.Size = new System.Drawing.Size(200, 27);
            datePickerStart2.TabIndex = 4;
            // 
            // datePickerEnd2
            // 
            datePickerEnd2.Location = new System.Drawing.Point(230, 130);
            datePickerEnd2.Name = "datePickerEnd2";
            datePickerEnd2.Size = new System.Drawing.Size(200, 27);
            datePickerEnd2.TabIndex = 5;
            // 
            // buttonCompare
            // 
            buttonCompare.Location = new System.Drawing.Point(20, 180);
            buttonCompare.Name = "buttonCompare";
            buttonCompare.Size = new System.Drawing.Size(410, 40);
            buttonCompare.TabIndex = 6;
            buttonCompare.Text = "Сравнить";
            buttonCompare.UseVisualStyleBackColor = true;
            buttonCompare.Click += ButtonCompare_Click;
            // 
            // ProfitComparisonForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(450, 250);
            Controls.Add(buttonCompare);
            Controls.Add(labelPeriod2);
            Controls.Add(datePickerEnd2);
            Controls.Add(datePickerStart2);
            Controls.Add(labelPeriod1);
            Controls.Add(datePickerEnd1);
            Controls.Add(datePickerStart1);
            Name = "ProfitComparisonForm";
            Text = "Сравнение прибыли";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion
    }
}
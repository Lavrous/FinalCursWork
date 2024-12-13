using static System.Net.Mime.MediaTypeNames;
using System.Drawing.Printing;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FinalCursWork
{
    partial class BuySellForm2
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxRequests;
        private System.Windows.Forms.Button buttonSelectRequest;




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
            richTextBoxRequests = new RichTextBox();
            buttonSelectRequest = new Button();
            nudRequestIndex = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudRequestIndex).BeginInit();
            SuspendLayout();
            // 
            // richTextBoxRequests
            // 
            richTextBoxRequests.Location = new Point(14, 103);
            richTextBoxRequests.Margin = new Padding(3, 4, 3, 4);
            richTextBoxRequests.Name = "richTextBoxRequests";
            richTextBoxRequests.ReadOnly = true;
            richTextBoxRequests.ScrollBars = RichTextBoxScrollBars.Vertical;
            richTextBoxRequests.Size = new Size(878, 317);
            richTextBoxRequests.TabIndex = 0;
            richTextBoxRequests.Text = "";
            // 
            // buttonSelectRequest
            // 
            buttonSelectRequest.Location = new Point(256, 465);
            buttonSelectRequest.Margin = new Padding(3, 4, 3, 4);
            buttonSelectRequest.Name = "buttonSelectRequest";
            buttonSelectRequest.Size = new Size(411, 31);
            buttonSelectRequest.TabIndex = 1;
            buttonSelectRequest.Text = "Выбрать заявку";
            buttonSelectRequest.UseVisualStyleBackColor = true;
            buttonSelectRequest.Click += buttonSelectRequest_Click;
            // 
            // nudRequestIndex
            // 
            nudRequestIndex.Location = new Point(391, 34);
            nudRequestIndex.Name = "nudRequestIndex";
            nudRequestIndex.Size = new Size(150, 27);
            nudRequestIndex.TabIndex = 2;
            // 
            // BuySellForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(987, 522);
            Controls.Add(nudRequestIndex);
            Controls.Add(buttonSelectRequest);
            Controls.Add(richTextBoxRequests);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BuySellForm2";
            Text = "Выбор заявки";
            ((System.ComponentModel.ISupportInitialize)nudRequestIndex).EndInit();
            ResumeLayout(false);
        }
        #endregion
        private NumericUpDown nudRequestIndex;
    }
}
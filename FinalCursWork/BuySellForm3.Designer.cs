namespace FinalCursWork
{
    partial class BuySellForm3
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.RichTextBox richTextBoxMatchingRequests;
        private System.Windows.Forms.NumericUpDown nudMatchingRequestIndex;
        private System.Windows.Forms.Button buttonConfirmSelection;
        /// <summary>
        /// Освобождение ресурсов.
        /// </summary>
        /// <param name="disposing"></param>
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
            richTextBoxMatchingRequests = new RichTextBox();
            nudMatchingRequestIndex = new NumericUpDown();
            buttonConfirmSelection = new Button();
            ((System.ComponentModel.ISupportInitialize)nudMatchingRequestIndex).BeginInit();
            SuspendLayout();
            // 
            // richTextBoxMatchingRequests
            // 
            richTextBoxMatchingRequests.Location = new Point(176, 83);
            richTextBoxMatchingRequests.Name = "richTextBoxMatchingRequests";
            richTextBoxMatchingRequests.ReadOnly = true;
            richTextBoxMatchingRequests.Size = new Size(640, 322);
            richTextBoxMatchingRequests.TabIndex = 0;
            richTextBoxMatchingRequests.Text = "";
            // 
            // nudMatchingRequestIndex
            // 
            nudMatchingRequestIndex.Location = new Point(412, 25);
            nudMatchingRequestIndex.Name = "nudMatchingRequestIndex";
            nudMatchingRequestIndex.Size = new Size(174, 27);
            nudMatchingRequestIndex.TabIndex = 1;
            // 
            // buttonConfirmSelection
            // 
            buttonConfirmSelection.Location = new Point(295, 421);
            buttonConfirmSelection.Name = "buttonConfirmSelection";
            buttonConfirmSelection.Size = new Size(378, 62);
            buttonConfirmSelection.TabIndex = 2;
            buttonConfirmSelection.Text = "Завершить сделку";
            buttonConfirmSelection.UseVisualStyleBackColor = true;
            buttonConfirmSelection.Click += ButtonConfirmSelection_Click;
            // 
            // BuySellForm3
            // 
            ClientSize = new Size(954, 542);
            Controls.Add(richTextBoxMatchingRequests);
            Controls.Add(nudMatchingRequestIndex);
            Controls.Add(buttonConfirmSelection);
            Name = "BuySellForm3";
            Text = "Подходящие заявки";
            ((System.ComponentModel.ISupportInitialize)nudMatchingRequestIndex).EndInit();
            ResumeLayout(false);
        }
        #endregion
    }
}
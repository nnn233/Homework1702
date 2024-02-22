namespace Homework1702
{
    partial class TextEditorForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            richTextBox = new RichTextBox();
            buttonOpen = new Button();
            buttonSave = new Button();
            textBoxSearch = new TextBox();
            buttonSearch = new Button();
            buttonReplace = new Button();
            textBoxReplace = new TextBox();
            checkedListBox = new CheckedListBox();
            buttonApplyStyle = new Button();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.BackColor = SystemColors.Window;
            richTextBox.Location = new Point(47, 66);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(955, 598);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(1025, 66);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(150, 29);
            buttonOpen.TabIndex = 1;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(1025, 126);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(150, 29);
            buttonSave.TabIndex = 2;
            buttonSave.Text = "Сохранить файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // textBoxSearch
            // 
            textBoxSearch.Location = new Point(1025, 204);
            textBoxSearch.Multiline = true;
            textBoxSearch.Name = "textBoxSearch";
            textBoxSearch.Size = new Size(150, 60);
            textBoxSearch.TabIndex = 3;
            // 
            // buttonSearch
            // 
            buttonSearch.Location = new Point(1025, 285);
            buttonSearch.Name = "buttonSearch";
            buttonSearch.Size = new Size(150, 29);
            buttonSearch.TabIndex = 4;
            buttonSearch.Text = "Искать в тексте";
            buttonSearch.UseVisualStyleBackColor = true;
            buttonSearch.Click += buttonSearch_Click;
            // 
            // buttonReplace
            // 
            buttonReplace.Enabled = false;
            buttonReplace.Location = new Point(1025, 425);
            buttonReplace.Name = "buttonReplace";
            buttonReplace.Size = new Size(150, 29);
            buttonReplace.TabIndex = 6;
            buttonReplace.Text = "Заменить";
            buttonReplace.UseVisualStyleBackColor = true;
            buttonReplace.Click += buttonReplace_Click;
            // 
            // textBoxReplace
            // 
            textBoxReplace.Location = new Point(1025, 344);
            textBoxReplace.Multiline = true;
            textBoxReplace.Name = "textBoxReplace";
            textBoxReplace.Size = new Size(150, 60);
            textBoxReplace.TabIndex = 5;
            // 
            // checkedListBox
            // 
            checkedListBox.FormattingEnabled = true;
            checkedListBox.Items.AddRange(new object[] { "жирный", "курсив", "подчеркнутый", "перечеркнутый" });
            checkedListBox.Location = new Point(1025, 516);
            checkedListBox.Name = "checkedListBox";
            checkedListBox.Size = new Size(150, 92);
            checkedListBox.TabIndex = 7;
            // 
            // buttonApplyStyle
            // 
            buttonApplyStyle.Location = new Point(1025, 625);
            buttonApplyStyle.Name = "buttonApplyStyle";
            buttonApplyStyle.Size = new Size(150, 29);
            buttonApplyStyle.TabIndex = 8;
            buttonApplyStyle.Text = "Применить";
            buttonApplyStyle.UseVisualStyleBackColor = true;
            buttonApplyStyle.Click += buttonApplyStyle_Click;
            // 
            // TextEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1187, 689);
            Controls.Add(buttonApplyStyle);
            Controls.Add(checkedListBox);
            Controls.Add(buttonReplace);
            Controls.Add(textBoxReplace);
            Controls.Add(buttonSearch);
            Controls.Add(textBoxSearch);
            Controls.Add(buttonSave);
            Controls.Add(buttonOpen);
            Controls.Add(richTextBox);
            Name = "TextEditorForm";
            Text = "Редактор текста";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox;
        private Button buttonOpen;
        private Button buttonSave;
        private TextBox textBoxSearch;
        private Button buttonSearch;
        private Button buttonReplace;
        private TextBox textBoxReplace;
        private CheckedListBox checkedListBox;
        private Button buttonApplyStyle;
    }
}
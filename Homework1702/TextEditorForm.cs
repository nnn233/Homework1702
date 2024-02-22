namespace Homework1702
{
    public partial class TextEditorForm : Form
    {
        string filename = null;
        public TextEditorForm()
        {
            InitializeComponent();
            richTextBox.MouseDown += richTextBox_MouseDown;
            FormClosed += TextEditorForm_FormClosed;
        }

        private void TextEditorForm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            DialogResult result = MessageBox.Show("У вас остались несохраненные изменения, сохранить перед выходом?", "Сохранение изменений", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (filename != null)
                    File.WriteAllText(filename, richTextBox.Text);
                else Save();
            }

            Application.Exit();
        }

        private void Save()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "(*.txt)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string fileName = saveFileDialog.FileName;
            filename = fileName;
            File.WriteAllText(fileName, richTextBox.Text);
            MessageBox.Show("Файл успешно сохранен", "Сохранение файла", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            richTextBox.Clear();
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "(*.txt)|*.txt";
            if (dialog.ShowDialog() == DialogResult.Cancel)
                return;
            var fileName = dialog.FileName;
            filename = fileName;
            string fileText = File.ReadAllText(fileName);
            richTextBox.Text = fileText;
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void richTextBox_MouseDown(object? sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                ContextMenuStrip contextMenu = new System.Windows.Forms.ContextMenuStrip();
                ToolStripMenuItem menuItem = new("Вырезать");
                menuItem.Click += new EventHandler(CutAction);
                contextMenu.Items.Add(menuItem);
                menuItem = new("Копировать");
                menuItem.Click += new EventHandler(CopyAction);
                contextMenu.Items.Add(menuItem);
                menuItem = new("Вставить");
                menuItem.Click += new EventHandler(PasteAction);
                contextMenu.Items.Add(menuItem);

                richTextBox.ContextMenuStrip = contextMenu;
            }
        }

        void CutAction(object? sender, EventArgs e)
        {
            richTextBox.Cut();
        }

        void CopyAction(object? sender, EventArgs e)
        {
            Clipboard.SetText(richTextBox.SelectedText);
        }

        void PasteAction(object? sender, EventArgs e)
        {
            if (Clipboard.ContainsText())
            {
                richTextBox.Text
                    += Clipboard.GetText(TextDataFormat.Text).ToString();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            richTextBox.SelectAll();
            richTextBox.SelectionBackColor = SystemColors.Window;
            richTextBox.DeselectAll();
            string find = textBoxSearch.Text;
            if (richTextBox.Text.Contains(find))
            {
                int index = 0;
                var temp = richTextBox.Text;
                richTextBox.Text = "";
                richTextBox.Text = temp;

                while (index < richTextBox.Text.LastIndexOf(textBoxSearch.Text))
                {
                    richTextBox.Find(textBoxSearch.Text, index, richTextBox.TextLength, RichTextBoxFinds.None);
                    richTextBox.SelectionBackColor = Color.Yellow;

                    index = richTextBox.Text.IndexOf(textBoxSearch.Text, index) + 1;
                }
                buttonReplace.Enabled = true;
            }
            else
                MessageBox.Show("Совпадений не найдено");
        }

        private void buttonReplace_Click(object sender, EventArgs e)
        {
            richTextBox.Text = richTextBox.Text.Replace(textBoxSearch.Text, textBoxReplace.Text);
        }

        private void buttonApplyStyle_Click(object sender, EventArgs e)
        {
            if (richTextBox.SelectedText != null)
            {
                if (checkedListBox.CheckedIndices.Contains(0))
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Bold);
                if (checkedListBox.CheckedIndices.Contains(1))
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Italic);
                if (checkedListBox.CheckedIndices.Contains(2))
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Underline);
                if (checkedListBox.CheckedIndices.Contains(3))
                    richTextBox.SelectionFont = new Font(richTextBox.SelectionFont, richTextBox.SelectionFont.Style | FontStyle.Strikeout);
            }
        }
    }
}
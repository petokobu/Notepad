namespace Notepad
{
    public partial class Form1 : Form
    {
#nullable enable
        private string? currentFile = null;
        private bool isFileSaved = false;
#nullable disable

        public Form1(string[] args)
        {
            InitializeComponent();

            // If a file was passed as an argument, open it
            if (args.Length > 0 && File.Exists(args[0]))
            {
                textBox2.Text = File.ReadAllText(args[0]);
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text Files|*.txt|Json Files|*.json|XML Files|*.xml|All Files|*.*";
            fileDialog.ShowDialog();
            if (fileDialog.FileName != "")
            {
                textBox2.Text = File.ReadAllText(fileDialog.FileName);
                currentFile = fileDialog.FileName;

                this.Text = $"Notepad - {Path.GetFileName(currentFile)}";
            }

            isFileSaved = true;
        }

        private void saveAsFileItemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Text Files|*.txt|Json Files|*.json|XML Files|*.xml|All Files|*.*";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                File.WriteAllText(saveFileDialog.FileName, textBox2.Text);
                currentFile = saveFileDialog.FileName;

                this.Text = $"Notepad - {Path.GetFileName(currentFile)}";
            }

            isFileSaved = true;
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                File.WriteAllText(currentFile, textBox2.Text);
                this.Text = $"Notepad - {Path.GetFileName(currentFile)}";
            }
            else
            {
                saveAsFileItemToolStripMenuItem_Click(sender, e);
            }

            isFileSaved = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isFileSaved && textBox2.Text.Length > 0)
            {
                var result = MessageBox.Show("Do you want to save changes to your document?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                    textBox2.Clear();
                    currentFile = null;
                    this.Text = "Notepad - untilted";
                }
                else if (result == DialogResult.No)
                {
                    textBox2.Clear();
                    currentFile = null;
                    this.Text = "Notepad - untilted";
                }
            }
            else
            {
                textBox2.Clear();
                currentFile = null;
                this.Text = "Notepad - untilted";
            }

            isFileSaved = false;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (currentFile != null)
            {
                this.Text = $"Notepad - {Path.GetFileName(currentFile)}*";
            }
            else
            {
                this.Text = "Notepad - untilted*";
            }

            isFileSaved = false;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!isFileSaved && textBox2.Text.Length > 0)
            {
                var result = MessageBox.Show("Do you want to save changes to your document?", "Notepad", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    saveToolStripMenuItem_Click(sender, e);
                }
                else if (result == DialogResult.Cancel)
                {
                    e.Cancel = true;
                }
            }
        }
    }
}

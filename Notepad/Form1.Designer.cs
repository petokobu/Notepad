using System.Windows.Forms;

namespace Notepad
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            toolStrip1 = new ToolStrip();
            toolStripDropDownButton1 = new ToolStripDropDownButton();
            newToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            saveAsFileItemToolStripMenuItem = new ToolStripMenuItem();
            textBox2 = new TextBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripDropDownButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 25);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            toolStripDropDownButton1.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, openFileToolStripMenuItem, toolStripMenuItem1, saveAsFileItemToolStripMenuItem });
            toolStripDropDownButton1.Image = (Image)resources.GetObject("toolStripDropDownButton1.Image");
            toolStripDropDownButton1.ImageTransparentColor = Color.Magenta;
            toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            toolStripDropDownButton1.Size = new Size(54, 22);
            toolStripDropDownButton1.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Image = (Image)resources.GetObject("newToolStripMenuItem.Image");
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + N";
            newToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            newToolStripMenuItem.Size = new Size(180, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Image = (Image)resources.GetObject("openFileToolStripMenuItem.Image");
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + O";
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "Open";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = (Image)resources.GetObject("toolStripMenuItem1.Image");
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.ShortcutKeyDisplayString = "Ctrl + S";
            toolStripMenuItem1.ShortcutKeys = Keys.Control | Keys.S;
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "Save";
            toolStripMenuItem1.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsFileItemToolStripMenuItem
            // 
            saveAsFileItemToolStripMenuItem.Image = (Image)resources.GetObject("saveAsFileItemToolStripMenuItem.Image");
            saveAsFileItemToolStripMenuItem.Name = "saveAsFileItemToolStripMenuItem";
            saveAsFileItemToolStripMenuItem.Size = new Size(180, 22);
            saveAsFileItemToolStripMenuItem.Text = "Save as";
            saveAsFileItemToolStripMenuItem.Click += saveAsFileItemToolStripMenuItem_Click;
            // 
            // textBox2
            // 
            textBox2.AcceptsReturn = true;
            textBox2.AcceptsTab = true;
            textBox2.AllowDrop = true;
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(0, 25);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.ScrollBars = ScrollBars.Vertical;
            textBox2.Size = new Size(800, 425);
            textBox2.TabIndex = 1;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(toolStrip1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Notepad - untilted";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
            this.FormClosing += new FormClosingEventHandler(this.Form1_FormClosing);
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem saveAsFileItemToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private TextBox textBox2;
    }
}

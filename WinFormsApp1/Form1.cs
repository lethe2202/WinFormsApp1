namespace WinFormsApp1
{
    public partial class Form1 : Form
    {

        bool b = false;
        bool s = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
           
            
                mainwrite.SaveFile(saveFileDialog1.FileName);
            



        }

        private void ճ��ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainwrite.Paste();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void ���ΪToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                mainwrite.SaveFile(saveFileDialog1.FileName);
            };

        }

        private void help_Click(object sender, EventArgs e)
        {

        }

        private void copy_Click(object sender, EventArgs e)
        {
            mainwrite.Copy();
            
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (b == true || mainwrite.Text.Trim() != "")
            {
                if (s == false)
                {
                    string result;
                    result = MessageBox.Show("�ļ���δ����,�Ƿ񱣴�?",
                        "�����ļ�", MessageBoxButtons.YesNoCancel).ToString();
                    switch (result)
                    {
                        case "Yes":
                            if (b == true)
                            {
                                mainwrite.SaveFile(openFileDialog1.FileName);
                            }
                            else if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                            {
                                mainwrite.SaveFile(saveFileDialog1.FileName);
                            }
                            s = true;
                            break;
                        case "No":
                            b = false;
                            mainwrite.Text = "";
                            break;
                    }
                }
            }
            openFileDialog1.RestoreDirectory = true;
            if ((openFileDialog1.ShowDialog() == DialogResult.OK) && openFileDialog1.FileName != "")
            {
                mainwrite.LoadFile(openFileDialog1.FileName);//�򿪴������
                b = true;
            }
            s = true;
        }
    }
}
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ChickensDAoCUICopy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("You must provide a character to copy from.");
                return;
            }
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("You must provide a character to copy to.");
                return;
            }
            string copyfrompath = comboBox1.Text;
            string copytopath = comboBox2.Text;
            string toserverid = ServerInfo.serverId[copytopath];
            string fromserverid = ServerInfo.serverId[copyfrompath];
            string appdatagetter = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            CultureInfo cultureInfo = System.Threading.Thread.CurrentThread.CurrentCulture;
            TextInfo textInfo = cultureInfo.TextInfo;
            textBox1.Text = textInfo.ToTitleCase(textBox1.Text);
            textBox2.Text = textInfo.ToTitleCase(textBox2.Text);
            if (System.IO.File.Exists($"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\{copyfrompath}\\{textBox1.Text}{fromserverid}"))
            {
                if (System.IO.File.Exists($"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\{copytopath}\\{textBox2.Text}{toserverid}"))
                {
                    System.IO.File.Delete($"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\{copytopath}\\{textBox2.Text}{toserverid}");
                }
                string filetocopy = $"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\{copyfrompath}\\{textBox1.Text}{fromserverid}";
                string targetfile = $"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\{copytopath}\\{textBox2.Text}{toserverid}";
                System.IO.File.Copy(filetocopy, targetfile);
                MessageBox.Show($"Copy from {textBox1.Text} to {textBox2.Text} is a sucess!");
            }
            else
            {
                MessageBox.Show($"{textBox1.Text} does not seem to exsist. Please check spelling.");
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Step 1: Enter Name of character you wish to copy the UI from and to.\n\nStep 2: Set the server you are copying the UI data from and to.\n\nStep 3: Hit Copy.\n\n This can be done at the character select screen.");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string appdatagetter = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            System.Diagnostics.Process.Start($"{appdatagetter}\\Electronic Arts\\Dark Age of Camelot\\");
        }
    }
}

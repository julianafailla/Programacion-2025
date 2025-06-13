using ClassLibrary1;

namespace patronIterator
{
    public partial class Form1 : Form
    {
        StringIterator stringIterator = new StringIterator();

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.ShowDialog();

            //.....

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // me creo el iterador
            stringIterator.setiteraObj(textBox1.Text);
            /*
            int conta = 0; 

            do { 
                if (stringIterator.Next() == ' ')
                {
                    conta++;
                }
            
            } while (stringIterator.HasNext());

            MessageBox.Show(conta.ToString());
            */
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringIterator.Next().ToString());

        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show(stringIterator.Prior().ToString());

        }

        private void button5_Click(object sender, EventArgs e)
        {
            stringIterator.GoFirst();

        }

        private void button6_Click(object sender, EventArgs e)
        {
            stringIterator.GoLast();
        }
    }
}

namespace OOP_Lb15._7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.textBox1.KeyPress += new KeyPressEventHandler(textBox1_KeyPress);

        }
        private void textBox1_KeyPress(object? sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >='0'&& e.KeyChar <= '9') { e.Handled = true; }

            if (e.KeyChar == (char)Keys.Enter)
            {
                button1.PerformClick();

            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
           int k=0;
           string Text = textBox1.Text;
           string[] words = Text.Split(' ');
           ;
            
           char[] letters = words[words.Length-1].ToCharArray();
           
           foreach (var letter in letters)
           {
                if (letter == 'к' || letter == 'k' || letter == 'K' || letter == 'К')
                {
                    k++;
                }
           }
            label1.Text = "Кількість букв К(k) в останньому слові: "+k;
        }

        
    }
}

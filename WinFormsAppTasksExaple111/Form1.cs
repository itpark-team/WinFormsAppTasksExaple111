namespace WinFormsAppTasksExaple111
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int i = 0;

        private void doubleText(string s)
        {
            Thread.Sleep(5000);
            MessageBox.Show(s + s);
        }

        private async Task doubleTextAsync(string s)
        {
            await Task.Run(() => { doubleText(s); });
        }


        private string funcDoubleText(string s)
        {
            Thread.Sleep(5000);
            return s + s;
        }


        private async void button1_Click(object sender, EventArgs e)
        {
            i++;
            this.Text = $"STARTED {i}";
            //await doubleTextAsync(textBox1.Text);
            //doubleText(textBox1.Text);

            string res = await Task.Run(() => funcDoubleText(textBox1.Text));

            MessageBox.Show(res);

            this.Text = $"DONE {i}";
        }
    }
}
namespace WinFormsApp12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void OpenForm2Button_Click(object sender, EventArgs e)
        {
            Person person = new Person
            {
                Name = nameTextBox.Text,
                Age = (int)ageNumericUpDown.Value
            };

            Form2 form2 = new Form2(person);
            form2.Show();
        }
    }
    
}
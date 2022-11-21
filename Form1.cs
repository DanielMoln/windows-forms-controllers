namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        List<Person> persons = new List<Person>();
        public Form1()
        {
            InitializeComponent();
            persons.Add(new Person()
            {
                FirstName = "Lajos",
                BirthDate = DateTime.Now
            });
            persons.Add(new Person()
            {
                FirstName = "Gábor",
                BirthDate = DateTime.Now
            });
            persons.Add(new Person()
            {
                FirstName = "Jocó",
                BirthDate = DateTime.Now
            });
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            myCheckBoxList.Items.Clear();
            persons.ForEach(x => myCheckBoxList.Items.Add(x));

            comboBox1.Items.Add(persons[0]);
            comboBox1.Items.Add(persons[1]);
            comboBox1.Items.Add(persons[2]);

            listView1.Items.Add(new ListViewItem(new String[]
            {
                persons[0].FirstName,
                persons[0].BirthDate.ToString()
            }));

            dataGridView1.Rows.Add(persons[0].FirstName, persons[0].BirthDate);
            dataGridView1.Rows.Add(persons[1].FirstName, persons[2].BirthDate);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{this.myCheckBoxList.CheckedItems.Count} kijelölt elem!");
            MessageBox.Show($"{this.comboBox1.SelectedItem.ToString()}");
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // open folder
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            folderBrowserDialog.ShowDialog();
            if (!string.IsNullOrEmpty(folderBrowserDialog.SelectedPath))
            {
                MessageBox.Show(folderBrowserDialog.SelectedPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // open file
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.ShowDialog();
            if (!string.IsNullOrEmpty(openFileDialog.FileName))
            {
                MessageBox.Show(openFileDialog.FileName);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            colorDialog.ShowDialog();
            this.BackColor = colorDialog.Color;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fájlToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void szerkesztésToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
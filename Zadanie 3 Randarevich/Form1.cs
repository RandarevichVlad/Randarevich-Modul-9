using System;
using System.Windows.Forms;

namespace Zadanie_3_Randarevich
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
            comboBox1.Items.Add("Низкий");
            comboBox1.Items.Add("Средний");
            comboBox1.Items.Add("Высокий");

            
            listView1.View = View.Details;
            listView1.Columns.Add("Задача", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Дата выполнения", -2, HorizontalAlignment.Left);
            listView1.Columns.Add("Приоритет", -2, HorizontalAlignment.Left);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            ListViewItem item = new ListViewItem(textBox1.Text);
            item.SubItems.Add(dateTimePicker1.Value.ToShortDateString());
            item.SubItems.Add(comboBox1.SelectedItem.ToString());
            listView1.Items.Add(item);

            
            textBox1.Clear();
            comboBox1.SelectedIndex = -1;
        }
    }
}

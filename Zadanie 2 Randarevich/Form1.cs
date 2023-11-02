using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Zadanie_2_Randarevich
{
    public partial class Form1 : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        private OleDbDataAdapter da;
        private DataTable dt;

        public Form1()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Учебная практика по программированию\Рандаревич Отчет по практике Модуль 9\Workers.accdb";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Workers";
                command.CommandText = query;

                da = new OleDbDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Workers set Задача='" + textBox1.Text + "' where Workers=" + textBox2.Text;
                command.CommandText = query;

                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated");
                connection.Close();

                // Refresh the DataGridView
                dt.Clear();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "update Workers set Прогресс='" + textBox3.Text + "' where Workers=" + textBox2.Text;
                command.CommandText = query;

                command.ExecuteNonQuery();

                MessageBox.Show("Data Updated");
                connection.Close();

                // Refresh the DataGridView
                dt.Clear();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                string query = "select * from Workers";
                command.CommandText = query;

                da = new OleDbDataAdapter(command);
                dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;

                MessageBox.Show("Table Updated");
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }
    }
}

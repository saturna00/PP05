using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mfc1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void клиентыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.mfcDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet.цены". При необходимости она может быть перемещена или удалена.
            this.ценыTableAdapter.Fill(this.mfcDataSet.цены);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet.страховка". При необходимости она может быть перемещена или удалена.
            this.страховкаTableAdapter.Fill(this.mfcDataSet.страховка);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet.срок_действия". При необходимости она может быть перемещена или удалена.
            this.срок_действияTableAdapter.Fill(this.mfcDataSet.срок_действия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet.клиенты". При необходимости она может быть перемещена или удалена.
            this.клиентыTableAdapter.Fill(this.mfcDataSet.клиенты);

        }

        private void клиентыBindingSource1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.клиентыBindingSource1.EndEdit();
            this.tableAdapterManager1.UpdateAll(this.mfcDataSet1);

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            try
            {
                // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet1.цены". При необходимости она может быть перемещена или удалена.
                this.ценыTableAdapter1.Fill(this.mfcDataSet1.цены);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet1.страховка". При необходимости она может быть перемещена или удалена.
                this.страховкаTableAdapter1.Fill(this.mfcDataSet1.страховка);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet1.срок_действия". При необходимости она может быть перемещена или удалена.
                this.срок_действияTableAdapter1.Fill(this.mfcDataSet1.срок_действия);
                // TODO: данная строка кода позволяет загрузить данные в таблицу "mfcDataSet1.клиенты". При необходимости она может быть перемещена или удалена.
                this.клиентыTableAdapter1.Fill(this.mfcDataSet1.клиенты);
            }
            catch
            {
                MessageBox.Show("Ошибка загрузки БД");
            }

        }

        private void срок_действияDataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void клиентыDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Window1 dd = new Window1();
            Form1 ff = new Form1();
            dd.Show();
            ff.Close();
        }
    }
}

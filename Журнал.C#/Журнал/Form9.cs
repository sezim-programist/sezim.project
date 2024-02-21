using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Курсавая
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
            this._5_семестрDataGridView.Columns[0].Visible = false;
        }

        private void _5_семестрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._5_семестрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form9_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet._5_семестр". При необходимости она может быть перемещена или удалена.
            this._5_семестрTableAdapter.Fill(this._3FormDataSet._5_семестр);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // TODO :)

            try
            {

                string msg = "Вы хотите сохранить|Обновить выбранную запись?";
                string caption = "Сохранить|Обнавить: ПОВТАС 9-1-20 ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    // Save | Update
                    this._5_семестрBindingSource.EndEdit();
                    this._5_семестрTableAdapter.Update(this._3FormDataSet._5_семестр);

                    // Refresh data
                    this._5_семестрTableAdapter.Fill(this._3FormDataSet._5_семестр);

                    MessageBox.Show("Запись успешно сохранено",
                    "Сохранить данные: ПОВТАС 9-1-20", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранить |обнавить данные не удалось : " + ex.Message.ToString(),
                    "Сохранить данные: ПОВТАС 9-1-20", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // TODO :)

            try
            {

                string msg = "Вы хотите навсегда удалить выбранные записи?";
                string caption = "Удалить данные: ПОВТАС 9-1-20 ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    // Update
                    this._5_семестрBindingSource.RemoveCurrent();

                    // Save the change :)
                    this._5_семестрBindingSource.EndEdit();
                    this._5_семестрTableAdapter.Update(this._3FormDataSet._5_семестр);

                    // Refresh data
                    this._5_семестрTableAdapter.Fill(this._3FormDataSet._5_семестр);

                    MessageBox.Show("Запись успешно удалено",
                    "Удалить данные: ПОВТАС 9-1-20", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Удалить данные не удалось : " + ex.Message.ToString(),
                    "Удалить данные: ПОВТАС 9-1-20 ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this._5_семестрBindingSource.AddNew();
        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

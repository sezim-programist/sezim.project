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
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
            this._6_семестрDataGridView.Columns[0].Visible = false;
        }

        private void _6_семестрBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this._6_семестрBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form10_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet._6_семестр". При необходимости она может быть перемещена или удалена.
            this._6_семестрTableAdapter.Fill(this._3FormDataSet._6_семестр);

        }

        private void назадToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form7 a = new Form7();
            a.Show();
            this.Hide();
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
                    this._6_семестрBindingSource.EndEdit();
                    this._6_семестрTableAdapter.Update(this._3FormDataSet._6_семестр);

                    // Refresh data
                    this._6_семестрTableAdapter.Fill(this._3FormDataSet._6_семестр);

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
                    this._6_семестрBindingSource.RemoveCurrent();

                    // Save the change :)
                    this._6_семестрBindingSource.EndEdit();
                    this._6_семестрTableAdapter.Update(this._3FormDataSet._6_семестр);

                    // Refresh data
                    this._6_семестрTableAdapter.Fill(this._3FormDataSet._6_семестр);

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
            this._6_семестрBindingSource.AddNew();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

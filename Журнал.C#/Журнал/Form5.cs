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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
            this.нижнея_неделияDataGridView.Columns[0].Visible = false;
        }

        private void верхня_неделияBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.верхня_неделияBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet.Нижнея_неделия". При необходимости она может быть перемещена или удалена.
            this.нижнея_неделияTableAdapter.Fill(this._3FormDataSet.Нижнея_неделия);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet.Верхня_неделия". При необходимости она может быть перемещена или удалена.
            this.верхня_неделияTableAdapter.Fill(this._3FormDataSet.Верхня_неделия);

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
                    this.нижнея_неделияBindingSource.EndEdit();
                    this.нижнея_неделияTableAdapter.Update(this._3FormDataSet.Нижнея_неделия);

                    // Refresh data
                    this.нижнея_неделияTableAdapter.Fill(this._3FormDataSet.Нижнея_неделия);

                    MessageBox.Show("Запись успешно сохранено",
                    "Сохранить данные: ПОВТАС 9-1-20 ", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Сохранить |обнавить данные не удалось : " + ex.Message.ToString(),
                    "Сохранить данные: ПОВТАС 9-1-20 ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void нижнея_неделияDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void гловноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.нижнея_неделияBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // TODO :)

            try
            {

                string msg = "Вы хотите навсегда удалить выбранные записи?";
                string caption = "Удалить данные:Кгуста ";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    // Update
                    this.нижнея_неделияBindingSource.RemoveCurrent();

                    // Save the change :)
                    this.нижнея_неделияBindingSource.EndEdit();
                    this.нижнея_неделияTableAdapter.Update(this._3FormDataSet.Нижнея_неделия);

                    // Refresh data
                    this.нижнея_неделияTableAdapter.Fill(this._3FormDataSet.Нижнея_неделия);

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

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

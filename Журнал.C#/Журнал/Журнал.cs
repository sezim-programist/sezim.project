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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
            this.учет_посешаемости_кураторского_часаDataGridView.Columns[0].Visible = false;
        }

        private void гловноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void учет_посешаемости_кураторского_часаBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.учет_посешаемости_кураторского_часаBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet.Учет_посешаемости_кураторского_часа". При необходимости она может быть перемещена или удалена.
            this.учет_посешаемости_кураторского_часаTableAdapter.Fill(this._3FormDataSet.Учет_посешаемости_кураторского_часа);

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
                    this.учет_посешаемости_кураторского_часаBindingSource.EndEdit();
                    this.учет_посешаемости_кураторского_часаTableAdapter.Update(this._3FormDataSet.Учет_посешаемости_кураторского_часа);

                    // Refresh data
                    this.учет_посешаемости_кураторского_часаTableAdapter.Fill(this._3FormDataSet.Учет_посешаемости_кураторского_часа);

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
                    this.учет_посешаемости_кураторского_часаBindingSource.RemoveCurrent();

                    // Save the change :)
                    this.учет_посешаемости_кураторского_часаBindingSource.EndEdit();
                    this.учет_посешаемости_кураторского_часаTableAdapter.Update(this._3FormDataSet.Учет_посешаемости_кураторского_часа);

                    // Refresh data
                    this.учет_посешаемости_кураторского_часаTableAdapter.Fill(this._3FormDataSet.Учет_посешаемости_кураторского_часа);

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
            this.учет_посешаемости_кураторского_часаBindingSource.AddNew();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

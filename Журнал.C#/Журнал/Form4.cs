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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
            this.социалный_студент_группыDataGridView.Columns[0].Visible = false;
        }

        private void социалный_студент_группыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.социалный_студент_группыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet.Социалный_студент_группы". При необходимости она может быть перемещена или удалена.
            this.социалный_студент_группыTableAdapter.Fill(this._3FormDataSet.Социалный_студент_группы);

        }

        private void buttonSave_Click(object sender, EventArgs e)
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
                    this.социалный_студент_группыBindingSource.EndEdit();
                    this.социалный_студент_группыTableAdapter.Update(this._3FormDataSet.Социалный_студент_группы);

                    // Refresh data
                    this.социалный_студент_группыTableAdapter.Fill(this._3FormDataSet.Социалный_студент_группы);

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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            // TODO :)

            try
            {

                string msg = "Вы хотите навсегда удалить выбранные записи?";
                string caption = "Удалить данные: ПОВТАС 9-1-20";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                MessageBoxIcon icon = MessageBoxIcon.Question;

                DialogResult result;

                result = MessageBox.Show(this, msg, caption, buttons, icon);

                if (result == DialogResult.Yes)
                {
                    // Update
                    this.социалный_студент_группыBindingSource.RemoveCurrent();

                    // Save the change :)
                    this.социалный_студент_группыBindingSource.EndEdit();
                    this.социалный_студент_группыTableAdapter.Update(this._3FormDataSet.Социалный_студент_группы);

                    // Refresh data
                    this.социалный_студент_группыTableAdapter.Fill(this._3FormDataSet.Социалный_студент_группы);

                    MessageBox.Show("Запись успешно удалено",
                    "Удалить данные: ПОВТАС 9-1-20", MessageBoxButtons.OK, MessageBoxIcon.Information);


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Удалить данные не удалось : " + ex.Message.ToString(),
                    "Удалить данные: ПОВТАС 9-1-20", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.социалный_студент_группыBindingSource.AddNew();
        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }
    }
}

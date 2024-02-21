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
    public partial class FormEmployee : Form
    {
        public FormEmployee()
        {
            InitializeComponent();
            this.сведение_о_студентахDataGridView.Columns[0].Visible = false;
        }

        private void сведение_о_студентахBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сведение_о_студентахBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this._3FormDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_3FormDataSet.Сведение_о_студентах". При необходимости она может быть перемещена или удалена.
            this.сведение_о_студентахTableAdapter.Fill(this._3FormDataSet.Сведение_о_студентах);

        }

        private void главноеМенюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 s = new Form2();
            s.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void FormEmployee_FormClosing(object sender, FormClosingEventArgs e)
        {
            string msg = "Вы хотите выйти из приложения ?";
            string caption = "Выод из приложение: ПОВТАС 9-1-20";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon icon = MessageBoxIcon.Question;

            DialogResult result;

            result = MessageBox.Show(this, msg, caption, buttons, icon);

            if (result == DialogResult.Yes)
            {   
                //Close the from.
                // MessageBox.Show("До свидания, приятно было познокомится ","isBasskung Tutorial",
                   // MessageBoxButtons.OK, MessageBoxIcon.Information);
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }

        }

        private void buttonPrevious_Click(object sender, EventArgs e)
        {
            this.сведение_о_студентахBindingSource.MovePrevious();
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.сведение_о_студентахBindingSource.MoveNext();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
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
                    this.сведение_о_студентахBindingSource.RemoveCurrent();

                    // Save the change :)
                    this.сведение_о_студентахBindingSource.EndEdit();
                    this.сведение_о_студентахTableAdapter.Update(this._3FormDataSet.Сведение_о_студентах);

                    // Refresh data
                    this.сведение_о_студентахTableAdapter.Fill(this._3FormDataSet.Сведение_о_студентах);

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

        private void buttonAddNew_Click(object sender, EventArgs e)
        {
            this.сведение_о_студентахBindingSource.AddNew();
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
                    this.сведение_о_студентахBindingSource.EndEdit();
                    this.сведение_о_студентахTableAdapter.Update(this._3FormDataSet.Сведение_о_студентах);

                    // Refresh data
                    this.сведение_о_студентахTableAdapter.Fill(this._3FormDataSet.Сведение_о_студентах);

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

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            buttonAddNew.PerformClick();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            buttonDelete.PerformClick();
        }

        private void toolStripButtonUpdateltem_Click(object sender, EventArgs e)
        {
            buttonSave.PerformClick();
        }

        private void toolStripButtonRefresh_Click(object sender, EventArgs e)
        {
            Form3_Load(sender, e);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void сведение_о_студентахBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void сведение_о_студентахDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void кодTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }
    }
}

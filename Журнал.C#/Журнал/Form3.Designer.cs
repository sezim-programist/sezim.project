
namespace Курсавая
{
    partial class FormEmployee
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label кодLabel;
            System.Windows.Forms.Label фИО_студентаLabel;
            System.Windows.Forms.Label дата_рождениеLabel;
            System.Windows.Forms.Label адрес_прожеваниеLabel;
            System.Windows.Forms.Label телефонLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEmployee));
            this._3FormDataSet = new Курсавая._3FormDataSet();
            this.сведение_о_студентахBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сведение_о_студентахTableAdapter = new Курсавая._3FormDataSetTableAdapters.Сведение_о_студентахTableAdapter();
            this.tableAdapterManager = new Курсавая._3FormDataSetTableAdapters.TableAdapterManager();
            this.сведение_о_студентахBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.сведение_о_студентахBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonUpdateltem = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRefresh = new System.Windows.Forms.ToolStripButton();
            this.сведение_о_студентахDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.главноеМенюToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddNew = new System.Windows.Forms.Button();
            this.телефонTextBox = new System.Windows.Forms.TextBox();
            this.адрес_прожеваниеTextBox = new System.Windows.Forms.TextBox();
            this.дата_рождениеDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.фИО_студентаTextBox = new System.Windows.Forms.TextBox();
            this.кодTextBox = new System.Windows.Forms.TextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonNext = new System.Windows.Forms.Button();
            this.buttonPrevious = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            кодLabel = new System.Windows.Forms.Label();
            фИО_студентаLabel = new System.Windows.Forms.Label();
            дата_рождениеLabel = new System.Windows.Forms.Label();
            адрес_прожеваниеLabel = new System.Windows.Forms.Label();
            телефонLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._3FormDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахBindingNavigator)).BeginInit();
            this.сведение_о_студентахBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахDataGridView)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // кодLabel
            // 
            кодLabel.AutoSize = true;
            кодLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            кодLabel.Location = new System.Drawing.Point(6, 39);
            кодLabel.Name = "кодLabel";
            кодLabel.Size = new System.Drawing.Size(36, 18);
            кодLabel.TabIndex = 6;
            кодLabel.Text = "Код:";
            // 
            // фИО_студентаLabel
            // 
            фИО_студентаLabel.AutoSize = true;
            фИО_студентаLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            фИО_студентаLabel.Location = new System.Drawing.Point(6, 108);
            фИО_студентаLabel.Name = "фИО_студентаLabel";
            фИО_студентаLabel.Size = new System.Drawing.Size(100, 18);
            фИО_студентаLabel.TabIndex = 8;
            фИО_студентаLabel.Text = "ФИО студента:";
            // 
            // дата_рождениеLabel
            // 
            дата_рождениеLabel.AutoSize = true;
            дата_рождениеLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            дата_рождениеLabel.Location = new System.Drawing.Point(6, 177);
            дата_рождениеLabel.Name = "дата_рождениеLabel";
            дата_рождениеLabel.Size = new System.Drawing.Size(111, 18);
            дата_рождениеLabel.TabIndex = 10;
            дата_рождениеLabel.Text = "Дата рождение:";
            // 
            // адрес_прожеваниеLabel
            // 
            адрес_прожеваниеLabel.AutoSize = true;
            адрес_прожеваниеLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            адрес_прожеваниеLabel.Location = new System.Drawing.Point(6, 141);
            адрес_прожеваниеLabel.Name = "адрес_прожеваниеLabel";
            адрес_прожеваниеLabel.Size = new System.Drawing.Size(134, 18);
            адрес_прожеваниеLabel.TabIndex = 12;
            адрес_прожеваниеLabel.Text = "Адрес прожевание:";
            // 
            // телефонLabel
            // 
            телефонLabel.AutoSize = true;
            телефонLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            телефонLabel.Location = new System.Drawing.Point(6, 76);
            телефонLabel.Name = "телефонLabel";
            телефонLabel.Size = new System.Drawing.Size(67, 18);
            телефонLabel.TabIndex = 14;
            телефонLabel.Text = "Телефон:";
            // 
            // _3FormDataSet
            // 
            this._3FormDataSet.DataSetName = "_3FormDataSet";
            this._3FormDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сведение_о_студентахBindingSource
            // 
            this.сведение_о_студентахBindingSource.DataMember = "Сведение о студентах";
            this.сведение_о_студентахBindingSource.DataSource = this._3FormDataSet;
            // 
            // сведение_о_студентахTableAdapter
            // 
            this.сведение_о_студентахTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager._4_семестрTableAdapter = null;
            this.tableAdapterManager._5_семестрTableAdapter = null;
            this.tableAdapterManager._6_семестрTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Курсавая._3FormDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Верхня_неделияTableAdapter = null;
            this.tableAdapterManager.Нижнея_неделияTableAdapter = null;
            this.tableAdapterManager.Сведение_о_студентахTableAdapter = this.сведение_о_студентахTableAdapter;
            this.tableAdapterManager.Социалный_студент_группыTableAdapter = null;
            this.tableAdapterManager.Учет_посешаемости_кураторского_часаTableAdapter = null;
            // 
            // сведение_о_студентахBindingNavigator
            // 
            this.сведение_о_студентахBindingNavigator.AddNewItem = null;
            this.сведение_о_студентахBindingNavigator.BindingSource = this.сведение_о_студентахBindingSource;
            this.сведение_о_студентахBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сведение_о_студентахBindingNavigator.DeleteItem = null;
            this.сведение_о_студентахBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.сведение_о_студентахBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.сведение_о_студентахBindingNavigatorSaveItem,
            this.toolStripButtonUpdateltem,
            this.toolStripButtonRefresh});
            this.сведение_о_студентахBindingNavigator.Location = new System.Drawing.Point(0, 25);
            this.сведение_о_студентахBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сведение_о_студентахBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сведение_о_студентахBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сведение_о_студентахBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сведение_о_студентахBindingNavigator.Name = "сведение_о_студентахBindingNavigator";
            this.сведение_о_студентахBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сведение_о_студентахBindingNavigator.Size = new System.Drawing.Size(888, 25);
            this.сведение_о_студентахBindingNavigator.TabIndex = 0;
            this.сведение_о_студентахBindingNavigator.Text = "bindingNavigator1";
            this.сведение_о_студентахBindingNavigator.RefreshItems += new System.EventHandler(this.сведение_о_студентахBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.bindingNavigatorMoveNextItem_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.ForeColor = System.Drawing.Color.Orange;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(86, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.ForeColor = System.Drawing.Color.Red;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(75, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // сведение_о_студентахBindingNavigatorSaveItem
            // 
            this.сведение_о_студентахBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сведение_о_студентахBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сведение_о_студентахBindingNavigatorSaveItem.Image")));
            this.сведение_о_студентахBindingNavigatorSaveItem.Name = "сведение_о_студентахBindingNavigatorSaveItem";
            this.сведение_о_студентахBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.сведение_о_студентахBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сведение_о_студентахBindingNavigatorSaveItem.Click += new System.EventHandler(this.сведение_о_студентахBindingNavigatorSaveItem_Click);
            // 
            // toolStripButtonUpdateltem
            // 
            this.toolStripButtonUpdateltem.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.toolStripButtonUpdateltem.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUpdateltem.Image")));
            this.toolStripButtonUpdateltem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUpdateltem.Name = "toolStripButtonUpdateltem";
            this.toolStripButtonUpdateltem.Size = new System.Drawing.Size(109, 22);
            this.toolStripButtonUpdateltem.Text = "Seve | Update";
            this.toolStripButtonUpdateltem.Click += new System.EventHandler(this.toolStripButtonUpdateltem_Click);
            // 
            // toolStripButtonRefresh
            // 
            this.toolStripButtonRefresh.ForeColor = System.Drawing.Color.Lime;
            this.toolStripButtonRefresh.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRefresh.Image")));
            this.toolStripButtonRefresh.ImageTransparentColor = System.Drawing.Color.MediumOrchid;
            this.toolStripButtonRefresh.Name = "toolStripButtonRefresh";
            this.toolStripButtonRefresh.Size = new System.Drawing.Size(86, 22);
            this.toolStripButtonRefresh.Text = "Обнавить";
            this.toolStripButtonRefresh.Click += new System.EventHandler(this.toolStripButtonRefresh_Click);
            // 
            // сведение_о_студентахDataGridView
            // 
            this.сведение_о_студентахDataGridView.AutoGenerateColumns = false;
            this.сведение_о_студентахDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.сведение_о_студентахDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.сведение_о_студентахDataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.сведение_о_студентахDataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.сведение_о_студентахDataGridView.ColumnHeadersHeight = 30;
            this.сведение_о_студентахDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.сведение_о_студентахDataGridView.DataSource = this.сведение_о_студентахBindingSource;
            this.сведение_о_студентахDataGridView.Location = new System.Drawing.Point(14, 25);
            this.сведение_о_студентахDataGridView.MultiSelect = false;
            this.сведение_о_студентахDataGridView.Name = "сведение_о_студентахDataGridView";
            this.сведение_о_студентахDataGridView.Size = new System.Drawing.Size(523, 299);
            this.сведение_о_студентахDataGridView.TabIndex = 1;
            this.сведение_о_студентахDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.сведение_о_студентахDataGridView_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn1.HeaderText = "Код";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ФИО студента";
            this.dataGridViewTextBoxColumn2.HeaderText = "ФИО студента";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Дата рождение";
            this.dataGridViewTextBoxColumn3.HeaderText = "Дата рождение";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Адрес прожевание";
            this.dataGridViewTextBoxColumn4.HeaderText = "Адрес прожевание";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Телефон";
            this.dataGridViewTextBoxColumn5.HeaderText = "Телефон";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumPurple;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.главноеМенюToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // главноеМенюToolStripMenuItem
            // 
            this.главноеМенюToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.главноеМенюToolStripMenuItem.Name = "главноеМенюToolStripMenuItem";
            this.главноеМенюToolStripMenuItem.Size = new System.Drawing.Size(107, 21);
            this.главноеМенюToolStripMenuItem.Text = "Главное меню";
            this.главноеМенюToolStripMenuItem.Click += new System.EventHandler(this.главноеМенюToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.MediumPurple;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(864, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 395);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(888, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel1.Text = "Status";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox1.Controls.Add(телефонLabel);
            this.groupBox1.Controls.Add(this.buttonAddNew);
            this.groupBox1.Controls.Add(this.телефонTextBox);
            this.groupBox1.Controls.Add(адрес_прожеваниеLabel);
            this.groupBox1.Controls.Add(this.адрес_прожеваниеTextBox);
            this.groupBox1.Controls.Add(дата_рождениеLabel);
            this.groupBox1.Controls.Add(this.дата_рождениеDateTimePicker);
            this.groupBox1.Controls.Add(фИО_студентаLabel);
            this.groupBox1.Controls.Add(this.фИО_студентаTextBox);
            this.groupBox1.Controls.Add(кодLabel);
            this.groupBox1.Controls.Add(this.кодTextBox);
            this.groupBox1.Controls.Add(this.buttonExit);
            this.groupBox1.Controls.Add(this.buttonDelete);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.buttonNext);
            this.groupBox1.Controls.Add(this.buttonPrevious);
            this.groupBox1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(315, 332);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информациа о студента ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonAddNew
            // 
            this.buttonAddNew.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonAddNew.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddNew.Location = new System.Drawing.Point(217, 279);
            this.buttonAddNew.Name = "buttonAddNew";
            this.buttonAddNew.Size = new System.Drawing.Size(92, 34);
            this.buttonAddNew.TabIndex = 1;
            this.buttonAddNew.Text = "Добавить";
            this.buttonAddNew.UseVisualStyleBackColor = false;
            this.buttonAddNew.Click += new System.EventHandler(this.buttonAddNew_Click);
            // 
            // телефонTextBox
            // 
            this.телефонTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_студентахBindingSource, "Телефон", true));
            this.телефонTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.телефонTextBox.Location = new System.Drawing.Point(142, 76);
            this.телефонTextBox.Name = "телефонTextBox";
            this.телефонTextBox.Size = new System.Drawing.Size(167, 26);
            this.телефонTextBox.TabIndex = 15;
            // 
            // адрес_прожеваниеTextBox
            // 
            this.адрес_прожеваниеTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_студентахBindingSource, "Адрес прожевание", true));
            this.адрес_прожеваниеTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.адрес_прожеваниеTextBox.Location = new System.Drawing.Point(143, 141);
            this.адрес_прожеваниеTextBox.Name = "адрес_прожеваниеTextBox";
            this.адрес_прожеваниеTextBox.Size = new System.Drawing.Size(166, 26);
            this.адрес_прожеваниеTextBox.TabIndex = 13;
            // 
            // дата_рождениеDateTimePicker
            // 
            this.дата_рождениеDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.сведение_о_студентахBindingSource, "Дата рождение", true));
            this.дата_рождениеDateTimePicker.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.дата_рождениеDateTimePicker.Location = new System.Drawing.Point(143, 177);
            this.дата_рождениеDateTimePicker.Name = "дата_рождениеDateTimePicker";
            this.дата_рождениеDateTimePicker.Size = new System.Drawing.Size(166, 26);
            this.дата_рождениеDateTimePicker.TabIndex = 11;
            // 
            // фИО_студентаTextBox
            // 
            this.фИО_студентаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_студентахBindingSource, "ФИО студента", true));
            this.фИО_студентаTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.фИО_студентаTextBox.Location = new System.Drawing.Point(143, 108);
            this.фИО_студентаTextBox.Name = "фИО_студентаTextBox";
            this.фИО_студентаTextBox.Size = new System.Drawing.Size(166, 26);
            this.фИО_студентаTextBox.TabIndex = 9;
            // 
            // кодTextBox
            // 
            this.кодTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.сведение_о_студентахBindingSource, "Код", true));
            this.кодTextBox.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.кодTextBox.Location = new System.Drawing.Point(142, 39);
            this.кодTextBox.Name = "кодTextBox";
            this.кодTextBox.Size = new System.Drawing.Size(167, 26);
            this.кодTextBox.TabIndex = 7;
            this.кодTextBox.TextChanged += new System.EventHandler(this.кодTextBox_TextChanged);
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonExit.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonExit.Location = new System.Drawing.Point(126, 226);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(87, 34);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "Назад";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonDelete.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonDelete.Location = new System.Drawing.Point(126, 279);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(90, 34);
            this.buttonDelete.TabIndex = 4;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonSave.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSave.Location = new System.Drawing.Point(5, 279);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(115, 34);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Сохранить";
            this.buttonSave.UseVisualStyleBackColor = false;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonNext
            // 
            this.buttonNext.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonNext.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonNext.Location = new System.Drawing.Point(213, 226);
            this.buttonNext.Name = "buttonNext";
            this.buttonNext.Size = new System.Drawing.Size(96, 34);
            this.buttonNext.TabIndex = 2;
            this.buttonNext.Text = " Следущий";
            this.buttonNext.UseVisualStyleBackColor = false;
            this.buttonNext.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // buttonPrevious
            // 
            this.buttonPrevious.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonPrevious.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonPrevious.Location = new System.Drawing.Point(5, 226);
            this.buttonPrevious.Name = "buttonPrevious";
            this.buttonPrevious.Size = new System.Drawing.Size(115, 34);
            this.buttonPrevious.TabIndex = 0;
            this.buttonPrevious.Text = "Предыдущий";
            this.buttonPrevious.UseVisualStyleBackColor = false;
            this.buttonPrevious.Click += new System.EventHandler(this.buttonPrevious_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MediumPurple;
            this.groupBox2.Controls.Add(this.сведение_о_студентахDataGridView);
            this.groupBox2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(333, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 332);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Лист о студентах";
            // 
            // FormEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 417);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.сведение_о_студентахBindingNavigator);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormEmployee";
            this.Text = "Form3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEmployee_FormClosing);
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this._3FormDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахBindingNavigator)).EndInit();
            this.сведение_о_студентахBindingNavigator.ResumeLayout(false);
            this.сведение_о_студентахBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сведение_о_студентахDataGridView)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private _3FormDataSet _3FormDataSet;
        private System.Windows.Forms.BindingSource сведение_о_студентахBindingSource;
        private _3FormDataSetTableAdapters.Сведение_о_студентахTableAdapter сведение_о_студентахTableAdapter;
        private _3FormDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сведение_о_студентахBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton сведение_о_студентахBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сведение_о_студентахDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem главноеМенюToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonUpdateltem;
        private System.Windows.Forms.ToolStripButton toolStripButtonRefresh;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonNext;
        private System.Windows.Forms.Button buttonAddNew;
        private System.Windows.Forms.Button buttonPrevious;
        private System.Windows.Forms.TextBox телефонTextBox;
        private System.Windows.Forms.TextBox адрес_прожеваниеTextBox;
        private System.Windows.Forms.DateTimePicker дата_рождениеDateTimePicker;
        private System.Windows.Forms.TextBox фИО_студентаTextBox;
        private System.Windows.Forms.TextBox кодTextBox;
    }
}
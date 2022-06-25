namespace mfc1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.mfcDataSet1 = new mfc1.mfcDataSet();
            this.клиентыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.клиентыTableAdapter1 = new mfc1.mfcDataSetTableAdapters.клиентыTableAdapter();
            this.tableAdapterManager1 = new mfc1.mfcDataSetTableAdapters.TableAdapterManager();
            this.клиентыBindingSource1BindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.клиентыBindingSource1BindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.клиентыDataGridView1 = new System.Windows.Forms.DataGridView();
            this.срок_действияBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.срок_действияTableAdapter1 = new mfc1.mfcDataSetTableAdapters.срок_действияTableAdapter();
            this.срок_действияDataGridView1 = new System.Windows.Forms.DataGridView();
            this.страховкаBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.страховкаTableAdapter1 = new mfc1.mfcDataSetTableAdapters.страховкаTableAdapter();
            this.страховкаDataGridView1 = new System.Windows.Forms.DataGridView();
            this.ценыBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ценыTableAdapter1 = new mfc1.mfcDataSetTableAdapters.ценыTableAdapter();
            this.label3 = new System.Windows.Forms.Label();
            this.срок_действияDataGridView2 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.idpriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ценаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iduslDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otm = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mfcDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1BindingNavigator)).BeginInit();
            this.клиентыBindingSource1BindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаDataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияDataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // mfcDataSet1
            // 
            this.mfcDataSet1.DataSetName = "mfcDataSet";
            this.mfcDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // клиентыBindingSource1
            // 
            this.клиентыBindingSource1.DataMember = "клиенты";
            this.клиентыBindingSource1.DataSource = this.mfcDataSet1;
            // 
            // клиентыTableAdapter1
            // 
            this.клиентыTableAdapter1.ClearBeforeFill = true;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.UpdateOrder = mfc1.mfcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.usersTableAdapter = null;
            this.tableAdapterManager1.клиентыTableAdapter = this.клиентыTableAdapter1;
            this.tableAdapterManager1.срок_действияTableAdapter = this.срок_действияTableAdapter1;
            this.tableAdapterManager1.страховкаTableAdapter = this.страховкаTableAdapter1;
            this.tableAdapterManager1.ценыTableAdapter = this.ценыTableAdapter1;
            // 
            // клиентыBindingSource1BindingNavigator
            // 
            this.клиентыBindingSource1BindingNavigator.AddNewItem = this.toolStripButton1;
            this.клиентыBindingSource1BindingNavigator.BindingSource = this.клиентыBindingSource1;
            this.клиентыBindingSource1BindingNavigator.CountItem = null;
            this.клиентыBindingSource1BindingNavigator.DeleteItem = this.toolStripButton2;
            this.клиентыBindingSource1BindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.клиентыBindingSource1BindingNavigatorSaveItem,
            this.toolStripButton1,
            this.toolStripButton2});
            this.клиентыBindingSource1BindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.клиентыBindingSource1BindingNavigator.MoveFirstItem = null;
            this.клиентыBindingSource1BindingNavigator.MoveLastItem = null;
            this.клиентыBindingSource1BindingNavigator.MoveNextItem = null;
            this.клиентыBindingSource1BindingNavigator.MovePreviousItem = null;
            this.клиентыBindingSource1BindingNavigator.Name = "клиентыBindingSource1BindingNavigator";
            this.клиентыBindingSource1BindingNavigator.PositionItem = null;
            this.клиентыBindingSource1BindingNavigator.Size = new System.Drawing.Size(701, 25);
            this.клиентыBindingSource1BindingNavigator.TabIndex = 0;
            this.клиентыBindingSource1BindingNavigator.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "bindingNavigatorAddNewItem";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "Добавить";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "bindingNavigatorDeleteItem";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton2.Text = "Удалить";
            // 
            // клиентыBindingSource1BindingNavigatorSaveItem
            // 
            this.клиентыBindingSource1BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.клиентыBindingSource1BindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("клиентыBindingSource1BindingNavigatorSaveItem.Image")));
            this.клиентыBindingSource1BindingNavigatorSaveItem.Name = "клиентыBindingSource1BindingNavigatorSaveItem";
            this.клиентыBindingSource1BindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.клиентыBindingSource1BindingNavigatorSaveItem.Text = "Сохранить данные";
            this.клиентыBindingSource1BindingNavigatorSaveItem.Click += new System.EventHandler(this.клиентыBindingSource1BindingNavigatorSaveItem_Click);
            // 
            // клиентыDataGridView1
            // 
            this.клиентыDataGridView1.AutoGenerateColumns = false;
            this.клиентыDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.клиентыDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.dataGridViewTextBoxColumn18});
            this.клиентыDataGridView1.DataSource = this.клиентыBindingSource1;
            this.клиентыDataGridView1.Location = new System.Drawing.Point(12, 228);
            this.клиентыDataGridView1.Name = "клиентыDataGridView1";
            this.клиентыDataGridView1.Size = new System.Drawing.Size(408, 118);
            this.клиентыDataGridView1.TabIndex = 1;
            this.клиентыDataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.клиентыDataGridView1_CellContentClick);
            // 
            // срок_действияBindingSource1
            // 
            this.срок_действияBindingSource1.DataMember = "срок_действия";
            this.срок_действияBindingSource1.DataSource = this.mfcDataSet1;
            // 
            // срок_действияTableAdapter1
            // 
            this.срок_действияTableAdapter1.ClearBeforeFill = true;
            // 
            // срок_действияDataGridView1
            // 
            this.срок_действияDataGridView1.AutoGenerateColumns = false;
            this.срок_действияDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.срок_действияDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idpriceDataGridViewTextBoxColumn,
            this.ценаDataGridViewTextBoxColumn,
            this.iduslDataGridViewTextBoxColumn});
            this.срок_действияDataGridView1.DataSource = this.ценыBindingSource1;
            this.срок_действияDataGridView1.Location = new System.Drawing.Point(429, 228);
            this.срок_действияDataGridView1.Name = "срок_действияDataGridView1";
            this.срок_действияDataGridView1.Size = new System.Drawing.Size(210, 118);
            this.срок_действияDataGridView1.TabIndex = 2;
            // 
            // страховкаBindingSource1
            // 
            this.страховкаBindingSource1.DataMember = "страховка";
            this.страховкаBindingSource1.DataSource = this.mfcDataSet1;
            // 
            // страховкаTableAdapter1
            // 
            this.страховкаTableAdapter1.ClearBeforeFill = true;
            // 
            // страховкаDataGridView1
            // 
            this.страховкаDataGridView1.AutoGenerateColumns = false;
            this.страховкаDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.страховкаDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn23,
            this.dataGridViewTextBoxColumn24,
            this.dataGridViewTextBoxColumn25});
            this.страховкаDataGridView1.DataSource = this.страховкаBindingSource1;
            this.страховкаDataGridView1.Location = new System.Drawing.Point(12, 76);
            this.страховкаDataGridView1.Name = "страховкаDataGridView1";
            this.страховкаDataGridView1.Size = new System.Drawing.Size(363, 118);
            this.страховкаDataGridView1.TabIndex = 3;
            // 
            // ценыBindingSource1
            // 
            this.ценыBindingSource1.DataMember = "цены";
            this.ценыBindingSource1.DataSource = this.mfcDataSet1;
            // 
            // ценыTableAdapter1
            // 
            this.ценыTableAdapter1.ClearBeforeFill = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Страховка";
            // 
            // срок_действияDataGridView2
            // 
            this.срок_действияDataGridView2.AutoGenerateColumns = false;
            this.срок_действияDataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.срок_действияDataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn19,
            this.dataGridViewTextBoxColumn20,
            this.dataGridViewTextBoxColumn21,
            this.dataGridViewTextBoxColumn22});
            this.срок_действияDataGridView2.DataSource = this.срок_действияBindingSource1;
            this.срок_действияDataGridView2.Location = new System.Drawing.Point(381, 76);
            this.срок_действияDataGridView2.Name = "срок_действияDataGridView2";
            this.срок_действияDataGridView2.Size = new System.Drawing.Size(310, 118);
            this.срок_действияDataGridView2.TabIndex = 5;
            this.срок_действияDataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.срок_действияDataGridView2_CellContentClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(426, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Цена";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 213);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Данные клиента";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(426, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Срок действия страховки";
            // 
            // idpriceDataGridViewTextBoxColumn
            // 
            this.idpriceDataGridViewTextBoxColumn.DataPropertyName = "id_price";
            this.idpriceDataGridViewTextBoxColumn.HeaderText = "id_price";
            this.idpriceDataGridViewTextBoxColumn.Name = "idpriceDataGridViewTextBoxColumn";
            this.idpriceDataGridViewTextBoxColumn.Width = 20;
            // 
            // ценаDataGridViewTextBoxColumn
            // 
            this.ценаDataGridViewTextBoxColumn.DataPropertyName = "цена";
            this.ценаDataGridViewTextBoxColumn.HeaderText = "цена";
            this.ценаDataGridViewTextBoxColumn.Name = "ценаDataGridViewTextBoxColumn";
            // 
            // iduslDataGridViewTextBoxColumn
            // 
            this.iduslDataGridViewTextBoxColumn.DataPropertyName = "id_usl";
            this.iduslDataGridViewTextBoxColumn.HeaderText = "id_usl";
            this.iduslDataGridViewTextBoxColumn.Name = "iduslDataGridViewTextBoxColumn";
            this.iduslDataGridViewTextBoxColumn.Width = 50;
            // 
            // dataGridViewTextBoxColumn19
            // 
            this.dataGridViewTextBoxColumn19.DataPropertyName = "id_srok";
            this.dataGridViewTextBoxColumn19.HeaderText = "id_srok";
            this.dataGridViewTextBoxColumn19.Name = "dataGridViewTextBoxColumn19";
            this.dataGridViewTextBoxColumn19.Width = 20;
            // 
            // dataGridViewTextBoxColumn20
            // 
            this.dataGridViewTextBoxColumn20.DataPropertyName = "дата_начала";
            this.dataGridViewTextBoxColumn20.HeaderText = "дата_начала";
            this.dataGridViewTextBoxColumn20.Name = "dataGridViewTextBoxColumn20";
            // 
            // dataGridViewTextBoxColumn21
            // 
            this.dataGridViewTextBoxColumn21.DataPropertyName = "дата_окончания";
            this.dataGridViewTextBoxColumn21.HeaderText = "дата_окончания";
            this.dataGridViewTextBoxColumn21.Name = "dataGridViewTextBoxColumn21";
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.DataPropertyName = "id_usl";
            this.dataGridViewTextBoxColumn22.HeaderText = "id_usl";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 50;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.DataPropertyName = "id_client";
            this.dataGridViewTextBoxColumn15.HeaderText = "id_client";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 20;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "ФИО";
            this.dataGridViewTextBoxColumn16.HeaderText = "ФИО";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 150;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.DataPropertyName = "Адрес";
            this.dataGridViewTextBoxColumn17.HeaderText = "Адрес";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.Width = 150;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.DataPropertyName = "id_usl";
            this.dataGridViewTextBoxColumn18.HeaderText = "id_usl";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 50;
            // 
            // dataGridViewTextBoxColumn23
            // 
            this.dataGridViewTextBoxColumn23.DataPropertyName = "id_usl";
            this.dataGridViewTextBoxColumn23.HeaderText = "id_usl";
            this.dataGridViewTextBoxColumn23.Name = "dataGridViewTextBoxColumn23";
            this.dataGridViewTextBoxColumn23.Width = 50;
            // 
            // dataGridViewTextBoxColumn24
            // 
            this.dataGridViewTextBoxColumn24.DataPropertyName = "название_страховки";
            this.dataGridViewTextBoxColumn24.HeaderText = "название_страховки";
            this.dataGridViewTextBoxColumn24.Name = "dataGridViewTextBoxColumn24";
            this.dataGridViewTextBoxColumn24.Width = 150;
            // 
            // dataGridViewTextBoxColumn25
            // 
            this.dataGridViewTextBoxColumn25.DataPropertyName = "необходимые_документы";
            this.dataGridViewTextBoxColumn25.HeaderText = "необходимые_документы";
            this.dataGridViewTextBoxColumn25.Name = "dataGridViewTextBoxColumn25";
            this.dataGridViewTextBoxColumn25.Width = 150;
            // 
            // otm
            // 
            this.otm.Location = new System.Drawing.Point(28, 360);
            this.otm.Name = "otm";
            this.otm.Size = new System.Drawing.Size(128, 35);
            this.otm.TabIndex = 9;
            this.otm.Text = "Выход";
            this.otm.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(13, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "з";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(701, 399);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.otm);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.срок_действияDataGridView2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.страховкаDataGridView1);
            this.Controls.Add(this.срок_действияDataGridView1);
            this.Controls.Add(this.клиентыDataGridView1);
            this.Controls.Add(this.клиентыBindingSource1BindingNavigator);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.mfcDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыBindingSource1BindingNavigator)).EndInit();
            this.клиентыBindingSource1BindingNavigator.ResumeLayout(false);
            this.клиентыBindingSource1BindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.клиентыDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.страховкаDataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ценыBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.срок_действияDataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private mfcDataSet mfcDataSet;
        private System.Windows.Forms.BindingSource клиентыBindingSource;
        private mfcDataSetTableAdapters.клиентыTableAdapter клиентыTableAdapter;
        private mfcDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator клиентыBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton клиентыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView клиентыDataGridView;
        private mfcDataSetTableAdapters.срок_действияTableAdapter срок_действияTableAdapter;
        private System.Windows.Forms.BindingSource срок_действияBindingSource;
        private mfcDataSetTableAdapters.страховкаTableAdapter страховкаTableAdapter;
        private System.Windows.Forms.DataGridView срок_действияDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.BindingSource страховкаBindingSource;
        private mfcDataSetTableAdapters.ценыTableAdapter ценыTableAdapter;
        private System.Windows.Forms.DataGridView страховкаDataGridView;
        private System.Windows.Forms.BindingSource ценыBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridView ценыDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private mfcDataSet mfcDataSet1;
        private System.Windows.Forms.BindingSource клиентыBindingSource1;
        private mfcDataSetTableAdapters.клиентыTableAdapter клиентыTableAdapter1;
        private mfcDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingNavigator клиентыBindingSource1BindingNavigator;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton клиентыBindingSource1BindingNavigatorSaveItem;
        private mfcDataSetTableAdapters.срок_действияTableAdapter срок_действияTableAdapter1;
        private System.Windows.Forms.DataGridView клиентыDataGridView1;
        private System.Windows.Forms.BindingSource срок_действияBindingSource1;
        private mfcDataSetTableAdapters.страховкаTableAdapter страховкаTableAdapter1;
        private System.Windows.Forms.DataGridView срок_действияDataGridView1;
        private System.Windows.Forms.BindingSource страховкаBindingSource1;
        private mfcDataSetTableAdapters.ценыTableAdapter ценыTableAdapter1;
        private System.Windows.Forms.DataGridView страховкаDataGridView1;
        private System.Windows.Forms.BindingSource ценыBindingSource1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView срок_действияDataGridView2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn idpriceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ценаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iduslDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn23;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn24;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn25;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn19;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn20;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn21;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.Button otm;
        private System.Windows.Forms.Label label7;
    }
}
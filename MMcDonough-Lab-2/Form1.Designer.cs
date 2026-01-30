namespace MMcDonough_Lab_2
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
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label populationLabel;
            this.dgvCity = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cityDBDataSet = new MMcDonough_Lab_2.CityDBDataSet();
            this.cityTableAdapter = new MMcDonough_Lab_2.CityDBDataSetTableAdapters.CityTableAdapter();
            this.tableAdapterManager = new MMcDonough_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager();
            this.btnPopASC = new System.Windows.Forms.Button();
            this.btnPopDESC = new System.Windows.Forms.Button();
            this.btnNameZA = new System.Windows.Forms.Button();
            this.btnNameAZ = new System.Windows.Forms.Button();
            this.CityBindingNav = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnClacStat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tBTotal = new System.Windows.Forms.TextBox();
            this.tBAvg = new System.Windows.Forms.TextBox();
            this.tBHigh = new System.Windows.Forms.TextBox();
            this.tBLow = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateTextBox = new System.Windows.Forms.TextBox();
            this.populationTextBox = new System.Windows.Forms.TextBox();
            this.btnCitySave = new System.Windows.Forms.Button();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.populationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnCityNew = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.cityToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.btnCancel = new System.Windows.Forms.Button();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            populationLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNav)).BeginInit();
            this.CityBindingNav.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCity
            // 
            this.dgvCity.AllowUserToAddRows = false;
            this.dgvCity.AllowUserToDeleteRows = false;
            this.dgvCity.AllowUserToOrderColumns = true;
            this.dgvCity.AutoGenerateColumns = false;
            this.dgvCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCity.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cityDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.populationDataGridViewTextBoxColumn});
            this.dgvCity.DataSource = this.cityBindingSource;
            this.dgvCity.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvCity.Location = new System.Drawing.Point(36, 138);
            this.dgvCity.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvCity.Name = "dgvCity";
            this.dgvCity.ReadOnly = true;
            this.dgvCity.Size = new System.Drawing.Size(453, 583);
            this.dgvCity.TabIndex = 10;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(649, 647);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(148, 74);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "E&xit";
            this.cityToolTip.SetToolTip(this.btnExit, "Exit the program");
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataMember = "City";
            this.cityBindingSource.DataSource = this.cityDBDataSet;
            // 
            // cityDBDataSet
            // 
            this.cityDBDataSet.DataSetName = "CityDBDataSet";
            this.cityDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cityTableAdapter
            // 
            this.cityTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CityTableAdapter = this.cityTableAdapter;
            this.tableAdapterManager.UpdateOrder = MMcDonough_Lab_2.CityDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnPopASC
            // 
            this.btnPopASC.Location = new System.Drawing.Point(394, 58);
            this.btnPopASC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopASC.Name = "btnPopASC";
            this.btnPopASC.Size = new System.Drawing.Size(95, 32);
            this.btnPopASC.TabIndex = 12;
            this.btnPopASC.Text = "&^ ASC";
            this.cityToolTip.SetToolTip(this.btnPopASC, "Sort by Acending Population");
            this.btnPopASC.UseVisualStyleBackColor = true;
            this.btnPopASC.Click += new System.EventHandler(this.btnPopASC_Click);
            // 
            // btnPopDESC
            // 
            this.btnPopDESC.Location = new System.Drawing.Point(394, 98);
            this.btnPopDESC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPopDESC.Name = "btnPopDESC";
            this.btnPopDESC.Size = new System.Drawing.Size(95, 32);
            this.btnPopDESC.TabIndex = 13;
            this.btnPopDESC.Text = " &v DESC";
            this.cityToolTip.SetToolTip(this.btnPopDESC, "Sort by decending population");
            this.btnPopDESC.UseVisualStyleBackColor = true;
            this.btnPopDESC.Click += new System.EventHandler(this.btnPopDESC_Click);
            // 
            // btnNameZA
            // 
            this.btnNameZA.Location = new System.Drawing.Point(36, 98);
            this.btnNameZA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNameZA.Name = "btnNameZA";
            this.btnNameZA.Size = new System.Drawing.Size(95, 32);
            this.btnNameZA.TabIndex = 14;
            this.btnNameZA.Text = "&Z-A";
            this.cityToolTip.SetToolTip(this.btnNameZA, "Sort Z to A");
            this.btnNameZA.UseVisualStyleBackColor = true;
            this.btnNameZA.Click += new System.EventHandler(this.btnNameZA_Click);
            // 
            // btnNameAZ
            // 
            this.btnNameAZ.Location = new System.Drawing.Point(36, 58);
            this.btnNameAZ.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnNameAZ.Name = "btnNameAZ";
            this.btnNameAZ.Size = new System.Drawing.Size(95, 32);
            this.btnNameAZ.TabIndex = 15;
            this.btnNameAZ.Text = "&A-Z";
            this.cityToolTip.SetToolTip(this.btnNameAZ, "Sort A to Z");
            this.btnNameAZ.UseVisualStyleBackColor = true;
            this.btnNameAZ.Click += new System.EventHandler(this.btnNameAZ_Click);
            // 
            // CityBindingNav
            // 
            this.CityBindingNav.AddNewItem = null;
            this.CityBindingNav.BindingSource = this.cityBindingSource;
            this.CityBindingNav.CountItem = this.bindingNavigatorCountItem;
            this.CityBindingNav.DeleteItem = null;
            this.CityBindingNav.Dock = System.Windows.Forms.DockStyle.None;
            this.CityBindingNav.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2});
            this.CityBindingNav.Location = new System.Drawing.Point(147, 105);
            this.CityBindingNav.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.CityBindingNav.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.CityBindingNav.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.CityBindingNav.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.CityBindingNav.Name = "CityBindingNav";
            this.CityBindingNav.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.CityBindingNav.PositionItem = this.bindingNavigatorPositionItem;
            this.CityBindingNav.Size = new System.Drawing.Size(233, 25);
            this.CityBindingNav.TabIndex = 16;
            this.CityBindingNav.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(73, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnClacStat
            // 
            this.btnClacStat.Location = new System.Drawing.Point(673, 58);
            this.btnClacStat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClacStat.Name = "btnClacStat";
            this.btnClacStat.Size = new System.Drawing.Size(112, 55);
            this.btnClacStat.TabIndex = 17;
            this.btnClacStat.Text = "&Calculate Stats";
            this.cityToolTip.SetToolTip(this.btnClacStat, "Calculate population stats");
            this.btnClacStat.UseVisualStyleBackColor = true;
            this.btnClacStat.Click += new System.EventHandler(this.btnClacStat_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(587, 146);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "Total Population";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(561, 179);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "Average Population";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(567, 213);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "Highest Population";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(568, 246);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "Lowest Population";
            // 
            // tBTotal
            // 
            this.tBTotal.Location = new System.Drawing.Point(719, 143);
            this.tBTotal.Name = "tBTotal";
            this.tBTotal.Size = new System.Drawing.Size(114, 26);
            this.tBTotal.TabIndex = 22;
            // 
            // tBAvg
            // 
            this.tBAvg.Location = new System.Drawing.Point(719, 176);
            this.tBAvg.Name = "tBAvg";
            this.tBAvg.Size = new System.Drawing.Size(114, 26);
            this.tBAvg.TabIndex = 23;
            // 
            // tBHigh
            // 
            this.tBHigh.Location = new System.Drawing.Point(719, 210);
            this.tBHigh.Name = "tBHigh";
            this.tBHigh.Size = new System.Drawing.Size(114, 26);
            this.tBHigh.TabIndex = 24;
            // 
            // tBLow
            // 
            this.tBLow.Location = new System.Drawing.Point(719, 243);
            this.tBLow.Name = "tBLow";
            this.tBLow.Size = new System.Drawing.Size(114, 26);
            this.tBLow.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(652, 341);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 18);
            this.label5.TabIndex = 26;
            this.label5.Text = "Add and Edit Cities";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(614, 405);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(44, 18);
            cityLabel.TabIndex = 26;
            cityLabel.Text = "City:";
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(664, 402);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(169, 26);
            this.cityTextBox.TabIndex = 27;
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(603, 452);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(55, 18);
            stateLabel.TabIndex = 27;
            stateLabel.Text = "State:";
            // 
            // stateTextBox
            // 
            this.stateTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "State", true));
            this.stateTextBox.Location = new System.Drawing.Point(664, 449);
            this.stateTextBox.Name = "stateTextBox";
            this.stateTextBox.Size = new System.Drawing.Size(169, 26);
            this.stateTextBox.TabIndex = 28;
            // 
            // populationLabel
            // 
            populationLabel.AutoSize = true;
            populationLabel.Location = new System.Drawing.Point(566, 495);
            populationLabel.Name = "populationLabel";
            populationLabel.Size = new System.Drawing.Size(92, 18);
            populationLabel.TabIndex = 28;
            populationLabel.Text = "Population:";
            // 
            // populationTextBox
            // 
            this.populationTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.cityBindingSource, "Population", true));
            this.populationTextBox.Location = new System.Drawing.Point(664, 492);
            this.populationTextBox.Name = "populationTextBox";
            this.populationTextBox.Size = new System.Drawing.Size(169, 26);
            this.populationTextBox.TabIndex = 29;
            // 
            // btnCitySave
            // 
            this.btnCitySave.Location = new System.Drawing.Point(542, 560);
            this.btnCitySave.Name = "btnCitySave";
            this.btnCitySave.Size = new System.Drawing.Size(110, 52);
            this.btnCitySave.TabIndex = 30;
            this.btnCitySave.Text = "&Save";
            this.cityToolTip.SetToolTip(this.btnCitySave, "Save new city to database");
            this.btnCitySave.UseVisualStyleBackColor = true;
            this.btnCitySave.Visible = false;
            this.btnCitySave.Click += new System.EventHandler(this.btnCitySave_Click);
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "City";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            this.cityDataGridViewTextBoxColumn.Width = 62;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "State";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            this.stateDataGridViewTextBoxColumn.Width = 73;
            // 
            // populationDataGridViewTextBoxColumn
            // 
            this.populationDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.populationDataGridViewTextBoxColumn.DataPropertyName = "Population";
            this.populationDataGridViewTextBoxColumn.HeaderText = "Population";
            this.populationDataGridViewTextBoxColumn.Name = "populationDataGridViewTextBoxColumn";
            this.populationDataGridViewTextBoxColumn.ReadOnly = true;
            this.populationDataGridViewTextBoxColumn.Width = 110;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(775, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(110, 52);
            this.btnDelete.TabIndex = 31;
            this.btnDelete.Text = "&Delete";
            this.cityToolTip.SetToolTip(this.btnDelete, "Delete selected city");
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnCityNew
            // 
            this.btnCityNew.Location = new System.Drawing.Point(543, 560);
            this.btnCityNew.Name = "btnCityNew";
            this.btnCityNew.Size = new System.Drawing.Size(110, 52);
            this.btnCityNew.TabIndex = 32;
            this.btnCityNew.Text = "&New";
            this.cityToolTip.SetToolTip(this.btnCityNew, "Add new city");
            this.btnCityNew.UseVisualStyleBackColor = true;
            this.btnCityNew.Click += new System.EventHandler(this.btnCityNew_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(659, 560);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(110, 52);
            this.btnEdit.TabIndex = 33;
            this.btnEdit.Text = "&Edit";
            this.cityToolTip.SetToolTip(this.btnEdit, "Edit existing selected city");
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(775, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 52);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "Ca&ncel";
            this.cityToolTip.SetToolTip(this.btnCancel, "Delete selected city");
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(918, 734);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnCityNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCitySave);
            this.Controls.Add(populationLabel);
            this.Controls.Add(this.populationTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tBLow);
            this.Controls.Add(this.tBHigh);
            this.Controls.Add(this.tBAvg);
            this.Controls.Add(this.tBTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClacStat);
            this.Controls.Add(this.CityBindingNav);
            this.Controls.Add(this.btnNameAZ);
            this.Controls.Add(this.btnNameZA);
            this.Controls.Add(this.btnPopDESC);
            this.Controls.Add(this.btnPopASC);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.dgvCity);
            this.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MMcDonough Lab 2";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CityBindingNav)).EndInit();
            this.CityBindingNav.ResumeLayout(false);
            this.CityBindingNav.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CityDBDataSet cityDBDataSet;
        private System.Windows.Forms.BindingSource cityBindingSource;
        private CityDBDataSetTableAdapters.CityTableAdapter cityTableAdapter;
        private CityDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dgvCity;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnPopASC;
        private System.Windows.Forms.Button btnPopDESC;
        private System.Windows.Forms.Button btnNameZA;
        private System.Windows.Forms.Button btnNameAZ;
        private System.Windows.Forms.BindingNavigator CityBindingNav;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.Button btnClacStat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tBTotal;
        private System.Windows.Forms.TextBox tBAvg;
        private System.Windows.Forms.TextBox tBHigh;
        private System.Windows.Forms.TextBox tBLow;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.TextBox stateTextBox;
        private System.Windows.Forms.TextBox populationTextBox;
        private System.Windows.Forms.Button btnCitySave;
        private System.Windows.Forms.DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn populationDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnCityNew;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.ToolTip cityToolTip;
        private System.Windows.Forms.Button btnCancel;
    }
}


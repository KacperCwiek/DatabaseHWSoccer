namespace DatabaseHWSoccer
{
    partial class PlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PlayersForm));
            this.playersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.playersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.playersDataGridView = new System.Windows.Forms.DataGridView();
            this.manUPlayersShowButton = new System.Windows.Forms.Button();
            this.maxGoalButton = new System.Windows.Forms.Button();
            this.spainPlayersButton = new System.Windows.Forms.Button();
            this.sortByTeamButton = new System.Windows.Forms.Button();
            this.greaterOrEqualButton = new System.Windows.Forms.Button();
            this.showEnglishPlayersButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.clearAndShowButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.searchLastNameTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.showAllButton = new System.Windows.Forms.Button();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.soccerDataSet = new DatabaseHWSoccer.SoccerDataSet();
            this.playersTableAdapter = new DatabaseHWSoccer.SoccerDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new DatabaseHWSoccer.SoccerDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).BeginInit();
            this.playersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // playersBindingNavigator
            // 
            this.playersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.playersBindingNavigator.BindingSource = this.playersBindingSource;
            this.playersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.playersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.playersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.playersBindingNavigatorSaveItem});
            this.playersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.playersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.playersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.playersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.playersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.playersBindingNavigator.Name = "playersBindingNavigator";
            this.playersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.playersBindingNavigator.Size = new System.Drawing.Size(1188, 25);
            this.playersBindingNavigator.TabIndex = 0;
            this.playersBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
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
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // playersBindingNavigatorSaveItem
            // 
            this.playersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersBindingNavigatorSaveItem.Image")));
            this.playersBindingNavigatorSaveItem.Name = "playersBindingNavigatorSaveItem";
            this.playersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.playersBindingNavigatorSaveItem.Text = "Save Data";
            this.playersBindingNavigatorSaveItem.Click += new System.EventHandler(this.playersBindingNavigatorSaveItem_Click);
            // 
            // playersDataGridView
            // 
            this.playersDataGridView.AutoGenerateColumns = false;
            this.playersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.playersDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10});
            this.playersDataGridView.DataSource = this.playersBindingSource;
            this.playersDataGridView.Location = new System.Drawing.Point(12, 28);
            this.playersDataGridView.Name = "playersDataGridView";
            this.playersDataGridView.Size = new System.Drawing.Size(1073, 221);
            this.playersDataGridView.TabIndex = 1;
            // 
            // manUPlayersShowButton
            // 
            this.manUPlayersShowButton.Location = new System.Drawing.Point(36, 285);
            this.manUPlayersShowButton.Name = "manUPlayersShowButton";
            this.manUPlayersShowButton.Size = new System.Drawing.Size(75, 41);
            this.manUPlayersShowButton.TabIndex = 2;
            this.manUPlayersShowButton.Text = "ManU Players";
            this.manUPlayersShowButton.UseVisualStyleBackColor = true;
            this.manUPlayersShowButton.Click += new System.EventHandler(this.manUPlayersShowButton_Click);
            // 
            // maxGoalButton
            // 
            this.maxGoalButton.Location = new System.Drawing.Point(36, 344);
            this.maxGoalButton.Name = "maxGoalButton";
            this.maxGoalButton.Size = new System.Drawing.Size(75, 40);
            this.maxGoalButton.TabIndex = 3;
            this.maxGoalButton.Text = "Max Goal Player";
            this.maxGoalButton.UseVisualStyleBackColor = true;
            this.maxGoalButton.Click += new System.EventHandler(this.maxGoalButton_Click);
            // 
            // spainPlayersButton
            // 
            this.spainPlayersButton.Location = new System.Drawing.Point(159, 285);
            this.spainPlayersButton.Name = "spainPlayersButton";
            this.spainPlayersButton.Size = new System.Drawing.Size(86, 41);
            this.spainPlayersButton.TabIndex = 4;
            this.spainPlayersButton.Text = "Spain Players";
            this.spainPlayersButton.UseVisualStyleBackColor = true;
            this.spainPlayersButton.Click += new System.EventHandler(this.spainPlayersButton_Click);
            // 
            // sortByTeamButton
            // 
            this.sortByTeamButton.Location = new System.Drawing.Point(159, 344);
            this.sortByTeamButton.Name = "sortByTeamButton";
            this.sortByTeamButton.Size = new System.Drawing.Size(86, 40);
            this.sortByTeamButton.TabIndex = 5;
            this.sortByTeamButton.Text = "Sort By Teams";
            this.sortByTeamButton.UseVisualStyleBackColor = true;
            this.sortByTeamButton.Click += new System.EventHandler(this.sortByTeamButton_Click);
            // 
            // greaterOrEqualButton
            // 
            this.greaterOrEqualButton.Location = new System.Drawing.Point(296, 285);
            this.greaterOrEqualButton.Name = "greaterOrEqualButton";
            this.greaterOrEqualButton.Size = new System.Drawing.Size(84, 41);
            this.greaterOrEqualButton.TabIndex = 6;
            this.greaterOrEqualButton.Text = "= or > 20 Goals";
            this.greaterOrEqualButton.UseVisualStyleBackColor = true;
            this.greaterOrEqualButton.Click += new System.EventHandler(this.greaterOrEqualButton_Click);
            // 
            // showEnglishPlayersButton
            // 
            this.showEnglishPlayersButton.Location = new System.Drawing.Point(296, 344);
            this.showEnglishPlayersButton.Name = "showEnglishPlayersButton";
            this.showEnglishPlayersButton.Size = new System.Drawing.Size(84, 58);
            this.showEnglishPlayersButton.TabIndex = 7;
            this.showEnglishPlayersButton.Text = "Show England Players on the New Form";
            this.showEnglishPlayersButton.UseVisualStyleBackColor = true;
            this.showEnglishPlayersButton.Click += new System.EventHandler(this.showEnglishPlayersButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.clearAndShowButton);
            this.groupBox1.Controls.Add(this.searchButton);
            this.groupBox1.Controls.Add(this.searchLastNameTextbox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(470, 285);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 135);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Enter Players to Find";
            // 
            // clearAndShowButton
            // 
            this.clearAndShowButton.Location = new System.Drawing.Point(136, 88);
            this.clearAndShowButton.Name = "clearAndShowButton";
            this.clearAndShowButton.Size = new System.Drawing.Size(65, 41);
            this.clearAndShowButton.TabIndex = 3;
            this.clearAndShowButton.Text = "Clear and Show All";
            this.clearAndShowButton.UseVisualStyleBackColor = true;
            this.clearAndShowButton.Click += new System.EventHandler(this.clearAndShowButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(32, 68);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 2;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // searchLastNameTextbox
            // 
            this.searchLastNameTextbox.Location = new System.Drawing.Point(32, 44);
            this.searchLastNameTextbox.Name = "searchLastNameTextbox";
            this.searchLastNameTextbox.Size = new System.Drawing.Size(100, 20);
            this.searchLastNameTextbox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter Last Name to find:";
            // 
            // showAllButton
            // 
            this.showAllButton.Location = new System.Drawing.Point(769, 285);
            this.showAllButton.Name = "showAllButton";
            this.showAllButton.Size = new System.Drawing.Size(127, 135);
            this.showAllButton.TabIndex = 9;
            this.showAllButton.Text = "Show All Players";
            this.showAllButton.UseVisualStyleBackColor = true;
            this.showAllButton.Click += new System.EventHandler(this.showAllButton_Click);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "FIFA_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "FIFA_ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Player_Number";
            this.dataGridViewTextBoxColumn2.HeaderText = "Player_Number";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Last_Name";
            this.dataGridViewTextBoxColumn3.HeaderText = "Last_Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "First_Name";
            this.dataGridViewTextBoxColumn4.HeaderText = "First_Name";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Team_Name";
            this.dataGridViewTextBoxColumn5.HeaderText = "Team_Name";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "League";
            this.dataGridViewTextBoxColumn6.HeaderText = "League";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Games_Played";
            this.dataGridViewTextBoxColumn7.HeaderText = "Games_Played";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Goals";
            this.dataGridViewTextBoxColumn8.HeaderText = "Goals";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Assists";
            this.dataGridViewTextBoxColumn9.HeaderText = "Assists";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Coach_ID";
            this.dataGridViewTextBoxColumn10.HeaderText = "Coach_ID";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.soccerDataSet;
            // 
            // soccerDataSet
            // 
            this.soccerDataSet.DataSetName = "SoccerDataSet";
            this.soccerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersTableAdapter
            // 
            this.playersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CoachTableAdapter = null;
            this.tableAdapterManager.PlayersTableAdapter = this.playersTableAdapter;
            this.tableAdapterManager.UpdateOrder = DatabaseHWSoccer.SoccerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // PlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1188, 432);
            this.Controls.Add(this.showAllButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.showEnglishPlayersButton);
            this.Controls.Add(this.greaterOrEqualButton);
            this.Controls.Add(this.sortByTeamButton);
            this.Controls.Add(this.spainPlayersButton);
            this.Controls.Add(this.maxGoalButton);
            this.Controls.Add(this.manUPlayersShowButton);
            this.Controls.Add(this.playersDataGridView);
            this.Controls.Add(this.playersBindingNavigator);
            this.Name = "PlayersForm";
            this.Text = "PlayersForm";
            this.Load += new System.EventHandler(this.PlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).EndInit();
            this.playersBindingNavigator.ResumeLayout(false);
            this.playersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.soccerDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SoccerDataSet soccerDataSet;
        private System.Windows.Forms.BindingSource playersBindingSource;
        private SoccerDataSetTableAdapters.PlayersTableAdapter playersTableAdapter;
        private SoccerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator playersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton playersBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView playersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.Button manUPlayersShowButton;
        private System.Windows.Forms.Button maxGoalButton;
        private System.Windows.Forms.Button spainPlayersButton;
        private System.Windows.Forms.Button sortByTeamButton;
        private System.Windows.Forms.Button greaterOrEqualButton;
        private System.Windows.Forms.Button showEnglishPlayersButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button clearAndShowButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.TextBox searchLastNameTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button showAllButton;
    }
}
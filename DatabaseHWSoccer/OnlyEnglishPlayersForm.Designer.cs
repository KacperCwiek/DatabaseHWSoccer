namespace DatabaseHWSoccer
{
    partial class OnlyEnglishPlayersForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OnlyEnglishPlayersForm));
            System.Windows.Forms.Label fIFA_IDLabel;
            System.Windows.Forms.Label player_NumberLabel;
            System.Windows.Forms.Label last_NameLabel;
            System.Windows.Forms.Label first_NameLabel;
            System.Windows.Forms.Label team_NameLabel;
            System.Windows.Forms.Label leagueLabel;
            System.Windows.Forms.Label games_PlayedLabel;
            System.Windows.Forms.Label goalsLabel;
            System.Windows.Forms.Label assistsLabel;
            System.Windows.Forms.Label coach_IDLabel;
            this.soccerDataSet = new DatabaseHWSoccer.SoccerDataSet();
            this.playersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.playersTableAdapter = new DatabaseHWSoccer.SoccerDataSetTableAdapters.PlayersTableAdapter();
            this.tableAdapterManager = new DatabaseHWSoccer.SoccerDataSetTableAdapters.TableAdapterManager();
            this.playersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.playersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.fIFA_IDTextBox = new System.Windows.Forms.TextBox();
            this.player_NumberTextBox = new System.Windows.Forms.TextBox();
            this.last_NameTextBox = new System.Windows.Forms.TextBox();
            this.first_NameTextBox = new System.Windows.Forms.TextBox();
            this.team_NameTextBox = new System.Windows.Forms.TextBox();
            this.leagueTextBox = new System.Windows.Forms.TextBox();
            this.games_PlayedTextBox = new System.Windows.Forms.TextBox();
            this.goalsTextBox = new System.Windows.Forms.TextBox();
            this.assistsTextBox = new System.Windows.Forms.TextBox();
            this.coach_IDTextBox = new System.Windows.Forms.TextBox();
            fIFA_IDLabel = new System.Windows.Forms.Label();
            player_NumberLabel = new System.Windows.Forms.Label();
            last_NameLabel = new System.Windows.Forms.Label();
            first_NameLabel = new System.Windows.Forms.Label();
            team_NameLabel = new System.Windows.Forms.Label();
            leagueLabel = new System.Windows.Forms.Label();
            games_PlayedLabel = new System.Windows.Forms.Label();
            goalsLabel = new System.Windows.Forms.Label();
            assistsLabel = new System.Windows.Forms.Label();
            coach_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.soccerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).BeginInit();
            this.playersBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // soccerDataSet
            // 
            this.soccerDataSet.DataSetName = "SoccerDataSet";
            this.soccerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // playersBindingSource
            // 
            this.playersBindingSource.DataMember = "Players";
            this.playersBindingSource.DataSource = this.soccerDataSet;
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
            this.playersBindingNavigator.Size = new System.Drawing.Size(595, 25);
            this.playersBindingNavigator.TabIndex = 0;
            this.playersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
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
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // playersBindingNavigatorSaveItem
            // 
            this.playersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.playersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("playersBindingNavigatorSaveItem.Image")));
            this.playersBindingNavigatorSaveItem.Name = "playersBindingNavigatorSaveItem";
            this.playersBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.playersBindingNavigatorSaveItem.Text = "Save Data";
            this.playersBindingNavigatorSaveItem.Click += new System.EventHandler(this.playersBindingNavigatorSaveItem_Click);
            // 
            // fIFA_IDLabel
            // 
            fIFA_IDLabel.AutoSize = true;
            fIFA_IDLabel.Location = new System.Drawing.Point(167, 84);
            fIFA_IDLabel.Name = "fIFA_IDLabel";
            fIFA_IDLabel.Size = new System.Drawing.Size(46, 13);
            fIFA_IDLabel.TabIndex = 1;
            fIFA_IDLabel.Text = "FIFA ID:";
            // 
            // fIFA_IDTextBox
            // 
            this.fIFA_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "FIFA_ID", true));
            this.fIFA_IDTextBox.Location = new System.Drawing.Point(252, 81);
            this.fIFA_IDTextBox.Name = "fIFA_IDTextBox";
            this.fIFA_IDTextBox.Size = new System.Drawing.Size(184, 20);
            this.fIFA_IDTextBox.TabIndex = 2;
            // 
            // player_NumberLabel
            // 
            player_NumberLabel.AutoSize = true;
            player_NumberLabel.Location = new System.Drawing.Point(167, 110);
            player_NumberLabel.Name = "player_NumberLabel";
            player_NumberLabel.Size = new System.Drawing.Size(79, 13);
            player_NumberLabel.TabIndex = 3;
            player_NumberLabel.Text = "Player Number:";
            // 
            // player_NumberTextBox
            // 
            this.player_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Player_Number", true));
            this.player_NumberTextBox.Location = new System.Drawing.Point(252, 107);
            this.player_NumberTextBox.Name = "player_NumberTextBox";
            this.player_NumberTextBox.Size = new System.Drawing.Size(184, 20);
            this.player_NumberTextBox.TabIndex = 4;
            // 
            // last_NameLabel
            // 
            last_NameLabel.AutoSize = true;
            last_NameLabel.Location = new System.Drawing.Point(167, 136);
            last_NameLabel.Name = "last_NameLabel";
            last_NameLabel.Size = new System.Drawing.Size(61, 13);
            last_NameLabel.TabIndex = 5;
            last_NameLabel.Text = "Last Name:";
            // 
            // last_NameTextBox
            // 
            this.last_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Last_Name", true));
            this.last_NameTextBox.Location = new System.Drawing.Point(252, 133);
            this.last_NameTextBox.Name = "last_NameTextBox";
            this.last_NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.last_NameTextBox.TabIndex = 6;
            // 
            // first_NameLabel
            // 
            first_NameLabel.AutoSize = true;
            first_NameLabel.Location = new System.Drawing.Point(167, 162);
            first_NameLabel.Name = "first_NameLabel";
            first_NameLabel.Size = new System.Drawing.Size(60, 13);
            first_NameLabel.TabIndex = 7;
            first_NameLabel.Text = "First Name:";
            // 
            // first_NameTextBox
            // 
            this.first_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "First_Name", true));
            this.first_NameTextBox.Location = new System.Drawing.Point(252, 159);
            this.first_NameTextBox.Name = "first_NameTextBox";
            this.first_NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.first_NameTextBox.TabIndex = 8;
            // 
            // team_NameLabel
            // 
            team_NameLabel.AutoSize = true;
            team_NameLabel.Location = new System.Drawing.Point(167, 188);
            team_NameLabel.Name = "team_NameLabel";
            team_NameLabel.Size = new System.Drawing.Size(68, 13);
            team_NameLabel.TabIndex = 9;
            team_NameLabel.Text = "Team Name:";
            // 
            // team_NameTextBox
            // 
            this.team_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Team_Name", true));
            this.team_NameTextBox.Location = new System.Drawing.Point(252, 185);
            this.team_NameTextBox.Name = "team_NameTextBox";
            this.team_NameTextBox.Size = new System.Drawing.Size(184, 20);
            this.team_NameTextBox.TabIndex = 10;
            // 
            // leagueLabel
            // 
            leagueLabel.AutoSize = true;
            leagueLabel.Location = new System.Drawing.Point(167, 214);
            leagueLabel.Name = "leagueLabel";
            leagueLabel.Size = new System.Drawing.Size(46, 13);
            leagueLabel.TabIndex = 11;
            leagueLabel.Text = "League:";
            // 
            // leagueTextBox
            // 
            this.leagueTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "League", true));
            this.leagueTextBox.Location = new System.Drawing.Point(252, 211);
            this.leagueTextBox.Name = "leagueTextBox";
            this.leagueTextBox.Size = new System.Drawing.Size(184, 20);
            this.leagueTextBox.TabIndex = 12;
            // 
            // games_PlayedLabel
            // 
            games_PlayedLabel.AutoSize = true;
            games_PlayedLabel.Location = new System.Drawing.Point(167, 240);
            games_PlayedLabel.Name = "games_PlayedLabel";
            games_PlayedLabel.Size = new System.Drawing.Size(78, 13);
            games_PlayedLabel.TabIndex = 13;
            games_PlayedLabel.Text = "Games Played:";
            // 
            // games_PlayedTextBox
            // 
            this.games_PlayedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Games_Played", true));
            this.games_PlayedTextBox.Location = new System.Drawing.Point(252, 237);
            this.games_PlayedTextBox.Name = "games_PlayedTextBox";
            this.games_PlayedTextBox.Size = new System.Drawing.Size(184, 20);
            this.games_PlayedTextBox.TabIndex = 14;
            // 
            // goalsLabel
            // 
            goalsLabel.AutoSize = true;
            goalsLabel.Location = new System.Drawing.Point(167, 266);
            goalsLabel.Name = "goalsLabel";
            goalsLabel.Size = new System.Drawing.Size(37, 13);
            goalsLabel.TabIndex = 15;
            goalsLabel.Text = "Goals:";
            // 
            // goalsTextBox
            // 
            this.goalsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Goals", true));
            this.goalsTextBox.Location = new System.Drawing.Point(252, 263);
            this.goalsTextBox.Name = "goalsTextBox";
            this.goalsTextBox.Size = new System.Drawing.Size(184, 20);
            this.goalsTextBox.TabIndex = 16;
            // 
            // assistsLabel
            // 
            assistsLabel.AutoSize = true;
            assistsLabel.Location = new System.Drawing.Point(167, 292);
            assistsLabel.Name = "assistsLabel";
            assistsLabel.Size = new System.Drawing.Size(42, 13);
            assistsLabel.TabIndex = 17;
            assistsLabel.Text = "Assists:";
            // 
            // assistsTextBox
            // 
            this.assistsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Assists", true));
            this.assistsTextBox.Location = new System.Drawing.Point(252, 289);
            this.assistsTextBox.Name = "assistsTextBox";
            this.assistsTextBox.Size = new System.Drawing.Size(184, 20);
            this.assistsTextBox.TabIndex = 18;
            // 
            // coach_IDLabel
            // 
            coach_IDLabel.AutoSize = true;
            coach_IDLabel.Location = new System.Drawing.Point(167, 318);
            coach_IDLabel.Name = "coach_IDLabel";
            coach_IDLabel.Size = new System.Drawing.Size(55, 13);
            coach_IDLabel.TabIndex = 19;
            coach_IDLabel.Text = "Coach ID:";
            // 
            // coach_IDTextBox
            // 
            this.coach_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.playersBindingSource, "Coach_ID", true));
            this.coach_IDTextBox.Location = new System.Drawing.Point(252, 315);
            this.coach_IDTextBox.Name = "coach_IDTextBox";
            this.coach_IDTextBox.Size = new System.Drawing.Size(184, 20);
            this.coach_IDTextBox.TabIndex = 20;
            // 
            // OnlyEnglishPlayersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 432);
            this.Controls.Add(fIFA_IDLabel);
            this.Controls.Add(this.fIFA_IDTextBox);
            this.Controls.Add(player_NumberLabel);
            this.Controls.Add(this.player_NumberTextBox);
            this.Controls.Add(last_NameLabel);
            this.Controls.Add(this.last_NameTextBox);
            this.Controls.Add(first_NameLabel);
            this.Controls.Add(this.first_NameTextBox);
            this.Controls.Add(team_NameLabel);
            this.Controls.Add(this.team_NameTextBox);
            this.Controls.Add(leagueLabel);
            this.Controls.Add(this.leagueTextBox);
            this.Controls.Add(games_PlayedLabel);
            this.Controls.Add(this.games_PlayedTextBox);
            this.Controls.Add(goalsLabel);
            this.Controls.Add(this.goalsTextBox);
            this.Controls.Add(assistsLabel);
            this.Controls.Add(this.assistsTextBox);
            this.Controls.Add(coach_IDLabel);
            this.Controls.Add(this.coach_IDTextBox);
            this.Controls.Add(this.playersBindingNavigator);
            this.Name = "OnlyEnglishPlayersForm";
            this.Text = "OnlyEnglishPlayersForm";
            this.Load += new System.EventHandler(this.OnlyEnglishPlayersForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.soccerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.playersBindingNavigator)).EndInit();
            this.playersBindingNavigator.ResumeLayout(false);
            this.playersBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.TextBox fIFA_IDTextBox;
        private System.Windows.Forms.TextBox player_NumberTextBox;
        private System.Windows.Forms.TextBox last_NameTextBox;
        private System.Windows.Forms.TextBox first_NameTextBox;
        private System.Windows.Forms.TextBox team_NameTextBox;
        private System.Windows.Forms.TextBox leagueTextBox;
        private System.Windows.Forms.TextBox games_PlayedTextBox;
        private System.Windows.Forms.TextBox goalsTextBox;
        private System.Windows.Forms.TextBox assistsTextBox;
        private System.Windows.Forms.TextBox coach_IDTextBox;
    }
}
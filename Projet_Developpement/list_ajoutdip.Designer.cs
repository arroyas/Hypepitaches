namespace Projet_Developpement
{
    partial class list_ajoutdip
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_ajoutdip));
            System.Windows.Forms.Label dIPLOME_IDLabel;
            System.Windows.Forms.Label dIPLOME_NOMLabel;
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.dIPLOMEBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.dIPLOMEBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.dIPLOME_IDTextBox = new System.Windows.Forms.TextBox();
            this.dIPLOME_NOMTextBox = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            dIPLOME_IDLabel = new System.Windows.Forms.Label();
            dIPLOME_NOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMEBindingNavigator)).BeginInit();
            this.dIPLOMEBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.DIPLOME);
            this.bs.CurrentChanged += new System.EventHandler(this.bs_CurrentChanged_1);
            // 
            // dIPLOMEBindingNavigator
            // 
            this.dIPLOMEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dIPLOMEBindingNavigator.BindingSource = this.bs;
            this.dIPLOMEBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.dIPLOMEBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.dIPLOMEBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.dIPLOMEBindingNavigatorSaveItem});
            this.dIPLOMEBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.dIPLOMEBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.dIPLOMEBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.dIPLOMEBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.dIPLOMEBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.dIPLOMEBindingNavigator.Name = "dIPLOMEBindingNavigator";
            this.dIPLOMEBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.dIPLOMEBindingNavigator.Size = new System.Drawing.Size(381, 25);
            this.dIPLOMEBindingNavigator.TabIndex = 0;
            this.dIPLOMEBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Placer en premier";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Déplacer vers le haut";
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
            this.bindingNavigatorPositionItem.ToolTipText = "Position actuelle";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Nombre total d\'éléments";
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
            this.bindingNavigatorMoveNextItem.Text = "Déplacer vers le bas";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Placer en dernier";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Ajouter nouveau";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Supprimer";
            // 
            // dIPLOMEBindingNavigatorSaveItem
            // 
            this.dIPLOMEBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.dIPLOMEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dIPLOMEBindingNavigatorSaveItem.Image")));
            this.dIPLOMEBindingNavigatorSaveItem.Name = "dIPLOMEBindingNavigatorSaveItem";
            this.dIPLOMEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dIPLOMEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.dIPLOMEBindingNavigatorSaveItem.Click += new System.EventHandler(this.dIPLOMEBindingNavigatorSaveItem_Click);
            // 
            // dIPLOME_IDLabel
            // 
            dIPLOME_IDLabel.AutoSize = true;
            dIPLOME_IDLabel.Location = new System.Drawing.Point(94, 82);
            dIPLOME_IDLabel.Name = "dIPLOME_IDLabel";
            dIPLOME_IDLabel.Size = new System.Drawing.Size(72, 13);
            dIPLOME_IDLabel.TabIndex = 1;
            dIPLOME_IDLabel.Text = "DIPLOME ID:";
            // 
            // dIPLOME_IDTextBox
            // 
            this.dIPLOME_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DIPLOME_ID", true));
            this.dIPLOME_IDTextBox.Location = new System.Drawing.Point(186, 79);
            this.dIPLOME_IDTextBox.Name = "dIPLOME_IDTextBox";
            this.dIPLOME_IDTextBox.ReadOnly = true;
            this.dIPLOME_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIPLOME_IDTextBox.TabIndex = 2;
            // 
            // dIPLOME_NOMLabel
            // 
            dIPLOME_NOMLabel.AutoSize = true;
            dIPLOME_NOMLabel.Location = new System.Drawing.Point(94, 108);
            dIPLOME_NOMLabel.Name = "dIPLOME_NOMLabel";
            dIPLOME_NOMLabel.Size = new System.Drawing.Size(86, 13);
            dIPLOME_NOMLabel.TabIndex = 3;
            dIPLOME_NOMLabel.Text = "DIPLOME NOM:";
            // 
            // dIPLOME_NOMTextBox
            // 
            this.dIPLOME_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "DIPLOME_NOM", true));
            this.dIPLOME_NOMTextBox.Location = new System.Drawing.Point(186, 105);
            this.dIPLOME_NOMTextBox.Name = "dIPLOME_NOMTextBox";
            this.dIPLOME_NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.dIPLOME_NOMTextBox.TabIndex = 4;
            // 
            // list_ajoutdip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(381, 184);
            this.Controls.Add(dIPLOME_IDLabel);
            this.Controls.Add(this.dIPLOME_IDTextBox);
            this.Controls.Add(dIPLOME_NOMLabel);
            this.Controls.Add(this.dIPLOME_NOMTextBox);
            this.Controls.Add(this.dIPLOMEBindingNavigator);
            this.Name = "list_ajoutdip";
            this.Text = "list_ajoutdip";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMEBindingNavigator)).EndInit();
            this.dIPLOMEBindingNavigator.ResumeLayout(false);
            this.dIPLOMEBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator dIPLOMEBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton dIPLOMEBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox dIPLOME_IDTextBox;
        private System.Windows.Forms.TextBox dIPLOME_NOMTextBox;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;

    }
}
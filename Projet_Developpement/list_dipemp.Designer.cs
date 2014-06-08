namespace Projet_Developpement
{
    partial class list_dipemp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_dipemp));
            this.bs_dip = new System.Windows.Forms.BindingSource(this.components);
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
            this.lb_autreDip = new System.Windows.Forms.ListBox();
            this.bs_dipemp = new System.Windows.Forms.BindingSource(this.components);
            this.lb_dipPoss = new System.Windows.Forms.ListBox();
            this.btn_poss = new System.Windows.Forms.Button();
            this.btn_autres = new System.Windows.Forms.Button();
            this.bs_emp = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bs_dip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMEBindingNavigator)).BeginInit();
            this.dIPLOMEBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dipemp)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_emp)).BeginInit();
            this.SuspendLayout();
            // 
            // bs_dip
            // 
            this.bs_dip.DataSource = typeof(Projet_Developpement.DIPLOME);
            // 
            // dIPLOMEBindingNavigator
            // 
            this.dIPLOMEBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.dIPLOMEBindingNavigator.BindingSource = this.bs_dip;
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
            this.dIPLOMEBindingNavigator.Size = new System.Drawing.Size(596, 25);
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
            this.dIPLOMEBindingNavigatorSaveItem.Enabled = false;
            this.dIPLOMEBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("dIPLOMEBindingNavigatorSaveItem.Image")));
            this.dIPLOMEBindingNavigatorSaveItem.Name = "dIPLOMEBindingNavigatorSaveItem";
            this.dIPLOMEBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.dIPLOMEBindingNavigatorSaveItem.Text = "Enregistrer les données";
            // 
            // lb_autreDip
            // 
            this.lb_autreDip.DataSource = this.bs_dip;
            this.lb_autreDip.DisplayMember = "DIPLOME_NOM";
            this.lb_autreDip.FormattingEnabled = true;
            this.lb_autreDip.Location = new System.Drawing.Point(351, 96);
            this.lb_autreDip.Name = "lb_autreDip";
            this.lb_autreDip.Size = new System.Drawing.Size(186, 160);
            this.lb_autreDip.TabIndex = 1;
            this.lb_autreDip.ValueMember = "DIPLOME_ID";
            this.lb_autreDip.SelectedIndexChanged += new System.EventHandler(this.dIPLOMEListBox_SelectedIndexChanged);
            // 
            // bs_dipemp
            // 
            this.bs_dipemp.DataSource = typeof(Projet_Developpement.DIPLOME);
            // 
            // lb_dipPoss
            // 
            this.lb_dipPoss.DataSource = this.bs_dipemp;
            this.lb_dipPoss.DisplayMember = "DIPLOME_NOM";
            this.lb_dipPoss.FormattingEnabled = true;
            this.lb_dipPoss.Location = new System.Drawing.Point(66, 96);
            this.lb_dipPoss.Name = "lb_dipPoss";
            this.lb_dipPoss.Size = new System.Drawing.Size(189, 160);
            this.lb_dipPoss.TabIndex = 2;
            this.lb_dipPoss.ValueMember = "DIPLOME_ID";
            // 
            // btn_poss
            // 
            this.btn_poss.Location = new System.Drawing.Point(284, 124);
            this.btn_poss.Name = "btn_poss";
            this.btn_poss.Size = new System.Drawing.Size(42, 23);
            this.btn_poss.TabIndex = 3;
            this.btn_poss.Text = "<";
            this.btn_poss.UseVisualStyleBackColor = true;
            this.btn_poss.Click += new System.EventHandler(this.btn_poss_Click);
            // 
            // btn_autres
            // 
            this.btn_autres.Location = new System.Drawing.Point(284, 191);
            this.btn_autres.Name = "btn_autres";
            this.btn_autres.Size = new System.Drawing.Size(42, 23);
            this.btn_autres.TabIndex = 4;
            this.btn_autres.Text = ">";
            this.btn_autres.UseVisualStyleBackColor = true;
            this.btn_autres.Click += new System.EventHandler(this.btn_autres_Click);
            // 
            // bs_emp
            // 
            this.bs_emp.DataSource = typeof(Projet_Developpement.EMPLOYE);
            // 
            // list_dipemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 374);
            this.Controls.Add(this.btn_autres);
            this.Controls.Add(this.btn_poss);
            this.Controls.Add(this.lb_dipPoss);
            this.Controls.Add(this.lb_autreDip);
            this.Controls.Add(this.dIPLOMEBindingNavigator);
            this.Name = "list_dipemp";
            this.Text = "list_dipemp";
            ((System.ComponentModel.ISupportInitialize)(this.bs_dip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dIPLOMEBindingNavigator)).EndInit();
            this.dIPLOMEBindingNavigator.ResumeLayout(false);
            this.dIPLOMEBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs_dipemp)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bs_emp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs_dip;
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
        private System.Windows.Forms.ListBox lb_autreDip;
        private System.Windows.Forms.BindingSource bs_dipemp;
        private System.Windows.Forms.ListBox lb_dipPoss;
        private System.Windows.Forms.Button btn_poss;
        private System.Windows.Forms.Button btn_autres;
        private System.Windows.Forms.BindingSource bs_emp;
    }
}
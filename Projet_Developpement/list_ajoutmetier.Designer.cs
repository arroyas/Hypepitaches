namespace Projet_Developpement
{
    partial class list_ajoutmetier
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(list_ajoutmetier));
            System.Windows.Forms.Label mETIER_DETAILSLabel;
            System.Windows.Forms.Label mETIER_IDLabel;
            System.Windows.Forms.Label mETIER_NOMLabel;
            this.mETIERBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.mETIERBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.mETIER_DETAILSTextBox = new System.Windows.Forms.TextBox();
            this.mETIER_IDTextBox = new System.Windows.Forms.TextBox();
            this.mETIER_NOMTextBox = new System.Windows.Forms.TextBox();
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            mETIER_DETAILSLabel = new System.Windows.Forms.Label();
            mETIER_IDLabel = new System.Windows.Forms.Label();
            mETIER_NOMLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mETIERBindingNavigator)).BeginInit();
            this.mETIERBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            this.SuspendLayout();
            // 
            // mETIERBindingNavigator
            // 
            this.mETIERBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.mETIERBindingNavigator.BindingSource = this.bs;
            this.mETIERBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.mETIERBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.mETIERBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.mETIERBindingNavigatorSaveItem});
            this.mETIERBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.mETIERBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.mETIERBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.mETIERBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.mETIERBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.mETIERBindingNavigator.Name = "mETIERBindingNavigator";
            this.mETIERBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.mETIERBindingNavigator.Size = new System.Drawing.Size(306, 25);
            this.mETIERBindingNavigator.TabIndex = 0;
            this.mETIERBindingNavigator.Text = "bindingNavigator1";
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
            // mETIERBindingNavigatorSaveItem
            // 
            this.mETIERBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.mETIERBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("mETIERBindingNavigatorSaveItem.Image")));
            this.mETIERBindingNavigatorSaveItem.Name = "mETIERBindingNavigatorSaveItem";
            this.mETIERBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.mETIERBindingNavigatorSaveItem.Text = "Enregistrer les données";
            this.mETIERBindingNavigatorSaveItem.Click += new System.EventHandler(this.mETIERBindingNavigatorSaveItem_Click);
            // 
            // mETIER_DETAILSLabel
            // 
            mETIER_DETAILSLabel.AutoSize = true;
            mETIER_DETAILSLabel.Location = new System.Drawing.Point(51, 79);
            mETIER_DETAILSLabel.Name = "mETIER_DETAILSLabel";
            mETIER_DETAILSLabel.Size = new System.Drawing.Size(99, 13);
            mETIER_DETAILSLabel.TabIndex = 1;
            mETIER_DETAILSLabel.Text = "METIER DETAILS:";
            // 
            // mETIER_DETAILSTextBox
            // 
            this.mETIER_DETAILSTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "METIER_DETAILS", true));
            this.mETIER_DETAILSTextBox.Location = new System.Drawing.Point(156, 76);
            this.mETIER_DETAILSTextBox.Name = "mETIER_DETAILSTextBox";
            this.mETIER_DETAILSTextBox.Size = new System.Drawing.Size(100, 20);
            this.mETIER_DETAILSTextBox.TabIndex = 2;
            // 
            // mETIER_IDLabel
            // 
            mETIER_IDLabel.AutoSize = true;
            mETIER_IDLabel.Location = new System.Drawing.Point(51, 105);
            mETIER_IDLabel.Name = "mETIER_IDLabel";
            mETIER_IDLabel.Size = new System.Drawing.Size(65, 13);
            mETIER_IDLabel.TabIndex = 3;
            mETIER_IDLabel.Text = "METIER ID:";
            // 
            // mETIER_IDTextBox
            // 
            this.mETIER_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "METIER_ID", true));
            this.mETIER_IDTextBox.Location = new System.Drawing.Point(156, 102);
            this.mETIER_IDTextBox.Name = "mETIER_IDTextBox";
            this.mETIER_IDTextBox.ReadOnly = true;
            this.mETIER_IDTextBox.Size = new System.Drawing.Size(100, 20);
            this.mETIER_IDTextBox.TabIndex = 4;
            // 
            // mETIER_NOMLabel
            // 
            mETIER_NOMLabel.AutoSize = true;
            mETIER_NOMLabel.Location = new System.Drawing.Point(51, 131);
            mETIER_NOMLabel.Name = "mETIER_NOMLabel";
            mETIER_NOMLabel.Size = new System.Drawing.Size(79, 13);
            mETIER_NOMLabel.TabIndex = 5;
            mETIER_NOMLabel.Text = "METIER NOM:";
            // 
            // mETIER_NOMTextBox
            // 
            this.mETIER_NOMTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bs, "METIER_NOM", true));
            this.mETIER_NOMTextBox.Location = new System.Drawing.Point(156, 128);
            this.mETIER_NOMTextBox.Name = "mETIER_NOMTextBox";
            this.mETIER_NOMTextBox.Size = new System.Drawing.Size(100, 20);
            this.mETIER_NOMTextBox.TabIndex = 6;
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.METIER);
            // 
            // list_ajoutmetier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 262);
            this.Controls.Add(mETIER_DETAILSLabel);
            this.Controls.Add(this.mETIER_DETAILSTextBox);
            this.Controls.Add(mETIER_IDLabel);
            this.Controls.Add(this.mETIER_IDTextBox);
            this.Controls.Add(mETIER_NOMLabel);
            this.Controls.Add(this.mETIER_NOMTextBox);
            this.Controls.Add(this.mETIERBindingNavigator);
            this.Name = "list_ajoutmetier";
            this.Text = "list_ajoutmetier";
            ((System.ComponentModel.ISupportInitialize)(this.mETIERBindingNavigator)).EndInit();
            this.mETIERBindingNavigator.ResumeLayout(false);
            this.mETIERBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.BindingNavigator mETIERBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton mETIERBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox mETIER_DETAILSTextBox;
        private System.Windows.Forms.TextBox mETIER_IDTextBox;
        private System.Windows.Forms.TextBox mETIER_NOMTextBox;
    }
}
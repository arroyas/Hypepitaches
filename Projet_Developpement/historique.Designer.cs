namespace Projet_Developpement
{
    partial class historique
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
            this.bs = new System.Windows.Forms.BindingSource(this.components);
            this.hISTORIQUEDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.bs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIQUEDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bs
            // 
            this.bs.DataSource = typeof(Projet_Developpement.HISTORIQUE);
            // 
            // hISTORIQUEDataGridView
            // 
            this.hISTORIQUEDataGridView.AllowUserToAddRows = false;
            this.hISTORIQUEDataGridView.AllowUserToDeleteRows = false;
            this.hISTORIQUEDataGridView.AutoGenerateColumns = false;
            this.hISTORIQUEDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hISTORIQUEDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.hISTORIQUEDataGridView.DataSource = this.bs;
            this.hISTORIQUEDataGridView.Location = new System.Drawing.Point(12, 12);
            this.hISTORIQUEDataGridView.Name = "hISTORIQUEDataGridView";
            this.hISTORIQUEDataGridView.ReadOnly = true;
            this.hISTORIQUEDataGridView.Size = new System.Drawing.Size(743, 328);
            this.hISTORIQUEDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "HISTORIQUE_ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ACTION N°";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "HISTORIQUE_LIBELLE";
            this.dataGridViewTextBoxColumn2.HeaderText = "DETAILS";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 500;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "HISTORIQUE_DATE";
            this.dataGridViewTextBoxColumn3.HeaderText = "DATE";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // historique
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 352);
            this.Controls.Add(this.hISTORIQUEDataGridView);
            this.Name = "historique";
            this.Text = "Historique";
            ((System.ComponentModel.ISupportInitialize)(this.bs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hISTORIQUEDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bs;
        private System.Windows.Forms.DataGridView hISTORIQUEDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;

    }
}
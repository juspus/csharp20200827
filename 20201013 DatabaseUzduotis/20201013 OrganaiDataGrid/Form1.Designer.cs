namespace _20201013_OrganaiDataGrid
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.zmogausOrganaiDataSet = new _20201013_OrganaiDataGrid.ZmogausOrganaiDataSet();
            this.zmogusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zmogusTableAdapter = new _20201013_OrganaiDataGrid.ZmogausOrganaiDataSetTableAdapters.ZmogusTableAdapter();
            this.vardasDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pavardeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amziusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kraujoGrupeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gyvasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.donorasDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmogausOrganaiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmogusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vardasDataGridViewTextBoxColumn,
            this.pavardeDataGridViewTextBoxColumn,
            this.amziusDataGridViewTextBoxColumn,
            this.kraujoGrupeDataGridViewTextBoxColumn,
            this.gyvasDataGridViewCheckBoxColumn,
            this.donorasDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.zmogusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(212, 171);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // zmogausOrganaiDataSet
            // 
            this.zmogausOrganaiDataSet.DataSetName = "ZmogausOrganaiDataSet";
            this.zmogausOrganaiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // zmogusBindingSource
            // 
            this.zmogusBindingSource.DataMember = "Zmogus";
            this.zmogusBindingSource.DataSource = this.zmogausOrganaiDataSet;
            // 
            // zmogusTableAdapter
            // 
            this.zmogusTableAdapter.ClearBeforeFill = true;
            // 
            // vardasDataGridViewTextBoxColumn
            // 
            this.vardasDataGridViewTextBoxColumn.DataPropertyName = "Vardas";
            this.vardasDataGridViewTextBoxColumn.HeaderText = "Vardas";
            this.vardasDataGridViewTextBoxColumn.Name = "vardasDataGridViewTextBoxColumn";
            // 
            // pavardeDataGridViewTextBoxColumn
            // 
            this.pavardeDataGridViewTextBoxColumn.DataPropertyName = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.HeaderText = "Pavarde";
            this.pavardeDataGridViewTextBoxColumn.Name = "pavardeDataGridViewTextBoxColumn";
            // 
            // amziusDataGridViewTextBoxColumn
            // 
            this.amziusDataGridViewTextBoxColumn.DataPropertyName = "Amzius";
            this.amziusDataGridViewTextBoxColumn.HeaderText = "Amzius";
            this.amziusDataGridViewTextBoxColumn.Name = "amziusDataGridViewTextBoxColumn";
            // 
            // kraujoGrupeDataGridViewTextBoxColumn
            // 
            this.kraujoGrupeDataGridViewTextBoxColumn.DataPropertyName = "KraujoGrupe";
            this.kraujoGrupeDataGridViewTextBoxColumn.HeaderText = "KraujoGrupe";
            this.kraujoGrupeDataGridViewTextBoxColumn.Name = "kraujoGrupeDataGridViewTextBoxColumn";
            // 
            // gyvasDataGridViewCheckBoxColumn
            // 
            this.gyvasDataGridViewCheckBoxColumn.DataPropertyName = "Gyvas";
            this.gyvasDataGridViewCheckBoxColumn.HeaderText = "Gyvas";
            this.gyvasDataGridViewCheckBoxColumn.Name = "gyvasDataGridViewCheckBoxColumn";
            // 
            // donorasDataGridViewCheckBoxColumn
            // 
            this.donorasDataGridViewCheckBoxColumn.DataPropertyName = "Donoras";
            this.donorasDataGridViewCheckBoxColumn.HeaderText = "Donoras";
            this.donorasDataGridViewCheckBoxColumn.Name = "donorasDataGridViewCheckBoxColumn";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 654);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmogausOrganaiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.zmogusBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private ZmogausOrganaiDataSet zmogausOrganaiDataSet;
        private System.Windows.Forms.BindingSource zmogusBindingSource;
        private ZmogausOrganaiDataSetTableAdapters.ZmogusTableAdapter zmogusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn vardasDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pavardeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amziusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kraujoGrupeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn gyvasDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn donorasDataGridViewCheckBoxColumn;
    }
}



namespace kykyurt
{
    partial class ogrlistesi
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
            this.ogridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogradDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrsoyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtcDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrtelefonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrdogumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrbolumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrmailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrodanoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogryakınıtelDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ogrencibilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.kykyurtDataSet6 = new kykyurt.kykyurtDataSet6();
            this.ogrencibilgiTableAdapter = new kykyurt.kykyurtDataSet6TableAdapters.ogrencibilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencibilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kykyurtDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Goldenrod;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ogridDataGridViewTextBoxColumn,
            this.ogradDataGridViewTextBoxColumn,
            this.ogrsoyadDataGridViewTextBoxColumn,
            this.ogrtcDataGridViewTextBoxColumn,
            this.ogrtelefonDataGridViewTextBoxColumn,
            this.ogrdogumDataGridViewTextBoxColumn,
            this.ogrbolumDataGridViewTextBoxColumn,
            this.ogrmailDataGridViewTextBoxColumn,
            this.ogrodanoDataGridViewTextBoxColumn,
            this.ogryakınıtelDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ogrencibilgiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1443, 428);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ogridDataGridViewTextBoxColumn
            // 
            this.ogridDataGridViewTextBoxColumn.DataPropertyName = "ogrid";
            this.ogridDataGridViewTextBoxColumn.HeaderText = "ogrid";
            this.ogridDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogridDataGridViewTextBoxColumn.Name = "ogridDataGridViewTextBoxColumn";
            this.ogridDataGridViewTextBoxColumn.ReadOnly = true;
            this.ogridDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogradDataGridViewTextBoxColumn
            // 
            this.ogradDataGridViewTextBoxColumn.DataPropertyName = "ograd";
            this.ogradDataGridViewTextBoxColumn.HeaderText = "ograd";
            this.ogradDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogradDataGridViewTextBoxColumn.Name = "ogradDataGridViewTextBoxColumn";
            this.ogradDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrsoyadDataGridViewTextBoxColumn
            // 
            this.ogrsoyadDataGridViewTextBoxColumn.DataPropertyName = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.HeaderText = "ogrsoyad";
            this.ogrsoyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrsoyadDataGridViewTextBoxColumn.Name = "ogrsoyadDataGridViewTextBoxColumn";
            this.ogrsoyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtcDataGridViewTextBoxColumn
            // 
            this.ogrtcDataGridViewTextBoxColumn.DataPropertyName = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.HeaderText = "ogrtc";
            this.ogrtcDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtcDataGridViewTextBoxColumn.Name = "ogrtcDataGridViewTextBoxColumn";
            this.ogrtcDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrtelefonDataGridViewTextBoxColumn
            // 
            this.ogrtelefonDataGridViewTextBoxColumn.DataPropertyName = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.HeaderText = "ogrtelefon";
            this.ogrtelefonDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrtelefonDataGridViewTextBoxColumn.Name = "ogrtelefonDataGridViewTextBoxColumn";
            this.ogrtelefonDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrdogumDataGridViewTextBoxColumn
            // 
            this.ogrdogumDataGridViewTextBoxColumn.DataPropertyName = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.HeaderText = "ogrdogum";
            this.ogrdogumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrdogumDataGridViewTextBoxColumn.Name = "ogrdogumDataGridViewTextBoxColumn";
            this.ogrdogumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrbolumDataGridViewTextBoxColumn
            // 
            this.ogrbolumDataGridViewTextBoxColumn.DataPropertyName = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.HeaderText = "ogrbolum";
            this.ogrbolumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrbolumDataGridViewTextBoxColumn.Name = "ogrbolumDataGridViewTextBoxColumn";
            this.ogrbolumDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrmailDataGridViewTextBoxColumn
            // 
            this.ogrmailDataGridViewTextBoxColumn.DataPropertyName = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.HeaderText = "ogrmail";
            this.ogrmailDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrmailDataGridViewTextBoxColumn.Name = "ogrmailDataGridViewTextBoxColumn";
            this.ogrmailDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrodanoDataGridViewTextBoxColumn
            // 
            this.ogrodanoDataGridViewTextBoxColumn.DataPropertyName = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.HeaderText = "ogrodano";
            this.ogrodanoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogrodanoDataGridViewTextBoxColumn.Name = "ogrodanoDataGridViewTextBoxColumn";
            this.ogrodanoDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogryakınıtelDataGridViewTextBoxColumn
            // 
            this.ogryakınıtelDataGridViewTextBoxColumn.DataPropertyName = "ogryakınıtel";
            this.ogryakınıtelDataGridViewTextBoxColumn.HeaderText = "ogryakınıtel";
            this.ogryakınıtelDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ogryakınıtelDataGridViewTextBoxColumn.Name = "ogryakınıtelDataGridViewTextBoxColumn";
            this.ogryakınıtelDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // ogrencibilgiBindingSource
            // 
            this.ogrencibilgiBindingSource.DataMember = "ogrencibilgi";
            this.ogrencibilgiBindingSource.DataSource = this.kykyurtDataSet6;
            // 
            // kykyurtDataSet6
            // 
            this.kykyurtDataSet6.DataSetName = "kykyurtDataSet6";
            this.kykyurtDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ogrencibilgiTableAdapter
            // 
            this.ogrencibilgiTableAdapter.ClearBeforeFill = true;
            // 
            // ogrlistesi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1444, 440);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ogrlistesi";
            this.Text = "ogrlistesi";
            this.Load += new System.EventHandler(this.ogrlistesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ogrencibilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kykyurtDataSet6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private kykyurtDataSet6 kykyurtDataSet6;
        private System.Windows.Forms.BindingSource ogrencibilgiBindingSource;
        private kykyurtDataSet6TableAdapters.ogrencibilgiTableAdapter ogrencibilgiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogradDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrsoyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtcDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrtelefonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrdogumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrbolumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrmailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogrodanoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ogryakınıtelDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
    }
}
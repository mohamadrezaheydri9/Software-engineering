namespace WindowsFormsApp1
{
    partial class list
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
            this.reservfoodDataSet = new WindowsFormsApp1.reservfoodDataSet();
            this.reservBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reservTableAdapter = new WindowsFormsApp1.reservfoodDataSetTableAdapters.reservTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shnaharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shshamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yeknaharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yekshamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.donaharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doshamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.senaharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seshamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charnaharDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.charshamDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservfoodDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.shnaharDataGridViewTextBoxColumn,
            this.shshamDataGridViewTextBoxColumn,
            this.yeknaharDataGridViewTextBoxColumn,
            this.yekshamDataGridViewTextBoxColumn,
            this.donaharDataGridViewTextBoxColumn,
            this.doshamDataGridViewTextBoxColumn,
            this.senaharDataGridViewTextBoxColumn,
            this.seshamDataGridViewTextBoxColumn,
            this.charnaharDataGridViewTextBoxColumn,
            this.charshamDataGridViewTextBoxColumn,
            this.unameDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.reservBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(948, 446);
            this.dataGridView1.TabIndex = 0;
            // 
            // reservfoodDataSet
            // 
            this.reservfoodDataSet.DataSetName = "reservfoodDataSet";
            this.reservfoodDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reservBindingSource
            // 
            this.reservBindingSource.DataMember = "reserv";
            this.reservBindingSource.DataSource = this.reservfoodDataSet;
            // 
            // reservTableAdapter
            // 
            this.reservTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ردیف";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // shnaharDataGridViewTextBoxColumn
            // 
            this.shnaharDataGridViewTextBoxColumn.DataPropertyName = "shnahar";
            this.shnaharDataGridViewTextBoxColumn.HeaderText = "شنبه ناهار";
            this.shnaharDataGridViewTextBoxColumn.Name = "shnaharDataGridViewTextBoxColumn";
            // 
            // shshamDataGridViewTextBoxColumn
            // 
            this.shshamDataGridViewTextBoxColumn.DataPropertyName = "shsham";
            this.shshamDataGridViewTextBoxColumn.HeaderText = "شنبه شام";
            this.shshamDataGridViewTextBoxColumn.Name = "shshamDataGridViewTextBoxColumn";
            // 
            // yeknaharDataGridViewTextBoxColumn
            // 
            this.yeknaharDataGridViewTextBoxColumn.DataPropertyName = "yeknahar";
            this.yeknaharDataGridViewTextBoxColumn.HeaderText = "یکشنبه ناهار";
            this.yeknaharDataGridViewTextBoxColumn.Name = "yeknaharDataGridViewTextBoxColumn";
            // 
            // yekshamDataGridViewTextBoxColumn
            // 
            this.yekshamDataGridViewTextBoxColumn.DataPropertyName = "yeksham";
            this.yekshamDataGridViewTextBoxColumn.HeaderText = "یکشنبه شام";
            this.yekshamDataGridViewTextBoxColumn.Name = "yekshamDataGridViewTextBoxColumn";
            // 
            // donaharDataGridViewTextBoxColumn
            // 
            this.donaharDataGridViewTextBoxColumn.DataPropertyName = "donahar";
            this.donaharDataGridViewTextBoxColumn.HeaderText = "دوشنبه ناهار";
            this.donaharDataGridViewTextBoxColumn.Name = "donaharDataGridViewTextBoxColumn";
            // 
            // doshamDataGridViewTextBoxColumn
            // 
            this.doshamDataGridViewTextBoxColumn.DataPropertyName = "dosham";
            this.doshamDataGridViewTextBoxColumn.HeaderText = "دوشنبه شام";
            this.doshamDataGridViewTextBoxColumn.Name = "doshamDataGridViewTextBoxColumn";
            // 
            // senaharDataGridViewTextBoxColumn
            // 
            this.senaharDataGridViewTextBoxColumn.DataPropertyName = "senahar";
            this.senaharDataGridViewTextBoxColumn.HeaderText = "سه‌شنبه ناهار";
            this.senaharDataGridViewTextBoxColumn.Name = "senaharDataGridViewTextBoxColumn";
            // 
            // seshamDataGridViewTextBoxColumn
            // 
            this.seshamDataGridViewTextBoxColumn.DataPropertyName = "sesham";
            this.seshamDataGridViewTextBoxColumn.HeaderText = "سه‌شام";
            this.seshamDataGridViewTextBoxColumn.Name = "seshamDataGridViewTextBoxColumn";
            // 
            // charnaharDataGridViewTextBoxColumn
            // 
            this.charnaharDataGridViewTextBoxColumn.DataPropertyName = "charnahar";
            this.charnaharDataGridViewTextBoxColumn.HeaderText = "چهارشنبه ناهار";
            this.charnaharDataGridViewTextBoxColumn.Name = "charnaharDataGridViewTextBoxColumn";
            // 
            // charshamDataGridViewTextBoxColumn
            // 
            this.charshamDataGridViewTextBoxColumn.DataPropertyName = "charsham";
            this.charshamDataGridViewTextBoxColumn.HeaderText = "چهارشنبه شام";
            this.charshamDataGridViewTextBoxColumn.Name = "charshamDataGridViewTextBoxColumn";
            // 
            // unameDataGridViewTextBoxColumn
            // 
            this.unameDataGridViewTextBoxColumn.DataPropertyName = "uname";
            this.unameDataGridViewTextBoxColumn.HeaderText = "مشتری";
            this.unameDataGridViewTextBoxColumn.Name = "unameDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(840, 483);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(85, 33);
            this.button1.TabIndex = 1;
            this.button1.Text = "بازگشت";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 528);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "list";
            this.Text = "list";
            this.Load += new System.EventHandler(this.list_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservfoodDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reservBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private reservfoodDataSet reservfoodDataSet;
        private System.Windows.Forms.BindingSource reservBindingSource;
        private reservfoodDataSetTableAdapters.reservTableAdapter reservTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shnaharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shshamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yeknaharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yekshamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn donaharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn doshamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn senaharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn seshamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charnaharDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn charshamDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unameDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
    }
}
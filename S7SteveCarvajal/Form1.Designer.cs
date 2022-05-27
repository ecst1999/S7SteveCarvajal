namespace S7SteveCarvajal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreTutor = new System.Windows.Forms.TextBox();
            this.s7_tutoriasDataSet = new S7SteveCarvajal.s7_tutoriasDataSet();
            this.s7tutoriasDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tutoresTableAdapter = new S7SteveCarvajal.s7_tutoriasDataSetTableAdapters.tutoresTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tutoresBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tutnombresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbEstudiante = new System.Windows.Forms.ComboBox();
            this.cmbTutor = new System.Windows.Forms.ComboBox();
            this.estudiantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.estudiantesTableAdapter = new S7SteveCarvajal.s7_tutoriasDataSetTableAdapters.estudiantesTableAdapter();
            this.tutoresBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.button2 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.s7_tutoriasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7tutoriasDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(63, 92);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(114, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Registrar tutor";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre tutor:";
            // 
            // txtNombreTutor
            // 
            this.txtNombreTutor.Location = new System.Drawing.Point(153, 49);
            this.txtNombreTutor.Name = "txtNombreTutor";
            this.txtNombreTutor.Size = new System.Drawing.Size(159, 20);
            this.txtNombreTutor.TabIndex = 2;
            // 
            // s7_tutoriasDataSet
            // 
            this.s7_tutoriasDataSet.DataSetName = "s7_tutoriasDataSet";
            this.s7_tutoriasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // s7tutoriasDataSetBindingSource
            // 
            this.s7tutoriasDataSetBindingSource.DataSource = this.s7_tutoriasDataSet;
            this.s7tutoriasDataSetBindingSource.Position = 0;
            // 
            // tutoresBindingSource
            // 
            this.tutoresBindingSource.DataMember = "tutores";
            this.tutoresBindingSource.DataSource = this.s7_tutoriasDataSet;
            // 
            // tutoresTableAdapter
            // 
            this.tutoresTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.tutnombresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tutoresBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(414, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(150, 92);
            this.dataGridView1.TabIndex = 3;
            // 
            // tutoresBindingSource1
            // 
            this.tutoresBindingSource1.DataMember = "tutores";
            this.tutoresBindingSource1.DataSource = this.s7tutoriasDataSetBindingSource;
            // 
            // tutnombresDataGridViewTextBoxColumn
            // 
            this.tutnombresDataGridViewTextBoxColumn.DataPropertyName = "tut_nombres";
            this.tutnombresDataGridViewTextBoxColumn.HeaderText = "NOMBRES";
            this.tutnombresDataGridViewTextBoxColumn.Name = "tutnombresDataGridViewTextBoxColumn";
            this.tutnombresDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Asigar Estudiante";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 240);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Asignar Tutor";
            // 
            // cmbEstudiante
            // 
            this.cmbEstudiante.DataSource = this.estudiantesBindingSource;
            this.cmbEstudiante.DisplayMember = "est_nombres";
            this.cmbEstudiante.FormattingEnabled = true;
            this.cmbEstudiante.Location = new System.Drawing.Point(218, 202);
            this.cmbEstudiante.Name = "cmbEstudiante";
            this.cmbEstudiante.Size = new System.Drawing.Size(121, 21);
            this.cmbEstudiante.TabIndex = 6;
            this.cmbEstudiante.ValueMember = "est_id";
            // 
            // cmbTutor
            // 
            this.cmbTutor.DataSource = this.tutoresBindingSource2;
            this.cmbTutor.DisplayMember = "tut_nombres";
            this.cmbTutor.FormattingEnabled = true;
            this.cmbTutor.Location = new System.Drawing.Point(218, 240);
            this.cmbTutor.Name = "cmbTutor";
            this.cmbTutor.Size = new System.Drawing.Size(121, 21);
            this.cmbTutor.TabIndex = 7;
            this.cmbTutor.ValueMember = "tut_id";
            // 
            // estudiantesBindingSource
            // 
            this.estudiantesBindingSource.DataMember = "estudiantes";
            this.estudiantesBindingSource.DataSource = this.s7tutoriasDataSetBindingSource;
            // 
            // estudiantesTableAdapter
            // 
            this.estudiantesTableAdapter.ClearBeforeFill = true;
            // 
            // tutoresBindingSource2
            // 
            this.tutoresBindingSource2.DataMember = "tutores";
            this.tutoresBindingSource2.DataSource = this.s7tutoriasDataSetBindingSource;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(63, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(114, 35);
            this.button2.TabIndex = 8;
            this.button2.Text = "Asignar tutor";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(414, 202);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cmbTutor);
            this.Controls.Add(this.cmbEstudiante);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtNombreTutor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Registrar Tutor";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.s7_tutoriasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s7tutoriasDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.estudiantesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tutoresBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreTutor;
        private System.Windows.Forms.BindingSource s7tutoriasDataSetBindingSource;
        private s7_tutoriasDataSet s7_tutoriasDataSet;
        private System.Windows.Forms.BindingSource tutoresBindingSource;
        private s7_tutoriasDataSetTableAdapters.tutoresTableAdapter tutoresTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tutnombresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tutoresBindingSource1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbEstudiante;
        private System.Windows.Forms.ComboBox cmbTutor;
        private System.Windows.Forms.BindingSource estudiantesBindingSource;
        private s7_tutoriasDataSetTableAdapters.estudiantesTableAdapter estudiantesTableAdapter;
        private System.Windows.Forms.BindingSource tutoresBindingSource2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}


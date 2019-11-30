namespace Kursovoi
{
    partial class Form12
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
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.usersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.igraDataSet211 = new Kursovoi.IgraDataSet21();
            this.usersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.igraDataSet21 = new Kursovoi.IgraDataSet21();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.reitingBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.igraDataSet23 = new Kursovoi.IgraDataSet23();
            this.reitingBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.reitingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reitingBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reitingBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.usersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter2 = new Kursovoi.IgraDataSet21TableAdapters.usersTableAdapter();
            this.button2 = new System.Windows.Forms.Button();
            this.reitingTableAdapter4 = new Kursovoi.IgraDataSet23TableAdapters.reitingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet211)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet23)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource2)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(234, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(485, 344);
            this.dataGridView1.TabIndex = 0;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton1.Location = new System.Drawing.Point(3, 15);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(210, 23);
            this.radioButton1.TabIndex = 1;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "По баллам набранным игроками";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe Print", 8F, System.Drawing.FontStyle.Bold);
            this.radioButton2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.radioButton2.Location = new System.Drawing.Point(3, 96);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(153, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "По месту в рейтинге";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.usersBindingSource3;
            this.comboBox1.DisplayMember = "kolvoBall";
            this.comboBox1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(0, 49);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 27);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.ValueMember = "kolvoBall";
            // 
            // usersBindingSource3
            // 
            this.usersBindingSource3.DataMember = "users";
            this.usersBindingSource3.DataSource = this.igraDataSet211;
            // 
            // igraDataSet211
            // 
            this.igraDataSet211.DataSetName = "IgraDataSet21";
            this.igraDataSet211.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource2
            // 
            this.usersBindingSource2.DataMember = "users";
            this.usersBindingSource2.DataSource = this.igraDataSet21;
            // 
            // igraDataSet21
            // 
            this.igraDataSet21.DataSetName = "IgraDataSet21";
            this.igraDataSet21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.reitingBindingSource4;
            this.comboBox2.DisplayMember = "mesto";
            this.comboBox2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(3, 142);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 27);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.ValueMember = "mesto";
            this.comboBox2.Visible = false;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // reitingBindingSource4
            // 
            this.reitingBindingSource4.DataMember = "reiting";
            this.reitingBindingSource4.DataSource = this.igraDataSet23;
            // 
            // igraDataSet23
            // 
            this.igraDataSet23.DataSetName = "IgraDataSet23";
            this.igraDataSet23.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reitingBindingSource3
            // 
            this.reitingBindingSource3.DataMember = "reiting";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(33, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сформировать отчет";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // reitingBindingSource
            // 
            this.reitingBindingSource.DataMember = "reiting";
            // 
            // reitingBindingSource1
            // 
            this.reitingBindingSource1.DataMember = "reiting";
            // 
            // reitingBindingSource2
            // 
            this.reitingBindingSource2.DataMember = "reiting";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 183);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // usersBindingSource1
            // 
            this.usersBindingSource1.DataMember = "users";
            // 
            // usersTableAdapter2
            // 
            this.usersTableAdapter2.ClearBeforeFill = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(33, 281);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(163, 57);
            this.button2.TabIndex = 7;
            this.button2.Text = "Импорт в Excel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // reitingTableAdapter4
            // 
            this.reitingTableAdapter4.ClearBeforeFill = true;
            // 
            // Form12
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Kursovoi.Properties.Resources._67ae8be872945cd487f4d8b57588d2cc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 383);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form12";
            this.Text = "Отчеты";
            this.Load += new System.EventHandler(this.Form12_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet211)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.igraDataSet23)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.reitingBindingSource2)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button button1;
      
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.BindingSource reitingBindingSource;
        private System.Windows.Forms.BindingSource reitingBindingSource1;
        private System.Windows.Forms.BindingSource reitingBindingSource2;
        private System.Windows.Forms.BindingSource reitingBindingSource3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource usersBindingSource1;
        private IgraDataSet21 igraDataSet21;
        private System.Windows.Forms.BindingSource usersBindingSource2;
        private IgraDataSet21TableAdapters.usersTableAdapter usersTableAdapter2;
        private IgraDataSet21 igraDataSet211;
        private System.Windows.Forms.BindingSource usersBindingSource3;
        private System.Windows.Forms.Button button2;
        private IgraDataSet23 igraDataSet23;
        private System.Windows.Forms.BindingSource reitingBindingSource4;
        private IgraDataSet23TableAdapters.reitingTableAdapter reitingTableAdapter4;
    }
}
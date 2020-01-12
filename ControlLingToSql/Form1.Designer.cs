namespace ControlLingToSql
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Recherche = new System.Windows.Forms.Button();
            this.comboBox_dep = new System.Windows.Forms.ComboBox();
            this.textBox_job = new System.Windows.Forms.TextBox();
            this.textBox_nom = new System.Windows.Forms.TextBox();
            this.checkBox_dep = new System.Windows.Forms.CheckBox();
            this.checkBox_job = new System.Windows.Forms.CheckBox();
            this.checkBox_nom = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 296);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(939, 150);
            this.dataGridView1.TabIndex = 23;
            // 
            // Recherche
            // 
            this.Recherche.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recherche.Location = new System.Drawing.Point(609, 89);
            this.Recherche.Name = "Recherche";
            this.Recherche.Size = new System.Drawing.Size(126, 51);
            this.Recherche.TabIndex = 22;
            this.Recherche.Text = "Recherche";
            this.Recherche.UseVisualStyleBackColor = true;
            this.Recherche.Click += new System.EventHandler(this.Recherche_Click);
            // 
            // comboBox_dep
            // 
            this.comboBox_dep.FormattingEnabled = true;
            this.comboBox_dep.Location = new System.Drawing.Point(253, 157);
            this.comboBox_dep.Name = "comboBox_dep";
            this.comboBox_dep.Size = new System.Drawing.Size(121, 21);
            this.comboBox_dep.TabIndex = 21;
            // 
            // textBox_job
            // 
            this.textBox_job.Location = new System.Drawing.Point(253, 99);
            this.textBox_job.Name = "textBox_job";
            this.textBox_job.Size = new System.Drawing.Size(100, 20);
            this.textBox_job.TabIndex = 20;
            // 
            // textBox_nom
            // 
            this.textBox_nom.Location = new System.Drawing.Point(253, 40);
            this.textBox_nom.Name = "textBox_nom";
            this.textBox_nom.Size = new System.Drawing.Size(100, 20);
            this.textBox_nom.TabIndex = 19;
            // 
            // checkBox_dep
            // 
            this.checkBox_dep.AutoSize = true;
            this.checkBox_dep.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_dep.Location = new System.Drawing.Point(113, 159);
            this.checkBox_dep.Name = "checkBox_dep";
            this.checkBox_dep.Size = new System.Drawing.Size(105, 27);
            this.checkBox_dep.TabIndex = 18;
            this.checkBox_dep.Text = "Departement";
            this.checkBox_dep.UseVisualStyleBackColor = true;
            this.checkBox_dep.CheckedChanged += new System.EventHandler(this.checkBox_dep_CheckedChanged);
            // 
            // checkBox_job
            // 
            this.checkBox_job.AutoSize = true;
            this.checkBox_job.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_job.Location = new System.Drawing.Point(113, 102);
            this.checkBox_job.Name = "checkBox_job";
            this.checkBox_job.Size = new System.Drawing.Size(50, 27);
            this.checkBox_job.TabIndex = 17;
            this.checkBox_job.Text = "Job";
            this.checkBox_job.UseVisualStyleBackColor = true;
            this.checkBox_job.CheckedChanged += new System.EventHandler(this.checkBox_job_CheckedChanged);
            // 
            // checkBox_nom
            // 
            this.checkBox_nom.AutoSize = true;
            this.checkBox_nom.Font = new System.Drawing.Font("Myanmar Text", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_nom.Location = new System.Drawing.Point(113, 43);
            this.checkBox_nom.Name = "checkBox_nom";
            this.checkBox_nom.Size = new System.Drawing.Size(58, 27);
            this.checkBox_nom.TabIndex = 16;
            this.checkBox_nom.Text = "Nom";
            this.checkBox_nom.UseVisualStyleBackColor = true;
            this.checkBox_nom.CheckedChanged += new System.EventHandler(this.checkBox_nom_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 446);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Recherche);
            this.Controls.Add(this.comboBox_dep);
            this.Controls.Add(this.textBox_job);
            this.Controls.Add(this.textBox_nom);
            this.Controls.Add(this.checkBox_dep);
            this.Controls.Add(this.checkBox_job);
            this.Controls.Add(this.checkBox_nom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Recherche;
        private System.Windows.Forms.ComboBox comboBox_dep;
        private System.Windows.Forms.TextBox textBox_job;
        private System.Windows.Forms.TextBox textBox_nom;
        private System.Windows.Forms.CheckBox checkBox_dep;
        private System.Windows.Forms.CheckBox checkBox_job;
        private System.Windows.Forms.CheckBox checkBox_nom;
    }
}


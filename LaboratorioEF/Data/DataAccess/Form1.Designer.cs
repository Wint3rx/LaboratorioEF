namespace LaboratorioEF
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelNombreCarnet = new Label();
            comboBoxCompanias = new ComboBox();
            dataGridViewConsolas = new DataGridView();
            btnSeleccionarTodo = new Button();
            btnSiguienteRegistro = new Button();
            btnFiltrarNintendo = new Button();
            btnFiltrarSega = new Button();
            btnFiltrarSony = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsolas).BeginInit();
            SuspendLayout();
            // 
            // labelNombreCarnet
            // 
            labelNombreCarnet.AutoSize = true;
            labelNombreCarnet.Location = new Point(47, 31);
            labelNombreCarnet.Name = "labelNombreCarnet";
            labelNombreCarnet.Size = new Size(550, 32);
            labelNombreCarnet.TabIndex = 0;
            labelNombreCarnet.Text = "Franklin Boanerges Lopez Chavarria 0905-23-4498";
            // 
            // comboBoxCompanias
            // 
            comboBoxCompanias.FormattingEnabled = true;
            comboBoxCompanias.Location = new Point(47, 91);
            comboBoxCompanias.Name = "comboBoxCompanias";
            comboBoxCompanias.Size = new Size(252, 40);
            comboBoxCompanias.TabIndex = 1;
            // 
            // dataGridViewConsolas
            // 
            dataGridViewConsolas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewConsolas.Location = new Point(63, 152);
            dataGridViewConsolas.Name = "dataGridViewConsolas";
            dataGridViewConsolas.RowHeadersWidth = 82;
            dataGridViewConsolas.Size = new Size(964, 370);
            dataGridViewConsolas.TabIndex = 2;
            // 
            // btnSeleccionarTodo
            // 
            btnSeleccionarTodo.Location = new Point(1107, 177);
            btnSeleccionarTodo.Name = "btnSeleccionarTodo";
            btnSeleccionarTodo.Size = new Size(164, 84);
            btnSeleccionarTodo.TabIndex = 3;
            btnSeleccionarTodo.Text = "button1";
            btnSeleccionarTodo.UseVisualStyleBackColor = true;
            // 
            // btnSiguienteRegistro
            // 
            btnSiguienteRegistro.Location = new Point(1105, 297);
            btnSiguienteRegistro.Name = "btnSiguienteRegistro";
            btnSiguienteRegistro.Size = new Size(167, 77);
            btnSiguienteRegistro.TabIndex = 4;
            btnSiguienteRegistro.Text = "button1";
            btnSiguienteRegistro.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarNintendo
            // 
            btnFiltrarNintendo.Location = new Point(73, 547);
            btnFiltrarNintendo.Name = "btnFiltrarNintendo";
            btnFiltrarNintendo.Size = new Size(168, 75);
            btnFiltrarNintendo.TabIndex = 5;
            btnFiltrarNintendo.Text = "button1";
            btnFiltrarNintendo.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarSega
            // 
            btnFiltrarSega.Location = new Point(269, 549);
            btnFiltrarSega.Name = "btnFiltrarSega";
            btnFiltrarSega.Size = new Size(183, 76);
            btnFiltrarSega.TabIndex = 6;
            btnFiltrarSega.Text = "button1";
            btnFiltrarSega.UseVisualStyleBackColor = true;
            // 
            // btnFiltrarSony
            // 
            btnFiltrarSony.Location = new Point(475, 550);
            btnFiltrarSony.Name = "btnFiltrarSony";
            btnFiltrarSony.Size = new Size(170, 76);
            btnFiltrarSony.TabIndex = 7;
            btnFiltrarSony.Text = "button1";
            btnFiltrarSony.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1675, 843);
            Controls.Add(btnFiltrarSony);
            Controls.Add(btnFiltrarSega);
            Controls.Add(btnFiltrarNintendo);
            Controls.Add(btnSiguienteRegistro);
            Controls.Add(btnSeleccionarTodo);
            Controls.Add(dataGridViewConsolas);
            Controls.Add(comboBoxCompanias);
            Controls.Add(labelNombreCarnet);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewConsolas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelNombreCarnet;
        private ComboBox comboBoxCompanias;
        private DataGridView dataGridViewConsolas;
        private Button btnSeleccionarTodo;
        private Button btnSiguienteRegistro;
        private Button btnFiltrarNintendo;
        private Button btnFiltrarSega;
        private Button btnFiltrarSony;
    }
}

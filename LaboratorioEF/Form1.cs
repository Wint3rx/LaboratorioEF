using LaboratorioEF.Data.DataAccess;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace LaboratorioEF
{

    public partial class Form1 : Form
    {
        private List<Consola> consolas;
        private int currentIndex = 0;
        private string connectionString = "Server=localhost;DataBase=catalogo_consolas;Uid=root;Pwd=Franklin23030917@";
        public Form1()
        {
            InitializeComponent();
            InicializarFormulario();
        }

        private void InicializarFormulario()
        {
            // Nombre completo y número de carnet
            labelNombreCarnet.Text = "Nombre Completo: [Tu Nombre], Carnet: [Tu Número de Carnet]";
            labelNombreCarnet.Font = new Font("Arial", 20);

            // ComboBox de compañías
            comboBoxCompanias.Items.AddRange(new string[] { "Atari", "Coleco", "Mattel", "Microsoft", "Nintendo", "Ouya Inc.", "Sega", "Sony" });

            // Inicializar DataGridView
            dataGridViewConsolas.AutoGenerateColumns = false;
            dataGridViewConsolas.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "IdConsola", HeaderText = "ID" });
            dataGridViewConsolas.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "NombreConsola", HeaderText = "Nombre" });
            dataGridViewConsolas.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Compania", HeaderText = "Compañía" });
            dataGridViewConsolas.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "AnioLanzamiento", HeaderText = "Año" });
            dataGridViewConsolas.Columns.Add(new DataGridViewTextBoxColumn() { DataPropertyName = "Generacion", HeaderText = "Generación" });

            // Cargar datos desde la base de datos
            CargarDatos();

            // Evento de botón Seleccionar Todo
            btnSeleccionarTodo.Click += (s, e) =>
            {
                dataGridViewConsolas.DataSource = consolas;
            };

            // Evento de botón Siguiente Registro
            btnSiguienteRegistro.Click += (s, e) =>
            {
                if (consolas.Count > 0)
                {
                    currentIndex = (currentIndex + 1) % consolas.Count;
                    dataGridViewConsolas.ClearSelection();
                    dataGridViewConsolas.Rows[currentIndex].Selected = true;
                    dataGridViewConsolas.FirstDisplayedScrollingRowIndex = currentIndex;
                }
            };

            // Eventos de botones de filtro
            btnFiltrarNintendo.Click += (s, e) => FiltrarConsolas("Nintendo");
            btnFiltrarSega.Click += (s, e) => FiltrarConsolas("Sega");
            btnFiltrarSony.Click += (s, e) => FiltrarConsolas("Sony");
        }

        private void CargarDatos()
        {
            consolas = new List<Consola>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT * FROM catalogo_consolas";
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                SqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    consolas.Add(new Consola
                    {
                        IdConsola = reader.GetInt32(0),
                        NombreConsola = reader.GetString(1),
                        Compania = reader.GetString(2),
                        AnioLanzamiento = reader.GetInt32(3),
                        Generacion = reader.GetInt32(4)
                    });
                }
            }
        }
        private void FiltrarConsolas(string compania)
        {
            var filtradas = consolas.Where(c => c.Compania == compania).ToList();
            dataGridViewConsolas.DataSource = filtradas;
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

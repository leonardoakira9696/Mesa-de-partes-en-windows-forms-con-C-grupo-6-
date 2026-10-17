
using System;
using System.IO;
using System.Globalization;
using System.Windows.Forms;

namespace Fundamentos_de_programación_Grupo_6_EP
{
    public partial class Form1 : Form
    {
        // Arreglo para almacenar hasta 100 expedientes.
        private Expediente[] Expedientes = new Expediente[100];
        private int CantidadExpedientes = 0;

        // Archivo donde se guardaran los expedientes.
        private readonly string RutaArchivo =
            Path.Combine(
                Environment.GetFolderPath(
                    Environment.SpecialFolder.LocalApplicationData),
                "MesaPartesDigital",
                "expedientes.txt");

        public Form1()
        {
            InitializeComponent();

            //Conectar los botones con sus metodos.
            BtnRegistrar.Click += BtnRegistrar_Click;
            BtnBuscar.Click += BtnBuscar_Click;
            BtnOrdenarCodigo.Click += BtnOrdenarPorCodigo_Click;
            BtnLimpiar.Click += BtnLimpiar_Click;
            BtnSalir.Click += BtnSalir_Click;
            Load += Form1_Load;

            //Evitar la fila vacia de insercion del DataGridView.
            DgvRegistro.AllowUserToAddRows = false;
            DgvRegistro.ReadOnly = true;
            DgvRegistro.AutoGenerateColumns = false;
            DgvRegistro.SelectionMode =
                DataGridViewSelectionMode.FullRowSelect;
            DgvRegistro.MultiSelect = false;
        }

        private void Form1_Load(object? sender, EventArgs e)
        {
            // Opciones para los ComboBox.
            CbTipoDocumento.Items.Clear();
            CbTipoDocumento.Items.Add("Oficio");
            CbTipoDocumento.Items.Add("Informe");
            CbTipoDocumento.Items.Add("Carta");
            CbTipoDocumento.Items.Add("Resolucion");
            CbTipoDocumento.Items.Add("Memorando");

            CbEstado.Items.Clear();
            CbEstado.Items.Add("Registrado");
            CbEstado.Items.Add("En tramite");
            CbEstado.Items.Add("Pendiente");

            DtpFechaRecepcion.Format =
                DateTimePickerFormat.Custom;
            DtpFechaRecepcion.CustomFormat = "dd/MM/yyyy";

            CargarExpedientes();
            ActualizarTabla();
        }

        // REGISTRAR
        private void BtnRegistrar_Click(object? sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim().ToUpper();

            if (codigo.Length != 7 ||
                !codigo.StartsWith("EXP-") ||
                !int.TryParse(codigo.Substring(4), out int numero) ||
                numero < 1 || numero > 999)
            {
                MessageBox.Show(
                    "El código debe tener el formato EXP-001 hasta EXP-999.",
                    "Código invalido",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                TxtCodigo.Focus();
                return;
            }

            string remitente = TxtRemitente.Text.Trim();
            string tipo = CbTipoDocumento.Text;
            string asunto = TxtAsunto.Text.Trim();
            string estado = CbEstado.Text;

            // Validar los campos obligatorios.
            if (codigo == "" || remitente == "" ||
                tipo == "" || asunto == "" || estado == "")
            {
                MessageBox.Show(
                    "Complete todos los campos.",
                    "Validacion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            // Verificar que no exista otro expediente con ese codigo.
            if (BuscarIndice(codigo) != -1)
            {
                MessageBox.Show(
                    "Ya existe un expediente con ese codigo.");
                return;
            }

            // Comprobar que haya espacio en el arreglo.
            if (CantidadExpedientes >= Expedientes.Length)
            {
                MessageBox.Show("Se alcanzo el limite de expedientes.");
                return;
            }

            // Crear y almacenar el nuevo expediente.
            Expediente nuevo = new Expediente();

            nuevo.Codigo = codigo;
            nuevo.Remitente = remitente;
            nuevo.TipoDocumento = tipo;
            nuevo.Asunto = asunto;
            nuevo.FechaRecepcion = DtpFechaRecepcion.Value.Date;
            nuevo.Estado = estado;

            Expedientes[CantidadExpedientes] = nuevo;
            CantidadExpedientes++;

            GuardarExpedientes();
            ActualizarTabla();
            LimpiarCampos();

            MessageBox.Show(
                "Expediente registrado correctamente.",
                "Registro",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        // BUSCAR POR CODIGO
        private void BtnBuscar_Click(object? sender, EventArgs e)
        {
            string codigo = TxtCodigo.Text.Trim().ToUpper();


            if (codigo == "")
            {
                MessageBox.Show("Ingrese el codigo que desea buscar.");
                TxtCodigo.Focus();
                return;
            }

            int indice = BuscarIndice(codigo);

            if (indice == -1)
            {
                MessageBox.Show("No se encontro el expediente.");
                return;
            }

            //Mostrar el expediente encontrado en la tabla.
            DgvRegistro.ClearSelection();
            DgvRegistro.Rows[indice].Selected = true;
            DgvRegistro.CurrentCell =
                DgvRegistro.Rows[indice].Cells[0];

            //Mostrar sus datos en los controles.
            Expediente encontrado = Expedientes[indice];

            TxtCodigo.Text = encontrado.Codigo;
            TxtRemitente.Text = encontrado.Remitente;
            CbTipoDocumento.Text = encontrado.TipoDocumento;
            TxtAsunto.Text = encontrado.Asunto;
            DtpFechaRecepcion.Value = encontrado.FechaRecepcion;
            CbEstado.Text = encontrado.Estado;
        }

        //BUSQUEDA SECUENCIAL
        private int BuscarIndice(string codigo)
        {
            for (int i = 0; i < CantidadExpedientes; i++)
            {
                if (Expedientes[i].Codigo.Equals(
                    codigo, StringComparison.OrdinalIgnoreCase))
                {
                    return i;
                }
            }

            return -1;
        }

        //ORDENAR POR CODIGO
        private void BtnOrdenarPorCodigo_Click(
            object? sender, EventArgs e)
        {
            for (int i = 0; i < CantidadExpedientes - 1; i++)
            {
                for (int j = 0; j < CantidadExpedientes - 1 - i; j++)
                {
                    if (string.Compare(
                        Expedientes[j].Codigo,
                        Expedientes[j + 1].Codigo,
                        StringComparison.OrdinalIgnoreCase) > 0)
                    {
                        Expediente temporal = Expedientes[j];
                        Expedientes[j] = Expedientes[j + 1];
                        Expedientes[j + 1] = temporal;
                    }
                }
            }

            ActualizarTabla();
            GuardarExpedientes();

            MessageBox.Show("Expedientes ordenados por codigo.");
        }

        //ACTUALIZAR EL DATAGRIDVIEW
        private void ActualizarTabla()
        {
            DgvRegistro.Rows.Clear();

            for (int i = 0; i < CantidadExpedientes; i++)
            {
                Expediente exp = Expedientes[i];

                DgvRegistro.Rows.Add(
                    exp.Codigo,
                    exp.Remitente,
                    exp.TipoDocumento,
                    exp.Asunto,
                    exp.FechaRecepcion.ToString("dd/MM/yyyy"),
                    exp.Estado);
            }

            LblTotal.Text =
                "Total de expedientes: " + CantidadExpedientes;
        }

        //LIMPIAR LOS CAMPOS
        private void BtnLimpiar_Click(object? sender, EventArgs e)
        {
            LimpiarCampos();
            DgvRegistro.ClearSelection();
        }

        private void LimpiarCampos()
        {
            TxtCodigo.Clear();
            TxtRemitente.Clear();
            TxtAsunto.Clear();

            CbTipoDocumento.SelectedIndex = -1;
            CbEstado.SelectedIndex = -1;

            DtpFechaRecepcion.Value = DateTime.Today;
            TxtCodigo.Focus();
        }

        // GUARDAR LOS DATOS EN UN ARCHIVO DE TEXTO
        private void GuardarExpedientes()
        {
            try
            {
                string? carpeta = Path.GetDirectoryName(RutaArchivo);

                if (carpeta != null)
                {
                    Directory.CreateDirectory(carpeta);
                }

                using (StreamWriter escritor =
                    new StreamWriter(RutaArchivo, false))
                {
                    for (int i = 0; i < CantidadExpedientes; i++)
                    {
                        Expediente exp = Expedientes[i];

                        escritor.WriteLine(
                            LimpiarTexto(exp.Codigo) + "\t" +
                            LimpiarTexto(exp.Remitente) + "\t" +
                            LimpiarTexto(exp.TipoDocumento) + "\t" +
                            LimpiarTexto(exp.Asunto) + "\t" +
                            exp.FechaRecepcion.ToString("yyyy-MM-dd") + "\t" +
                            LimpiarTexto(exp.Estado));
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "No se pudieron guardar los datos: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    "No hay permiso para guardar los datos: " + ex.Message);
            }
        }

        // EVITAR QUE LOS CAMPOS ROMPAN EL FORMATO DEL ARCHIVO
        private string LimpiarTexto(string texto)
        {
            return texto
                .Replace("\t", " ")
                .Replace("\r", " ")
                .Replace("\n", " ");
        }

        // CARGAR LOS DATOS DEL ARCHIVO
        private void CargarExpedientes()
        {
            if (!File.Exists(RutaArchivo))
                return;

            try
            {
                using (StreamReader lector =
                    new StreamReader(RutaArchivo))
                {
                    string? linea;

                    while ((linea = lector.ReadLine()) != null &&
                           CantidadExpedientes < Expedientes.Length)
                    {
                        string[] datos = linea.Split('\t');

                        if (datos.Length != 6)
                            continue;

                        DateTime fecha;

                        if (!DateTime.TryParseExact(
                            datos[4],
                            "yyyy-MM-dd",
                            CultureInfo.InvariantCulture,
                            DateTimeStyles.None,
                            out fecha))
                        {
                            continue;
                        }

                        // Evitar codigos duplicados en el archivo.
                        if (BuscarIndice(datos[0]) != -1)
                            continue;

                        Expediente exp = new Expediente();

                        exp.Codigo = datos[0];
                        exp.Remitente = datos[1];
                        exp.TipoDocumento = datos[2];
                        exp.Asunto = datos[3];
                        exp.FechaRecepcion = fecha;
                        exp.Estado = datos[5];

                        Expedientes[CantidadExpedientes] = exp;
                        CantidadExpedientes++;
                    }
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(
                    "No se pudieron cargar los datos: " + ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(
                    "No hay permiso para leer los datos: " + ex.Message);
            }
        }

        // SALIR
        private void BtnSalir_Click(object? sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show(
                "¿Desea cerrar la aplicacion?",
                "Confirmar salida",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
                Close();
        }
    }
}

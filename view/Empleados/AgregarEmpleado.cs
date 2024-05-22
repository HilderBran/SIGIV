using Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace view.Empleados
{
    public partial class AgregarEmpleado : Form
    {
        public AgregarEmpleado()
        {
            InitializeComponent();
            cbPais.SelectionChangeCommitted += CbPais_SelectionChangeCommitted;
            cbDepartamento.SelectionChangeCommitted += CbDepartamento_SelectionChangeCommitted;
            cbMunicipio.SelectionChangeCommitted += CbMunicipio_SelectionChangeCommitted;
        }

        protected async override void OnLoad(EventArgs e)
        {
            await CargarPaises();
            base.OnLoad(e);
        }

        private async void CbMunicipio_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            try
            {
                string idMunicipio = cbMunicipio.SelectedValue.ToString();
                await CargarDistritos(idMunicipio);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Municipios");
            }
        }

        private async Task CargarDistritos(string? idMunicipio)
        {
            try
            {
                var distritos = await DistritoController.GetDistritosByIdMunicipio(idMunicipio);
                cbDistrito.DataSource = distritos;
                cbDistrito.DisplayMember = "Nombre";
                cbDistrito.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void CbDepartamento_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            try
            {
                string idDepartamento = cbDepartamento.SelectedValue.ToString();
                await CargarMunicipios(idDepartamento);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Municipios");
            }
        }

        private async Task CargarMunicipios(string? idDepartamento)
        {
            try
            {
                var municipios = await MunicipioController.GetMunicipiosByIdDepartamento(idDepartamento);
                cbMunicipio.DataSource = municipios;
                cbMunicipio.DisplayMember = "Nombre";
                cbMunicipio.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async void CbPais_SelectionChangeCommitted(object? sender, EventArgs e)
        {
            try
            {
                string idPais = cbPais.SelectedValue.ToString();
                await CargarDepartamentos(idPais);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar los datos de Departamentos");
            }
        }

        private async Task CargarDepartamentos(string? idPais)
        {
            try
            {
                var departamentos = await DepartamentoController.GetDepartamentosByIdPais(idPais);
                cbDepartamento.DataSource = departamentos;
                cbDepartamento.DisplayMember = "Nombre";
                cbDepartamento.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private async Task CargarPaises()
        {
            try
            {
                var paises = await PaisController.GetAsync();
                cbPais.DataSource = paises;
                cbPais.DisplayMember = "Pais";
                cbPais.ValueMember = "IdPais";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

    }
}

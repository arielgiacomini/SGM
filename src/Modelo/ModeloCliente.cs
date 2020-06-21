using System;

namespace Modelo
{
    public class ModeloCliente
    {
        public ModeloCliente()
        {
            this.ClienteId = 0;
            this.Cliente = "";
            this.Apelido = "";
            this.DocumentoCliente = "";
            this.Sexo = "";
            this.EstadoCivil = "";
            this.DataNascimento = DateTime.Today;
            this.Email = "";
            this.TelefoneFixo = "";
            this.TelefoneCelular = "";
            this.TelefoneOutros = "";
            this.LogradouroCEP = "";
            this.LogradouroNome = "";
            this.LogradouroNumero = "";
            this.LogradouroComplemento = "";
            this.LogradouroMunicipio = "";
            this.LogradouroBairro = "";
            this.LogradouroUF = "";
            this.DataCadastro = DateTime.Now;
        }

        public ModeloCliente(int ClienteId, string Cliente, string Apelido, string DocumentoCliente, string Sexo, string EstadoCivil, DateTime DataNascimento, string Email, string TelefoneFixo, string TelefoneCelular, string TelefoneOutros, string LogradouroCEP, string LogradouroNome, string LogradouroNumero, string LogradouroComplemento, string LogradouroMunicipio, string LogradouroBairro, string LogradouroUF, DateTime DataCadastro)

        {
            this.ClienteId = ClienteId;
            this.Cliente = Cliente;
            this.Apelido = Apelido;
            this.DocumentoCliente = DocumentoCliente;
            this.Sexo = Sexo;
            this.EstadoCivil = EstadoCivil;
            this.DataNascimento = DataNascimento;
            this.Email = Email;
            this.TelefoneFixo = TelefoneFixo;
            this.TelefoneCelular = TelefoneCelular;
            this.TelefoneOutros = TelefoneCelular;
            this.LogradouroCEP = LogradouroCEP;
            this.LogradouroNome = LogradouroNome;
            this.LogradouroNumero = LogradouroNumero;
            this.LogradouroComplemento = LogradouroComplemento;
            this.LogradouroMunicipio = LogradouroMunicipio;
            this.LogradouroBairro = LogradouroBairro;
            this.LogradouroUF = LogradouroUF;
            this.DataCadastro = DataCadastro;
        }

        private int ClienteId;
        private string Cliente;
        private string Apelido;
        private string DocumentoCliente;
        private string Sexo;
        private string EstadoCivil;
        private DateTime DataNascimento;
        private string Email;
        private string TelefoneFixo;
        private string TelefoneCelular;
        private string TelefoneOutros;
        private string LogradouroCEP;
        private string LogradouroNome;
        private string LogradouroNumero;
        private string LogradouroComplemento;
        private string LogradouroMunicipio;
        private string LogradouroBairro;
        private string LogradouroUF;
        private DateTime DataCadastro;

        public int CClienteId
        {
            get { return this.ClienteId; }
            set { this.ClienteId = value; }
        }

        public string CNomeCliente
        {
            get { return this.Cliente; }
            set { this.Cliente = value; }
        }
        public string CApelido
        {
            get { return this.Apelido; }
            set { this.Apelido = value; }
        }
        public string CDocumentoCliente
        {
            get { return this.DocumentoCliente; }
            set { this.DocumentoCliente = value; }
        }
        public string CSexo
        {
            get { return this.Sexo; }
            set { this.Sexo = value; }
        }
        public string CEstadoCivil
        {
            get { return this.EstadoCivil; }
            set { this.EstadoCivil = value; }
        }
        public DateTime CDataNascimento
        {
            get { return this.DataNascimento; }
            set { this.DataNascimento = value; }
        }
        public string CEmail
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public string CTelefoneFixo
        {
            get { return this.TelefoneFixo; }
            set { this.TelefoneFixo = value; }
        }
        public string CTelefoneCelular
        {
            get { return this.TelefoneCelular; }
            set { this.TelefoneCelular = value; }
        }
        public string CTelefoneOutros
        {
            get { return this.TelefoneOutros; }
            set { this.TelefoneOutros = value; }
        }
        public string CLogradouroCEP
        {
            get { return this.LogradouroCEP; }
            set { this.LogradouroCEP = value; }
        }
        public string CLogradouroNome
        {
            get { return this.LogradouroNome; }
            set { this.LogradouroNome = value; }
        }
        public string CLogradouroNumero
        {
            get { return this.LogradouroNumero; }
            set { this.LogradouroNumero = value; }
        }
        public string CLogradouroComplemento
        {
            get { return this.LogradouroComplemento; }
            set { this.LogradouroComplemento = value; }
        }
        public string CLogradouroMunicipio
        {
            get { return this.LogradouroMunicipio; }
            set { this.LogradouroMunicipio = value; }
        }
        public string CLogradouroBairro
        {
            get { return this.LogradouroBairro; }
            set { this.LogradouroBairro = value; }
        }
        public string CLogradouroUF
        {
            get { return this.LogradouroUF; }
            set { this.LogradouroUF = value; }
        }
        public DateTime CDataCadastro
        {
            get { return this.DataCadastro; }
            set { this.DataCadastro = value; }
        }
    }
}



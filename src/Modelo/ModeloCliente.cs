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
        }

        public ModeloCliente(int ClienteId, String Cliente, String Apelido, String DocumentoCliente, String Sexo, String EstadoCivil, DateTime DataNascimento, String Email, String TelefoneFixo, String TelefoneCelular, String TelefoneOutros, String LogradouroCEP, String LogradouroNome, String LogradouroNumero, String LogradouroComplemento, String LogradouroMunicipio, String LogradouroBairro, String LogradouroUF)

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
        }

        private int ClienteId;
        private String Cliente;
        private String Apelido;
        private String DocumentoCliente;
        private String Sexo;
        private String EstadoCivil;
        private DateTime DataNascimento;
        private String Email;
        private String TelefoneFixo;
        private String TelefoneCelular;
        private String TelefoneOutros;
        private String LogradouroCEP;
        private String LogradouroNome;
        private String LogradouroNumero;
        private String LogradouroComplemento;
        private String LogradouroMunicipio;
        private String LogradouroBairro;
        private String LogradouroUF;

        public int CClienteId
        {
            get { return this.ClienteId; }
            set { this.ClienteId = value; }
        }

        public String CCliente
        {
            get { return this.Cliente; }
            set { this.Cliente = value; }
        }
        public String CApelido
        {
            get { return this.Apelido; }
            set { this.Apelido = value; }
        }
        public String CDocumentoCliente
        {
            get { return this.DocumentoCliente; }
            set { this.DocumentoCliente = value; }
        }
        public String CSexo
        {
            get { return this.Sexo; }
            set { this.Sexo = value; }
        }
        public String CEstadoCivil
        {
            get { return this.EstadoCivil; }
            set { this.EstadoCivil = value; }
        }
        public DateTime CDataNascimento
        {
            get { return this.DataNascimento; }
            set { this.DataNascimento = value; }
        }
        public String CEmail
        {
            get { return this.Email; }
            set { this.Email = value; }
        }
        public String CTelefoneFixo
        {
            get { return this.TelefoneFixo; }
            set { this.TelefoneFixo = value; }
        }
        public String CTelefoneCelular
        {
            get { return this.TelefoneCelular; }
            set { this.TelefoneCelular = value; }
        }
        public String CTelefoneOutros
        {
            get { return this.TelefoneOutros; }
            set { this.TelefoneOutros = value; }
        }
        public String CLogradouroCEP
        {
            get { return this.LogradouroCEP; }
            set { this.LogradouroCEP = value; }
        }
        public String CLogradouroNome
        {
            get { return this.LogradouroNome; }
            set { this.LogradouroNome = value; }
        }
        public String CLogradouroNumero
        {
            get { return this.LogradouroNumero; }
            set { this.LogradouroNumero = value; }
        }
        public String CLogradouroComplemento
        {
            get { return this.LogradouroComplemento; }
            set { this.LogradouroComplemento = value; }
        }
        public String CLogradouroMunicipio
        {
            get { return this.LogradouroMunicipio; }
            set { this.LogradouroMunicipio = value; }
        }
        public String CLogradouroBairro
        {
            get { return this.LogradouroBairro; }
            set { this.LogradouroBairro = value; }
        }
        public String CLogradouroUF
        {
            get { return this.LogradouroUF; }
            set { this.LogradouroUF = value; }
        }
    }
}



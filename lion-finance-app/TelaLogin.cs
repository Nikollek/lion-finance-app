using System;
using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace lion_finance_app
{
    public partial class TelaLogin : Form
    {
        // string de conex�o para o banco de dados Access
        string stringcon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Layla\Documents\lion-finance-app\lion-finance-app\lion-finance-app\LionFinance.mdb";

        public TelaLogin()
        {
            InitializeComponent();
        }

        private void lblCadastrar_Click(object sender, EventArgs e)
        {
            TelaCadastro telaCadastro = new TelaCadastro();
            telaCadastro.Show();
            this.Hide();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            try{
                // Abrir conex�o com o banco de dados Access
                OleDbConnection conn = new OleDbConnection(stringcon);
                conn.Open();

                // Consultar o banco de dados Access
                string query = "SELECT * FROM Usuarios WHERE Nome = @Nome AND Senha = @Senha";
                OleDbCommand cmd = new OleDbCommand(query, conn);
                cmd.Parameters.AddWithValue("@Nome", txtLogin.Text);
                cmd.Parameters.AddWithValue("@Senha", txtSenha.Text);

                OleDbDataAdapter dp = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();
                dp.Fill(dt);

                if (dt.Rows.Count == 1){
                    TelaRelatorio financeiro = new(txtLogin.Text); // Passando o nome do usu�rio como argumento
                    conn.Close(); // Fechar conex�o com o banco de dados Access
                    financeiro.Show();
                    this.Hide();
                }else{
                    MessageBox.Show("Usu�rio ou Senha Incorreto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }catch (Exception erro){
                MessageBox.Show(erro.Message);
            }
        }
    }
}

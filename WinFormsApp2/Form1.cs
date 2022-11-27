using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            txt_nome.Enabled = true;
            txt_cpf.Enabled = true;
            txt_endereço.Enabled = true;
            txt_estado.Enabled = true;
            txt_bairro.Enabled = true;
            txt_cep.Enabled = true;
            txt_telefone.Enabled = true;
           
        }
        SqlConnection sqlCon = null;
        private string strCon = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=form;Data Source=ABELHA_RAINHA\\SQL";
        private string strSql= string.Empty;
        private void label2_Click(object sender, EventArgs e)
        {
            
         
        }

        private void lblnome_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbltelefone_Click(object sender, EventArgs e)
        {
           
               }
        private void lbl_cpf_Click(object sender, EventArgs e)
        {

        }

        private void lbl_endereço_Click(object sender, EventArgs e)
        {

        }

        private void lbl_cep_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            txt_nome.Text = "";
            txt_cep.Text = "";
            txt_endereço.Text = "";
            txt_estado.Text = "";
            txt_telefone.Text = "";
            txt_cpf.Text = "";
            txt_bairro.Text = "";
            
        }

private void enviar_Click(object sender, EventArgs e)
        {
            strSql = "insert into form (Nome,Cpf,Endereço,Bairro,Cep,Numero,Estado,Telefone) values(@Nome,@Cpf,@Endereço,@Bairro,@Cep,@Numero,@Estado,@Telefone)";
            sqlCon = new SqlConnection(strCon);
            SqlCommand comando = new SqlCommand(strSql, sqlCon);

            comando.Parameters.Add("@Nome", SqlDbType.VarChar).Value = txt_nome.Text;
            comando.Parameters.Add("@Cpf", SqlDbType.VarChar).Value = txt_cpf.Text;
            comando.Parameters.Add("@Endereço", SqlDbType.VarChar).Value = txt_endereço.Text;
            comando.Parameters.Add("@Estado", SqlDbType.VarChar).Value = txt_estado.Text;
            comando.Parameters.Add("@Bairro", SqlDbType.VarChar).Value = txt_bairro.Text;
            comando.Parameters.Add("@Telefone", SqlDbType.VarChar).Value = txt_telefone.Text;
            comando.Parameters.Add("@Cep", SqlDbType.VarChar).Value = txt_cep.Text;

            try
            {
                sqlCon.Open();
                comando.ExecuteNonQuery();
                MessageBox.Show("Cadastro enviado com sucesso!");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                sqlCon.Close();
            }
            txt_nome.Clear();
            txt_cep.Clear();
            txt_endereço.Clear();
            txt_estado.Clear();
            txt_telefone.Clear();
            txt_cpf.Clear();
            txt_bairro.Clear();
        }

       
    }







   
namespace MédiadeAluno
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calcularButton_Click(object sender, EventArgs e)
        {
            // 1ª Etapa: Validação do Formulário
            if (alunoTextBox.Text == "")
            {
                MessageBox.Show("Campo nome é obrigatório", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (materiaComboBox.SelectedIndex == -1)
            {
                MessageBox.Show("Selecione uma Matéria", "Média", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (exercicio1TextBox.Text == "")
            {
                MessageBox.Show("Digite o valor do Exercício de Fixação 1, a 20% da nota final", "Média",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (exercicio2TextBox.Text == "")
            {
                MessageBox.Show("Digite o valor do Exercício de Fixação, correspondente a 20% da nota final", "Média",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (portifolioTextBox.Text == "")
            {
                MessageBox.Show("Digite o valor do Portifólio, correspondente a 35% da nota final", "Média",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (menadeTextBox.Text == "")
            {
                MessageBox.Show("Digite o valor do Momento Enade, correspondente a 10% da nota final", "Média",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (provaTextBox.Text == "")
            {
                MessageBox.Show("Digite o valor d a Prova Eletrônica, correspondente a 35% da nota final", "Média",
                MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            // 2ª Etapa: Entrada da Informação e Processamento
            decimal e1, e2, p2 ,m3, p4, media;
            e1 = Convert.ToDecimal(exercicio2TextBox.Text);
            e2 = Convert.ToDecimal(exercicio1TextBox.Text);
            p2 = Convert.ToDecimal(portifolioTextBox.Text);
            m3 = Convert.ToDecimal(menadeTextBox.Text);
            p4 = Convert.ToDecimal(provaTextBox.Text);

            media = (e1 + e2 +p2 + m3 + p4) / 5;

            if (media >= 6) 
            {
                label8.Text = "APROVADO";
            }
            else 
            { 
                label8.Text = "REPROVADO";
            }

            // 3ª Etapa: Saída da Informação
            mediaTextBox.Text = Convert.ToString(media);
        }

        private void limparButton_Click(object sender, EventArgs e)
        {
            alunoTextBox.Text = String.Empty;
            materiaComboBox.SelectedIndex = -1;
            exercicio1TextBox.Text = String.Empty;
            exercicio2TextBox.Text = String.Empty;
            portifolioTextBox.Text = String.Empty;
            menadeTextBox.Text = String.Empty;
            provaTextBox.Text = String.Empty;
            mediaTextBox.Text = String.Empty;
            alunoTextBox.Focus();
            label8.Text = String.Empty;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void sairBtText_Click(object sender, EventArgs e)
        {
            //this - próprio objeto : fechar essa janela
            DialogResult resposta = MessageBox.Show(" DESEJA REALMENTE SAIR ? ", "ATENÇÃO",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resposta == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
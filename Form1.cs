namespace Linqteste
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Metodo que procura  os produtos dentro  da lista  returna os produtos da lista enquanto a condição for satisfeita
        private List<Produtos> Takewhile(List<Produtos>listaprodutos,int Id)
        {
            return( from produtos in listaprodutos
                    select produtos).TakeWhile(p=>p.Id<Id).ToList();
        }
       //Metodo   returna vedadeiro ou falso de acordo com a  condição se a condição for verdadeira ele encontrou o produto na lista
        private bool Any(List<Produtos>listaprodutos,string produto)
        {
            return (from produtos in listaprodutos
                    select produtos).Any(p => p.Descrisao == produto);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

            var listaprodutos = new Produtos().GetALL();
            dataGridView1.DataSource = Takewhile(listaprodutos,30);
            dataGridView1.Columns[0].Width = 35;
            dataGridView1.Columns[1].Width = 200;
        }

        private void btn_pesquisar_Click(object sender, EventArgs e)
        {
            // instancia da class produtos
            var listaprodutos = new Produtos().GetALL();
           
            if (Any(listaprodutos, tb_pesc.Text))
            {
                var prod = listaprodutos.Single(p => p.Descrisao == tb_pesc.Text);
                MessageBox.Show(prod.Id + " - " + prod.Descrisao + " - " + prod.Setor.ToString());
            }
            else
                MessageBox.Show("Nao encontrado");


        }
    }
}
namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            decimal sum = SuccesfulWork.soldats.Where(x=>x.Id.Length == 1 || x.Id[0] == x.Id[x.Id.Length-1]).Sum(x=>x.AD.Average());
            sumLabel.Text = ((int)sum).ToString();
        }
        public static class SuccesfulWork
        {
            public static List<Rota> rotas = new List<Rota>();
            public static List<Soldat> soldats = new List<Soldat>();
            static SuccesfulWork()
            {
                rotas.Add(new Rota { Id = "1", Capability = 100, isActive = true, Placement = "sds" });
                rotas.Add(new Rota { Id = "2", Capability = 200, isActive = false, Placement = "lkj" });
                soldats.Add(new Soldat { Id = "1", Name = "kok", Rank = "5", Sex = true, rota = rotas.Where(x => x.Id == "1").FirstOrDefault(), RotaId = "1", AD = new decimal[] { 1, 2, 3 } });
                soldats.Add(new Soldat { Id = "22", Name = "mkl", Rank = "3", Sex = true, rota = rotas.Where(x => x.Id == "1").FirstOrDefault(), RotaId = "1", AD = new decimal[] { 1, 6, 9 } });
                soldats.Add(new Soldat { Id = "3", Name = "qwe", Rank = "3", Sex = false, rota = rotas.Where(x => x.Id == "2").FirstOrDefault(), RotaId = "2", AD = new decimal[] { 1, 4, 2 } });
                soldats.Add(new Soldat { Id = "32", Name = "lok", Rank = "8", Sex = true, rota = rotas.Where(x => x.Id == "2").FirstOrDefault(), RotaId = "2", AD = new decimal[] { 1, 9, 4 } });
            }

        }

        private void logicSumBTN_Click(object sender, EventArgs e)
        {
            var rotas = SuccesfulWork.rotas.Where(x => x.Id == inputTB.Text).ToList();
            var booleans = SuccesfulWork.soldats.Where(x => x.RotaId == rotas[0].Id).Select(x => x.Sex).ToList();
            int sum = 0;
            foreach(var boolean in booleans)
            {
                sum = sum + (boolean ? 1 : 0);
            }
            boolSumLabel.Text = sum.ToString();
        }
    }
}
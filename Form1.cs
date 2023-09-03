namespace SayisalLotoWinForm;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        btnMakinaniOynat.Click += btnMakinaniOynat_Click;
        btnBaslat.Click += btnBaslat_Click;
        //btnBitir.Click += btnBitir_Click;
    }

    private void btnBaslat_Click(object? sender, EventArgs e)
    {
        MessageBox.Show($"Maximom 6 kez oyunu başlatabilirsiniz !");
        Random rnd = new Random();
        int[] randomSayilar = new int[6];
        int k = rnd.Next(1, 1000);
        string output = " ," + k;
        txttahmin.Text += output + Environment.NewLine;
        //txtpuan  


    }
    private void btnMakinaniOynat_Click(object? sender, EventArgs e)
    {
        Random rnd = new Random();
        int a = rnd.Next(1, 1000);
        int b = rnd.Next(1, 1000);
        int c = rnd.Next(1, 1000);
        int d = rnd.Next(1, 1000);
        int i = rnd.Next(1, 1000);
        int j = rnd.Next(1, 1000);
        txtSayi1.Text = a.ToString();
        txtSayi2.Text = b.ToString();
        txtSayi3.Text = c.ToString();
        txtSayi4.Text = d.ToString();
        txtSayi5.Text = i.ToString();
        txtSayi6.Text = j.ToString();
    }

/*
    private void btnBitir_Click(object? sender, EventArgs e)
    {
        string inputStart = "2016-V-0049";
        string inputEnd = "2016-V-0070";

        string pattern = @"[0-9]{4}\-[A-Z]{1}\-([0-9]{4})";

        var regex = new Regex(pattern);

        var match = regex.Match(inputStart);
        var numberStart = int.Parse(match.Groups[1].Value);

        match = regex.Match(inputEnd);
        var numberEnd = int.Parse(match.Groups[1].Value);

        for (int currentNumber = numberStart + 1; currentNumber < numberEnd; currentNumber++)
        {
            Console.WriteLine("2016-V-{0:0000}", currentNumber);
        }
        //txtpuan  

        string esitnumbre;

        string[] kredi = new string[4];

        while (esitnumbre >= 0)
        {
            Console.WriteLine("Lütfen Yapmak İstediğiz İşlemi Seçiniz");
            Console.WriteLine("***************************************");
            Console.WriteLine("[1] Kayıt Listele");
            Console.WriteLine("[2] Kayıt Ekle");
            Console.WriteLine("[3] Kayıt Düzenle");
            Console.WriteLine("[4] Kayıt Sil");
            Console.WriteLine("[0] Çıkış");

            esitnumbre = ;

            switch (esitnumbre)
            {
                case "0":
                    goto cikis;
                case "1":
                    goto ;
                case "2":
                    goto ;
                case "3":
                    goto ;
                default:
                    M
                    continue;
            }

        cikis:
        MessageBox.Show($"Üzgünüm ama Kaybettiğniz!!!");
            break;

*/

        }




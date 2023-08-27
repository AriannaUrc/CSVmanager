using System.ComponentModel;
using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace CSVmanager
{
    public partial class Form1 : Form
    {
        public struct dati
        {
            public string draw_date;
            public string winning_numbers;
            public int mega_ball;
            public int multiplier;
            public int miovalore;
            public bool cancLogic;
        }

        public int recordLength;
        public string separator;

        public dati d;
        public string FileName;
        public string BackUp;

        public Form1()
        {
            InitializeComponent();
            recordLength = 64;
            FileName = "Lottery_Numbers.csv";
            BackUp = "BackUp.csv";
            separator = ",";

            Format();
            LoadFromFile();
        }


        //dato un comando lo esegue appogiandosi allo shell
        public void ExecuteCommand(string Command, string Arguments = "", string Path = "", bool ShellExecute = true)
        {
            ProcessStartInfo ProcessInfo = new ProcessStartInfo(Command);

            if (Path != "")
            {
                ProcessInfo.WorkingDirectory = Path;
            }
            if (Arguments != "")
            {
                ProcessInfo.Arguments = Arguments;
            }
            ProcessInfo.CreateNoWindow = true;
            ProcessInfo.UseShellExecute = ShellExecute;

            //Process Process =
            Process.Start(ProcessInfo);
        }


        //rende il file utilizzabile per l'accesso diretto
        public void Format()
        {
            StreamReader sr = new StreamReader(BackUp);
            StreamWriter sw = new StreamWriter(FileName, false);

            string str = sr.ReadLine();
            Random random = new Random();

            while (str != null)
            {

                sw.WriteLine((str + separator + random.Next(10, 21).ToString() + separator + "true" + separator).PadRight(60) + "##");
                str = sr.ReadLine();
            }
            sw.Close();
            sr.Close();
        }

        public static void scriviAppend(string content, string filename)
        {
            var fStream = new FileStream(filename, FileMode.Append, FileAccess.Write, FileShare.Read);
            StreamWriter sw = new StreamWriter(fStream);
            sw.WriteLine(content);
            sw.Close();
        }

        //prende una variabile dati e la transforma per renderla idonea ad essere scritta sul file
        public string FileString(dati d)
        {
            return ((d.draw_date + separator + d.winning_numbers + separator + d.mega_ball + separator + d.multiplier + separator).PadRight(60) + "##");
        }

        public static dati FromString(string temp, string sep = ",")
        {
            //MessageBox.Show(temp);
            dati p;
            String[] fields = temp.Split(sep[0]);
            //MessageBox.Show(fields[3]);
            p.draw_date = fields[0];
            p.winning_numbers = fields[1];
            p.mega_ball = int.Parse(fields[2]);



            //controlla se il multiplier non é nullo
            if (fields[3] != "")
                p.multiplier = int.Parse(fields[3]);
            else
                p.multiplier = 1;

            p.miovalore = int.Parse(fields[4]);
            p.cancLogic = bool.Parse(fields[5]);

            //dalla stringa deve ritornare la variabile dati p settata con i valori estratti
            return p;
        }


        public void LoadFromFile(bool showw = false)
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);



            string[] words = new string[4];

            listView.Items.Clear();

            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //valore x debug per mostrare che linee legge
                if (showw)
                {
                    MessageBox.Show(line);
                }
                //estraggo dalla stringa i valori e gli inserisco il d
                d = FromString(line);

                //aggiunge alla lista i dati di d
                ListViewItem item = new ListViewItem(new[] { d.draw_date, d.winning_numbers, d.mega_ball.ToString(), d.multiplier.ToString() });
                listView.Items.Add(item);

            }

            writer.Close();
            reader.Close();
            f.Close();

        }

        public void ModificaFile()
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);
            BinaryWriter writer = new BinaryWriter(f);



            string[] words = new string[4];


            while (f.Position < f.Length - 2)
            {

                br = reader.ReadBytes(recordLength);
                //converte in stringa
                line = Encoding.ASCII.GetString(br, 0, br.Length);

                //estraggo dalla stringa i valori e gli inserisco il d
                d = FromString(line);

                if (d.draw_date == modify_draw_date_textbox.Text)
                {
                    switch (modify_target.Text)
                    {
                        case "WinNumbers":
                            //MessageBox.Show("you are in modif winnumbers");
                            d.winning_numbers = modify_new_value_textbox.Text;
                            break;

                        case "MegaBall":
                            if (int.TryParse(modify_new_value_textbox.Text, out int number))
                            {
                                d.mega_ball = int.Parse(modify_new_value_textbox.Text);
                            }
                            else
                            {
                                MessageBox.Show("il valore inserito non è valido");
                            }
                            break;

                        case "Multiplier":
                            if (int.TryParse(modify_new_value_textbox.Text, out int number1))
                            {
                                d.multiplier = int.Parse(modify_new_value_textbox.Text);
                            }
                            else
                            {
                                MessageBox.Show("il valore inserito non è valido");
                            }
                            break;

                        default:
                            MessageBox.Show("valori inseriti non validi");
                            break;
                    }


                    f.Seek(-recordLength, SeekOrigin.Current);
                    writer.Write(Encoding.UTF8.GetBytes(FileString(d)));
                }

            }

            writer.Close();
            reader.Close();
            f.Close();

        }

        public int findNumberOfFields()
        {
            String line;
            byte[] br;

            var f = new FileStream(FileName, FileMode.Open, FileAccess.ReadWrite);
            BinaryReader reader = new BinaryReader(f);



            string[] words = new string[4];


            br = reader.ReadBytes(recordLength);
            //converte in stringa
            line = Encoding.ASCII.GetString(br, 0, br.Length);

            //estraggo dalla stringa i valori e gli inserisco il d

            String[] fields = line.Split(separator);
            

            reader.Close();
            f.Close();

            //meno 1 per tenere in considerazione l'ultima virgola
            return fields.Length-1;
        }




        //windows form functions
        private void OpenButton_Click(object sender, EventArgs e)
        {

            ExecuteCommand(FileName);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            LoadFromFile();
        }

        private void Modify_button_Click(object sender, EventArgs e)
        {
            ModificaFile();
        }

        private void fields_num_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show(findNumberOfFields().ToString());
        }
    }
}
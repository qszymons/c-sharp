using System.CodeDom.Compiler;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {

        int[] tab = null;

        int[] Tab
        {
            get { return tab; }
            set { tab = value; }
        }


        bool isgenerated = false;


        public void randomint(int n)
        {
            tab = new int[n];
            Random random = new Random(DateTime.Now.Millisecond);

            for (int i = 0; i < tab.Length; i++)
            {
                tab[i] = random.Next(1, 100);
                
            }
            isgenerated = true;

        }

        public static void BubbleSort(int[] tab)
        {
            int temp;
            for (int i = 0; i < tab.Length; i++)
            {
                for(int j = 0; j<tab.Length-1; j++)
                {
                    if (tab[j] > tab[j + 1])
                    {
                        temp = tab[j+1];
                        tab[j+1] = tab[j];
                        tab[j] = temp;
                    }
                }
            }
        }



public static void InsertSort(int[] tab)
        {
            for(int i = 1; i < tab.Length; i++)
            {
                int key = tab[i];
                int j = i - 1;
                while(j>=0 && tab[j] > key)
                {
                    tab[j + 1] = tab[j];
                    j--;
                }
                tab[j+1] = key;
            }
        }



        public static void CountingSort(int[] tab)
        {
            int max = tab.Max();
            int[] tab2 = new int[max + 1];
            for (int i = 0; i < tab.Length; i++)
            {
                tab2[tab[i]] ++;
            }
            for (int i = 0, j = 0; i <= max; i++)
            {
                while (tab2[i]> 0)
                {
                    tab[j++] = i;
                    tab2[i]--;                
                }
            }
        }





        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!isgenerated)
            {
                MessageBox.Show("wygeneruj tablice");
                    return;
            }
            int[] tabClone = (int[])Tab.Clone();
            BubbleSort(tabClone);
            label1.Text = String.Join(", ", tabClone);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!isgenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            InsertSort(tabClone);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!isgenerated)
            {
                MessageBox.Show("Najpierw wygeneruj tablice!");
                return;
            }
            int[] tabClone = (int[])Tab.Clone();
            CountingSort(tabClone);
            label1.Text = String.Join(", ", tabClone);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            randomint(6);
            label1.Text = String.Join(", ", Tab);
        }
    }
}

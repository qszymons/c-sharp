namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            int[] array = { 34, 7, 23, 32, 5, 62, 12, 45 };

            MergeSort(array, 0, array.Length - 1);

            MessageBox.Show("Posortowana tablica: " + string.Join(", ", array), "Wynik Sortowania");
        }

        private void MergeSort(int[] array, int jeden, int dwa)
        {
            if (jeden < dwa)
            {
                int mid = (jeden + dwa) / 2;

                MergeSort(array, jeden, mid);
                MergeSort(array, mid + 1, dwa);

                Merge(array, jeden, mid, dwa);
            }
        }

        private void Merge(int[] array, int jeden, int mid, int dwa)
        {
            int n1 = mid - jeden + 1;
            int n2 = dwa - mid;

            int[] Larr = new int[n1]; // Zmieniono nazwę z leftArray na Larr
            int[] Parr = new int[n2]; // Zmieniono nazwę z rightArray na Parr

            for (int i = 0; i < n1; i++)
                Larr[i] = array[jeden + i];
            for (int j = 0; j < n2; j++)
                Parr[j] = array[mid + 1 + j];

            int k = jeden, iIndex = 0, jIndex = 0;
            while (iIndex < n1 && jIndex < n2)
            {
                if (Larr[iIndex] <= Parr[jIndex])
                {
                    array[k] = Larr[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = Parr[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                array[k] = Larr[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                array[k] = Parr[jIndex];
                jIndex++;
                k++;
            }
        }
    }
}

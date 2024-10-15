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

            int[] leftArray = new int[n1];
            int[] rightArray = new int[n2];

            for (int i = 0; i < n1; i++)
                leftArray[i] = array[jeden + i];
            for (int j = 0; j < n2; j++)
                rightArray[j] = array[mid + 1 + j];

            int k = jeden, iIndex = 0, jIndex = 0;
            while (iIndex < n1 && jIndex < n2)
            {
                if (leftArray[iIndex] <= rightArray[jIndex])
                {
                    array[k] = leftArray[iIndex];
                    iIndex++;
                }
                else
                {
                    array[k] = rightArray[jIndex];
                    jIndex++;
                }
                k++;
            }

            while (iIndex < n1)
            {
                array[k] = leftArray[iIndex];
                iIndex++;
                k++;
            }

            while (jIndex < n2)
            {
                array[k] = rightArray[jIndex];
                jIndex++;
                k++;
            }
        }
    }
}

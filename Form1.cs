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

            QuickSort(array, 0, array.Length - 1);

            MessageBox.Show("Posortowana: " + string.Join(", ", array), "Wynik Sortowania");
        }

        private void QuickSort(int[] array, int jeden, int dwa)
        {
            if (jeden < dwa)
            {
                int pivotIndex = Partition(array, jeden, dwa);
                QuickSort(array, jeden, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, dwa);
            }
        }

        private int Partition(int[] array, int jeden, int dwa)
        {
            int pivot = array[dwa];
            int i = jeden - 1;

            for (int j = jeden; j < dwa; j++)
            {
                if (array[j] <= pivot)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, dwa);
            return i + 1;
        }

        private void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}

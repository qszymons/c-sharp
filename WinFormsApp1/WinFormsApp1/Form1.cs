using System.Globalization;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        private int[] arr; // Pole globalne

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
  
            BubbleSort(arr);
            string result = string.Join(", ", arr);
            MessageBox.Show(result);
        }

        private void BubbleSort(int[] array)
        {
            int a;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        a = array[j + 1];
                        array[j + 1] = array[j];
                        array[j] = a;
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Uøywanie globalnej tablicy arr
            if (arr == null)
            {
                MessageBox.Show("Najpierw wprowadü dane w TextBox.");
                return;
            }

            int a = 0;
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        a = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = a;
                    }
                }
            }

            string result = string.Join(", ", arr);
            MessageBox.Show(result);
        }

        public void button3_Click(object sender, EventArgs e)
        {
            // Uøywanie globalnej tablicy arr
            if (arr == null)
            {
                MessageBox.Show("Najpierw wprowadü dane w TextBox.");
                return;
            }

            QuickSort(arr, 0, arr.Length - 1);
            MessageBox.Show("Posortowana: " + string.Join(", ", arr), "Wynik Sortowania");
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

        private void button4_Click(object sender, EventArgs e)
        {
            if (arr == null)
            {
                MessageBox.Show("Najpierw wprowadü dane w TextBox.");
                return;
            }

            MergeSort(arr, 0, arr.Length - 1);
            MessageBox.Show("Posortowana tablica: " + string.Join(", ", arr), "Wynik Sortowania");
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

            int[] Larr = new int[n1];
            int[] Parr = new int[n2];

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

        private void button5_Click(object sender, EventArgs e)
        {
            string inputText = textBox1.Text;
            string[] strings = inputText.Split(',');

            arr = new int[strings.Length]; // Inicjalizowanie globalnej tablicy
            for (int i = 0; i < strings.Length; i++)
            {
                if (!int.TryParse(strings[i].Trim(), out arr[i]))
                {
                    MessageBox.Show("Wprowadü poprawne liczby ca≥kowite.");
                    return;
                }
            }

            MessageBox.Show("Dane zosta≥y pomyúlnie skonwertowane.");
        }
    }
}

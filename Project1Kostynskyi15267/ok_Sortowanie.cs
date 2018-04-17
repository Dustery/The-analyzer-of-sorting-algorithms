using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortowanieAlgorytmow
{
    class ok_Sortowanie
    {
        public static int ok_SelectionSort(int[] tab)
        {
            int pom, licznik = 0;
            for (int i = 0; i < tab.Length; i++)
            {
                int min = i;//
                for (int j = i + 1; j < tab.Length; j++)
                {
                    if (tab[j] < tab[min]) min = j;
                    licznik++;
                } // koniec for j
                pom = tab[i];
                tab[i] = tab[min];
                tab[min] = pom;
            }
            return licznik;
        } // koniec SelectionSort

        public static int ok_InsertionSort(int[] tab)
        {
            int v, j, licznik = 0;
            for (int i = 1; i < tab.Length; i++)
            {
                j = i; v = tab[i];
                while (tab[j - 1] > v)
                {
                    tab[j] = tab[j - 1]; j = j - 1;
                    licznik++;
                    if (j == 0) break;
                } // koniec while
                tab[j] = v;
            } // koniec for i
            return licznik;
        } // koniec InsertionSort

        public static int ok_QuickSort(int[] tab, int d, int g)
        {
            int elementOsiowy = tab[(d + g) / 2];
            int i = d;
            int j = g;
            int pom, licznik = 0;
            do
            {
                while (tab[i] < elementOsiowy) { i++; licznik++; }
                while (tab[j] > elementOsiowy) { j--; licznik++; }
                if (i <= j)
                {
                    pom = tab[i];
                    tab[i] = tab[j];
                    tab[j] = pom;
                    j--; i++;
                }

            } while (i <= j);
            if (d < j) licznik += ok_QuickSort(tab, d, j);
            if (g > i) licznik += ok_QuickSort(tab, i, g);
            return licznik;
        }
        public static int ok_MegreSort(int[] tab, int rozmiar)
        {
            int ok_licznik = 0;
            int[] ok_wynik = new int[rozmiar];
            for (int x = 1; x < rozmiar; x += x)
            {
                int i = 0;
                for (int j = 0; j < rozmiar; j += x + x)
                {
                    int l = j;
                    int lend = Math.Min(l + x, rozmiar);
                    int r = lend;
                    int rend = Math.Min(r + x, rozmiar);
                    while (l < lend && r < rend)
                    {
                        ok_wynik[i++] = (tab[l].CompareTo(tab[r]) < 1 ? tab[l++] : tab[r++]);
                        ok_licznik++;
                    }
                    while (l < lend)
                    {
                        ok_wynik[i++] = tab[l++];
                        ok_licznik++;
                    }
                    while (r < rend)
                    {
                        ok_wynik[i++] = tab[r++];
                        ok_licznik++;
                    }
                }
                var tmp = tab;
                tab = ok_wynik;
                ok_wynik = tmp;
            }
            return ok_licznik;
        }
        public static void ok_swap<T>(T[] items, int i, int k)
        {
            T t = items[i];
            items[i] = items[k];
            items[k] = t;
        }
        public static int ok_HeapSort(int[] tab, int rozmiar)
        {
            int ok_licznik = 0;
            int ok_heapSize = rozmiar;
            for (int h = (ok_heapSize - 1) / 2; h >= 0; h--)
                ok_Heap(tab, ok_heapSize, h, ref ok_licznik);

            for (int i = rozmiar - 1; i > 0; i--)
            {
                ok_swap(tab, i, 0);

                ok_heapSize--;
                ok_Heap(tab, ok_heapSize, 0, ref ok_licznik);
            }
            return ok_licznik;
        }
        private static void ok_Heap(int[] items, int heapSize, int index, ref int ok_licznik)
        {
            int ok_left = (index + 1) * 2 - 1;
            int ok_right = (index + 1) * 2;
            int ok_largest = 0;

            if (ok_left < heapSize && items[ok_left].CompareTo(items[index]) == 1)
                ok_largest = ok_left;
            else
                ok_largest = index;
            if (ok_right < heapSize && items[ok_right].CompareTo(items[ok_largest]) == 1)
                ok_largest = ok_right;

            if (ok_largest != index)
            {
                ok_swap(items, index, ok_largest);

                ok_Heap(items, heapSize, ok_largest, ref ok_licznik);
            }
            ok_licznik++;
        }
        public static int ok_BubbleSort(int[] tab, int rozmiar)
        {
            int ok_licznik = 0;
            for (int i = 0; i < rozmiar - 1; i++)
                for (int j = 0; j < rozmiar - i - 1; j++)
                    if (tab[j].CompareTo(tab[j + 1]) == 1)
                    {
                        ok_swap(tab, j, j + 1);
                        ok_licznik++;
                    }
            return ok_licznik;
        }
        public static int ok_ShellSort(int[] tab, int rozmiar)
        {
            int ok_licznik = 0;
            int ok_step = rozmiar / 2;
            while (ok_step > 0)
            {
                for (int i = 0; i < (rozmiar - ok_step); i++)
                {
                    int j = i;
                    while (j >= 0 && tab[j].CompareTo(tab[j + ok_step]) == 1)
                    {
                        ok_swap(tab, j, j + ok_step);
                        j--;
                        ok_licznik++;
                    }
                }
                ok_step = ok_step / 2;
            }
            return ok_licznik;
        }
        public static int ok_CombSort(int[] tab, int rozmiar)
        {
            int ok_licznik = 0;
            int ok_r = rozmiar;
            bool ok_f = true;
            while (ok_r > 1 || ok_f)
            {
                ok_r = ok_r * 10 / 13;
                if (ok_r == 0)
                    ok_r = 1;
                ok_f = false;
                for (int i = 0; i + ok_r < rozmiar; i++)
                    if (tab[i + ok_r].CompareTo(tab[i]) == -1)
                    {
                        ok_swap(tab, i + ok_r, i);
                        ok_f = true;
                        ok_licznik++;
                    }
            }
            return ok_licznik;
        }
    }
}


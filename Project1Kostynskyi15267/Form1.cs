using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Windows.Forms.DataVisualization.Charting;


namespace SortowanieAlgorytmow
{
    public partial class Form1 : Form
    {
        private Pen ok_Pen = new Pen(Color.Black, 1.0f);
        int ok_maxRozTab = 30, a, b = 0, i = 0;
        int[] ok_pomTab, ok_posortowana;
        int[,] ok_wyniki;
        public Form1()
        {
            InitializeComponent();
            ok_TabAfter.Visible = false;
            ok_Pen.Width = 4;
            ok_TabKosztA.Visible = false;
            ok_Wykres.Visible = false;
            ok_lbl1.Visible = false;
            ok_lbl2.Visible = false;
            ok_lbl3.Visible = false;
            ok_lbl4.Visible = false;
            ok_lbl5.Visible = false;
            ok_lbl6.Visible = false;
            ok_lbl7.Visible = false;
            ok_lbl8.Visible = false;
            ok_lbl9.Visible = false;
            ok_lbl10.Visible = false;
            ok_pomTab = new int[10];
            Random ok_los = new Random();
            for (int i = 0; i < 10; i++)
            {
                ok_pomTab[i] = ok_los.Next(1, 101);
            }
            ok_posortowana = ok_pomTab;
            ok_Sortowanie.ok_SelectionSort(ok_posortowana);
        }
        bool ok_PobirzDane(out int ok_rozmiar, out int ok_a, out int ok_b, out int ok_max)
        {
            ok_rozmiar = 0; ok_a = 0; ok_b = 0; ok_max = 0;
            if (string.IsNullOrEmpty(ok_txtMin.Text))
            {
                ok_error.SetError(ok_txtMin, "ERROR: Musisz podać wartość");
                return false;
            }
            else ok_error.Dispose();
            if (string.IsNullOrEmpty(ok_txtMax.Text))
            {
                ok_error.SetError(ok_txtMax, "ERROR: Musisz podać wartość");
                return false;
            }
            else ok_error.Dispose();
            if (string.IsNullOrEmpty(ok_txtDolnaG.Text))
            {
                ok_error.SetError(ok_txtDolnaG, "ERROR: Musisz podać wartość");
                return false;
            }
            else ok_error.Dispose();
            if (string.IsNullOrEmpty(ok_txtGornaG.Text))
            {
                ok_error.SetError(ok_txtGornaG, "ERROR: Musisz podać wartość");
                return false;
            }
            else ok_error.Dispose();
            if (!int.TryParse(ok_txtMin.Text, out ok_rozmiar))
            {
                ok_error.SetError(ok_txtMin, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else ok_error.Dispose();
            if (!int.TryParse(ok_txtDolnaG.Text, out ok_a))
            {
                ok_error.SetError(ok_txtDolnaG, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else ok_error.Dispose();
            if (!int.TryParse(ok_txtGornaG.Text, out ok_b))
            {
                ok_error.SetError(ok_txtGornaG, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else ok_error.Dispose();
            if (!int.TryParse(ok_txtMax.Text, out ok_max))
            {
                ok_error.SetError(ok_txtMax, "ERROR: Wystąpił błąd w zapisie zmiennej - niedozwolony znak");
                return false;
            }
            else ok_error.Dispose();
            if (ok_a > ok_b)
            {
                ok_error.SetError(ok_txtGornaG, "ERROR: Górna granica jest mniejsza niż dolna");
                return false;
            }
            else ok_error.Dispose();
            return true;
        }
        private void ok_btnKolorLinii_Click(object sender, EventArgs e)
        {
            if (ok_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                ok_lblKolorLini.BackColor = ok_cdKolorLini.Color;

            }
            ok_Pen.Color = ok_lblKolorLini.BackColor;
            ok_panel.Refresh();
        }

        private void ok_btnKolorTla_Click(object sender, EventArgs e)
        {
            if (ok_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                ok_lblKolorTla.BackColor = ok_cdKolorLini.Color;
            }
        }

        private void ok_tbGruboscLinii_Scroll(object sender, EventArgs e)
        {
            ok_panel.Refresh();
            ok_Pen.Width = ok_tbGruboscLinii.Value;
            ok_numericGrubosc.Value = ok_tbGruboscLinii.Value;

        }

        private void ok_numericGrubosc_ValueChanged(object sender, EventArgs e)
        {
            ok_panel.Refresh();
            ok_Pen.Width = ok_tbGruboscLinii.Value;
            ok_tbGruboscLinii.Value = (int)ok_numericGrubosc.Value;

        }

        private void ok_btnWizPrzed_Click(object sender, EventArgs e)
        {
            ok_dGWTabelaprzed.Visible = true;
            ok_Wykres.Visible = false;
            ok_TabAfter.Visible = false;
            ok_TabKosztA.Visible = false;
            ok_TabBefore.HeaderText = "Tablica przed sortowaniem";
            ok_TabAfter.HeaderText = "Tablica po sortowaniu";
            int ok_a = 0;
            int ok_b = 0, ok_rozmiar, ok_max;
            if (!ok_PobirzDane(out ok_rozmiar, out ok_a, out ok_b, out ok_max))
            {
                return;
            }
            int[] ok_wynik = new int[ok_rozmiar];
            Random ok_los = new Random();
            for (int i = 0; i < ok_rozmiar; i++)
            {
                ok_wynik[i] = ok_los.Next(ok_a, ok_b);
            }
            if (ok_dGWTabelaprzed.RowCount > 1)
            {
                ok_dGWTabelaprzed.Rows.Clear();
                ok_dGWTabelaprzed.Refresh();
            }
            for (int i = 0; i < ok_wynik.GetLength(0); i++)
            {
                ok_dGWTabelaprzed.Rows.Add(ok_wynik[i].ToString());
            }


        }

        private void ok_btnWizPo_Click(object sender, EventArgs e)
        {
            ok_dGWTabelaprzed.Visible = true;
            ok_Wykres.Visible = false;
            ok_TabAfter.Visible = true;
            ok_TabKosztA.Visible = false;
            ok_TabBefore.HeaderText = "Tablica przed sortowaniem";
            ok_TabAfter.HeaderText = "Tablica po sortowaniu";
            int[] ok_tabela = new int[ok_dGWTabelaprzed.Rows.Count - 1];
            if (ok_dGWTabelaprzed.RowCount > 1)
            {
                for (int i = 0; i < ok_tabela.Length; i++)
                {
                    ok_tabela[i] = int.Parse(ok_dGWTabelaprzed[0, i].Value.ToString());
                }
            }
            else
                MessageBox.Show("Nie utworzono tabeli");
            for (int i = 1; i < ok_tabela.Length + 1; i++)
            {
                switch (ok_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            ok_Sortowanie.ok_SelectionSort(ok_tabela);
                        }
                        break;
                    case "Insertion":
                        {
                            ok_Sortowanie.ok_InsertionSort(ok_tabela);
                        }
                        break;
                    case "Quick":
                        {
                            ok_Sortowanie.ok_QuickSort(ok_tabela, 0, ok_tabela.Length - 1);
                        }
                        break;
                    case "Merge":
                        {
                            ok_Sortowanie.ok_MegreSort(ok_tabela, ok_tabela.Length);
                        }
                        break;
                    case "Heap":
                        {
                            ok_Sortowanie.ok_HeapSort(ok_tabela, ok_tabela.Length);
                        }
                        break;
                    case "Bubble":
                        {
                            ok_Sortowanie.ok_BubbleSort(ok_tabela, ok_tabela.Length);
                        }
                        break;
                    case "Shell":
                        {
                            ok_Sortowanie.ok_ShellSort(ok_tabela, ok_tabela.Length);
                        }
                        break;
                    case "Comb":
                        {
                            ok_Sortowanie.ok_CombSort(ok_tabela, ok_tabela.Length);
                        }
                        break;
                    default:
                        {
                            ok_Sortowanie.ok_SelectionSort(ok_tabela);
                        }
                        break;
                }
            }
            for (int i = 0; i < ok_tabela.Length; i++)
            {
                ok_dGWTabelaprzed.Rows[i].Cells[1].Value = ok_tabela[i];
            }
        }

        private void ok_panel_Paint(object sender, PaintEventArgs e)
        {
            ok_Pen.Width = (float)ok_numericGrubosc.Value;
            ok_Pen.Color = ok_lblKolorLini.BackColor;
            e.Graphics.DrawLine(ok_Pen, 0, ok_panel.Height / 2, ok_panel.Width, ok_panel.Height / 2);
        }

        private void ok_cbStylLinii_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (ok_cbStylLinii.SelectedIndex)
            {
                case 0:
                    ok_Pen.DashStyle = DashStyle.Solid;
                    break;
                case 1:
                    ok_Pen.DashStyle = DashStyle.Dash;
                    break;
                case 2:
                    ok_Pen.DashStyle = DashStyle.Dot;
                    break;
                case 3:
                    ok_Pen.DashStyle = DashStyle.DashDot;
                    break;
                case 4:
                    ok_Pen.DashStyle = DashStyle.DashDotDot;
                    break;
                default:
                    break;
            }
            ok_panel.Refresh();
        }

        private void ok_btnTabela_Click(object sender, EventArgs e)
        {
            ok_dGWTabelaprzed.Visible = true;
            ok_Wykres.Visible = false;
            ok_dGWTabelaprzed.Rows.Clear();
            ok_TabKosztA.Visible = true;
            ok_TabAfter.Visible = true;
            ok_TabBefore.HeaderText = "Rozmiar sortowanej tablicy";
            ok_TabAfter.HeaderText = "Wynik pomiaru kosztu czasowego";
            int ok_a = 0;
            int ok_b = 0, ok_rozmiar, ok_max;
            if (!ok_PobirzDane(out ok_rozmiar, out ok_a, out ok_b, out ok_max))
            {
                return;
            }
            ok_wyniki = new int[3, ok_maxRozTab + 1];
            int[] ok_tab;
            Random rnd = new Random();
            for (int i = 1; i < ok_maxRozTab + 1; i++)
            {
                ok_tab = new int[i];
                for (int j = 0; j < ok_tab.Length; j++)
                {
                    ok_tab[j] = rnd.Next(ok_a, ok_b);
                }
                ok_wyniki[0, i - 1] = i;
                switch (ok_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_SelectionSort(ok_tab);
                            ok_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                    case "Insertion":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_InsertionSort(ok_tab);
                            ok_wyniki[2, i - 1] = (i + 2) * (i - 1) / 2;
                        }
                        break;
                    case "Quick":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_QuickSort(ok_tab, 0, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = (int)Math.Log(i) * 1;
                        }
                        break;
                    case "Merge":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_MegreSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Heap":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_HeapSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Bubble":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_BubbleSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * i;
                        }
                        break;
                    case "Shell":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_ShellSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = (int)Math.Pow(i, 1.15);
                        }
                        break;
                    case "Comb":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_CombSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i); // wydajnosc w najlepszym wypadku
                        }
                        break;
                    default:
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_SelectionSort(ok_tab);
                            ok_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                }
            }
            if (ok_dGWTabelaprzed.RowCount > 1)
            {
                ok_dGWTabelaprzed.Rows.Clear();
                ok_dGWTabelaprzed.Refresh();
            }
            string[] pj_cells = new string[3];
            for (int i = 0; i < ok_wyniki.GetLength(1); i++)
            {
                pj_cells[0] = ok_wyniki[0, i].ToString();
                pj_cells[1] = ok_wyniki[1, i].ToString();
                pj_cells[2] = ok_wyniki[2, i].ToString();
                if (i == ok_wyniki.GetLength(1) - 1)
                {
                    break;
                }
                ok_dGWTabelaprzed.Rows.Add(pj_cells);
            }
        }

        private void ok_btnWykres_Click(object sender, EventArgs e)
        {
            ok_dGWTabelaprzed.Visible = false;
            ok_Wykres.Visible = true;
            int ok_a = 0;
            int ok_b = 0, ok_rozmiar, ok_max;
            if (!ok_PobirzDane(out ok_rozmiar, out ok_a, out ok_b, out ok_max))
            {
                return;
            }
            ok_wyniki = new int[3, ok_maxRozTab + 1];
            int[] ok_tab;
            Random rnd = new Random();
            for (int i = 1; i < ok_maxRozTab + 1; i++)
            {
                ok_tab = new int[i];
                for (int j = 0; j < ok_tab.Length; j++)
                {
                    ok_tab[j] = rnd.Next(ok_a, ok_b);
                }
                ok_wyniki[0, i - 1] = i;
                switch (ok_cbAlgorytm.Text)
                {
                    case "Selection":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_SelectionSort(ok_tab);
                            ok_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                    case "Insertion":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_InsertionSort(ok_tab);
                            ok_wyniki[2, i - 1] = (i + 2) * (i - 1) / 2;
                        }
                        break;
                    case "Quick":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_QuickSort(ok_tab, 0, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = (int)Math.Log(i) * 1;
                        }
                        break;
                    case "Merge":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_MegreSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Heap":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_HeapSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i);
                        }
                        break;
                    case "Bubble":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_BubbleSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * i;
                        }
                        break;
                    case "Shell":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_ShellSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = (int)Math.Pow(i, 1.15);
                        }
                        break;
                    case "Comb":
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_CombSort(ok_tab, ok_tab.Length - 1);
                            ok_wyniki[2, i - 1] = i * (int)Math.Log(i); // wydajnosc w najlepszym wypadku
                        }
                        break;
                    default:
                        {
                            ok_wyniki[1, i - 1] = ok_Sortowanie.ok_SelectionSort(ok_tab);
                            ok_wyniki[2, i - 1] = i * (i - 1) / 2;
                        }
                        break;
                }
            }
            if (ok_Wykres.Series.Count > 0)
                ok_Wykres.Series.Clear();
            ok_Wykres.Series.Add("liczba operacji z pomiaru");
            switch (ok_cbStylLinii.SelectedIndex)
            {
                case 0:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 4:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                default:
                    ok_Wykres.Series[0].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
            ok_Wykres.Series[0].Color = ok_lblKolorLini.BackColor;
            ok_Wykres.Series[0].BorderWidth = ok_tbGruboscLinii.Value;

            ok_Wykres.Series.Add("liczba operacji z obliczen");
            switch (ok_cbStylLinii.SelectedIndex)
            {
                case 0:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                    break;
                case 1:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dash;
                    break;
                case 2:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Dot;
                    break;
                case 3:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.DashDot;
                    break;
                case 4:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.DashDotDot;
                    break;
                default:
                    ok_Wykres.Series[1].BorderDashStyle = ChartDashStyle.Solid;
                    break;
            }
            ok_Wykres.Series[1].Color = ok_kolLini2.BackColor;
            ok_Wykres.Series[1].BorderWidth = ok_tbGruboscLinii.Value;
            ok_Wykres.BackColor = ok_lblKolorTla.BackColor;
            ok_Wykres.Series[0].ChartType = SeriesChartType.Line;
            ok_Wykres.Series[1].ChartType = SeriesChartType.Line;
            for (int i = 0; i < ok_wyniki.GetLength(1) - 1; i++)
            {
                ok_Wykres.Series[1].Points.AddXY(i, ok_wyniki[2, i]);
                ok_Wykres.Series[0].Points.AddXY(i, ok_wyniki[1, i]);

            }
        }

        private void ok_btnResetuj_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ok_cdKolorLini.ShowDialog() == DialogResult.OK)
            {
                ok_kolLini2.BackColor = ok_cdKolorLini.Color;

            }
            ok_Pen.Color = ok_kolLini2.BackColor;
            ok_panel.Refresh();
        }

        private void ok_btnDemo_Click(object sender, EventArgs e)
        {

        }

        private void ok_zegar_Tick(object sender, EventArgs e)
        {


        }
    }
}

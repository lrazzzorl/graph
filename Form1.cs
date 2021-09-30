using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using ZedGraph;
using Microsoft.Office.Interop.Excel;

namespace graph
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //переменные
        int i;
        bool ras = false;
        double m = 0, k = 0, tmin = 0, tmax = 0, dt = 0, dl = 0, x0 = 0, v0 = 0, w = 0, T = 0, f = 0, B = 0, x = 0;
        const double g = 9.80665;
        double[] speed = new double[500];
        double[] path = new double[500];


        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            //вывод координат при клике
            // Сюда будут записаны координаты в системе координат графика
            double x, y;
            // Пересчитываем пиксели в координаты на графике
            zedGraph.GraphPane.ReverseTransform(e.Location, out x, out y);
            // Выводим результат
            coordLabel.Text = string.Format("X: {0};    Y: {1}", Math.Round(x, 5), Math.Round(y, 5));
        }

        private void Calculation(object sender, EventArgs e)
        {
            //расчет
            //ввод данных
            try
            {
                m = Convert.ToDouble(textBox_m.Text);
                k = Convert.ToDouble(textBox_k.Text);
                tmin = Convert.ToDouble(textBox_tmin.Text);
                tmax = Convert.ToDouble(textBox_tmax.Text);
                dl = Convert.ToDouble(textBox_dl.Text);
                x0 = Convert.ToDouble(textBox_x0.Text);
                v0 = Convert.ToDouble(textBox_v0.Text);
                T = Convert.ToDouble(textBox_T.Text);
                f = Convert.ToDouble(textBox_f.Text);        
            }
            catch (Exception)
            {
                MessageBox.Show("Введены некорректные данные!","Ошибка!");
            }

            ras = true;//флаг о выполнении расчета
            dt = (tmax - tmin) / 500;
            w = Math.Pow(k / m, 0.5);
            B = f / (2 * m);

            label_dt.Text = Convert.ToString(Math.Round(dt, 5));
            label_B.Text = Convert.ToString(Math.Round(B, 5));
            label_w.Text = Convert.ToString(Math.Round(w, 5));

            speed[1] = v0;
            path[1] = x0;
            speed[2] = speed[1] + dt / 2 * (g - f / m * speed[1] - k / m * (path[1] + dl));
            path[2] = path[1] + speed[2] * dt;

            for (i = 3; i < 500; i++)
            {
                speed[i] = speed[i - 1] + dt * (g - f / m * speed[i - 1] - k / m * (path[i - 1] + dl));
                path[i] = path[i - 1] + speed[i] * dt;
            }

            //построим график
            //построить график
            // Получим панель для рисования
            GraphPane pane = zedGraph.GraphPane;
            // Очистим список кривых на тот случай, если до этого сигналы уже были нарисованы
            pane.CurveList.Clear();
            // Установим масштаб по умолчанию для оси X
            pane.XAxis.Scale.MinAuto = true;
            pane.XAxis.Scale.MaxAuto = true;
            // Установим масштаб по умолчанию для оси Y
            pane.YAxis.Scale.MinAuto = true;
            pane.YAxis.Scale.MaxAuto = true;
            // Включаем отображение сетки напротив крупных рисок по оси X
            pane.XAxis.MajorGrid.IsVisible = true;
            pane.XAxis.MajorGrid.DashOn = 10; // Длина штрихов равна 10 пикселям
            pane.XAxis.MajorGrid.DashOff = 5; // затем 5 пикселей - пропуск
            // Включаем отображение сетки напротив крупных рисок по оси Y
            pane.YAxis.MajorGrid.IsVisible = true;
            pane.YAxis.MajorGrid.DashOn = 10; // Длина штрихов равна 10 пикселям
            pane.YAxis.MajorGrid.DashOff = 5; // затем 5 пикселей - пропуск
            // Включаем отображение сетки напротив мелких рисок по оси X
            pane.YAxis.MinorGrid.IsVisible = true;
            pane.YAxis.MinorGrid.DashOn = 1; // Длина штрихов равна одному пикселю 
            pane.YAxis.MinorGrid.DashOff = 2; // затем 2 пикселя - пропуск
            // Включаем отображение сетки напротив мелких рисок по оси Y
            pane.XAxis.MinorGrid.IsVisible = true;
            pane.XAxis.MinorGrid.DashOn = 1; // Длина штрихов равна одному пикселю 
            pane.XAxis.MinorGrid.DashOff = 2; // затем 2 пикселя - пропуск

            // Создадим список точек
            PointPairList list_speed = new PointPairList();
            PointPairList list_path = new PointPairList();

            x = tmin;
            // Заполняем список точек
            for (i = 1; i < 500; i++)
            {
                list_speed.Add(x, speed[i]);
                list_path.Add(x, path[i]);
                x += dt;
            }
            // Создадим выбранную в radioButton кривую
            if (radioButton_speed.Checked == true)
            {
                //текст заголовка графика
                pane.Title.Text = "Скорость колеблющегося тела";
                // Изменим тест надписи по оси X
                pane.XAxis.Title.Text = "Время, с";
                // Изменим текст по оси Y
                pane.YAxis.Title.Text = "Скорость, м/с";
                // Создадим кривую
                LineItem Curve_speed = pane.AddCurve("Скорость", list_speed, Color.Blue, SymbolType.None);
            }
            else if (radioButton_path.Checked == true)
            {
                //текст заголовка графика
                pane.Title.Text = "Смещение колеблющегося тела";
                // Изменим тест надписи по оси X
                pane.XAxis.Title.Text = "Время, с";
                // Изменим текст по оси Y
                pane.YAxis.Title.Text = "Смещение, м";
                // Создадим кривую
                LineItem Curve_path = pane.AddCurve("Смещение", list_path, Color.Red, SymbolType.None);
            }

            // Вызываем метод AxisChange (), чтобы обновить данные об осях. 
            zedGraph.AxisChange();
            // Обновляем график
            zedGraph.Invalidate();
        }

        private void save_to_exel_Click(object sender, EventArgs e)
        {
            //сохранить данные в excel
            //если рачет не выполнен - сообщение об этом
            if (ras == false)
            {
                MessageBox.Show("Расчет еще не выполнен!", "Ошибка!");
            }
            else
            {
                Microsoft.Office.Interop.Excel.Application ObjExcel = new Microsoft.Office.Interop.Excel.Application();
                //книга
                Microsoft.Office.Interop.Excel.Workbook ObjWorkBook = ObjExcel.Workbooks.Add(System.Reflection.Missing.Value);
                //таблица
                Microsoft.Office.Interop.Excel.Worksheet ObjWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ObjWorkBook.Sheets[1];
                //Значения [y - строка,x - столбец]
                ObjWorkSheet.Cells[1, 1] = "Результаты рассчета";
                ObjWorkSheet.Cells[2, 1] = "Время, с";
                ObjWorkSheet.Cells[2, 2] = "Скорость, м/с";
                ObjWorkSheet.Cells[2, 3] = "Смещение от положения равновесия, м";
                x = tmin;
                for (int i = 1; i < 500; i++)
                {
                    //Время - 1 столбец
                    ObjWorkSheet.Cells[2 + i, 1] = x;
                    //Скорость - 2 столбец
                    ObjWorkSheet.Cells[2 + i, 2] = speed[i];
                    //Смещение - 3 столбец
                    ObjWorkSheet.Cells[2 + i, 3] = path[i];
                    x += dt;
                }
                //показываем файл exel
                ObjExcel.Visible = true;
                ObjExcel.UserControl = true;
                //сохраняем файл отчета
                //ObjExcel.GetSaveAsFilename("Результаты расчета");
                
            }
            
        }

        private void save_to_txt_Click(object sender, EventArgs e)
        {
            //сохранить данные в txt
            //если рачет не выполнен - сообщение об этом
            if (ras == false)
            {
                MessageBox.Show("Расчет еще не выполнен!", "Ошибка!");
            }
            else
            {
                string[] lines = new string[500];

                lines[0] = "Время, с  |  Скорость, м/с  |  Смещение от положения равновесия, м";
                x = tmin;
                for (i = 1; i < 500; i++)
                {
                    lines[i] = Convert.ToString(x) + "  |  " + Convert.ToString(speed[i]) + "  |  " + Convert.ToString(path[i]);
                    x += dt;
                }

                Stream myStream;
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                //фильтры
                saveFileDialog1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                saveFileDialog1.FilterIndex = 2;
                saveFileDialog1.RestoreDirectory = true;
                //расширение по умолчанию
                saveFileDialog1.AddExtension = true;
                saveFileDialog1.DefaultExt = ".txt";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    if ((myStream = saveFileDialog1.OpenFile()) != null)
                    {
                        string fileName = saveFileDialog1.FileName;
                        myStream.Close();
                        System.IO.File.WriteAllLines(fileName, lines);
                    }
                }
            }

        }

        private void button_save_as_bitmap_Click(object sender, EventArgs e)
        {
            //сохранить изображение графика
            if (ras == false)
            {
                MessageBox.Show("Расчет еще не выполнен!", "Ошибка!");
            }
            else
            {
                zedGraph.SaveAsBitmap();
            }
        }


    }
}

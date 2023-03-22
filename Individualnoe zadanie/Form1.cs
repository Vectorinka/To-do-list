using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Individualnoe_zadanie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            passField.AutoSize = false;/*выключаем свойство AutoSize, которое подстраивает ширину и высоту под содержание 
                                        автоматическое подстраивание ширины и высоты будет отключено
                                        */
            passField.Size = new Size(passField.Size.Width, 63);//при запуске высота passField была равна высоте loginField 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();//Зыкрытие программы при нажатии на closeButton
        }

        private void closeButton_MouseEnter(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Pink; //курсор мыши меняет цвет при наведении
        }

        private void closeButton_MouseLeave(object sender, EventArgs e)
        {
            closeButton.ForeColor = Color.Red; //курсор мыши меняет цвет при отведении
        }

        Point lastPoint; //создадим переменную класса задавания координат
        private void panel1_MouseMove(object sender, MouseEventArgs e)//Перемещение формы по удержанию кнопки мыши
        {
            //Внутри объекта "e" хранятся все характеристики этого события, в т. ч. координаты мышки. Импользуем это
            if (e.Button == MouseButtons.Left)//условие нажатия на ЛКМ
            {
                Left = Left + e.X - lastPoint.X;
                Top = Top + e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)//Сохраняем коорлинат формы в переменную при отпускании ЛКМ
        {
            lastPoint = new Point(e.X, e.Y);

        }

        private void button1_Click(object sender, EventArgs e)//Переход между формами
        {
            to_doList moving = new to_doList();//создадим объект формы to-doList
            Form1 authorization = new Form1();//создадим объект формы Form1
            moving.Show();//открывает форму to-doList
            Hide();//прячет (не закрывает) форму Form1
        }
    }
}

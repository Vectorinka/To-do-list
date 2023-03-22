using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Individualnoe_zadanie
{
    public partial class to_doList : Form//Форма to_doList наследник от формы Form1 родителя
    {
        private object data = 0;

        public to_doList()
        {
            InitializeComponent();
            label1.Text = "Время: " +DateTime.Now.ToString();//Таймер                       
        }

        public void newTask_Click(object sender, EventArgs e)//Кнопка "Новая задача"
        {
            toDo.Items.Add(descriptionTask.Text + ". Дата: " + label1.Text + ". " + "Исполнитель: " + NameBox.Text);//Добавляет в toDo запись из descriptionTask 
            data = descriptionTask.Text + ". Дата: " + label1.Text + ". " + "Исполнитель: " + NameBox.Text;//Сохраняем запись для дальнейшего использования
            descriptionTask.Text = "";/*Делает пустую строку в descriptionTask.
                                       *Удалив запись можно было написать descriptionTask.Clear();                                       
                                       */                                       
        }

        private void Delete_Click(object sender, EventArgs e)//Кнопка "Удалить"
        {
            if (Ready.SelectedIndex != -1) //Защита от сбоя если ни один элемент не выбран.  
            {
                Ready.Items.RemoveAt(Ready.SelectedIndex); //удаление выбранного элемента
            }
        }

        public void reposition_Click(object sender, EventArgs e)//Кнопка "Переместить" 1
        {
            inProgress.Items.Add(data);//Перемещает выбранный элемент из toDo в inProgress 
            if (toDo.SelectedIndex != -1)//Исключение. Если ни один по элементу (индексу) не выбран
                /*Выбранные элементы начинает с 1 до n добавленных  
                 * -1 ни один не выбран. 0, -2 до -n выдает ошибку.
                 */
            {                
                toDo.Items.RemoveAt(toDo.SelectedIndex);//Удаляет выбранный элемент из toDo в inProgress
            }             
        }

        private void descriptionTaskLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)//Кнопка "Переместить" 2
        {
            Ready.Items.Add(data);//Перемещает выбранный элемент из inProgress в Ready 
            if (inProgress.SelectedIndex != -1)//Исключение. Если ни один по элементу (индексу) не выбран
            /*Выбранные элементы начинает с 1 до n добавленных  
             * -1 ни один не выбран. 0, -2 до -n выдает ошибку.
             */
            {
                inProgress.Items.RemoveAt(inProgress.SelectedIndex);//Удаляет выбранный элемент из inProgress в Ready
            }
        }
    }
}

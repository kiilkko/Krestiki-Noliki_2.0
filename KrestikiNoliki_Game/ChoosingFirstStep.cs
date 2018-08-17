using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNoliki_Game
{
    //Класс - форма выбора игрока, делающего первый ход
    public partial class ChoosingFirstStep : Form 
    {
       
        //конструктор
        public ChoosingFirstStep()
        {
            InitializeComponent();
            
        }
        

        //Обработчик события формы: выбран переключатель Машина (делает первый ход)
        private void radioButtonMachine_CheckedChanged(object sender, EventArgs e)
        {
            //значению переменной класса Game присваивается Истина
            Game.FirstStMachine = true;

        }
    }
}

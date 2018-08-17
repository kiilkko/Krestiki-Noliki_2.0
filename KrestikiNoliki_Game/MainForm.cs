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
    /*класс - родительская форма для всех других форм приложения, кроме Игры.
     * позволяет ознакомиться с правилами в меню или запустить новую игру*/
    public partial class MainForm : Form
    {
        //флаг, показывающий, есть ли уже запущенная форма Game
        public static bool isAlreadyGame = false;

        //конструктор
        public MainForm()
        {
            InitializeComponent();
            
        }
        

        //Обработчик события формы: выбран пункт меню Новая игра 
        private void новаяИграToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //Если игра уже запущена, то показываем игроку предупреждающее сообщение и обрабатываем его выбор
            if (isAlreadyGame)
            {
               
                DialogResult res = MessageBox.Show("Игра уже начата! Вы действительно хотите прервать ее?", "Предупреждение", MessageBoxButtons.YesNo);
                if (res == System.Windows.Forms.DialogResult.Yes)
                {
                    Game.ClosingisLegal = true;
                    //при ответе "Да" закрываются активные дочерние окна главной формы, в тч Game
                    //и очищается массив значений от старых ходов
                    Array.Clear(Game.Board,0,9);
                    this.ActiveMdiChild.Close();

                }
                else
                {
                    //в ином случае возвращаемся к игре
                    return;
                }
            }

        //если запущенной игры еще нет, то создаем экземпляр формы выбора первого хода
           ChoosingFirstStep newFirst = new ChoosingFirstStep();
            //и после подтвержденного выбора создаем новую игру
           if(newFirst.ShowDialog(this) ==DialogResult.OK)
            {
                Game newGame = new Game();
                isAlreadyGame = true;
                newGame.MdiParent = this;
                newGame.Show();
            }
           
        }

        //Обработчик события формы: выбран пункт меню: О программе (аналогично)
        private void ОпрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Titul_Form newTitul = new Titul_Form();
            newTitul.MdiParent = this;            
            newTitul.Show();
        }

        //при событии загрузка формы вначале загружается титульная форма
        private void ParentForm_Load(object sender, EventArgs e)
        {
            Titul_Form newTitul = new Titul_Form();
            newTitul.MdiParent = this;
            newTitul.Show();
            
        }

        //Обработчик события формы: выбран пункт меню Правила
        private void правилаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //создается экземпляр класса (формы) GameInfo
            GameInfo newInfo = new GameInfo();
            //родителем назначается данная форма
            newInfo.MdiParent = this;
            //новая форма открывается
            newInfo.Show();
        }

    }
}


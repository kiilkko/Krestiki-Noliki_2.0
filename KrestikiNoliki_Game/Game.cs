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
    //класс - основная форма игры
    public partial class Game : Form
    {
        //конструктор
        public Game()
        {
            InitializeComponent();
        }
        //массив текущих значений ячеек игрового поля - отражение игровой ситуации на поле в любой момент
        public static string[] Board = new string[9];

        //флаг, говорящий о том, что машина совершает первый ход
        public static bool FirstStMachine = false;
        //флаг блокировки - для осуществления блокировки поля во время хода машины
        public static bool Bloсking = false;       
        //флаг, показывающий, что последний ход машины стал выигрышным
        public static bool MachineWins = false;
        //флаг-разрешение закрыть форму
        public static bool ClosingisLegal = false;

        //событие формы: загрузка формы
        private void Game_Load(object sender, EventArgs e)
        {
            
            
            //сначала определим, кто ходит первым
            if(Game.FirstStMachine==true)
            {
                //если это Машина, то заблокируем поле
                Bloсking = true;

                /*Ход машины: 
                - переменной присваивается значение имени целевой ячейки,
                возвращаемое методом*/
                string TargetName = GetTargetIndName();

                /* - присваивается нолик свойству text элемента массива кнопок(ячеек), 
                свойство name которого совпадает с именем целевой ячейки  */
                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                foreach (Button x in M)
                {
                    if (x.Name.Equals(TargetName))
                    {
                        x.Text = "О";
                    }
                }
                //значения переменных-флагов необходимо снова сделать Ложь
                Game.FirstStMachine = false;
                Bloсking = false;
            }
        }

        /*метод класса, совершающий выбор индекса целевой ячейки
         * для хода машины, возвращающий ее имя в формате строки*/
        public static string GetTargetIndName()
        {
            //переменная - индекс целевой ячейки
            int TargetIndex;
            //переменная - имя целевой ячейки
            string Name;

            /*выбор ячейки может происходить двумя способами:
             * 1 - если он происходит в начале игры (если ходит первой Машина),
             * когда игровое поле пустое:*/
            if (FirstStMachine == true)
            {
                //тогда создается экземпляр класса Random для генерации случайного номера ячейки
                Random rand = new Random();
                //переменной индекса присваивается случайный номер
                TargetIndex = rand.Next(0, 8);
            }

            /*2 - если выбор ячейки происходит в ходе игры.
             * Тогда для получения индекса используется метод класса Playboard
             * */
            else
            {
                //переменной индекса присваивается результат, возвращаемый методом, анализирующим ситуацию на игровом поле
                TargetIndex = Machine_Intelligence.CombinationAnalysis(Board);
            }

            //элементу массива значений с соответствующим индексом присваивается нолик 
            Board[TargetIndex] = "О";
            //Имя целевой ячейки составляется из буквы C и целевого индекса
            Name = "С" + TargetIndex;

            return Name;
        }

        //Метод-обработчик события: клик по кнопке С0: ход игрока и ответный ход машины
        public void С0_Click(object sender, EventArgs e)
        {
            if (Bloсking == false) //если поле не заблокировано, т.е. сейчас ход игрока:
            {
                С0.Text = "Х"; //меняем текст ячейки поля(кнопки) на крестик
                Machine_Intelligence.GetIndexAndValue(С0.Name);

                /*в результате анализа машиной текущей ситуации на поле получаем цифру - номер ячейки, в которую машина совершит ход                          
                и осуществляем ход машины*/
                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if(MachineWins) //если ход машины оказался выигрышным, то игру можно далее не продолжать
                {
                    //вызов метода, если Нолики (Машина) победили
                    CongratulationsO();
                }
                
            }

        }

        //Метод-обработчик события: клик по кнопке C1 - аналогичен клику по C0
        private void С1_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С1.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С1.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }

        //Метод-обработчик события: клик по кнопке C2 - аналогичен клику по C0
        private void С2_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С2.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С2.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }

        //Метод-обработчик события: клик по кнопке C3 - аналогичен клику по C0
        private void С3_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С3.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С3.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }

        //Метод-обработчик события: клик по кнопке C4 - аналогичен клику по C0
        private void С4_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С4.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С4.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }

        //Метод-обработчик события: клик по кнопке C5 - аналогичен клику по C0
        private void С5_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С5.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С5.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }


        //Метод-обработчик события: клик по кнопке C6 - аналогичен клику по C0
        private void С6_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С6.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С6.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }


            }

        }


        //Метод-обработчик события: клик по кнопке C7 - аналогичен клику по C0
        private void С7_Click(object sender, EventArgs e)
        {
            if (Bloсking == false)
            {
                С7.Text = "Х";
                Machine_Intelligence.GetIndexAndValue(С7.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if ((x.Name.Equals(TargetName)) && (TargetName.Equals(this.Name)==false))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                    this.Close();
                }


            }

        }

        //Метод-обработчик события: клик по кнопке C8 - аналогичен клику по C0
        private void С8_Click(object sender, EventArgs e)
        {
            
            if (Bloсking == false)
            {
                С8.Text = "X";
                Machine_Intelligence.GetIndexAndValue(С8.Name);

                string TargetName = GetTargetIndName();

                Button[] M = new Button[9] { С0, С1, С2, С3, С4, С5, С6, С7, С8 };
                    foreach (Button x in M)
                    {
                        if (x.Name.Equals(TargetName))
                        {
                            x.Text = "О";
                        }
                    }
                if (MachineWins)
                {
                    CongratulationsO();
                }

            }

        }

       
        //метод класса - блокировка игрового поля
        public static void Buttons_lock()
        {            
            Bloсking = true;
        }

        //метод класса - разблокировка игрового поля
        public static void Buttons_unlock()
        {
            Bloсking = false;
        }

        //метод класса - поздравление с выигрышем Игрока
      public static void CongratulationsX()
        {
            //создается окно сообщения с текстом
            MessageBox.Show("Поздравляем! Вы победили!");
            //разрешение закрыть форму
            ClosingisLegal = true;
            Application.Restart();

        }

        //метод класса - поздравление с выигрышем Машины
        public static void CongratulationsO()
        {
            MessageBox.Show("Победила машина. Попробуйте еще разок!");
            ClosingisLegal = true;
            Application.Restart();
        }

        //метод класса - ничья
      public static void CongratulationsN()
        {
            MessageBox.Show("Ничья! Это была отличная игра!");
            ClosingisLegal = true;
            //приложение перезапускается
            Application.Restart();
        }

        //событие закрытие формы
        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
           //если закрытие запрещено, а оно разрешено только либо когда конец игры, либо если получено подтверждение от пользователя
           if(ClosingisLegal==false)           
            {
                //пользователь получает предупреждение
                DialogResult res = MessageBox.Show("Игра уже начата! Вы действительно хотите прервать ее?", "Предупреждение", MessageBoxButtons.YesNo);
                //при ответе Нет мы просто отменяем операцию
                if (res == System.Windows.Forms.DialogResult.No)
                {
                    e.Cancel = true;
                }
                //в противном случае убираем препятствия для ее закрытия
                //и очищаем массив значений от старых ходов
                else
                {
                    MainForm.isAlreadyGame = false;
                    Array.Clear(Board, 0, 9);
                }
                
            }
            
        }
    }
}
       
    

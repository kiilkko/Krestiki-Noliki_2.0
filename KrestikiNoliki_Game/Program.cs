using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KrestikiNoliki_Game
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]

        
        static void Main()
        {
            //сгенерированный автоматически код: подключение стилей графики и текста

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //запуск приложения начинается с создания Родительской формы
            Application.Run(new MainForm());
        }
    }
}

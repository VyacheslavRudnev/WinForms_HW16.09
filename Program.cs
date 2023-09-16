namespace WinFormsApp1
{
//Задание 1
//Вывести на экран свое(краткое!!!) резюме с помощью последова-
//тельности MessageBox’ов(числом не менее трех). Причем на заголовке
//последнего должно отобразиться среднее число символов на странице
//(общее количество символов в резюме / количество MessageBox’ов).
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}
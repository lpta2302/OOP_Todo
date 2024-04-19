using TODO.PL;

namespace TODO
{
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
            MyFakeData.Init();
            ApplicationConfiguration.Initialize();
            Application.Run(new frmMyDay(frmMyDay.MyDayType.Myday));
            //Application.Run(new frmCreateLobby());
        }
    }
}
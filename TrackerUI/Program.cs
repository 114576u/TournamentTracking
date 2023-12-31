namespace TrackerUI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            // Application.EnableVisualStyles();
            // Application.SetCompatibleTextRenderingDefault(false);
            // ApplicationConfiguration.Initialize();

            // Initialize the database connections
            TrackerLibrary.GlobalConfig.InitializeConnections(false, true);

            // Application.Run(new TournamentDashboardForm());
            // Application.Run(new CreatePrizeForm());
            Application.Run(new CreateTeamForm());
        }
    }
}
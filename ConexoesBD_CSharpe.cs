        #region SQLite

        string baseDados = Application.StartupPath + @"\db\DBSQLite.db";
        string strConection = @"Data Source = " + baseDados + "; Version = 3";

         if (!File.Exists(baseDados))
         {
             SQLiteConnection.CreateFile(baseDados);
         }

        SQLiteConnection conexao = new SQLiteConnection(strConection);
         // ou
         //conexao.ConnectionString = strConection;
         try
         {
             conexao.Open();
             lblResultado.Text = "Conectado SQLite";
         }
         catch (Exception ex)
         {
             lblResultado.Text = "Erro de conexão com SQLite \n" + ex.Message;
         }
         finally
         {
    conexao.Close();
}

         #endregion

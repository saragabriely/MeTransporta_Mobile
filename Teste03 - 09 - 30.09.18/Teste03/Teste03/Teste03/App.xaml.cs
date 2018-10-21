using Xamarin.Forms;
using Xamarin.Forms.Xaml;


[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace Teste03
{
    public partial class App : Application
	{
        /*
        public SqliteConnection Conexao { get; private set; }
        using Mono.Data.Sqlite;
        using PCLExt.FileStorage;
        using PCLExt.FileStorage.Folders;
        using SQLite;
        using System.Collections.Generic;
        using System.Net;
             
             */

        public App ()
		{
            /*
            var pasta   = new LocalRootFolder();
            var arquivo = pasta.CreateFile("banco.db", CreationCollisionOption.OpenIfExists);
            Conexao     = new SQLiteConnection(arquivo.Path);
            Conexao.Execute("create table if not exists informacoes (id integer primary key autoincrement, info text)");
            */

            InitializeComponent();

            MainPage = new Views.PaginaInicial();
            
        }
        
        protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using System.IO;
using Xamarin.Forms;

namespace Demo6
{
	public class AppDatabase
	{
		static readonly object locker = new object();

		readonly SQLiteConnection database;

		string DatabasePath
		{
			get
			{
				const string sqliteFilename = "AppSQLite.db3";
				var path = Path.Combine("", "");

				if (Device.OS == TargetPlatform.iOS)
				{
					string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
					string libraryPath = Path.Combine(documentsPath, "..", "Library"); // Library folder
					path = Path.Combine(libraryPath, sqliteFilename);
				}

				if (Device.OS == TargetPlatform.Android)
				{
					string documentsPath = Environment.GetFolderPath(Environment.SpecialFolder.Personal); // Documents folder
					path = Path.Combine(documentsPath, sqliteFilename);
				}

				return path;
			}
		}

		/// <summary>
		/// Initializes a new instance of the <see cref="Tasky.DL.TaskDatabase"/> TaskDatabase. 
		/// if the database doesn't exist, it will create the database and all the tables.
		/// </summary>
		/// <param name='path'>
		/// Path.
		/// </param>
		public AppDatabase()
		{
			database = new SQLiteConnection(DatabasePath);
			// create the tables
			database.CreateTable<AppItem>();
		}

		public IEnumerable<AppItem> GetItems()
		{
			lock (locker)
			{
				return (from i in database.Table<AppItem>() select i).ToList();
			}
		}

		public IEnumerable<AppItem> GetItemsNotDone()
		{
			lock (locker)
			{
				return database.Query<AppItem>("SELECT * FROM [AppItem] WHERE [Done] = 0");
			}
		}

		public AppItem GetItem(int id)
		{
			//lock (locker)
			//{
			//	return database.Table<AppItem>().FirstOrDefault(x => x.ID == id);
			//}

			return database.Table<AppItem>().FirstOrDefault(x => x.ID == id);
		}

		public int SaveItem(AppItem item)
		{


			/*
			lock (locker)
			{
				if (item.ID != 0)
				{
					database.Update(item);
					return item.ID;
				}
				else {
					return database.Insert(item);
				}
			}
           */

			Console.WriteLine("Entro nuevo insert");


			return database.Insert(item);

		}

		public int DeleteItem(AppItem item)
		{
			lock (locker)
			{
				return database.Delete<AppItem>(item);
			}
		}

	}
}







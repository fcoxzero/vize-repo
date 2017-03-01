using System;
using System.Collections.Generic;
using System.Linq;
using SQLite;
using System.IO;
using Xamarin.Forms;

namespace Demo6
{
	public class zoneDatabase
	{
		static readonly object locker = new object();

		readonly SQLiteConnection database;

		string DatabasePath
		{
			get
			{
				const string sqliteFilename = "zoneDB.db3";
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
		public zoneDatabase()
		{
			database = new SQLiteConnection(DatabasePath);
			// create the tables
			database.CreateTable<zoneItem>();
		}

		public IEnumerable<zoneItem> GetItems()
		{
			lock (locker)
			{
				return (from i in database.Table<zoneItem>() select i).ToList();
			}
		}

		public IEnumerable<zoneItem> GetItemsNotDone()
		{
			lock (locker)
			{
				return database.Query<zoneItem>("SELECT * FROM [TodoItem] WHERE [Done] = 0");
			}
		}

		public zoneItem GetItem(int id)
		{
			lock (locker)
			{
				return database.Table<zoneItem>().FirstOrDefault(x => x.ID == id);
			}
		}

		public int Find(string item)
		{
			zoneItem temp;
			lock (locker)
			{
				temp = database.Table<zoneItem>().FirstOrDefault(x => x.name == item);
				return temp.ID;
			}
		}





		//		public int ModItem (zoneItem item, string C)
		//		{
		//			lock (locker) 
		//			{
		//				zoneItem temp;
		//				temp = item;
		//				DeleteItem (item);
		//				temp.name = C;
		//				database.Update (temp);
		//				return database.Insert (temp);
		//			}
		//		}

		public int SaveItem(zoneItem item)
		{
			lock (locker)
			{
				if (item.ID != 0)
				{
					database.Update(item);
					return database.Insert(item);
				}
				else
				{
					return item.ID;
				}
			}
		}

		public int DeleteItem(zoneItem item)
		{
			lock (locker)
			{
				return database.Delete<zoneItem>(item);
			}
		}


		//Para borrar todos los elementos

		public void DeleteAllItem()
		{

			database.Query<zoneItem>("DELETE FROM [zoneItem]");

		}


	}
}



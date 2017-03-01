using SQLite;


namespace Demo6
{
	public class AppItem
	{
		[PrimaryKey]
		public int ID { get; set; }
		public string ip { get; set; }
		public string puerto { get; set; }


	}
}

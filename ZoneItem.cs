using SQLite;

namespace Demo6
{
	public class zoneItem
	{
		[PrimaryKey]
		public int ID { get; set; }
		public string name { get; set; }
		public string zona { get; set; }
	}
}
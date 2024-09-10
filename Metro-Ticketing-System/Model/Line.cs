namespace Metro_Ticketing_System.Model
{
    public class Line
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Station> Stations { get; set; } = new List<Station>();

    }
}

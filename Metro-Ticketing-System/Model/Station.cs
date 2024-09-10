namespace Metro_Ticketing_System.Model
{
    public class Station
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool HasTransition { get; set; }

        public int? TransionToStationId { get; set; }

        public Station? TransionToStation { get; set; }

        public int LineId { get; set; }
        public Line Line { get; set; }

        public int Postion { get; set; }
    }
}

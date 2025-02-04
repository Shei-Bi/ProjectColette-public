namespace Supercell.Laser.Logic.Data
{
    public class LocationData : LogicData
    {
        public LocationData(Row row, DataTable datatable) : base(row, datatable)
        {
            LoadData(this, GetType(), row);
        }

        public string Name { get; set; }

        public bool Disabled { get; set; }

        public string TID { get; set; }

        public string GameModeVariation { get; set; }

        public string Map { get; set; }
    }
}

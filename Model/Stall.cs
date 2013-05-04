namespace Model
{
    public class Stall
    {
        public int FloorNumber { get; set; }
        public int StallNumber { get; set; }
        public bool IsOccuppied { get; set; }

        public string CompositeId
        {
            get { return string.Format("#stall_{0}_{1}", FloorNumber, StallNumber); }
        }

        public string Description
        {
            get { return string.Format("Floor {0} Stall {1}", FloorNumber, StallNumber); }
        }
    }
}

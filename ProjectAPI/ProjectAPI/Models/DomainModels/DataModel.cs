namespace ProjectAPI.Models.DomainModels
{
    public enum DataType
    {
        // 0
        Text = 0,
        // 1
        Number = 1,
        // 2
        Date = 2,
        // 3
        Time = 3,
        // 4
        DateTime = 4,
        // 5
        Boolean = 5,
        // 6
        Image = 6,
        // 7
        Video = 7,
        // 8
        Audio = 8,
        // 9
        File = 9

    }
    public class DataModel
    {
        public int Id { get; set; }
        public string Value { get; set; }
        public DataType DataType { get; set; }
        public String Name { get; set; }
    }
}
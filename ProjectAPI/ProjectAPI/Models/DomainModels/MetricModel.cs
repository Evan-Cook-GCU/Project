using static ProjectAPI.Models.DomainModels.MetricModel;

namespace ProjectAPI.Models.DomainModels
{
    public class MetricModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int MetricTypeId { get; set; }
        public int GridElementId { get; set; }
        public List<DataModel> Values { get {
                if (Values == null)
                {
                    Values = new List<DataModel>();
                }
                return Values;
            }
            set
            {
                Values = value;
            }
        }
        public int MetricElementId { get; set; }
        // Keep history of changes
        public Boolean KeepHistory { get; set; } 
    }

}

namespace ProjectAPI.Models.DomainModels
{
    public class GridModel
    {
        public int Id { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public List<GridElementModel> GridElements { get; set; }
        public int GroupDomainModelId { get; set; }
        public List<MetricModel> MetricElements { get; set; }

    }
}
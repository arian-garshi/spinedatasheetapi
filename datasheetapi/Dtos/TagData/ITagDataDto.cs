using System.Text.Json.Serialization;

namespace datasheetapi.Dtos
{
    [JsonConverter(typeof(ITagDataDtoConverter))]
    public interface ITagDataDto
    {
        Guid Id { get; set; }
        string? TagNo { get; set; }
        string? Description { get; set; }
        string? Category { get; set; }
        string? Area { get; set; }
        string? Discipline { get; set; }
        int Version { get; set; }
        TagDataReviewDto? Review { get; set; }
        RevisionContainerDto? RevisionContainer { get; set; }
    }
}
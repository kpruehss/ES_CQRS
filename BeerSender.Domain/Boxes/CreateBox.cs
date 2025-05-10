namespace BeerSender.Domain.Boxes;

public record CreateBox(
    Guid BoxId,
    int DesiredNumberOfSpots);
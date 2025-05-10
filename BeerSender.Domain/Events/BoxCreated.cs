using BeerSender.Domain.Model;

namespace BeerSender.Domain.Events;

public record BoxCreated(BoxCapacity Capacity);
using BeerSender.Domain.Model;

namespace BeerSender.Domain.Events;

public record ShippingLabelAdded(ShippingLabel Label);
namespace BeerSender.Domain.Boxes;
public class Box : AggregateRoot
{
  public void Apply(BoxCreated @event)
  {
    Capacity = @event.Capacity;
  }

  public void Apply(ShippingLabelAdded @event)
  {
    ShippingLabel = @event.Label;
  }
  public BoxCapacity? Capacity { get; private set; }
  public ShippingLabel? ShippingLabel { get; private set; }
}

// Commands

// Events

// -----------------------------------------------
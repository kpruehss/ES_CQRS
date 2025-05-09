namespace BeerSender.Domain.Boxes;
public class Box
{

}

// Commands
public record CreateBox(
  Guid BoxId,
  int DesiredNumberOfSpots);

public record AddShippingLabel(
  Guid BoxId,
  string TrackingCode,
  Carrier Carrier);

// Events
public record ShippingLabelAdded(ShippingLabel Label);

public record ShippingLabelFailedToAdd(ShippingLabelFailedToAdd.FailReason Reason)
{
  public enum FailReason
  {
    TrackingCodeInvalid
  }
};

public record BoxCreated(int NumberOfSpots);

// -----------------------------------------------
public record ShippingLabel(Carrier Carrier, string TrackingCode)
{
  public bool IsValid(Carrier carrier, string trackingCode)
  {
    return carrier switch
    {
      Carrier.UPS => trackingCode.StartsWith("ABC"),
      Carrier.FedEx => trackingCode.StartsWith("DEF"),
      Carrier.BPost => trackingCode.StartsWith("GHI"),
      _ => throw new ArgumentOutOfRangeException(nameof(carrier), carrier, null)
    };
  }
}

public enum Carrier
{
  UPS,
  FedEx,
  BPost
}

public record BoxCapacity(int NumberOfSpots)
{
  public static BoxCapacity Create(int desiredNumberOfSpots)
  {
    return desiredNumberOfSpots switch
    {
      <= 6 => new BoxCapacity(6),
      <= 12 => new BoxCapacity(12),
      _ => new BoxCapacity(24)
    };
  }
}

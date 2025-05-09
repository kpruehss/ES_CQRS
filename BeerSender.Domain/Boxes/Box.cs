namespace BeerSender.Domain.Boxes;
public class Box
{

}

public record CreateBox(
  Guid BoxId,
  int DesiredNumberOfSpots);

public record AddShippingLabel(
  Guid BoxId,
  string TrackingCode,
  Carrier Carrier);


public record ShippingLabelAdded(
  string TrackingCode,
  Carrier Carrier);

public record ShippingLabelFailedToAdd(ShippingLabelFailedToAdd.FailReason Reason)
{
  public enum FailReason
  {
    TrackingCodeInvalid
  }
};

public enum Carrier
{
  UPS,
  FedEx,
  BPost
}
public record BoxCreated(int NumberOfSpots);



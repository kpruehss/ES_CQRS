namespace BeerSender.Domain.Boxes;

public record ShippingLabelFailedToAdd(ShippingLabelFailedToAdd.FailReason Reason)
{
    public enum FailReason
    {
        TrackingCodeInvalid
    }
};
namespace BeerSender.Domain.Events;

public record ShippingLabelFailedToAdd(ShippingLabelFailedToAdd.FailReason Reason)
{
    public enum FailReason
    {
        TrackingCodeInvalid
    }
};
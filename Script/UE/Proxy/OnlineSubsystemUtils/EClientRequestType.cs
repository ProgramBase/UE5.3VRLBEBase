using Script.CoreUObject;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EClientRequestType")]
	public enum EClientRequestType : byte
	{
		NonePending = 0,
		ExistingSessionReservation = 1,
		ReservationUpdate = 2,
		EmptyServerReservation = 3,
		Reconnect = 4,
		Abandon = 5,
		ReservationRemoveMembers = 6,
		AddOrUpdateReservation = 7,
	}
}
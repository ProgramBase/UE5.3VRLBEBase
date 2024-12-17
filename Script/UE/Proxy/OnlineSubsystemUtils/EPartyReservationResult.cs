using Script.CoreUObject;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.EPartyReservationResult")]
	public enum EPartyReservationResult : byte
	{
		NoResult = 0,
		RequestPending = 1,
		GeneralError = 2,
		PartyLimitReached = 3,
		IncorrectPlayerCount = 4,
		RequestTimedOut = 5,
		ReservationDuplicate = 6,
		ReservationNotFound = 7,
		ReservationAccepted = 8,
		ReservationDenied = 9,
		ReservationDenied_CrossPlayRestriction = 10,
		ReservationDenied_Banned = 11,
		ReservationRequestCanceled = 12,
		ReservationInvalid = 13,
		BadSessionId = 14,
		ReservationDenied_ContainsExistingPlayers = 15,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPingType")]
	public enum EPingType : long
	{
		None = 0,
		RoundTrip = 1,
		RoundTripExclFrame = 2,
		ICMP = 4,
		UDPQoS = 8,
		Max = 8,
		Count = 4,
	}
}
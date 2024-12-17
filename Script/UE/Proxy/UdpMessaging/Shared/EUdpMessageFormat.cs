using Script.CoreUObject;

namespace Script.UdpMessaging
{
	[PathName("/Script/UdpMessaging.EUdpMessageFormat")]
	public enum EUdpMessageFormat : byte
	{
		None = 0,
		Json = 1,
		TaggedProperty = 2,
		CborPlatformEndianness = 3,
		CborStandardEndianness = 4,
	}
}
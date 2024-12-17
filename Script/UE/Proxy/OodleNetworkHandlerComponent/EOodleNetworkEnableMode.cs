using Script.CoreUObject;

namespace Script.OodleNetworkHandlerComponent
{
	[PathName("/Script/OodleNetworkHandlerComponent.EOodleNetworkEnableMode")]
	public enum EOodleNetworkEnableMode : long
	{
		AlwaysEnabled = 0,
		WhenCompressedPacketReceived = 1,
	}
}
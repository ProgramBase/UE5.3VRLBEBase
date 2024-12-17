using Script.CoreUObject;

namespace Script.OodleNetworkHandlerComponent
{
	[PathName("/Script/OodleNetworkHandlerComponent.EOodleNetResult")]
	public enum EOodleNetResult : long
	{
		Unknown = 0,
		Success = 1,
		OodleDecodeFailed = 2,
		OodleSerializePayloadFail = 3,
		OodleBadDecompressedLength = 4,
		OodleNoDictionary = 5,
	}
}
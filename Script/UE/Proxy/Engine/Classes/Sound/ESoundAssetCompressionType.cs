using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESoundAssetCompressionType")]
	public enum ESoundAssetCompressionType : byte
	{
		BinkAudio = 0,
		ADPCM = 1,
		PCM = 2,
		PlatformSpecific = 3,
		ProjectDefined = 4,
	}
}
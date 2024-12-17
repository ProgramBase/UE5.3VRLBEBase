using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESubmixSendStage")]
	public enum ESubmixSendStage : byte
	{
		PostDistanceAttenuation = 0,
		PreDistanceAttenuation = 1,
	}
}
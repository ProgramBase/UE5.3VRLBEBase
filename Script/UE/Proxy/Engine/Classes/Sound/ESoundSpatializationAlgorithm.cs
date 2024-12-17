using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESoundSpatializationAlgorithm")]
	public enum ESoundSpatializationAlgorithm : byte
	{
		SPATIALIZATION_Default = 0,
		SPATIALIZATION_HRTF = 1,
	}
}
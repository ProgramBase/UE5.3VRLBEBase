using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EChunkSeekTableMode")]
	public enum EChunkSeekTableMode : long
	{
		ConstantSamplesPerEntry = 0,
		VariableSamplesPerEntry = 1,
	}
}
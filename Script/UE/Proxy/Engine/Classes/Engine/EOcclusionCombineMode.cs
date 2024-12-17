using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EOcclusionCombineMode")]
	public enum EOcclusionCombineMode : byte
	{
		OCM_Minimum = 0,
		OCM_Multiply = 1,
	}
}
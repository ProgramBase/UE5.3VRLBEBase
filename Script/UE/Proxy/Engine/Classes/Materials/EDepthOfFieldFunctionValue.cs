using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDepthOfFieldFunctionValue")]
	public enum EDepthOfFieldFunctionValue : byte
	{
		TDOF_NearAndFarMask = 0,
		TDOF_NearMask = 1,
		TDOF_FarMask = 2,
		TDOF_CircleOfConfusionRadius = 3,
	}
}
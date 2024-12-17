using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EAdditiveAnimationType")]
	public enum EAdditiveAnimationType : byte
	{
		AAT_None = 0,
		AAT_LocalSpaceBase = 1,
		AAT_RotationOffsetMeshSpace = 2,
	}
}
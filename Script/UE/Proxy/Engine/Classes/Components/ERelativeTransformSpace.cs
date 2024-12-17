using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ERelativeTransformSpace")]
	public enum ERelativeTransformSpace : byte
	{
		RTS_World = 0,
		RTS_Actor = 1,
		RTS_Component = 2,
		RTS_ParentBoneSpace = 3,
	}
}
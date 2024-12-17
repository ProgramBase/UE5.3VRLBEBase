using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBoneControlSpace")]
	public enum EBoneControlSpace : byte
	{
		BCS_WorldSpace = 0,
		BCS_ComponentSpace = 1,
		BCS_ParentBoneSpace = 2,
		BCS_BoneSpace = 3,
	}
}
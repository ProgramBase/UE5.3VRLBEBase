using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ECustomBoneAttributeLookup")]
	public enum ECustomBoneAttributeLookup : byte
	{
		BoneOnly = 0,
		ImmediateParent = 1,
		ParentHierarchy = 2,
	}
}
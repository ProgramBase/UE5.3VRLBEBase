using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EBoneVisibilityStatus")]
	public enum EBoneVisibilityStatus : long
	{
		BVS_HiddenByParent = 0,
		BVS_Visible = 1,
		BVS_ExplicitlyHidden = 2,
	}
}
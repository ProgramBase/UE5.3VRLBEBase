using Script.CoreUObject;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.ENDISkeletalMesh_SkinningMode")]
	public enum ENDISkeletalMesh_SkinningMode : byte
	{
		Invalid = 255,
		None = 0,
		SkinOnTheFly = 1,
		PreSkin = 2,
	}
}
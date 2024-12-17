using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EThumbnailPrimType")]
	public enum EThumbnailPrimType : byte
	{
		TPT_None = 0,
		TPT_Sphere = 1,
		TPT_Cube = 2,
		TPT_Plane = 3,
		TPT_Cylinder = 4,
	}
}
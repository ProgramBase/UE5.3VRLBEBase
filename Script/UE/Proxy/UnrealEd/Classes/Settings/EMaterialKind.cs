using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EMaterialKind")]
	public enum EMaterialKind : byte
	{
		Unknown = 0,
		Base = 1,
		Normal = 2,
		Specular = 3,
		Emissive = 4,
	}
}
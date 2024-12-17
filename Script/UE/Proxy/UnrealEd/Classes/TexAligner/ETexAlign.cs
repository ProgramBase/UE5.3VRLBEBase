using Script.CoreUObject;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ETexAlign")]
	public enum ETexAlign : byte
	{
		TEXALIGN_None = 0,
		TEXALIGN_Default = 1,
		TEXALIGN_Box = 2,
		TEXALIGN_Planar = 3,
		TEXALIGN_Fit = 4,
		TEXALIGN_PlanarAuto = 5,
		TEXALIGN_PlanarWall = 6,
		TEXALIGN_PlanarFloor = 7,
	}
}
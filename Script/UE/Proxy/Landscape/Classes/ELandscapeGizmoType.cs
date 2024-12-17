using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeGizmoType")]
	public enum ELandscapeGizmoType : byte
	{
		LGT_None = 0,
		LGT_Height = 1,
		LGT_Weight = 2,
	}
}
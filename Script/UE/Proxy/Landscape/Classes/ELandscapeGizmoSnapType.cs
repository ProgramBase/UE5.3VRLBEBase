using Script.CoreUObject;

namespace Script.Landscape
{
	[PathName("/Script/Landscape.ELandscapeGizmoSnapType")]
	public enum ELandscapeGizmoSnapType : int
	{
		None = 0,
		Component = 1,
		Texel = 2,
	}
}
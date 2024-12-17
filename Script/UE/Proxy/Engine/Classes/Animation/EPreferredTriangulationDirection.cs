using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPreferredTriangulationDirection")]
	public enum EPreferredTriangulationDirection : byte
	{
		None = 0,
		Tangential = 1,
		Radial = 2,
	}
}
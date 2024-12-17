using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EHasCustomNavigableGeometry")]
	public enum EHasCustomNavigableGeometry : byte
	{
		No = 0,
		Yes = 1,
		EvenIfNotCollidable = 2,
		DontExport = 3,
	}
}
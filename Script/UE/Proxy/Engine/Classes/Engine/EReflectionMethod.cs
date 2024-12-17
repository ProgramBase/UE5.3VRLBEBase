using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EReflectionMethod")]
	public enum EReflectionMethod : byte
	{
		None = 0,
		Lumen = 1,
		ScreenSpace = 2,
		RayTraced = 3,
	}
}
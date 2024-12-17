using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EDynamicGlobalIlluminationMethod")]
	public enum EDynamicGlobalIlluminationMethod : byte
	{
		None = 0,
		Lumen = 1,
		ScreenSpace = 2,
		RayTraced = 3,
		Plugin = 4,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETranslucencyType")]
	public enum ETranslucencyType : byte
	{
		Raster = 0,
		RayTracing = 1,
	}
}
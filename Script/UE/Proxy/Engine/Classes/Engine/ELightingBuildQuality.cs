using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELightingBuildQuality")]
	public enum ELightingBuildQuality : byte
	{
		Quality_Preview = 0,
		Quality_Medium = 1,
		Quality_High = 2,
		Quality_Production = 3,
	}
}
using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ELightmapType")]
	public enum ELightmapType : byte
	{
		Default = 0,
		ForceSurface = 1,
		ForceVolumetric = 2,
	}
}
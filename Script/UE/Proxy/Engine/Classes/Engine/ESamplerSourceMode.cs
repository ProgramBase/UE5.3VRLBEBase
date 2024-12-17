using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESamplerSourceMode")]
	public enum ESamplerSourceMode : byte
	{
		SSM_FromTextureAsset = 0,
		SSM_Wrap_WorldGroupSettings = 1,
		SSM_Clamp_WorldGroupSettings = 2,
		SSM_TerrainWeightmapGroupSettings = 3,
	}
}
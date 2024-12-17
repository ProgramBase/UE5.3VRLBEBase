using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EPathTracingBufferTextureId")]
	public enum EPathTracingBufferTextureId : byte
	{
		PTBT_Radiance = 0,
		PTBT_DenoisedRadiance = 1,
		PTBT_Albedo = 2,
		PTBT_Normal = 3,
		PTBT_Variance = 4,
	}
}
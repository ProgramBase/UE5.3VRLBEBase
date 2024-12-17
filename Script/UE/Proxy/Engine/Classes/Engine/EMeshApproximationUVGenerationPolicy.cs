using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshApproximationUVGenerationPolicy")]
	public enum EMeshApproximationUVGenerationPolicy : byte
	{
		PreferUVAtlas = 0,
		PreferXAtlas = 1,
		PreferPatchBuilder = 2,
	}
}
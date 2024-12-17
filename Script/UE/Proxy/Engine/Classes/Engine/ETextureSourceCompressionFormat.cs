using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ETextureSourceCompressionFormat")]
	public enum ETextureSourceCompressionFormat : byte
	{
		TSCF_None = 0,
		TSCF_PNG = 1,
		TSCF_JPEG = 2,
	}
}
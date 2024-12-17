using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EShaderCompressionFormat")]
	public enum EShaderCompressionFormat : long
	{
		None = 0,
		LZ4 = 1,
		Oodle = 2,
		Zlib = 3,
	}
}
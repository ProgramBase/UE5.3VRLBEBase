using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EGBufferFormat")]
	public enum EGBufferFormat : byte
	{
		Force8BitsPerChannel = 0,
		Default = 1,
		HighPrecisionNormals = 3,
		Force16BitsPerChannel = 5,
	}
}
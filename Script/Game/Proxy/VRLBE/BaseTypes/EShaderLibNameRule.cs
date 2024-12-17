using Script.CoreUObject;

namespace Script.HotPatcherRuntime
{
	[PathName("/Script/HotPatcherRuntime.EShaderLibNameRule")]
	public enum EShaderLibNameRule : byte
	{
		CHUNK_NAME = 0,
		PROJECT_NAME = 1,
		CUSTOM = 2,
	}
}
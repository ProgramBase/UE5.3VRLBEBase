using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.EMeshBufferAccess")]
	public enum EMeshBufferAccess : long
	{
		Default = 0,
		ForceCPUAndGPU = 1,
	}
}
using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EBTParallelMode")]
	public enum EBTParallelMode : byte
	{
		AbortBackground = 0,
		WaitForBackground = 1,
	}
}
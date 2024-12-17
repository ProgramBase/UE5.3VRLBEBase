using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EBTBlackboardRestart")]
	public enum EBTBlackboardRestart : byte
	{
		ValueChange = 0,
		ResultChange = 1,
	}
}
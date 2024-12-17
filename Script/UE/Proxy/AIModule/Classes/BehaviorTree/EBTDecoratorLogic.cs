using Script.CoreUObject;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.EBTDecoratorLogic")]
	public enum EBTDecoratorLogic : byte
	{
		Invalid = 0,
		Test = 1,
		And = 2,
		Or = 3,
		Not = 4,
	}
}
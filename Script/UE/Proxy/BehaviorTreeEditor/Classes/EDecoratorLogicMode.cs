using Script.CoreUObject;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.EDecoratorLogicMode")]
	public enum EDecoratorLogicMode : byte
	{
		Sink = 0,
		And = 1,
		Or = 2,
		Not = 3,
	}
}
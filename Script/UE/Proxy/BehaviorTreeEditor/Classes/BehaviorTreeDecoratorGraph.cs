using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraph")]
	public partial class UBehaviorTreeDecoratorGraph : UEdGraph, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraph");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
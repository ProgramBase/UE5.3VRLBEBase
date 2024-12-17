using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraphNode")]
	public partial class UBehaviorTreeDecoratorGraphNode : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeDecoratorGraphNode");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
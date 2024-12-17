using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Decorator")]
	public partial class UBehaviorTreeGraphNode_Decorator : UBehaviorTreeGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Decorator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
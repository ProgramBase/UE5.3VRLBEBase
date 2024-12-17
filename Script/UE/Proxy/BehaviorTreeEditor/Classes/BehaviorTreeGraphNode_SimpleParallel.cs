using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_SimpleParallel")]
	public partial class UBehaviorTreeGraphNode_SimpleParallel : UBehaviorTreeGraphNode_Composite, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_SimpleParallel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
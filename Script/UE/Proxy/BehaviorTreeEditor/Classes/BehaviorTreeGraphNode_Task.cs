using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Task")]
	public partial class UBehaviorTreeGraphNode_Task : UBehaviorTreeGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Task");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
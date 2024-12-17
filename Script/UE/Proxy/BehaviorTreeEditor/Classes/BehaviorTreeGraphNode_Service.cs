using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Service")]
	public partial class UBehaviorTreeGraphNode_Service : UBehaviorTreeGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Service");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
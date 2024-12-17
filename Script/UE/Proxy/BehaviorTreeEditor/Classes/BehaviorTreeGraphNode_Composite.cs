using Script.CoreUObject;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Composite")]
	public partial class UBehaviorTreeGraphNode_Composite : UBehaviorTreeGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.BehaviorTreeGraphNode_Composite");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
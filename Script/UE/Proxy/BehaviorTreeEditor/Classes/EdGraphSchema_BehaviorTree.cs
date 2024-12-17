using Script.CoreUObject;
using Script.AIGraph;
using Script.Library;

namespace Script.BehaviorTreeEditor
{
	[PathName("/Script/BehaviorTreeEditor.EdGraphSchema_BehaviorTree")]
	public partial class UEdGraphSchema_BehaviorTree : UAIGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BehaviorTreeEditor.EdGraphSchema_BehaviorTree");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
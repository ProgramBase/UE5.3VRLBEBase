using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_CustomTransitionResult")]
	public partial class UAnimGraphNode_CustomTransitionResult : UAnimGraphNode_StateResult, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_CustomTransitionResult");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
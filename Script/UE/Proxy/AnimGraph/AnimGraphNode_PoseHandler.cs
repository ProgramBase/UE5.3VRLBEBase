using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_PoseHandler")]
	public partial class UAnimGraphNode_PoseHandler : UAnimGraphNode_AssetPlayerBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_PoseHandler");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
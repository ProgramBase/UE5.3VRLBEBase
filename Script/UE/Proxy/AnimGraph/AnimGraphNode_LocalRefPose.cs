using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_LocalRefPose")]
	public partial class UAnimGraphNode_LocalRefPose : UAnimGraphNode_RefPoseBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_LocalRefPose");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
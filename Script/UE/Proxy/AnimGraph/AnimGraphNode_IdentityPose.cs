using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_IdentityPose")]
	public partial class UAnimGraphNode_IdentityPose : UAnimGraphNode_RefPoseBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_IdentityPose");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_SkeletalControlBase")]
	public partial class UAnimGraphNode_SkeletalControlBase : UAnimGraphNode_Base, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_SkeletalControlBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
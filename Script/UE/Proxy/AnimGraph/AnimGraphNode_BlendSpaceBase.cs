using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_BlendSpaceBase")]
	public partial class UAnimGraphNode_BlendSpaceBase : UAnimGraphNode_AssetPlayerBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_BlendSpaceBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
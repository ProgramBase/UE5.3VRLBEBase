using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_AssetPlayerBase")]
	public partial class UAnimGraphNode_AssetPlayerBase : UAnimGraphNode_Base, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_AssetPlayerBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
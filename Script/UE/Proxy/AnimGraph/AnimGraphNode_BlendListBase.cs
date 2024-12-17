using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_BlendListBase")]
	public partial class UAnimGraphNode_BlendListBase : UAnimGraphNode_Base, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_BlendListBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
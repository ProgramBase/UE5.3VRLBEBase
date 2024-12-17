using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimStateNodeBase")]
	public partial class UAnimStateNodeBase : UEdGraphNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimStateNodeBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
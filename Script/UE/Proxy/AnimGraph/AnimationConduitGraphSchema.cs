using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationConduitGraphSchema")]
	public partial class UAnimationConduitGraphSchema : UEdGraphSchema_K2, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationConduitGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationTransitionSchema")]
	public partial class UAnimationTransitionSchema : UEdGraphSchema_K2, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationTransitionSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
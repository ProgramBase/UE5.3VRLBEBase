using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationCustomTransitionSchema")]
	public partial class UAnimationCustomTransitionSchema : UAnimationGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationCustomTransitionSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
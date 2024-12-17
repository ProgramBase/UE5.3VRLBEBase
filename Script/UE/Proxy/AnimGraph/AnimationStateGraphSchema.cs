using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationStateGraphSchema")]
	public partial class UAnimationStateGraphSchema : UAnimationGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationStateGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
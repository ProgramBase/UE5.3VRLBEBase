using Script.CoreUObject;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimBlueprintExtension_StateMachine")]
	public partial class UAnimBlueprintExtension_StateMachine : UAnimBlueprintExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimBlueprintExtension_StateMachine");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
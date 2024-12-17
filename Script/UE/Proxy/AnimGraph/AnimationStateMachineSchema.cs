using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimationStateMachineSchema")]
	public partial class UAnimationStateMachineSchema : UEdGraphSchema, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimationStateMachineSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
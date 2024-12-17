using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.K2Node_PlayMontage")]
	public partial class UK2Node_PlayMontage : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.K2Node_PlayMontage");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
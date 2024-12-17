using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.K2Node_PlayAnimationTimeRange")]
	public partial class UK2Node_PlayAnimationTimeRange : UK2Node_BaseAsyncTask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.K2Node_PlayAnimationTimeRange");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
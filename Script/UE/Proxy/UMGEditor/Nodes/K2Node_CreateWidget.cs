using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.K2Node_CreateWidget")]
	public partial class UK2Node_CreateWidget : UK2Node_ConstructObjectFromClass, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.K2Node_CreateWidget");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.K2Node_GetEditorProperty")]
	public partial class UK2Node_GetEditorProperty : UK2Node_EditorPropertyAccessBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/BlueprintGraph.K2Node_GetEditorProperty");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
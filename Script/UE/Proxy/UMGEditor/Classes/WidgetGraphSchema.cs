using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.WidgetGraphSchema")]
	public partial class UWidgetGraphSchema : UEdGraphSchema_K2, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.WidgetGraphSchema");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
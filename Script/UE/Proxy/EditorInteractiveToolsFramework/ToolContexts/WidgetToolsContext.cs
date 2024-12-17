using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.WidgetToolsContext")]
	public partial class UWidgetToolsContext : UModeManagerInteractiveToolsContext, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.WidgetToolsContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
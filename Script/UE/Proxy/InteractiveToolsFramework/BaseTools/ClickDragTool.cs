using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.ClickDragTool")]
	public partial class UClickDragTool : UInteractiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.ClickDragTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
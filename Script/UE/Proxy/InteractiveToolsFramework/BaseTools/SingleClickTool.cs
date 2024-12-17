using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.SingleClickTool")]
	public partial class USingleClickTool : UInteractiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.SingleClickTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
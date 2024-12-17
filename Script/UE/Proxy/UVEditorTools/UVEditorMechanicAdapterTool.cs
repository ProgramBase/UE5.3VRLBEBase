using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorMechanicAdapterTool")]
	public partial class UUVEditorMechanicAdapterTool : UInteractiveTool, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorMechanicAdapterTool");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorTools
{
	[PathName("/Script/UVEditorTools.UVEditorUVTransformPropertiesBase")]
	public partial class UUVEditorUVTransformPropertiesBase : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorTools.UVEditorUVTransformPropertiesBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
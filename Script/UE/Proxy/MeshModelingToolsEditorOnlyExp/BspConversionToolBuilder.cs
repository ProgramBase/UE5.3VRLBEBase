using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.BspConversionToolBuilder")]
	public partial class UBspConversionToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.BspConversionToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
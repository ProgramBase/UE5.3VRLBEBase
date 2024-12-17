using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolActionPropertySetBase")]
	public partial class UISMEditorToolActionPropertySetBase : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolActionPropertySetBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
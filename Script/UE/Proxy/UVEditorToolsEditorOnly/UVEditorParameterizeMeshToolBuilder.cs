using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.UVEditorToolsEditorOnly
{
	[PathName("/Script/UVEditorToolsEditorOnly.UVEditorParameterizeMeshToolBuilder")]
	public partial class UUVEditorParameterizeMeshToolBuilder : UInteractiveToolBuilder, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditorToolsEditorOnly.UVEditorParameterizeMeshToolBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
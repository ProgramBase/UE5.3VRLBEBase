using Script.CoreUObject;
using Script.EditorFramework;
using Script.Library;

namespace Script.UVEditor
{
	[PathName("/Script/UVEditor.UVEditorUISubsystem")]
	public partial class UUVEditorUISubsystem : UAssetEditorUISubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UVEditor.UVEditorUISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
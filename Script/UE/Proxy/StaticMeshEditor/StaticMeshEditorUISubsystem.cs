using Script.CoreUObject;
using Script.EditorFramework;
using Script.Library;

namespace Script.StaticMeshEditor
{
	[PathName("/Script/StaticMeshEditor.StaticMeshEditorUISubsystem")]
	public partial class UStaticMeshEditorUISubsystem : UAssetEditorUISubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/StaticMeshEditor.StaticMeshEditorUISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.EditorFramework
{
	[PathName("/Script/EditorFramework.AssetEditorUISubsystem")]
	public partial class UAssetEditorUISubsystem : UEditorSubsystem, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorFramework.AssetEditorUISubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
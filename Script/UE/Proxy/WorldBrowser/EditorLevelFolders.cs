using Script.CoreUObject;
using Script.Library;

namespace Script.WorldBrowser
{
	[PathName("/Script/WorldBrowser.EditorLevelFolders")]
	public partial class UEditorLevelFolders : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/WorldBrowser.EditorLevelFolders");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
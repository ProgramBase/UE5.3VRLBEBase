using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.HotPatcherEditor
{
	[PathName("/Script/HotPatcherEditor.FlibHotPatcherEditorHelper")]
	public partial class UFlibHotPatcherEditorHelper : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/HotPatcherEditor.FlibHotPatcherEditorHelper");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
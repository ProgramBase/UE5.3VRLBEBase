using Script.CoreUObject;
using Script.UnrealEd;
using Script.Library;

namespace Script.VREditor
{
	[PathName("/Script/VREditor.VREditorModeBase")]
	public partial class UVREditorModeBase : UEditorWorldExtension, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/VREditor.VREditorModeBase");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorViewportViewMenuContext")]
	public partial class UEditorViewportViewMenuContext : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorViewportViewMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
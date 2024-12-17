using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.EditorWorldExtensionCollection")]
	public partial class UEditorWorldExtensionCollection : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.EditorWorldExtensionCollection");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityEditableText")]
	public partial class UEditorUtilityEditableText : UEditableText, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityEditableText");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityMultiLineEditableText")]
	public partial class UEditorUtilityMultiLineEditableText : UMultiLineEditableText, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityMultiLineEditableText");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
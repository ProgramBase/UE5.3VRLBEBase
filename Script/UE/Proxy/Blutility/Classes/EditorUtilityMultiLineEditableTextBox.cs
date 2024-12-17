using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityMultiLineEditableTextBox")]
	public partial class UEditorUtilityMultiLineEditableTextBox : UMultiLineEditableTextBox, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityMultiLineEditableTextBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
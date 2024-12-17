using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityComboBoxKey")]
	public partial class UEditorUtilityComboBoxKey : UComboBoxKey, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityComboBoxKey");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
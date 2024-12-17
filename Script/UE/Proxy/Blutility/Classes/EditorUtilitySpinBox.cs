using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilitySpinBox")]
	public partial class UEditorUtilitySpinBox : USpinBox, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilitySpinBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
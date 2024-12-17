using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilityCheckBox")]
	public partial class UEditorUtilityCheckBox : UCheckBox, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilityCheckBox");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
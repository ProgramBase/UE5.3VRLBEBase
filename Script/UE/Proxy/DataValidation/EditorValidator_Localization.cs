using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.EditorValidator_Localization")]
	public partial class UEditorValidator_Localization : UEditorValidatorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.EditorValidator_Localization");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
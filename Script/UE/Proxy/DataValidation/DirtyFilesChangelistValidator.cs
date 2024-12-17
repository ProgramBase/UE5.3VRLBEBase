using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.DirtyFilesChangelistValidator")]
	public partial class UDirtyFilesChangelistValidator : UEditorValidatorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.DirtyFilesChangelistValidator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
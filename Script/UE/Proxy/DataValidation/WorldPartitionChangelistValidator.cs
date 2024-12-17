using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.WorldPartitionChangelistValidator")]
	public partial class UWorldPartitionChangelistValidator : UEditorValidatorBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.WorldPartitionChangelistValidator");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
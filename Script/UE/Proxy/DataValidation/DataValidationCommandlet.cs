using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.DataValidationCommandlet")]
	public partial class UDataValidationCommandlet : UCommandlet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.DataValidationCommandlet");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
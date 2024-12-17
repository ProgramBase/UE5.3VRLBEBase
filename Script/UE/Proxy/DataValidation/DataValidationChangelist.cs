using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.DataValidationChangelist")]
	public partial class UDataValidationChangelist : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.DataValidationChangelist");
		}

		private static UClass StaticClassSingleton { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.DataValidation
{
	[PathName("/Script/DataValidation.DataValidationSettings")]
	public partial class UDataValidationSettings : UObject, IStaticClass
	{
		public bool bValidateOnSave
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateOnSave, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateOnSave, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataValidation.DataValidationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bValidateOnSave = 0;
	}
}
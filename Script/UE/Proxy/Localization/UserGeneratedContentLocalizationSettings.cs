using Script.CoreUObject;
using Script.Library;

namespace Script.Localization
{
	[PathName("/Script/Localization.UserGeneratedContentLocalizationSettings")]
	public partial class UUserGeneratedContentLocalizationSettings : UObject, IStaticClass
	{
		public TArray<FString> CulturesToDisable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CulturesToDisable, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CulturesToDisable, __InBuffer);
				}
			}
		}

		public bool bCompileDLCLocalizationDuringCook
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCompileDLCLocalizationDuringCook, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCompileDLCLocalizationDuringCook, __InBuffer);
				}
			}
		}

		public bool bValidateDLCLocalizationDuringCook
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateDLCLocalizationDuringCook, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateDLCLocalizationDuringCook, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Localization.UserGeneratedContentLocalizationSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __CulturesToDisable = 0;

		private static uint __bCompileDLCLocalizationDuringCook = 0;

		private static uint __bValidateDLCLocalizationDuringCook = 0;
	}
}
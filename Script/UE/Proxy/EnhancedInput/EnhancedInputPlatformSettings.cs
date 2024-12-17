using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.EnhancedInput
{
	[PathName("/Script/EnhancedInput.EnhancedInputPlatformSettings")]
	public partial class UEnhancedInputPlatformSettings : UPlatformSettings, IStaticClass
	{
		public TArray<TSoftClassPtr<UEnhancedInputPlatformData>> InputData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputData, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UEnhancedInputPlatformData>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputData, __InBuffer);
				}
			}
		}

		public TArray<TSubclassOf<UEnhancedInputPlatformData>> InputDataClasses
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InputDataClasses, __ReturnBuffer);

					return *(TArray<TSubclassOf<UEnhancedInputPlatformData>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InputDataClasses, __InBuffer);
				}
			}
		}

		public bool bShouldLogMappingContextRedirects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldLogMappingContextRedirects, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldLogMappingContextRedirects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EnhancedInput.EnhancedInputPlatformSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InputData = 0;

		private static uint __InputDataClasses = 0;

		private static uint __bShouldLogMappingContextRedirects = 0;
	}
}
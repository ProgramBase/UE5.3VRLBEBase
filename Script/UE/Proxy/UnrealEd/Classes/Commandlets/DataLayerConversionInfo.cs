using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DataLayerConversionInfo")]
	public partial class UDataLayerConversionInfo : UObject, IStaticClass
	{
		public UDeprecatedDataLayerInstance DataLayerToConvert
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerToConvert, __ReturnBuffer);

					return *(UDeprecatedDataLayerInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerToConvert, __InBuffer);
				}
			}
		}

		public UDataLayerAsset DataLayerAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __ReturnBuffer);

					return *(UDataLayerAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerAsset, __InBuffer);
				}
			}
		}

		public UDataLayerInstanceWithAsset DataLayerInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstance, __ReturnBuffer);

					return *(UDataLayerInstanceWithAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerInstance, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UDataLayerConversionInfo>> PreviousConversionsInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousConversionsInfo, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UDataLayerConversionInfo>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviousConversionsInfo, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UDataLayerConversionInfo> CurrentConvertingInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentConvertingInfo, __ReturnBuffer);

					return *(TWeakObjectPtr<UDataLayerConversionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentConvertingInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DataLayerConversionInfo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataLayerToConvert = 0;

		private static uint __DataLayerAsset = 0;

		private static uint __DataLayerInstance = 0;

		private static uint __PreviousConversionsInfo = 0;

		private static uint __CurrentConvertingInfo = 0;
	}
}
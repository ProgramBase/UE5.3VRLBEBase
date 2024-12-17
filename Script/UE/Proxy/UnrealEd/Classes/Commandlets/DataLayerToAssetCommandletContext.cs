using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.DataLayerToAssetCommandletContext")]
	public partial class UDataLayerToAssetCommandletContext : UObject, IStaticClass
	{
		public TArray<UDataLayerConversionInfo> DataLayerConversionInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerConversionInfo, __ReturnBuffer);

					return *(TArray<UDataLayerConversionInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DataLayerConversionInfo, __InBuffer);
				}
			}
		}

		public TArray<TWeakObjectPtr<UDataLayerConversionInfo>> ConvertingDataLayerInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConvertingDataLayerInfo, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UDataLayerConversionInfo>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConvertingDataLayerInfo, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.DataLayerToAssetCommandletContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DataLayerConversionInfo = 0;

		private static uint __ConvertingDataLayerInfo = 0;
	}
}
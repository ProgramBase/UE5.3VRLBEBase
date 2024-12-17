using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Overlay
{
	[PathName("/Script/Overlay.LocalizedOverlays")]
	public partial class ULocalizedOverlays : UOverlays, IStaticClass
	{
		public UBasicOverlays DefaultOverlays
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOverlays, __ReturnBuffer);

					return *(UBasicOverlays*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultOverlays, __InBuffer);
				}
			}
		}

		public TMap<FString, UBasicOverlays> LocaleToOverlaysMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LocaleToOverlaysMap, __ReturnBuffer);

					return *(TMap<FString, UBasicOverlays>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LocaleToOverlaysMap, __InBuffer);
				}
			}
		}

		public UAssetImportData AssetImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __ReturnBuffer);

					return *(UAssetImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Overlay.LocalizedOverlays");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultOverlays = 0;

		private static uint __LocaleToOverlaysMap = 0;

		private static uint __AssetImportData = 0;
	}
}
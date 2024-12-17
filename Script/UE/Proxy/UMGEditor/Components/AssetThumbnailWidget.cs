using Script.CoreUObject;
using Script.UMG;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.AssetThumbnailWidget")]
	public partial class UAssetThumbnailWidget : UWidget, IStaticClass
	{
		public FAssetData AssetToShow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetToShow, __ReturnBuffer);

					return *(FAssetData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetToShow, __InBuffer);
				}
			}
		}

		public FIntPoint Resolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Resolution, __ReturnBuffer);

					return *(FIntPoint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Resolution, __InBuffer);
				}
			}
		}

		public FAssetThumbnailWidgetSettings ThumbnailSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailSettings, __ReturnBuffer);

					return *(FAssetThumbnailWidgetSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.AssetThumbnailWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetThumbnailSettings(FAssetThumbnailWidgetSettings InThumbnailSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InThumbnailSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetThumbnailSettings, __InBuffer);
			}
		}

		public virtual void SetResolution(FIntPoint InResolution)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InResolution?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetResolution, __InBuffer);
			}
		}

		public virtual void SetAssetByObject(UObject Object)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Object?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAssetByObject, __InBuffer);
			}
		}

		public virtual void SetAsset(FAssetData AssetData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetData?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAsset, __InBuffer);
			}
		}

		public virtual FIntPoint GetResolution()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetResolution, __ReturnBuffer);

				return *(FIntPoint*)__ReturnBuffer;
			}
		}

		private static uint __AssetToShow = 0;

		private static uint __Resolution = 0;

		private static uint __ThumbnailSettings = 0;

		private static uint __SetThumbnailSettings = 0;

		private static uint __SetResolution = 0;

		private static uint __SetAssetByObject = 0;

		private static uint __SetAsset = 0;

		private static uint __GetResolution = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.GooglePAD
{
	[PathName("/Script/GooglePAD.GooglePADFunctionLibrary")]
	public partial class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GooglePAD.GooglePADFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static EGooglePADErrorCode ShowCellularDataConfirmation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __ShowCellularDataConfirmation, __ReturnBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode RequestRemoval(FString Name)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RequestRemoval, __InBuffer, __ReturnBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode RequestInfo(TArray<FString> AssetPacks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPacks?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RequestInfo, __InBuffer, __ReturnBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode RequestDownload(TArray<FString> AssetPacks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPacks?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RequestDownload, __InBuffer, __ReturnBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static void ReleaseDownloadState(int State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = State;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReleaseDownloadState, __InBuffer);
			}
		}

		public static void ReleaseAssetPackLocation(int Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Location;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReleaseAssetPackLocation, __InBuffer);
			}
		}

		public static int GetTotalBytesToDownload(int State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = State;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetTotalBytesToDownload, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static EGooglePADStorageMethod GetStorageMethod(int Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Location;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetStorageMethod, __InBuffer, __ReturnBuffer);

				return *(EGooglePADStorageMethod*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode GetShowCellularDataConfirmationStatus(ref EGooglePADCellularDataConfirmStatus Status)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Status;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetShowCellularDataConfirmationStatus, __InBuffer, __OutBuffer, __ReturnBuffer);

				Status = *(EGooglePADCellularDataConfirmStatus*)(__OutBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static EGooglePADDownloadStatus GetDownloadStatus(int State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = State;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetDownloadStatus, __InBuffer, __ReturnBuffer);

				return *(EGooglePADDownloadStatus*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode GetDownloadState(FString Name, ref int State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = State;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetDownloadState, __InBuffer, __OutBuffer, __ReturnBuffer);

				State = *(int*)(__OutBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static int GetBytesDownloaded(int State)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = State;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBytesDownloaded, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static FString GetAssetsPath(int Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Location;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAssetsPath, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode GetAssetPackLocation(FString Name, ref int Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Location;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetAssetPackLocation, __InBuffer, __OutBuffer, __ReturnBuffer);

				Location = *(int*)(__OutBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		public static EGooglePADErrorCode CancelDownload(TArray<FString> AssetPacks)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AssetPacks?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CancelDownload, __InBuffer, __ReturnBuffer);

				return *(EGooglePADErrorCode*)__ReturnBuffer;
			}
		}

		private static uint __ShowCellularDataConfirmation = 0;

		private static uint __RequestRemoval = 0;

		private static uint __RequestInfo = 0;

		private static uint __RequestDownload = 0;

		private static uint __ReleaseDownloadState = 0;

		private static uint __ReleaseAssetPackLocation = 0;

		private static uint __GetTotalBytesToDownload = 0;

		private static uint __GetStorageMethod = 0;

		private static uint __GetShowCellularDataConfirmationStatus = 0;

		private static uint __GetDownloadStatus = 0;

		private static uint __GetDownloadState = 0;

		private static uint __GetBytesDownloaded = 0;

		private static uint __GetAssetsPath = 0;

		private static uint __GetAssetPackLocation = 0;

		private static uint __CancelDownload = 0;
	}
}
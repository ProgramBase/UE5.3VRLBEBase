using Script.CoreUObject;
using Script.Library;

namespace Script.MobilePatchingUtils
{
	[PathName("/Script/MobilePatchingUtils.MobilePendingContent")]
	public partial class UMobilePendingContent : UMobileInstalledContent, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MobilePatchingUtils.MobilePendingContent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OnSucceeded">
		/// : Callback on installation success. 
		/// </param>
		/// <param name="OnFailed">
		/// : Callback on installation fail. Will return error message text and error integer code
		/// </param>
		public virtual void StartInstall(FOnContentInstallSucceeded OnSucceeded, FOnContentInstallFailed OnFailed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OnSucceeded?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnFailed?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StartInstall, __InBuffer);
			}
		}

		public virtual float GetTotalDownloadedSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetTotalDownloadedSize, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetRequiredDiskSpace()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetRequiredDiskSpace, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetInstallProgress()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetInstallProgress, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FText GetDownloadStatusText()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDownloadStatusText, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual float GetDownloadSpeed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDownloadSpeed, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetDownloadSize()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetDownloadSize, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __StartInstall = 0;

		private static uint __GetTotalDownloadedSize = 0;

		private static uint __GetRequiredDiskSpace = 0;

		private static uint __GetInstallProgress = 0;

		private static uint __GetDownloadStatusText = 0;

		private static uint __GetDownloadSpeed = 0;

		private static uint __GetDownloadSize = 0;
	}
}
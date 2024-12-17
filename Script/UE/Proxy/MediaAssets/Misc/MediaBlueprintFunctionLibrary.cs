using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MediaAssets
{
	[PathName("/Script/MediaAssets.MediaBlueprintFunctionLibrary")]
	public partial class UMediaBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MediaAssets.MediaBlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OutDevices">
		/// Will contain the available capture devices.
		/// </param>
		/// <param name="Filter">
		/// The types of capture devices to return (-1 = all).
		/// </param>
		public static void EnumerateWebcamCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = OutDevices?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Filter;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __EnumerateWebcamCaptureDevices, __InBuffer, __OutBuffer);

				OutDevices = *(TArray<FMediaCaptureDevice>*)(__OutBuffer);

			}
		}

		/// <param name="OutDevices">
		/// Will contain the available capture devices.
		/// </param>
		/// <param name="Filter">
		/// The types of capture devices to return (-1 = all).
		/// </param>
		public static void EnumerateVideoCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = OutDevices?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Filter;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __EnumerateVideoCaptureDevices, __InBuffer, __OutBuffer);

				OutDevices = *(TArray<FMediaCaptureDevice>*)(__OutBuffer);

			}
		}

		/// <param name="OutDevices">
		/// Will contain the available capture devices.
		/// </param>
		/// <param name="Filter">
		/// The types of capture devices to return (-1 = all).
		/// </param>
		public static void EnumerateAudioCaptureDevices(ref TArray<FMediaCaptureDevice> OutDevices, int Filter = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = OutDevices?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Filter;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __EnumerateAudioCaptureDevices, __InBuffer, __OutBuffer);

				OutDevices = *(TArray<FMediaCaptureDevice>*)(__OutBuffer);

			}
		}

		private static uint __EnumerateWebcamCaptureDevices = 0;

		private static uint __EnumerateVideoCaptureDevices = 0;

		private static uint __EnumerateAudioCaptureDevices = 0;
	}
}
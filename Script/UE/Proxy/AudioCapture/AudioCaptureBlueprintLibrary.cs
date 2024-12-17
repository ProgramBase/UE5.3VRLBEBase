using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioCapture
{
	[PathName("/Script/AudioCapture.AudioCaptureBlueprintLibrary")]
	public partial class UAudioCaptureBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioCapture.AudioCaptureBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OnObtainDevicesEvent">
		/// - the event to fire when the audio endpoint devices have been retrieved
		/// </param>
		public static void GetAvailableAudioInputDevices(UObject WorldContextObject, FOnAudioInputDevicesObtained OnObtainDevicesEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OnObtainDevicesEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __GetAvailableAudioInputDevices, __InBuffer);
			}
		}

		/// <param name="info">
		/// - The audio device data to print
		/// </param>
		/// <returns>
		/// The data in a string format
		/// </returns>
		public static FString Conv_AudioInputDeviceInfoToString(FAudioInputDeviceInfo info)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = info?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __Conv_AudioInputDeviceInfoToString, __InBuffer, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __GetAvailableAudioInputDevices = 0;

		private static uint __Conv_AudioInputDeviceInfoToString = 0;
	}
}
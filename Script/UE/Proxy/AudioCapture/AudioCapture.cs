using Script.CoreUObject;
using Script.AudioMixer;
using Script.Library;

namespace Script.AudioCapture
{
	[PathName("/Script/AudioCapture.AudioCapture")]
	public partial class UAudioCapture : UAudioGenerator, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioCapture.AudioCapture");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopCapturingAudio()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StopCapturingAudio);
			}
		}

		public virtual void StartCapturingAudio()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartCapturingAudio);
			}
		}

		public virtual bool IsCapturingAudio()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsCapturingAudio, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetAudioCaptureDeviceInfo(ref FAudioCaptureDeviceInfo OutInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutInfo?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetAudioCaptureDeviceInfo, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutInfo = *(FAudioCaptureDeviceInfo*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __StopCapturingAudio = 0;

		private static uint __StartCapturingAudio = 0;

		private static uint __IsCapturingAudio = 0;

		private static uint __GetAudioCaptureDeviceInfo = 0;
	}
}
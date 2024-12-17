using Script.CoreUObject;
using Script.TakesCore;
using Script.Library;

namespace Script.TakeRecorderSources
{
	[PathName("/Script/TakeRecorderSources.TakeRecorderMicrophoneAudioManager")]
	public partial class UTakeRecorderMicrophoneAudioManager : UTakeRecorderAudioInputSettings, IStaticClass
	{
		public FAudioInputDeviceProperty AudioInputDevice
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AudioInputDevice, __ReturnBuffer);

					return *(FAudioInputDeviceProperty*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AudioInputDevice, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TakeRecorderSources.TakeRecorderMicrophoneAudioManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AudioInputDevice = 0;
	}
}
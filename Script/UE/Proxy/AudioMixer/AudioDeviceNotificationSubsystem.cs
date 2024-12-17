using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AudioMixer
{
	[PathName("/Script/AudioMixer.AudioDeviceNotificationSubsystem")]
	public partial class UAudioDeviceNotificationSubsystem : UEngineSubsystem, IStaticClass
	{
		public FOnAudioDefaultDeviceChanged DefaultCaptureDeviceChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCaptureDeviceChanged, __ReturnBuffer);

					return *(FOnAudioDefaultDeviceChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultCaptureDeviceChanged, __InBuffer);
				}
			}
		}

		public FOnAudioDefaultDeviceChanged DefaultRenderDeviceChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultRenderDeviceChanged, __ReturnBuffer);

					return *(FOnAudioDefaultDeviceChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultRenderDeviceChanged, __InBuffer);
				}
			}
		}

		public FOnAudioDeviceChange DeviceAdded
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceAdded, __ReturnBuffer);

					return *(FOnAudioDeviceChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceAdded, __InBuffer);
				}
			}
		}

		public FOnAudioDeviceChange DeviceRemoved
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceRemoved, __ReturnBuffer);

					return *(FOnAudioDeviceChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceRemoved, __InBuffer);
				}
			}
		}

		public FOnAudioDeviceStateChanged DeviceStateChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceStateChanged, __ReturnBuffer);

					return *(FOnAudioDeviceStateChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceStateChanged, __InBuffer);
				}
			}
		}

		public FOnAudioDeviceChange DeviceSwitched
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceSwitched, __ReturnBuffer);

					return *(FOnAudioDeviceChange*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceSwitched, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioMixer.AudioDeviceNotificationSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DefaultCaptureDeviceChanged = 0;

		private static uint __DefaultRenderDeviceChanged = 0;

		private static uint __DeviceAdded = 0;

		private static uint __DeviceRemoved = 0;

		private static uint __DeviceStateChanged = 0;

		private static uint __DeviceSwitched = 0;
	}
}
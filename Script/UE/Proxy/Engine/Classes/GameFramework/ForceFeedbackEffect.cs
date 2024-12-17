using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ForceFeedbackEffect")]
	public partial class UForceFeedbackEffect : UObject, IStaticClass
	{
		public TArray<FForceFeedbackChannelDetails> ChannelDetails
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelDetails, __ReturnBuffer);

					return *(TArray<FForceFeedbackChannelDetails>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChannelDetails, __InBuffer);
				}
			}
		}

		public TMap<FName, FForceFeedbackEffectOverridenChannelDetails> PerDeviceOverrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PerDeviceOverrides, __ReturnBuffer);

					return *(TMap<FName, FForceFeedbackEffectOverridenChannelDetails>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PerDeviceOverrides, __InBuffer);
				}
			}
		}

		public TArray<UInputDeviceProperty> DeviceProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceProperties, __ReturnBuffer);

					return *(TArray<UInputDeviceProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DeviceProperties, __InBuffer);
				}
			}
		}

		public float Duration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ForceFeedbackEffect");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ChannelDetails = 0;

		private static uint __PerDeviceOverrides = 0;

		private static uint __DeviceProperties = 0;

		private static uint __Duration = 0;
	}
}
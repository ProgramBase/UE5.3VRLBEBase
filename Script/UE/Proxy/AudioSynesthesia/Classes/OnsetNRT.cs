using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.OnsetNRT")]
	public partial class UOnsetNRT : UAudioSynesthesiaNRT, IStaticClass
	{
		public UOnsetNRTSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UOnsetNRTSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.OnsetNRT");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetNormalizedChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = InStartSeconds;

				*(float*)(__InBuffer + 4) = InEndSeconds;

				*(int*)(__InBuffer + 8) = InChannel;

				*(nint*)(__InBuffer + 12) = OutOnsetTimestamps?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = OutOnsetStrengths?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNormalizedChannelOnsetsBetweenTimes, __InBuffer, __OutBuffer);

				OutOnsetTimestamps = *(TArray<float>*)(__OutBuffer);

				OutOnsetStrengths = *(TArray<float>*)(__OutBuffer + 8);

			}
		}

		public virtual void GetChannelOnsetsBetweenTimes(float InStartSeconds, float InEndSeconds, int InChannel, ref TArray<float> OutOnsetTimestamps, ref TArray<float> OutOnsetStrengths)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(float*)(__InBuffer) = InStartSeconds;

				*(float*)(__InBuffer + 4) = InEndSeconds;

				*(int*)(__InBuffer + 8) = InChannel;

				*(nint*)(__InBuffer + 12) = OutOnsetTimestamps?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = OutOnsetStrengths?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetChannelOnsetsBetweenTimes, __InBuffer, __OutBuffer);

				OutOnsetTimestamps = *(TArray<float>*)(__OutBuffer);

				OutOnsetStrengths = *(TArray<float>*)(__OutBuffer + 8);

			}
		}

		private static uint __Settings = 0;

		private static uint __GetNormalizedChannelOnsetsBetweenTimes = 0;

		private static uint __GetChannelOnsetsBetweenTimes = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.LoudnessNRT")]
	public partial class ULoudnessNRT : UAudioSynesthesiaNRT, IStaticClass
	{
		public ULoudnessNRTSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(ULoudnessNRTSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.LoudnessNRT");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetNormalizedLoudnessAtTime(float InSeconds, ref float OutLoudness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InSeconds;

				*(float*)(__InBuffer + 4) = OutLoudness;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNormalizedLoudnessAtTime, __InBuffer, __OutBuffer);

				OutLoudness = *(float*)(__OutBuffer);

			}
		}

		public virtual void GetNormalizedChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InSeconds;

				*(int*)(__InBuffer + 4) = InChannel;

				*(float*)(__InBuffer + 8) = OutLoudness;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNormalizedChannelLoudnessAtTime, __InBuffer, __OutBuffer);

				OutLoudness = *(float*)(__OutBuffer);

			}
		}

		public virtual void GetLoudnessAtTime(float InSeconds, ref float OutLoudness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = InSeconds;

				*(float*)(__InBuffer + 4) = OutLoudness;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetLoudnessAtTime, __InBuffer, __OutBuffer);

				OutLoudness = *(float*)(__OutBuffer);

			}
		}

		public virtual void GetChannelLoudnessAtTime(float InSeconds, int InChannel, ref float OutLoudness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InSeconds;

				*(int*)(__InBuffer + 4) = InChannel;

				*(float*)(__InBuffer + 8) = OutLoudness;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetChannelLoudnessAtTime, __InBuffer, __OutBuffer);

				OutLoudness = *(float*)(__OutBuffer);

			}
		}

		private static uint __Settings = 0;

		private static uint __GetNormalizedLoudnessAtTime = 0;

		private static uint __GetNormalizedChannelLoudnessAtTime = 0;

		private static uint __GetLoudnessAtTime = 0;

		private static uint __GetChannelLoudnessAtTime = 0;
	}
}
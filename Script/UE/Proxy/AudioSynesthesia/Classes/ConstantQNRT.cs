using Script.CoreUObject;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.ConstantQNRT")]
	public partial class UConstantQNRT : UAudioSynesthesiaNRT, IStaticClass
	{
		public UConstantQNRTSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(UConstantQNRTSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.ConstantQNRT");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void GetNormalizedChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = InSeconds;

				*(int*)(__InBuffer + 4) = InChannel;

				*(nint*)(__InBuffer + 8) = OutConstantQ?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetNormalizedChannelConstantQAtTime, __InBuffer, __OutBuffer);

				OutConstantQ = *(TArray<float>*)(__OutBuffer);

			}
		}

		public virtual void GetChannelConstantQAtTime(float InSeconds, int InChannel, ref TArray<float> OutConstantQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = InSeconds;

				*(int*)(__InBuffer + 4) = InChannel;

				*(nint*)(__InBuffer + 8) = OutConstantQ?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetChannelConstantQAtTime, __InBuffer, __OutBuffer);

				OutConstantQ = *(TArray<float>*)(__OutBuffer);

			}
		}

		private static uint __Settings = 0;

		private static uint __GetNormalizedChannelConstantQAtTime = 0;

		private static uint __GetChannelConstantQAtTime = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectDelayStatics")]
	public partial class USubmixEffectDelayStatics : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SubmixEffectDelayStatics");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static FSubmixEffectDelaySettings SetMaximumDelayLength(ref FSubmixEffectDelaySettings DelaySettings, float MaximumDelayLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = DelaySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = MaximumDelayLength;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __SetMaximumDelayLength, __InBuffer, __OutBuffer, __ReturnBuffer);

				DelaySettings = *(FSubmixEffectDelaySettings*)(__OutBuffer);

				return *(FSubmixEffectDelaySettings*)__ReturnBuffer;
			}
		}

		public static FSubmixEffectDelaySettings SetInterpolationTime(ref FSubmixEffectDelaySettings DelaySettings, float InterpolationTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = DelaySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = InterpolationTime;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __SetInterpolationTime, __InBuffer, __OutBuffer, __ReturnBuffer);

				DelaySettings = *(FSubmixEffectDelaySettings*)(__OutBuffer);

				return *(FSubmixEffectDelaySettings*)__ReturnBuffer;
			}
		}

		public static FSubmixEffectDelaySettings SetDelayLength(ref FSubmixEffectDelaySettings DelaySettings, float DelayLength)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = DelaySettings?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = DelayLength;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __SetDelayLength, __InBuffer, __OutBuffer, __ReturnBuffer);

				DelaySettings = *(FSubmixEffectDelaySettings*)(__OutBuffer);

				return *(FSubmixEffectDelaySettings*)__ReturnBuffer;
			}
		}

		private static uint __SetMaximumDelayLength = 0;

		private static uint __SetInterpolationTime = 0;

		private static uint __SetDelayLength = 0;
	}
}
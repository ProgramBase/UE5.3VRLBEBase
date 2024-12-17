using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary")]
	public partial class USynthesisUtilitiesBlueprintFunctionLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SynthesisUtilitiesBlueprintFunctionLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static float GetLogFrequency(float InLinearValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(float*)(__InBuffer) = InLinearValue;

				*(float*)(__InBuffer + 4) = InDomainMin;

				*(float*)(__InBuffer + 8) = InDomainMax;

				*(float*)(__InBuffer + 12) = InRangeMin;

				*(float*)(__InBuffer + 16) = InRangeMax;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLogFrequency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetLinearFrequency(float InLogFrequencyValue, float InDomainMin, float InDomainMax, float InRangeMin, float InRangeMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(float*)(__InBuffer) = InLogFrequencyValue;

				*(float*)(__InBuffer + 4) = InDomainMin;

				*(float*)(__InBuffer + 8) = InDomainMax;

				*(float*)(__InBuffer + 12) = InRangeMin;

				*(float*)(__InBuffer + 16) = InRangeMax;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetLinearFrequency, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __GetLogFrequency = 0;

		private static uint __GetLinearFrequency = 0;
	}
}
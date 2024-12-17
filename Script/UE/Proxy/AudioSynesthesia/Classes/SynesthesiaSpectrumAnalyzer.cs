using Script.CoreUObject;
using Script.AudioAnalyzer;
using Script.Library;

namespace Script.AudioSynesthesia
{
	[PathName("/Script/AudioSynesthesia.SynesthesiaSpectrumAnalyzer")]
	public partial class USynesthesiaSpectrumAnalyzer : UAudioAnalyzer, IStaticClass
	{
		public USynesthesiaSpectrumAnalysisSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(USynesthesiaSpectrumAnalysisSettings*)__ReturnBuffer;
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

		public FOnSpectrumResults OnSpectrumResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSpectrumResults, __ReturnBuffer);

					return *(FOnSpectrumResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSpectrumResults, __InBuffer);
				}
			}
		}

		public FOnLatestSpectrumResults OnLatestSpectrumResults
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestSpectrumResults, __ReturnBuffer);

					return *(FOnLatestSpectrumResults*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLatestSpectrumResults, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AudioSynesthesia.SynesthesiaSpectrumAnalyzer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual int GetNumCenterFrequencies()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumCenterFrequencies, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetCenterFrequencies(float InSampleRate, ref TArray<float> OutCenterFrequencies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = InSampleRate;

				*(nint*)(__InBuffer + 4) = OutCenterFrequencies?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetCenterFrequencies, __InBuffer, __OutBuffer);

				OutCenterFrequencies = *(TArray<float>*)(__OutBuffer);

			}
		}

		private static uint __Settings = 0;

		private static uint __OnSpectrumResults = 0;

		private static uint __OnLatestSpectrumResults = 0;

		private static uint __GetNumCenterFrequencies = 0;

		private static uint __GetCenterFrequencies = 0;
	}
}
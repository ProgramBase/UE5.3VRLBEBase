using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectFilterPreset")]
	public partial class USubmixEffectFilterPreset : USoundEffectSubmixPreset, IStaticClass
	{
		public FSubmixEffectFilterSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSubmixEffectFilterSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SubmixEffectFilterPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettings(FSubmixEffectFilterSettings InSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void SetFilterType(ESubmixFilterType InType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterType, __InBuffer);
			}
		}

		public virtual void SetFilterQMod(float InQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InQ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterQMod, __InBuffer);
			}
		}

		public virtual void SetFilterQ(float InQ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InQ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterQ, __InBuffer);
			}
		}

		public virtual void SetFilterCutoffFrequencyMod(float InFrequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFrequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterCutoffFrequencyMod, __InBuffer);
			}
		}

		public virtual void SetFilterCutoffFrequency(float InFrequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InFrequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterCutoffFrequency, __InBuffer);
			}
		}

		public virtual void SetFilterAlgorithm(ESubmixFilterAlgorithm InAlgorithm)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)InAlgorithm;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFilterAlgorithm, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetSettings = 0;

		private static uint __SetFilterType = 0;

		private static uint __SetFilterQMod = 0;

		private static uint __SetFilterQ = 0;

		private static uint __SetFilterCutoffFrequencyMod = 0;

		private static uint __SetFilterCutoffFrequency = 0;

		private static uint __SetFilterAlgorithm = 0;
	}
}
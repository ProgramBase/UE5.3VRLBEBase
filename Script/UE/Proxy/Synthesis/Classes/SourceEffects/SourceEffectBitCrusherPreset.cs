using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectBitCrusherPreset")]
	public partial class USourceEffectBitCrusherPreset : USoundEffectSourcePreset, IStaticClass
	{
		public FSourceEffectBitCrusherSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSourceEffectBitCrusherSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SourceEffectBitCrusherPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSettings(FSourceEffectBitCrusherBaseSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void SetSampleRateModulators(TSet<USoundModulatorBase> InModulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InModulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSampleRateModulators, __InBuffer);
			}
		}

		public virtual void SetSampleRateModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSampleRateModulator, __InBuffer);
			}
		}

		public virtual void SetSampleRate(float SampleRate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = SampleRate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSampleRate, __InBuffer);
			}
		}

		public virtual void SetModulationSettings(FSourceEffectBitCrusherSettings ModulationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModulationSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModulationSettings, __InBuffer);
			}
		}

		public virtual void SetBits(float Bits)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Bits;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBits, __InBuffer);
			}
		}

		public virtual void SetBitModulators(TSet<USoundModulatorBase> InModulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InModulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBitModulators, __InBuffer);
			}
		}

		public virtual void SetBitModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBitModulator, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetSettings = 0;

		private static uint __SetSampleRateModulators = 0;

		private static uint __SetSampleRateModulator = 0;

		private static uint __SetSampleRate = 0;

		private static uint __SetModulationSettings = 0;

		private static uint __SetBits = 0;

		private static uint __SetBitModulators = 0;

		private static uint __SetBitModulator = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.AudioExtensions;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectChorusPreset")]
	public partial class USourceEffectChorusPreset : USoundEffectSourcePreset, IStaticClass
	{
		public FSourceEffectChorusSettings Settings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Settings, __ReturnBuffer);

					return *(FSourceEffectChorusSettings*)__ReturnBuffer;
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
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Synthesis.SourceEffectChorusPreset");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWetModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWetModulators, __InBuffer);
			}
		}

		public virtual void SetWetModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWetModulator, __InBuffer);
			}
		}

		public virtual void SetWet(float WetAmount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = WetAmount;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWet, __InBuffer);
			}
		}

		public virtual void SetSpreadModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpreadModulators, __InBuffer);
			}
		}

		public virtual void SetSpreadModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpreadModulator, __InBuffer);
			}
		}

		public virtual void SetSpread(float Spread)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Spread;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSpread, __InBuffer);
			}
		}

		public virtual void SetSettings(FSourceEffectChorusBaseSettings Settings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSettings, __InBuffer);
			}
		}

		public virtual void SetModulationSettings(FSourceEffectChorusSettings ModulationSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ModulationSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModulationSettings, __InBuffer);
			}
		}

		public virtual void SetFrequencyModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequencyModulators, __InBuffer);
			}
		}

		public virtual void SetFrequencyModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequencyModulator, __InBuffer);
			}
		}

		public virtual void SetFrequency(float Frequency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Frequency;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrequency, __InBuffer);
			}
		}

		public virtual void SetFeedbackModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFeedbackModulators, __InBuffer);
			}
		}

		public virtual void SetFeedbackModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFeedbackModulator, __InBuffer);
			}
		}

		public virtual void SetFeedback(float Feedback)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Feedback;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFeedback, __InBuffer);
			}
		}

		public virtual void SetDryModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDryModulators, __InBuffer);
			}
		}

		public virtual void SetDryModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDryModulator, __InBuffer);
			}
		}

		public virtual void SetDry(float DryAmount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DryAmount;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDry, __InBuffer);
			}
		}

		public virtual void SetDepthModulators(TSet<USoundModulatorBase> Modulators)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulators?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDepthModulators, __InBuffer);
			}
		}

		public virtual void SetDepthModulator(USoundModulatorBase Modulator)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Modulator?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDepthModulator, __InBuffer);
			}
		}

		public virtual void SetDepth(float Depth)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Depth;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDepth, __InBuffer);
			}
		}

		private static uint __Settings = 0;

		private static uint __SetWetModulators = 0;

		private static uint __SetWetModulator = 0;

		private static uint __SetWet = 0;

		private static uint __SetSpreadModulators = 0;

		private static uint __SetSpreadModulator = 0;

		private static uint __SetSpread = 0;

		private static uint __SetSettings = 0;

		private static uint __SetModulationSettings = 0;

		private static uint __SetFrequencyModulators = 0;

		private static uint __SetFrequencyModulator = 0;

		private static uint __SetFrequency = 0;

		private static uint __SetFeedbackModulators = 0;

		private static uint __SetFeedbackModulator = 0;

		private static uint __SetFeedback = 0;

		private static uint __SetDryModulators = 0;

		private static uint __SetDryModulator = 0;

		private static uint __SetDry = 0;

		private static uint __SetDepthModulators = 0;

		private static uint __SetDepthModulator = 0;

		private static uint __SetDepth = 0;
	}
}
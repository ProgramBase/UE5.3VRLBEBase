using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings")]
	public partial class FSourceEffectFilterAudioBusModulationSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectFilterAudioBusModulationSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectFilterAudioBusModulationSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectFilterAudioBusModulationSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectFilterAudioBusModulationSettings A, FSourceEffectFilterAudioBusModulationSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectFilterAudioBusModulationSettings A, FSourceEffectFilterAudioBusModulationSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectFilterAudioBusModulationSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAudioBus AudioBus
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __AudioBus, __ReturnBuffer);

					return *(UAudioBus*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __AudioBus, __InBuffer);
				}
			}
		}

		public int EnvelopeFollowerAttackTimeMsec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerAttackTimeMsec, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerAttackTimeMsec, __InBuffer);
				}
			}
		}

		public int EnvelopeFollowerReleaseTimeMsec
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerReleaseTimeMsec, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeFollowerReleaseTimeMsec, __InBuffer);
				}
			}
		}

		public float EnvelopeGainMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeGainMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EnvelopeGainMultiplier, __InBuffer);
				}
			}
		}

		public ESourceEffectFilterParam FilterParam
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterParam, __ReturnBuffer);

					return *(ESourceEffectFilterParam*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterParam, __InBuffer);
				}
			}
		}

		public float MinFrequencyModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinFrequencyModulation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinFrequencyModulation, __InBuffer);
				}
			}
		}

		public float MaxFrequencyModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxFrequencyModulation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxFrequencyModulation, __InBuffer);
				}
			}
		}

		public float MinResonanceModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MinResonanceModulation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MinResonanceModulation, __InBuffer);
				}
			}
		}

		public float MaxResonanceModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxResonanceModulation, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxResonanceModulation, __InBuffer);
				}
			}
		}

		private static uint __AudioBus = 0;

		private static uint __EnvelopeFollowerAttackTimeMsec = 0;

		private static uint __EnvelopeFollowerReleaseTimeMsec = 0;

		private static uint __EnvelopeGainMultiplier = 0;

		private static uint __FilterParam = 0;

		private static uint __MinFrequencyModulation = 0;

		private static uint __MaxFrequencyModulation = 0;

		private static uint __MinResonanceModulation = 0;

		private static uint __MaxResonanceModulation = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
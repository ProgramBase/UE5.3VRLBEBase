using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectBitCrusherSettings")]
	public partial class FSourceEffectBitCrusherSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectBitCrusherSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectBitCrusherSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectBitCrusherSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectBitCrusherSettings A, FSourceEffectBitCrusherSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectBitCrusherSettings A, FSourceEffectBitCrusherSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectBitCrusherSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float CrushedSampleRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CrushedSampleRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CrushedSampleRate, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings SampleRateModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SampleRateModulation, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SampleRateModulation, __InBuffer);
				}
			}
		}

		public float CrushedBits
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CrushedBits, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CrushedBits, __InBuffer);
				}
			}
		}

		public FSoundModulationDestinationSettings BitModulation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BitModulation, __ReturnBuffer);

					return *(FSoundModulationDestinationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BitModulation, __InBuffer);
				}
			}
		}

		private static uint __CrushedSampleRate = 0;

		private static uint __SampleRateModulation = 0;

		private static uint __CrushedBits = 0;

		private static uint __BitModulation = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
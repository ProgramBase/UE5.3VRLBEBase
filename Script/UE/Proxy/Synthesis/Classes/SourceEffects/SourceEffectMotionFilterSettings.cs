using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectMotionFilterSettings")]
	public partial class FSourceEffectMotionFilterSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectMotionFilterSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectMotionFilterSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectMotionFilterSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectMotionFilterSettings A, FSourceEffectMotionFilterSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectMotionFilterSettings A, FSourceEffectMotionFilterSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectMotionFilterSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESourceEffectMotionFilterTopology MotionFilterTopology
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MotionFilterTopology, __ReturnBuffer);

					return *(ESourceEffectMotionFilterTopology*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MotionFilterTopology, __InBuffer);
				}
			}
		}

		public float MotionFilterMix
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MotionFilterMix, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MotionFilterMix, __InBuffer);
				}
			}
		}

		public FSourceEffectIndividualFilterSettings FilterASettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterASettings, __ReturnBuffer);

					return *(FSourceEffectIndividualFilterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterASettings, __InBuffer);
				}
			}
		}

		public FSourceEffectIndividualFilterSettings FilterBSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterBSettings, __ReturnBuffer);

					return *(FSourceEffectIndividualFilterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterBSettings, __InBuffer);
				}
			}
		}

		public TMap<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings> ModulationMappings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ModulationMappings, __ReturnBuffer);

					return *(TMap<ESourceEffectMotionFilterModDestination, FSourceEffectMotionFilterModulationSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ModulationMappings, __InBuffer);
				}
			}
		}

		public float DryVolumeDb
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DryVolumeDb, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DryVolumeDb, __InBuffer);
				}
			}
		}

		private static uint __MotionFilterTopology = 0;

		private static uint __MotionFilterMix = 0;

		private static uint __FilterASettings = 0;

		private static uint __FilterBSettings = 0;

		private static uint __ModulationMappings = 0;

		private static uint __DryVolumeDb = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
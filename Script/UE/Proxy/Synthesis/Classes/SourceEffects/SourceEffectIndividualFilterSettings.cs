using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SourceEffectIndividualFilterSettings")]
	public partial class FSourceEffectIndividualFilterSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SourceEffectIndividualFilterSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSourceEffectIndividualFilterSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSourceEffectIndividualFilterSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSourceEffectIndividualFilterSettings A, FSourceEffectIndividualFilterSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSourceEffectIndividualFilterSettings A, FSourceEffectIndividualFilterSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSourceEffectIndividualFilterSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESourceEffectMotionFilterCircuit FilterCircuit
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterCircuit, __ReturnBuffer);

					return *(ESourceEffectMotionFilterCircuit*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterCircuit, __InBuffer);
				}
			}
		}

		public ESourceEffectMotionFilterType FilterType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterType, __ReturnBuffer);

					return *(ESourceEffectMotionFilterType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterType, __InBuffer);
				}
			}
		}

		public float CutoffFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CutoffFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CutoffFrequency, __InBuffer);
				}
			}
		}

		public float FilterQ
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterQ, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterQ, __InBuffer);
				}
			}
		}

		private static uint __FilterCircuit = 0;

		private static uint __FilterType = 0;

		private static uint __CutoffFrequency = 0;

		private static uint __FilterQ = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
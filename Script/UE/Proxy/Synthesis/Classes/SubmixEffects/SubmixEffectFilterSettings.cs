using Script.CoreUObject;
using Script.Library;

namespace Script.Synthesis
{
	[PathName("/Script/Synthesis.SubmixEffectFilterSettings")]
	public partial class FSubmixEffectFilterSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Synthesis.SubmixEffectFilterSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubmixEffectFilterSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSubmixEffectFilterSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSubmixEffectFilterSettings A, FSubmixEffectFilterSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubmixEffectFilterSettings A, FSubmixEffectFilterSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubmixEffectFilterSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ESubmixFilterType FilterType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterType, __ReturnBuffer);

					return *(ESubmixFilterType*)__ReturnBuffer;
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

		public ESubmixFilterAlgorithm FilterAlgorithm
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterAlgorithm, __ReturnBuffer);

					return *(ESubmixFilterAlgorithm*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterAlgorithm, __InBuffer);
				}
			}
		}

		public float FilterFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FilterFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FilterFrequency, __InBuffer);
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

		private static uint __FilterType = 0;

		private static uint __FilterAlgorithm = 0;

		private static uint __FilterFrequency = 0;

		private static uint __FilterQ = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
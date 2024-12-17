using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPerfBaselineStats")]
	public partial class FNiagaraPerfBaselineStats : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraPerfBaselineStats");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraPerfBaselineStats() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraPerfBaselineStats() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraPerfBaselineStats A, FNiagaraPerfBaselineStats B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraPerfBaselineStats A, FNiagaraPerfBaselineStats B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraPerfBaselineStats;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float PerInstanceAvg_GT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceAvg_GT, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceAvg_GT, __InBuffer);
				}
			}
		}

		public float PerInstanceAvg_RT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceAvg_RT, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceAvg_RT, __InBuffer);
				}
			}
		}

		public float PerInstanceMax_GT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceMax_GT, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceMax_GT, __InBuffer);
				}
			}
		}

		public float PerInstanceMax_RT
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceMax_RT, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerInstanceMax_RT, __InBuffer);
				}
			}
		}

		private static uint __PerInstanceAvg_GT = 0;

		private static uint __PerInstanceAvg_RT = 0;

		private static uint __PerInstanceMax_GT = 0;

		private static uint __PerInstanceMax_RT = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
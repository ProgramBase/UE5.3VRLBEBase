using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraGlobalBudgetScaling")]
	public partial class FNiagaraGlobalBudgetScaling : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraGlobalBudgetScaling");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraGlobalBudgetScaling() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraGlobalBudgetScaling() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraGlobalBudgetScaling A, FNiagaraGlobalBudgetScaling B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraGlobalBudgetScaling A, FNiagaraGlobalBudgetScaling B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraGlobalBudgetScaling;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCullByGlobalBudget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCullByGlobalBudget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCullByGlobalBudget, __InBuffer);
				}
			}
		}

		public bool bScaleMaxDistanceByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bScaleMaxDistanceByGlobalBudgetUse, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bScaleMaxDistanceByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		public bool bScaleMaxInstanceCountByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bScaleMaxInstanceCountByGlobalBudgetUse, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bScaleMaxInstanceCountByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		public bool bScaleSystemInstanceCountByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bScaleSystemInstanceCountByGlobalBudgetUse, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bScaleSystemInstanceCountByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		public float MaxGlobalBudgetUsage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxGlobalBudgetUsage, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxGlobalBudgetUsage, __InBuffer);
				}
			}
		}

		public FNiagaraLinearRamp MaxDistanceScaleByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxDistanceScaleByGlobalBudgetUse, __ReturnBuffer);

					return *(FNiagaraLinearRamp*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxDistanceScaleByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		public FNiagaraLinearRamp MaxInstanceCountScaleByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxInstanceCountScaleByGlobalBudgetUse, __ReturnBuffer);

					return *(FNiagaraLinearRamp*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxInstanceCountScaleByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		public FNiagaraLinearRamp MaxSystemInstanceCountScaleByGlobalBudgetUse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MaxSystemInstanceCountScaleByGlobalBudgetUse, __ReturnBuffer);

					return *(FNiagaraLinearRamp*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MaxSystemInstanceCountScaleByGlobalBudgetUse, __InBuffer);
				}
			}
		}

		private static uint __bCullByGlobalBudget = 0;

		private static uint __bScaleMaxDistanceByGlobalBudgetUse = 0;

		private static uint __bScaleMaxInstanceCountByGlobalBudgetUse = 0;

		private static uint __bScaleSystemInstanceCountByGlobalBudgetUse = 0;

		private static uint __MaxGlobalBudgetUsage = 0;

		private static uint __MaxDistanceScaleByGlobalBudgetUse = 0;

		private static uint __MaxInstanceCountScaleByGlobalBudgetUse = 0;

		private static uint __MaxSystemInstanceCountScaleByGlobalBudgetUse = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
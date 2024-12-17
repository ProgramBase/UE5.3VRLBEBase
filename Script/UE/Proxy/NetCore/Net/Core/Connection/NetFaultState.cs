using Script.CoreUObject;
using Script.Library;

namespace Script.NetCore
{
	[PathName("/Script/NetCore.NetFaultState")]
	public partial class FNetFaultState : FEscalationState, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NetCore.NetFaultState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNetFaultState()
		{
		}

		public static bool operator ==(FNetFaultState A, FNetFaultState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNetFaultState A, FNetFaultState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNetFaultState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCloseConnection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCloseConnection, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCloseConnection, __InBuffer);
				}
			}
		}

		public short EscalateQuotaFaultsPerPeriod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaFaultsPerPeriod, __ReturnBuffer);

					return *(short*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(short*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaFaultsPerPeriod, __InBuffer);
				}
			}
		}

		public sbyte EscalateQuotaFaultPercentPerPeriod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaFaultPercentPerPeriod, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaFaultPercentPerPeriod, __InBuffer);
				}
			}
		}

		public short DescalateQuotaFaultsPerPeriod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DescalateQuotaFaultsPerPeriod, __ReturnBuffer);

					return *(short*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(short*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DescalateQuotaFaultsPerPeriod, __InBuffer);
				}
			}
		}

		public sbyte DescalateQuotaFaultPercentPerPeriod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DescalateQuotaFaultPercentPerPeriod, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DescalateQuotaFaultPercentPerPeriod, __InBuffer);
				}
			}
		}

		public sbyte EscalateQuotaTimePeriod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaTimePeriod, __ReturnBuffer);

					return *(sbyte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(sbyte*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EscalateQuotaTimePeriod, __InBuffer);
				}
			}
		}

		private static uint __bCloseConnection = 0;

		private static uint __EscalateQuotaFaultsPerPeriod = 0;

		private static uint __EscalateQuotaFaultPercentPerPeriod = 0;

		private static uint __DescalateQuotaFaultsPerPeriod = 0;

		private static uint __DescalateQuotaFaultPercentPerPeriod = 0;

		private static uint __EscalateQuotaTimePeriod = 0;

	}
}
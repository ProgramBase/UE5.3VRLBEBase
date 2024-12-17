using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemScalabilityOverride")]
	public partial class FNiagaraSystemScalabilityOverride : FNiagaraSystemScalabilitySettings, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemScalabilityOverride");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemScalabilityOverride()
		{
		}

		public static bool operator ==(FNiagaraSystemScalabilityOverride A, FNiagaraSystemScalabilityOverride B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemScalabilityOverride A, FNiagaraSystemScalabilityOverride B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemScalabilityOverride;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bOverrideDistanceSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideDistanceSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideDistanceSettings, __InBuffer);
				}
			}
		}

		public bool bOverrideInstanceCountSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideInstanceCountSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideInstanceCountSettings, __InBuffer);
				}
			}
		}

		public bool bOverridePerSystemInstanceCountSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverridePerSystemInstanceCountSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverridePerSystemInstanceCountSettings, __InBuffer);
				}
			}
		}

		public bool bOverrideVisibilitySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideVisibilitySettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideVisibilitySettings, __InBuffer);
				}
			}
		}

		public bool bOverrideGlobalBudgetScalingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideGlobalBudgetScalingSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideGlobalBudgetScalingSettings, __InBuffer);
				}
			}
		}

		public bool bOverrideCullProxySettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideCullProxySettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bOverrideCullProxySettings, __InBuffer);
				}
			}
		}

		private static uint __bOverrideDistanceSettings = 0;

		private static uint __bOverrideInstanceCountSettings = 0;

		private static uint __bOverridePerSystemInstanceCountSettings = 0;

		private static uint __bOverrideVisibilitySettings = 0;

		private static uint __bOverrideGlobalBudgetScalingSettings = 0;

		private static uint __bOverrideCullProxySettings = 0;

	}
}
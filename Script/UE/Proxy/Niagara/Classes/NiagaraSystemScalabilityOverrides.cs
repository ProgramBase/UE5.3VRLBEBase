using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraSystemScalabilityOverrides")]
	public partial class FNiagaraSystemScalabilityOverrides : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraSystemScalabilityOverrides");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSystemScalabilityOverrides() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraSystemScalabilityOverrides() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraSystemScalabilityOverrides A, FNiagaraSystemScalabilityOverrides B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSystemScalabilityOverrides A, FNiagaraSystemScalabilityOverrides B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSystemScalabilityOverrides;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FNiagaraSystemScalabilityOverride> Overrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Overrides, __ReturnBuffer);

					return *(TArray<FNiagaraSystemScalabilityOverride>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Overrides, __InBuffer);
				}
			}
		}

		private static uint __Overrides = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScalabilityManager")]
	public partial class FNiagaraScalabilityManager : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScalabilityManager");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScalabilityManager() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraScalabilityManager() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraScalabilityManager A, FNiagaraScalabilityManager B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScalabilityManager A, FNiagaraScalabilityManager B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScalabilityManager;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UNiagaraEffectType EffectType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EffectType, __ReturnBuffer);

					return *(UNiagaraEffectType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EffectType, __InBuffer);
				}
			}
		}

		public TArray<UNiagaraComponent> ManagedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ManagedComponents, __ReturnBuffer);

					return *(TArray<UNiagaraComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ManagedComponents, __InBuffer);
				}
			}
		}

		private static uint __EffectType = 0;

		private static uint __ManagedComponents = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraResolvedUserDataInterfaceBinding")]
	public partial class FNiagaraResolvedUserDataInterfaceBinding : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraResolvedUserDataInterfaceBinding");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraResolvedUserDataInterfaceBinding() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraResolvedUserDataInterfaceBinding() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraResolvedUserDataInterfaceBinding A, FNiagaraResolvedUserDataInterfaceBinding B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraResolvedUserDataInterfaceBinding A, FNiagaraResolvedUserDataInterfaceBinding B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraResolvedUserDataInterfaceBinding;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
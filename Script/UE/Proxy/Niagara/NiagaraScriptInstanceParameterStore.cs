using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraScriptInstanceParameterStore")]
	public partial class FNiagaraScriptInstanceParameterStore : FNiagaraParameterStore, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraScriptInstanceParameterStore");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraScriptInstanceParameterStore()
		{
		}

		public static bool operator ==(FNiagaraScriptInstanceParameterStore A, FNiagaraScriptInstanceParameterStore B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraScriptInstanceParameterStore A, FNiagaraScriptInstanceParameterStore B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraScriptInstanceParameterStore;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
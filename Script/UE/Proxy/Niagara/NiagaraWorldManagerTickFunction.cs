using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraWorldManagerTickFunction")]
	public partial class FNiagaraWorldManagerTickFunction : FTickFunction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraWorldManagerTickFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraWorldManagerTickFunction()
		{
		}

		public static bool operator ==(FNiagaraWorldManagerTickFunction A, FNiagaraWorldManagerTickFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraWorldManagerTickFunction A, FNiagaraWorldManagerTickFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraWorldManagerTickFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
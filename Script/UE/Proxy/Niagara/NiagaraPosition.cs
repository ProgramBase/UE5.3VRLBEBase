using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraPosition")]
	public partial class FNiagaraPosition : FVector3f, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraPosition");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraPosition()
		{
		}

		public static bool operator ==(FNiagaraPosition A, FNiagaraPosition B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraPosition A, FNiagaraPosition B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraPosition;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Niagara
{
	[PathName("/Script/Niagara.NiagaraRequestSimpleClientInfoMessage")]
	public partial class FNiagaraRequestSimpleClientInfoMessage : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Niagara.NiagaraRequestSimpleClientInfoMessage");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraRequestSimpleClientInfoMessage() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraRequestSimpleClientInfoMessage() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraRequestSimpleClientInfoMessage A, FNiagaraRequestSimpleClientInfoMessage B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraRequestSimpleClientInfoMessage A, FNiagaraRequestSimpleClientInfoMessage B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraRequestSimpleClientInfoMessage;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
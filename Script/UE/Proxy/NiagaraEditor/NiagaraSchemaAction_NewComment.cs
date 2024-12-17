using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSchemaAction_NewComment")]
	public partial class FNiagaraSchemaAction_NewComment : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraSchemaAction_NewComment");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSchemaAction_NewComment()
		{
		}

		public static bool operator ==(FNiagaraSchemaAction_NewComment A, FNiagaraSchemaAction_NewComment B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSchemaAction_NewComment A, FNiagaraSchemaAction_NewComment B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSchemaAction_NewComment;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
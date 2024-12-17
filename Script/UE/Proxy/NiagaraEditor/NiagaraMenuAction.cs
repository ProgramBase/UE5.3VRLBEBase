using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraMenuAction")]
	public partial class FNiagaraMenuAction : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraMenuAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraMenuAction()
		{
		}

		public static bool operator ==(FNiagaraMenuAction A, FNiagaraMenuAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraMenuAction A, FNiagaraMenuAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraMenuAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
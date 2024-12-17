using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraParameterBindingAction")]
	public partial class FNiagaraParameterBindingAction : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraParameterBindingAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraParameterBindingAction()
		{
		}

		public static bool operator ==(FNiagaraParameterBindingAction A, FNiagaraParameterBindingAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraParameterBindingAction A, FNiagaraParameterBindingAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraParameterBindingAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
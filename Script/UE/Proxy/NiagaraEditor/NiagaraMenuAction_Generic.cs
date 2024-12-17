using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraMenuAction_Generic")]
	public partial class FNiagaraMenuAction_Generic : FNiagaraMenuAction_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraMenuAction_Generic");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraMenuAction_Generic()
		{
		}

		public static bool operator ==(FNiagaraMenuAction_Generic A, FNiagaraMenuAction_Generic B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraMenuAction_Generic A, FNiagaraMenuAction_Generic B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraMenuAction_Generic;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
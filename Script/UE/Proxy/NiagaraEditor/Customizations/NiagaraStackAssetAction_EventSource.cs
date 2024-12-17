using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraStackAssetAction_EventSource")]
	public partial class FNiagaraStackAssetAction_EventSource : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraStackAssetAction_EventSource");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraStackAssetAction_EventSource()
		{
		}

		public static bool operator ==(FNiagaraStackAssetAction_EventSource A, FNiagaraStackAssetAction_EventSource B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraStackAssetAction_EventSource A, FNiagaraStackAssetAction_EventSource B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraStackAssetAction_EventSource;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
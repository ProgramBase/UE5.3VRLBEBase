using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraBakerTextureSourceAction")]
	public partial class FNiagaraBakerTextureSourceAction : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraBakerTextureSourceAction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraBakerTextureSourceAction()
		{
		}

		public static bool operator ==(FNiagaraBakerTextureSourceAction A, FNiagaraBakerTextureSourceAction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraBakerTextureSourceAction A, FNiagaraBakerTextureSourceAction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraBakerTextureSourceAction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
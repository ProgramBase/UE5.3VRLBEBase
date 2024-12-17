using Script.CoreUObject;
using Script.Library;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraMenuAction_Base")]
	public partial class FNiagaraMenuAction_Base : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraMenuAction_Base");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraMenuAction_Base() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FNiagaraMenuAction_Base() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FNiagaraMenuAction_Base A, FNiagaraMenuAction_Base B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraMenuAction_Base A, FNiagaraMenuAction_Base B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraMenuAction_Base;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
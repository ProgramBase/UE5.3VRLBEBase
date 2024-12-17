using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraAction_NewNode")]
	public partial class FNiagaraAction_NewNode : FNiagaraMenuAction_Generic, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraAction_NewNode()
		{
		}

		public static bool operator ==(FNiagaraAction_NewNode A, FNiagaraAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraAction_NewNode A, FNiagaraAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UEdGraphNode NodeTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeTemplate, __ReturnBuffer);

					return *(UEdGraphNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeTemplate, __InBuffer);
				}
			}
		}

		private static uint __NodeTemplate = 0;

	}
}
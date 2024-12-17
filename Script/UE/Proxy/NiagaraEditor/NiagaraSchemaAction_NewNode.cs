using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.NiagaraEditor
{
	[PathName("/Script/NiagaraEditor.NiagaraSchemaAction_NewNode")]
	public partial class FNiagaraSchemaAction_NewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/NiagaraEditor.NiagaraSchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FNiagaraSchemaAction_NewNode()
		{
		}

		public static bool operator ==(FNiagaraSchemaAction_NewNode A, FNiagaraSchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FNiagaraSchemaAction_NewNode A, FNiagaraSchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FNiagaraSchemaAction_NewNode;

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

		public FName InternalName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InternalName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InternalName, __InBuffer);
				}
			}
		}

		private static uint __NodeTemplate = 0;

		private static uint __InternalName = 0;

	}
}
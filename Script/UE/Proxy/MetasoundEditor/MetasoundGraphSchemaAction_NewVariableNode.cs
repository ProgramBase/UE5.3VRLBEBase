using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableNode")]
	public partial class FMetasoundGraphSchemaAction_NewVariableNode : FMetasoundGraphSchemaAction_NodeWithMultipleOutputs, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewVariableNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewVariableNode()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewVariableNode A, FMetasoundGraphSchemaAction_NewVariableNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewVariableNode A, FMetasoundGraphSchemaAction_NewVariableNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewVariableNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid VariableID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VariableID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VariableID, __InBuffer);
				}
			}
		}

		private static uint __VariableID = 0;

	}
}
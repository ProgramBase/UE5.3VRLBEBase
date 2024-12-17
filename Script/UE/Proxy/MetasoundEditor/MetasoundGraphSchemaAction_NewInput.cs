using Script.CoreUObject;
using Script.Library;

namespace Script.MetasoundEditor
{
	[PathName("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewInput")]
	public partial class FMetasoundGraphSchemaAction_NewInput : FMetasoundGraphSchemaAction_NodeWithMultipleOutputs, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MetasoundEditor.MetasoundGraphSchemaAction_NewInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMetasoundGraphSchemaAction_NewInput()
		{
		}

		public static bool operator ==(FMetasoundGraphSchemaAction_NewInput A, FMetasoundGraphSchemaAction_NewInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMetasoundGraphSchemaAction_NewInput A, FMetasoundGraphSchemaAction_NewInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMetasoundGraphSchemaAction_NewInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid NodeID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodeID, __InBuffer);
				}
			}
		}

		private static uint __NodeID = 0;

	}
}
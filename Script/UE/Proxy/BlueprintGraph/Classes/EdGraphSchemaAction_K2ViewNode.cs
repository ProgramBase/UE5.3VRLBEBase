using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_K2ViewNode")]
	public partial class FEdGraphSchemaAction_K2ViewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_K2ViewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_K2ViewNode()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_K2ViewNode A, FEdGraphSchemaAction_K2ViewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_K2ViewNode A, FEdGraphSchemaAction_K2ViewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_K2ViewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UK2Node NodePtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodePtr, __ReturnBuffer);

					return *(UK2Node*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NodePtr, __InBuffer);
				}
			}
		}

		private static uint __NodePtr = 0;

	}
}
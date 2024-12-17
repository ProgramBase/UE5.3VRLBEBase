using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AIGraph
{
	[PathName("/Script/AIGraph.AISchemaAction_NewNode")]
	public partial class FAISchemaAction_NewNode : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AIGraph.AISchemaAction_NewNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAISchemaAction_NewNode()
		{
		}

		public static bool operator ==(FAISchemaAction_NewNode A, FAISchemaAction_NewNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAISchemaAction_NewNode A, FAISchemaAction_NewNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAISchemaAction_NewNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UAIGraphNode NodeTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NodeTemplate, __ReturnBuffer);

					return *(UAIGraphNode*)__ReturnBuffer;
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
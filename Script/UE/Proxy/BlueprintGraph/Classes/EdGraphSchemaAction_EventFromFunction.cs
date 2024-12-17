using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.BlueprintGraph
{
	[PathName("/Script/BlueprintGraph.EdGraphSchemaAction_EventFromFunction")]
	public partial class FEdGraphSchemaAction_EventFromFunction : FEdGraphSchemaAction, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/BlueprintGraph.EdGraphSchemaAction_EventFromFunction");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FEdGraphSchemaAction_EventFromFunction()
		{
		}

		public static bool operator ==(FEdGraphSchemaAction_EventFromFunction A, FEdGraphSchemaAction_EventFromFunction B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FEdGraphSchemaAction_EventFromFunction A, FEdGraphSchemaAction_EventFromFunction B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FEdGraphSchemaAction_EventFromFunction;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UFunction SignatureFunction
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SignatureFunction, __ReturnBuffer);

					return *(UFunction*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SignatureFunction, __InBuffer);
				}
			}
		}

		private static uint __SignatureFunction = 0;

	}
}
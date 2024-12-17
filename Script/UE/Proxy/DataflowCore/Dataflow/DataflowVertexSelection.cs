using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowVertexSelection")]
	public partial class FDataflowVertexSelection : FDataflowSelection, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowVertexSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowVertexSelection()
		{
		}

		public static bool operator ==(FDataflowVertexSelection A, FDataflowVertexSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowVertexSelection A, FDataflowVertexSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowVertexSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
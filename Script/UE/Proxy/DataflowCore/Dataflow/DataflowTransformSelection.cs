using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowTransformSelection")]
	public partial class FDataflowTransformSelection : FDataflowSelection, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowTransformSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowTransformSelection()
		{
		}

		public static bool operator ==(FDataflowTransformSelection A, FDataflowTransformSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowTransformSelection A, FDataflowTransformSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowTransformSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
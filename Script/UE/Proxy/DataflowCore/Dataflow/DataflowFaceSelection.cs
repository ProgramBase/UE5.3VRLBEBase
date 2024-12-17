using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowFaceSelection")]
	public partial class FDataflowFaceSelection : FDataflowSelection, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowFaceSelection");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowFaceSelection()
		{
		}

		public static bool operator ==(FDataflowFaceSelection A, FDataflowFaceSelection B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowFaceSelection A, FDataflowFaceSelection B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowFaceSelection;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
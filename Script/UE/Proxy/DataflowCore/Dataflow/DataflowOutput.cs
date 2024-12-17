using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowOutput")]
	public partial class FDataflowOutput : FDataflowConnection, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowOutput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowOutput()
		{
		}

		public static bool operator ==(FDataflowOutput A, FDataflowOutput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowOutput A, FDataflowOutput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowOutput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
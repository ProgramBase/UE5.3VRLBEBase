using Script.CoreUObject;
using Script.Library;

namespace Script.DataflowCore
{
	[PathName("/Script/DataflowCore.DataflowTerminalNode")]
	public partial class FDataflowTerminalNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/DataflowCore.DataflowTerminalNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataflowTerminalNode()
		{
		}

		public static bool operator ==(FDataflowTerminalNode A, FDataflowTerminalNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataflowTerminalNode A, FDataflowTerminalNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataflowTerminalNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.DivideDataflowNode")]
	public partial class FDivideDataflowNode : FSafeDivideDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.DivideDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDivideDataflowNode()
		{
		}

		public static bool operator ==(FDivideDataflowNode A, FDivideDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDivideDataflowNode A, FDivideDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDivideDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
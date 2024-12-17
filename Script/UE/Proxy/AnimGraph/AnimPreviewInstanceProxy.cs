using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimPreviewInstanceProxy")]
	public partial class FAnimPreviewInstanceProxy : FAnimSingleNodeInstanceProxy, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraph.AnimPreviewInstanceProxy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimPreviewInstanceProxy()
		{
		}

		public static bool operator ==(FAnimPreviewInstanceProxy A, FAnimPreviewInstanceProxy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimPreviewInstanceProxy A, FAnimPreviewInstanceProxy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimPreviewInstanceProxy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
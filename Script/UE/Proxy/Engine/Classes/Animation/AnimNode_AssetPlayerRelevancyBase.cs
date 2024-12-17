using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimNode_AssetPlayerRelevancyBase")]
	public partial class FAnimNode_AssetPlayerRelevancyBase : FAnimNode_Base, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.AnimNode_AssetPlayerRelevancyBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_AssetPlayerRelevancyBase()
		{
		}

		public static bool operator ==(FAnimNode_AssetPlayerRelevancyBase A, FAnimNode_AssetPlayerRelevancyBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_AssetPlayerRelevancyBase A, FAnimNode_AssetPlayerRelevancyBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_AssetPlayerRelevancyBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData")]
	public partial class FLiveLinkBaseBlueprintData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkBaseBlueprintData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkBaseBlueprintData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FLiveLinkBaseBlueprintData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FLiveLinkBaseBlueprintData A, FLiveLinkBaseBlueprintData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkBaseBlueprintData A, FLiveLinkBaseBlueprintData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkBaseBlueprintData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkFrameRate")]
	public partial class FLiveLinkFrameRate : FFrameRate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkFrameRate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkFrameRate()
		{
		}

		public static bool operator ==(FLiveLinkFrameRate A, FLiveLinkFrameRate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkFrameRate A, FLiveLinkFrameRate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkFrameRate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
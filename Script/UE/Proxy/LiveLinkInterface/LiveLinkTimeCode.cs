using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.LiveLinkTimeCode")]
	public partial class FLiveLinkTimeCode : FLiveLinkTimeCode_Base_DEPRECATED, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.LiveLinkTimeCode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FLiveLinkTimeCode()
		{
		}

		public static bool operator ==(FLiveLinkTimeCode A, FLiveLinkTimeCode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FLiveLinkTimeCode A, FLiveLinkTimeCode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FLiveLinkTimeCode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
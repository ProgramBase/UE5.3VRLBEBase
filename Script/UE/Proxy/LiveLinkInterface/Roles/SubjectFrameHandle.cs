using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.SubjectFrameHandle")]
	public partial class FSubjectFrameHandle : FLiveLinkBaseBlueprintData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.SubjectFrameHandle");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSubjectFrameHandle()
		{
		}

		public static bool operator ==(FSubjectFrameHandle A, FSubjectFrameHandle B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSubjectFrameHandle A, FSubjectFrameHandle B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSubjectFrameHandle;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

	}
}
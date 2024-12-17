using Script.CoreUObject;
using Script.Library;

namespace Script.LiveLinkInterface
{
	[PathName("/Script/LiveLinkInterface.CachedSubjectFrame")]
	public partial class FCachedSubjectFrame : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/LiveLinkInterface.CachedSubjectFrame");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCachedSubjectFrame() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCachedSubjectFrame() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCachedSubjectFrame A, FCachedSubjectFrame B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCachedSubjectFrame A, FCachedSubjectFrame B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCachedSubjectFrame;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
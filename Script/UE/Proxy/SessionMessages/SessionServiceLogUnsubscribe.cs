using Script.CoreUObject;
using Script.Library;

namespace Script.SessionMessages
{
	[PathName("/Script/SessionMessages.SessionServiceLogUnsubscribe")]
	public partial class FSessionServiceLogUnsubscribe : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SessionMessages.SessionServiceLogUnsubscribe");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSessionServiceLogUnsubscribe() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSessionServiceLogUnsubscribe() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSessionServiceLogUnsubscribe A, FSessionServiceLogUnsubscribe B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSessionServiceLogUnsubscribe A, FSessionServiceLogUnsubscribe B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSessionServiceLogUnsubscribe;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
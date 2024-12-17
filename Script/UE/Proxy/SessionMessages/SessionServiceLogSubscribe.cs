using Script.CoreUObject;
using Script.Library;

namespace Script.SessionMessages
{
	[PathName("/Script/SessionMessages.SessionServiceLogSubscribe")]
	public partial class FSessionServiceLogSubscribe : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/SessionMessages.SessionServiceLogSubscribe");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSessionServiceLogSubscribe() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSessionServiceLogSubscribe() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSessionServiceLogSubscribe A, FSessionServiceLogSubscribe B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSessionServiceLogSubscribe A, FSessionServiceLogSubscribe B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSessionServiceLogSubscribe;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
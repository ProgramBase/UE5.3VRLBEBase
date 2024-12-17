using Script.CoreUObject;
using Script.Library;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.CacheEventBase")]
	public partial class FCacheEventBase : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.CacheEventBase");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCacheEventBase() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FCacheEventBase() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FCacheEventBase A, FCacheEventBase B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCacheEventBase A, FCacheEventBase B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCacheEventBase;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
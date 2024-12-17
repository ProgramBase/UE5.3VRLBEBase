using Script.CoreUObject;
using Script.Library;

namespace Script.CoreOnline
{
	[PathName("/Script/CoreOnline.UniqueNetIdWrapper")]
	public partial class FUniqueNetIdWrapper : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreOnline.UniqueNetIdWrapper");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FUniqueNetIdWrapper() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FUniqueNetIdWrapper() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FUniqueNetIdWrapper A, FUniqueNetIdWrapper B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FUniqueNetIdWrapper A, FUniqueNetIdWrapper B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FUniqueNetIdWrapper;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DataCacheDuplicatedObjectData")]
	public partial class FDataCacheDuplicatedObjectData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.DataCacheDuplicatedObjectData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FDataCacheDuplicatedObjectData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FDataCacheDuplicatedObjectData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FDataCacheDuplicatedObjectData A, FDataCacheDuplicatedObjectData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FDataCacheDuplicatedObjectData A, FDataCacheDuplicatedObjectData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FDataCacheDuplicatedObjectData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
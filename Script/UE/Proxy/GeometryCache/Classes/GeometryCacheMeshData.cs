using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheMeshData")]
	public partial class FGeometryCacheMeshData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCache.GeometryCacheMeshData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCacheMeshData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCacheMeshData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCacheMeshData A, FGeometryCacheMeshData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCacheMeshData A, FGeometryCacheMeshData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCacheMeshData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheMeshBatchInfo")]
	public partial class FGeometryCacheMeshBatchInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCache.GeometryCacheMeshBatchInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCacheMeshBatchInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCacheMeshBatchInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCacheMeshBatchInfo A, FGeometryCacheMeshBatchInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCacheMeshBatchInfo A, FGeometryCacheMeshBatchInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCacheMeshBatchInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
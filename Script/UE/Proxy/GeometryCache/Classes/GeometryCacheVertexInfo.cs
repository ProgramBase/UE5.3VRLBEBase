using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCache
{
	[PathName("/Script/GeometryCache.GeometryCacheVertexInfo")]
	public partial class FGeometryCacheVertexInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCache.GeometryCacheVertexInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCacheVertexInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCacheVertexInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCacheVertexInfo A, FGeometryCacheVertexInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCacheVertexInfo A, FGeometryCacheVertexInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCacheVertexInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
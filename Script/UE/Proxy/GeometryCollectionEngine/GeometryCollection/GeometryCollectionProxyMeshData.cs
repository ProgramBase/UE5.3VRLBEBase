using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionProxyMeshData")]
	public partial class FGeometryCollectionProxyMeshData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionProxyMeshData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionProxyMeshData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionProxyMeshData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionProxyMeshData A, FGeometryCollectionProxyMeshData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionProxyMeshData A, FGeometryCollectionProxyMeshData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionProxyMeshData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UStaticMesh> ProxyMeshes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ProxyMeshes, __ReturnBuffer);

					return *(TArray<UStaticMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ProxyMeshes, __InBuffer);
				}
			}
		}

		private static uint __ProxyMeshes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
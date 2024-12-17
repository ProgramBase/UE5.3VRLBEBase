using Script.CoreUObject;
using Script.Library;

namespace Script.GeometryCollectionEngine
{
	[PathName("/Script/GeometryCollectionEngine.GeometryCollectionRenderResourceSizeInfo")]
	public partial class FGeometryCollectionRenderResourceSizeInfo : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionEngine.GeometryCollectionRenderResourceSizeInfo");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionRenderResourceSizeInfo() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGeometryCollectionRenderResourceSizeInfo() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGeometryCollectionRenderResourceSizeInfo A, FGeometryCollectionRenderResourceSizeInfo B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionRenderResourceSizeInfo A, FGeometryCollectionRenderResourceSizeInfo B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionRenderResourceSizeInfo;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public ulong MeshResourcesSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MeshResourcesSize, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MeshResourcesSize, __InBuffer);
				}
			}
		}

		public ulong NaniteResourcesSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NaniteResourcesSize, __ReturnBuffer);

					return *(ulong*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(ulong*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NaniteResourcesSize, __InBuffer);
				}
			}
		}

		private static uint __MeshResourcesSize = 0;

		private static uint __NaniteResourcesSize = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
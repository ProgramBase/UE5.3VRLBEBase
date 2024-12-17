using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryFramework;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.BoxToMeshDataflowNode")]
	public partial class FBoxToMeshDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.BoxToMeshDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FBoxToMeshDataflowNode()
		{
		}

		public static bool operator ==(FBoxToMeshDataflowNode A, FBoxToMeshDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FBoxToMeshDataflowNode A, FBoxToMeshDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FBoxToMeshDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FBox Box
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Box, __ReturnBuffer);

					return *(FBox*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Box, __InBuffer);
				}
			}
		}

		public UDynamicMesh Mesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __ReturnBuffer);

					return *(UDynamicMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Mesh, __InBuffer);
				}
			}
		}

		public int TriangleCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TriangleCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TriangleCount, __InBuffer);
				}
			}
		}

		private static uint __Box = 0;

		private static uint __Mesh = 0;

		private static uint __TriangleCount = 0;

	}
}
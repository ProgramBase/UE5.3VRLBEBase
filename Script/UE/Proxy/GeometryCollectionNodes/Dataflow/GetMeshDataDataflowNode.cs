using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryFramework;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GetMeshDataDataflowNode")]
	public partial class FGetMeshDataDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GetMeshDataDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGetMeshDataDataflowNode()
		{
		}

		public static bool operator ==(FGetMeshDataDataflowNode A, FGetMeshDataDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGetMeshDataDataflowNode A, FGetMeshDataDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGetMeshDataDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public int VertexCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VertexCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VertexCount, __InBuffer);
				}
			}
		}

		public int EdgeCount
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EdgeCount, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EdgeCount, __InBuffer);
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

		private static uint __Mesh = 0;

		private static uint __VertexCount = 0;

		private static uint __EdgeCount = 0;

		private static uint __TriangleCount = 0;

	}
}
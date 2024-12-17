using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryFramework;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.SphereCoveringToMeshDataflowNode")]
	public partial class FSphereCoveringToMeshDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.SphereCoveringToMeshDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSphereCoveringToMeshDataflowNode()
		{
		}

		public static bool operator ==(FSphereCoveringToMeshDataflowNode A, FSphereCoveringToMeshDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSphereCoveringToMeshDataflowNode A, FSphereCoveringToMeshDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSphereCoveringToMeshDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FDataflowSphereCovering SphereCovering
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SphereCovering, __ReturnBuffer);

					return *(FDataflowSphereCovering*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SphereCovering, __InBuffer);
				}
			}
		}

		public int VerticesAlongEachSide
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __VerticesAlongEachSide, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __VerticesAlongEachSide, __InBuffer);
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

		private static uint __SphereCovering = 0;

		private static uint __VerticesAlongEachSide = 0;

		private static uint __Mesh = 0;

	}
}
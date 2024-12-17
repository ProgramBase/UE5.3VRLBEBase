using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;
using Script.GeometryFramework;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CollectionToMeshDataflowNode")]
	public partial class FCollectionToMeshDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CollectionToMeshDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCollectionToMeshDataflowNode()
		{
		}

		public static bool operator ==(FCollectionToMeshDataflowNode A, FCollectionToMeshDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCollectionToMeshDataflowNode A, FCollectionToMeshDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCollectionToMeshDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FManagedArrayCollection Collection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __ReturnBuffer);

					return *(FManagedArrayCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Collection, __InBuffer);
				}
			}
		}

		public bool bCenterPivot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCenterPivot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCenterPivot, __InBuffer);
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

		private static uint __Collection = 0;

		private static uint __bCenterPivot = 0;

		private static uint __Mesh = 0;

	}
}
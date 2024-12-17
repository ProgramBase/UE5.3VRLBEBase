using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.GeometryFramework;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.MeshInfoDataflowNode")]
	public partial class FMeshInfoDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.MeshInfoDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMeshInfoDataflowNode()
		{
		}

		public static bool operator ==(FMeshInfoDataflowNode A, FMeshInfoDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMeshInfoDataflowNode A, FMeshInfoDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMeshInfoDataflowNode;

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

		public FString InfoString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InfoString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InfoString, __InBuffer);
				}
			}
		}

		private static uint __Mesh = 0;

		private static uint __InfoString = 0;

	}
}
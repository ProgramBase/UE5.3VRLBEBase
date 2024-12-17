using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;
using Script.Engine;
using Script.GeometryCollectionEngine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.GeometryCollectionTerminalDataflowNode")]
	public partial class FGeometryCollectionTerminalDataflowNode : FDataflowTerminalNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.GeometryCollectionTerminalDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGeometryCollectionTerminalDataflowNode()
		{
		}

		public static bool operator ==(FGeometryCollectionTerminalDataflowNode A, FGeometryCollectionTerminalDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGeometryCollectionTerminalDataflowNode A, FGeometryCollectionTerminalDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGeometryCollectionTerminalDataflowNode;

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

		public TArray<UMaterial> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<UMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public TArray<FGeometryCollectionAutoInstanceMesh> InstancedMeshes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InstancedMeshes, __ReturnBuffer);

					return *(TArray<FGeometryCollectionAutoInstanceMesh>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InstancedMeshes, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __Materials = 0;

		private static uint __InstancedMeshes = 0;

	}
}
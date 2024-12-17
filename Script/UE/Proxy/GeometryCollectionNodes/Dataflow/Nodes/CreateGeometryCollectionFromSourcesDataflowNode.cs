using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;
using Script.GeometryCollectionEngine;
using Script.Engine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.CreateGeometryCollectionFromSourcesDataflowNode")]
	public partial class FCreateGeometryCollectionFromSourcesDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.CreateGeometryCollectionFromSourcesDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FCreateGeometryCollectionFromSourcesDataflowNode()
		{
		}

		public static bool operator ==(FCreateGeometryCollectionFromSourcesDataflowNode A, FCreateGeometryCollectionFromSourcesDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FCreateGeometryCollectionFromSourcesDataflowNode A, FCreateGeometryCollectionFromSourcesDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FCreateGeometryCollectionFromSourcesDataflowNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FGeometryCollectionSource> Sources
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sources, __ReturnBuffer);

					return *(TArray<FGeometryCollectionSource>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sources, __InBuffer);
				}
			}
		}

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

		private static uint __Sources = 0;

		private static uint __Collection = 0;

		private static uint __Materials = 0;

		private static uint __InstancedMeshes = 0;

	}
}
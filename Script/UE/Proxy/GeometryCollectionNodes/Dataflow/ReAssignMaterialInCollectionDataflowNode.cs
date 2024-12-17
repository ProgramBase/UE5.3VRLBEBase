using Script.CoreUObject;
using Script.Library;
using Script.DataflowCore;
using Script.Chaos;
using Script.Engine;

namespace Script.GeometryCollectionNodes
{
	[PathName("/Script/GeometryCollectionNodes.ReAssignMaterialInCollectionDataflowNode")]
	public partial class FReAssignMaterialInCollectionDataflowNode : FDataflowNode, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionNodes.ReAssignMaterialInCollectionDataflowNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FReAssignMaterialInCollectionDataflowNode()
		{
		}

		public static bool operator ==(FReAssignMaterialInCollectionDataflowNode A, FReAssignMaterialInCollectionDataflowNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FReAssignMaterialInCollectionDataflowNode A, FReAssignMaterialInCollectionDataflowNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FReAssignMaterialInCollectionDataflowNode;

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

		public FDataflowFaceSelection FaceSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __ReturnBuffer);

					return *(FDataflowFaceSelection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __FaceSelection, __InBuffer);
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

		public int OutsideMaterialIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OutsideMaterialIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OutsideMaterialIdx, __InBuffer);
				}
			}
		}

		public int InsideMaterialIdx
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InsideMaterialIdx, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InsideMaterialIdx, __InBuffer);
				}
			}
		}

		public bool bAssignOutsideMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAssignOutsideMaterial, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAssignOutsideMaterial, __InBuffer);
				}
			}
		}

		public bool bAssignInsideMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAssignInsideMaterial, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAssignInsideMaterial, __InBuffer);
				}
			}
		}

		private static uint __Collection = 0;

		private static uint __FaceSelection = 0;

		private static uint __Materials = 0;

		private static uint __OutsideMaterialIdx = 0;

		private static uint __InsideMaterialIdx = 0;

		private static uint __bAssignOutsideMaterial = 0;

		private static uint __bAssignInsideMaterial = 0;

	}
}
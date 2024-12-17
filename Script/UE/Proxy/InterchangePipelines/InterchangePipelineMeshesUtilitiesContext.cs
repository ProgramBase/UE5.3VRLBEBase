using Script.CoreUObject;
using Script.Library;

namespace Script.InterchangePipelines
{
	[PathName("/Script/InterchangePipelines.InterchangePipelineMeshesUtilitiesContext")]
	public partial class FInterchangePipelineMeshesUtilitiesContext : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/InterchangePipelines.InterchangePipelineMeshesUtilitiesContext");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FInterchangePipelineMeshesUtilitiesContext() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FInterchangePipelineMeshesUtilitiesContext() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FInterchangePipelineMeshesUtilitiesContext A, FInterchangePipelineMeshesUtilitiesContext B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FInterchangePipelineMeshesUtilitiesContext A, FInterchangePipelineMeshesUtilitiesContext B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FInterchangePipelineMeshesUtilitiesContext;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bConvertStaticMeshToSkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bConvertStaticMeshToSkeletalMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bConvertStaticMeshToSkeletalMesh, __InBuffer);
				}
			}
		}

		public bool bConvertSkeletalMeshToStaticMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bConvertSkeletalMeshToStaticMesh, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bConvertSkeletalMeshToStaticMesh, __InBuffer);
				}
			}
		}

		public bool bConvertStaticsWithMorphTargetsToSkeletals
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bConvertStaticsWithMorphTargetsToSkeletals, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bConvertStaticsWithMorphTargetsToSkeletals, __InBuffer);
				}
			}
		}

		public bool bImportMeshesInBoneHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bImportMeshesInBoneHierarchy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bImportMeshesInBoneHierarchy, __InBuffer);
				}
			}
		}

		public bool bQueryGeometryOnlyIfNoInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bQueryGeometryOnlyIfNoInstance, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bQueryGeometryOnlyIfNoInstance, __InBuffer);
				}
			}
		}

		private static uint __bConvertStaticMeshToSkeletalMesh = 0;

		private static uint __bConvertSkeletalMeshToStaticMesh = 0;

		private static uint __bConvertStaticsWithMorphTargetsToSkeletals = 0;

		private static uint __bImportMeshesInBoneHierarchy = 0;

		private static uint __bQueryGeometryOnlyIfNoInstance = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
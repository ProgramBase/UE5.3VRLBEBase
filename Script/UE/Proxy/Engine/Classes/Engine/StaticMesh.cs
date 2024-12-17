using Script.CoreUObject;
using Script.Library;
using Script.StaticMeshDescription;

namespace Script.Engine
{
	[PathName("/Script/Engine.StaticMesh")]
	public partial class UStaticMesh : UStreamableRenderAsset, IStaticClass, IInterface_CollisionDataProvider, IInterface_AssetUserData, IInterface_AsyncCompilation
	{
		public TArray<FStaticMeshSourceModel> SourceModels
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceModels, __ReturnBuffer);

					return *(TArray<FStaticMeshSourceModel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceModels, __InBuffer);
				}
			}
		}

		public FStaticMeshSourceModel HiResSourceModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HiResSourceModel, __ReturnBuffer);

					return *(FStaticMeshSourceModel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HiResSourceModel, __InBuffer);
				}
			}
		}

		public FMeshSectionInfoMap SectionInfoMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SectionInfoMap, __ReturnBuffer);

					return *(FMeshSectionInfoMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SectionInfoMap, __InBuffer);
				}
			}
		}

		public FMeshSectionInfoMap OriginalSectionInfoMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalSectionInfoMap, __ReturnBuffer);

					return *(FMeshSectionInfoMap*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OriginalSectionInfoMap, __InBuffer);
				}
			}
		}

		public FName LODGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODGroup, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODGroup, __InBuffer);
				}
			}
		}

		public FPerPlatformInt NumStreamedLODs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumStreamedLODs, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumStreamedLODs, __InBuffer);
				}
			}
		}

		public int ImportVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportVersion, __InBuffer);
				}
			}
		}

		public TArray<FMaterialRemapIndex> MaterialRemapIndexPerImportVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialRemapIndexPerImportVersion, __ReturnBuffer);

					return *(TArray<FMaterialRemapIndex>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaterialRemapIndexPerImportVersion, __InBuffer);
				}
			}
		}

		public int LightmapUVVersion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapUVVersion, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapUVVersion, __InBuffer);
				}
			}
		}

		public bool bAutoComputeLODScreenSize
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoComputeLODScreenSize, __InBuffer);
				}
			}
		}

		public FMeshNaniteSettings NaniteSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteSettings, __ReturnBuffer);

					return *(FMeshNaniteSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NaniteSettings, __InBuffer);
				}
			}
		}

		public FPerQualityLevelInt MinQualityLevelLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinQualityLevelLOD, __ReturnBuffer);

					return *(FPerQualityLevelInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinQualityLevelLOD, __InBuffer);
				}
			}
		}

		public FPerPlatformInt MinLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinLOD, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinLOD, __InBuffer);
				}
			}
		}

		public TArray<FStaticMaterial> StaticMaterials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMaterials, __ReturnBuffer);

					return *(TArray<FStaticMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMaterials, __InBuffer);
				}
			}
		}

		public float LightmapUVDensity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapUVDensity, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightmapUVDensity, __InBuffer);
				}
			}
		}

		public int LightMapResolution
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightMapResolution, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightMapResolution, __InBuffer);
				}
			}
		}

		public int LightMapCoordinateIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LightMapCoordinateIndex, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LightMapCoordinateIndex, __InBuffer);
				}
			}
		}

		public float DistanceFieldSelfShadowBias
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DistanceFieldSelfShadowBias, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DistanceFieldSelfShadowBias, __InBuffer);
				}
			}
		}

		public UBodySetup BodySetup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __ReturnBuffer);

					return *(UBodySetup*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BodySetup, __InBuffer);
				}
			}
		}

		public int LODForCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODForCollision, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODForCollision, __InBuffer);
				}
			}
		}

		public bool bGenerateMeshDistanceField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateMeshDistanceField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bGenerateMeshDistanceField, __InBuffer);
				}
			}
		}

		public bool bHasNavigationData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNavigationData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasNavigationData, __InBuffer);
				}
			}
		}

		public bool bSupportUniformlyDistributedSampling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportUniformlyDistributedSampling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportUniformlyDistributedSampling, __InBuffer);
				}
			}
		}

		public bool bSupportPhysicalMaterialMasks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportPhysicalMaterialMasks, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportPhysicalMaterialMasks, __InBuffer);
				}
			}
		}

		public bool bSupportRayTracing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportRayTracing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportRayTracing, __InBuffer);
				}
			}
		}

		public bool bDoFastBuild
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDoFastBuild, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDoFastBuild, __InBuffer);
				}
			}
		}

		public bool bAllowCPUAccess
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCPUAccess, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAllowCPUAccess, __InBuffer);
				}
			}
		}

		public bool bSupportGpuUniformlyDistributedSampling
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportGpuUniformlyDistributedSampling, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportGpuUniformlyDistributedSampling, __InBuffer);
				}
			}
		}

		public UAssetImportData AssetImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __ReturnBuffer);

					return *(UAssetImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportData, __InBuffer);
				}
			}
		}

		public UThumbnailInfo ThumbnailInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __ReturnBuffer);

					return *(UThumbnailInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ThumbnailInfo, __InBuffer);
				}
			}
		}

		public FAssetEditorOrbitCameraPosition EditorCameraPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorCameraPosition, __ReturnBuffer);

					return *(FAssetEditorOrbitCameraPosition*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorCameraPosition, __InBuffer);
				}
			}
		}

		public bool bCustomizedCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCustomizedCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCustomizedCollision, __InBuffer);
				}
			}
		}

		public TArray<UStaticMeshSocket> Sockets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sockets, __ReturnBuffer);

					return *(TArray<UStaticMeshSocket>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Sockets, __InBuffer);
				}
			}
		}

		public FVector PositiveBoundsExtension
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PositiveBoundsExtension, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PositiveBoundsExtension, __InBuffer);
				}
			}
		}

		public FVector NegativeBoundsExtension
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NegativeBoundsExtension, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NegativeBoundsExtension, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds ExtendedBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ExtendedBounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ExtendedBounds, __InBuffer);
				}
			}
		}

		public int ElementToIgnoreForTexFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ElementToIgnoreForTexFactor, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ElementToIgnoreForTexFactor, __InBuffer);
				}
			}
		}

		public TArray<UAssetUserData> AssetUserData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __ReturnBuffer);

					return *(TArray<UAssetUserData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetUserData, __InBuffer);
				}
			}
		}

		public UStaticMesh ComplexCollisionMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComplexCollisionMesh, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComplexCollisionMesh, __InBuffer);
				}
			}
		}

		public UNavCollisionBase NavCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NavCollision, __ReturnBuffer);

					return *(UNavCollisionBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NavCollision, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.StaticMesh");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		public virtual void SetStaticMaterials(TArray<FStaticMaterial> InStaticMaterials)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InStaticMaterials?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetStaticMaterials, __InBuffer);
			}
		}

		public virtual void SetNumSourceModels(int Num)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Num;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumSourceModels, __InBuffer);
			}
		}

		public virtual void SetMinLODForQualityLevels(TMap<EPerQualityLevels, int> QualityLevelMinimumLODs, int Default = -1)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = QualityLevelMinimumLODs?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Default;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinLODForQualityLevels, __InBuffer);
			}
		}

		public virtual void SetMinimumLODForPlatforms(TMap<FName, int> PlatformMinimumLODs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlatformMinimumLODs?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinimumLODForPlatforms, __InBuffer);
			}
		}

		public virtual void SetMinimumLODForPlatform(FName PlatformName, int InMinLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = PlatformName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = InMinLOD;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinimumLODForPlatform, __InBuffer);
			}
		}

		public virtual void SetMaterial(int MaterialIndex, UMaterialInterface NewMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = MaterialIndex;

				*(nint*)(__InBuffer + 4) = NewMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterial, __InBuffer);
			}
		}

		public virtual void RemoveSocket(UStaticMeshSocket Socket)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Socket?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveSocket, __InBuffer);
			}
		}

		public virtual bool IsLODScreenSizeAutoComputed()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsLODScreenSizeAutoComputed, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UStaticMeshDescription GetStaticMeshDescription(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetStaticMeshDescription, __InBuffer, __ReturnBuffer);

				return *(UStaticMeshDescription*)__ReturnBuffer;
			}
		}

		public virtual TArray<FStaticMaterial> GetStaticMaterials()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetStaticMaterials, __ReturnBuffer);

				return *(TArray<FStaticMaterial>*)__ReturnBuffer;
			}
		}

		public virtual TArray<UStaticMeshSocket> GetSocketsByTag(FString InSocketTag)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketTag?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketsByTag, __InBuffer, __ReturnBuffer);

				return *(TArray<UStaticMeshSocket>*)__ReturnBuffer;
			}
		}

		public virtual int GetNumTriangles(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumTriangles, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumSections(int InLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InLOD;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetNumSections, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumLODs()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumLODs, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetMinLODForQualityLevels(ref TMap<EPerQualityLevels, int> QualityLevelMinimumLODs, ref int Default)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = QualityLevelMinimumLODs?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Default;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMinLODForQualityLevels, __InBuffer, __OutBuffer);

				QualityLevelMinimumLODs = *(TMap<EPerQualityLevels, int>*)(__OutBuffer);

				Default = *(int*)(__OutBuffer + 8);

			}
		}

		public virtual void GetMinimumLODForQualityLevels(ref TMap<FName, int> QualityLevelMinimumLODs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = QualityLevelMinimumLODs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMinimumLODForQualityLevels, __InBuffer, __OutBuffer);

				QualityLevelMinimumLODs = *(TMap<FName, int>*)(__OutBuffer);

			}
		}

		public virtual int GetMinimumLODForQualityLevel(FName QualityLevel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = QualityLevel?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMinimumLODForQualityLevel, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetMinimumLODForPlatforms(ref TMap<FName, int> PlatformMinimumLODs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlatformMinimumLODs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMinimumLODForPlatforms, __InBuffer, __OutBuffer);

				PlatformMinimumLODs = *(TMap<FName, int>*)(__OutBuffer);

			}
		}

		public virtual int GetMinimumLODForPlatform(FName PlatformName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PlatformName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMinimumLODForPlatform, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Requested material
		/// </returns>
		public virtual int GetMaterialIndex(FName MaterialSlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialSlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetMaterialIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// Requested material
		/// </returns>
		public virtual UMaterialInterface GetMaterial(int MaterialIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = MaterialIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetMaterial, __InBuffer, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The bounding box represented as box origin with extents and also a sphere that encapsulates that box
		/// </returns>
		public virtual FBoxSphereBounds GetBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBounds, __ReturnBuffer);

				return *(FBoxSphereBounds*)__ReturnBuffer;
			}
		}

		public virtual FBox GetBoundingBox()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBoundingBox, __ReturnBuffer);

				return *(FBox*)__ReturnBuffer;
			}
		}

		public virtual UStaticMeshSocket FindSocket(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindSocket, __InBuffer, __ReturnBuffer);

				return *(UStaticMeshSocket*)__ReturnBuffer;
			}
		}

		public static UStaticMeshDescription CreateStaticMeshDescription(UObject Outer = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Outer?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateStaticMeshDescription, __InBuffer, __ReturnBuffer);

				return *(UStaticMeshDescription*)__ReturnBuffer;
			}
		}

		public virtual void BuildFromStaticMeshDescriptions(TArray<UStaticMeshDescription> StaticMeshDescriptions, bool bBuildSimpleCollision = false, bool bFastBuild = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = StaticMeshDescriptions?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bBuildSimpleCollision;

				*(bool*)(__InBuffer + 9) = bFastBuild;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BuildFromStaticMeshDescriptions, __InBuffer);
			}
		}

		public virtual void AddSocket(UStaticMeshSocket Socket)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Socket?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSocket, __InBuffer);
			}
		}

		public virtual FName AddMaterial(UMaterialInterface Material)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Material?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddMaterial, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		private static uint __SourceModels = 0;

		private static uint __HiResSourceModel = 0;

		private static uint __SectionInfoMap = 0;

		private static uint __OriginalSectionInfoMap = 0;

		private static uint __LODGroup = 0;

		private static uint __NumStreamedLODs = 0;

		private static uint __ImportVersion = 0;

		private static uint __MaterialRemapIndexPerImportVersion = 0;

		private static uint __LightmapUVVersion = 0;

		private static uint __bAutoComputeLODScreenSize = 0;

		private static uint __NaniteSettings = 0;

		private static uint __MinQualityLevelLOD = 0;

		private static uint __MinLOD = 0;

		private static uint __StaticMaterials = 0;

		private static uint __LightmapUVDensity = 0;

		private static uint __LightMapResolution = 0;

		private static uint __LightMapCoordinateIndex = 0;

		private static uint __DistanceFieldSelfShadowBias = 0;

		private static uint __BodySetup = 0;

		private static uint __LODForCollision = 0;

		private static uint __bGenerateMeshDistanceField = 0;

		private static uint __bHasNavigationData = 0;

		private static uint __bSupportUniformlyDistributedSampling = 0;

		private static uint __bSupportPhysicalMaterialMasks = 0;

		private static uint __bSupportRayTracing = 0;

		private static uint __bDoFastBuild = 0;

		private static uint __bAllowCPUAccess = 0;

		private static uint __bSupportGpuUniformlyDistributedSampling = 0;

		private static uint __AssetImportData = 0;

		private static uint __ThumbnailInfo = 0;

		private static uint __EditorCameraPosition = 0;

		private static uint __bCustomizedCollision = 0;

		private static uint __Sockets = 0;

		private static uint __PositiveBoundsExtension = 0;

		private static uint __NegativeBoundsExtension = 0;

		private static uint __ExtendedBounds = 0;

		private static uint __ElementToIgnoreForTexFactor = 0;

		private static uint __AssetUserData = 0;

		private static uint __ComplexCollisionMesh = 0;

		private static uint __NavCollision = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetStaticMaterials = 0;

		private static uint __SetNumSourceModels = 0;

		private static uint __SetMinLODForQualityLevels = 0;

		private static uint __SetMinimumLODForPlatforms = 0;

		private static uint __SetMinimumLODForPlatform = 0;

		private static uint __SetMaterial = 0;

		private static uint __RemoveSocket = 0;

		private static uint __IsLODScreenSizeAutoComputed = 0;

		private static uint __GetStaticMeshDescription = 0;

		private static uint __GetStaticMaterials = 0;

		private static uint __GetSocketsByTag = 0;

		private static uint __GetNumTriangles = 0;

		private static uint __GetNumSections = 0;

		private static uint __GetNumLODs = 0;

		private static uint __GetMinLODForQualityLevels = 0;

		private static uint __GetMinimumLODForQualityLevels = 0;

		private static uint __GetMinimumLODForQualityLevel = 0;

		private static uint __GetMinimumLODForPlatforms = 0;

		private static uint __GetMinimumLODForPlatform = 0;

		private static uint __GetMaterialIndex = 0;

		private static uint __GetMaterial = 0;

		private static uint __GetBounds = 0;

		private static uint __GetBoundingBox = 0;

		private static uint __FindSocket = 0;

		private static uint __CreateStaticMeshDescription = 0;

		private static uint __BuildFromStaticMeshDescriptions = 0;

		private static uint __AddSocket = 0;

		private static uint __AddMaterial = 0;
	}
}
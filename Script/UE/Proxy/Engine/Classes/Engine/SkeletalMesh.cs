using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkeletalMesh")]
	public partial class USkeletalMesh : USkinnedAsset, IStaticClass, IInterface_CollisionDataProvider, IInterface_AssetUserData, INodeMappingProviderInterface
	{
		public USkeletalMeshEditorData MeshEditorDataObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshEditorDataObject, __ReturnBuffer);

					return *(USkeletalMeshEditorData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshEditorDataObject, __InBuffer);
				}
			}
		}

		public USkeleton Skeleton
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Skeleton, __ReturnBuffer);

					return *(USkeleton*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Skeleton, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds ImportedBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedBounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportedBounds, __InBuffer);
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

		public TArray<FSkeletalMaterial> Materials
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __ReturnBuffer);

					return *(TArray<FSkeletalMaterial>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Materials, __InBuffer);
				}
			}
		}

		public TArray<FBoneMirrorInfo> SkelMirrorTable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorTable, __ReturnBuffer);

					return *(TArray<FBoneMirrorInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorTable, __InBuffer);
				}
			}
		}

		public TArray<FSkeletalMeshLODInfo> LODInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfo, __ReturnBuffer);

					return *(TArray<FSkeletalMeshLODInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfo, __InBuffer);
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

		public FPerPlatformInt MinLod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinLod, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinLod, __InBuffer);
				}
			}
		}

		public FPerPlatformBool DisableBelowMinLodStripping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisableBelowMinLodStripping, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisableBelowMinLodStripping, __InBuffer);
				}
			}
		}

		public bool bOverrideLODStreamingSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLODStreamingSettings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideLODStreamingSettings, __InBuffer);
				}
			}
		}

		public FPerPlatformBool bSupportLODStreaming
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportLODStreaming, __ReturnBuffer);

					return *(FPerPlatformBool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportLODStreaming, __InBuffer);
				}
			}
		}

		public FPerPlatformInt MaxNumStreamedLODs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNumStreamedLODs, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNumStreamedLODs, __InBuffer);
				}
			}
		}

		public FPerPlatformInt MaxNumOptionalLODs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNumOptionalLODs, __ReturnBuffer);

					return *(FPerPlatformInt*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxNumOptionalLODs, __InBuffer);
				}
			}
		}

		public USkeletalMeshLODSettings LODSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODSettings, __ReturnBuffer);

					return *(USkeletalMeshLODSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LODSettings, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UObject> DefaultAnimatingRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimatingRig, __ReturnBuffer);

					return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultAnimatingRig, __InBuffer);
				}
			}
		}

		public EAxis SkelMirrorAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorAxis, __ReturnBuffer);

					return *(EAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorAxis, __InBuffer);
				}
			}
		}

		public EAxis SkelMirrorFlipAxis
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorFlipAxis, __ReturnBuffer);

					return *(EAxis*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkelMirrorFlipAxis, __InBuffer);
				}
			}
		}

		public bool bHasBeenSimplified
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBeenSimplified, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasBeenSimplified, __InBuffer);
				}
			}
		}

		public bool bHasVertexColors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasVertexColors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasVertexColors, __InBuffer);
				}
			}
		}

		public bool bEnablePerPolyCollision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePerPolyCollision, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnablePerPolyCollision, __InBuffer);
				}
			}
		}

		public FGuid VertexColorGuid
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorGuid, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VertexColorGuid, __InBuffer);
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

		public UPhysicsAsset PhysicsAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsAsset, __ReturnBuffer);

					return *(UPhysicsAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsAsset, __InBuffer);
				}
			}
		}

		public UPhysicsAsset ShadowPhysicsAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowPhysicsAsset, __ReturnBuffer);

					return *(UPhysicsAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShadowPhysicsAsset, __InBuffer);
				}
			}
		}

		public TArray<UNodeMappingContainer> NodeMappingData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NodeMappingData, __ReturnBuffer);

					return *(TArray<UNodeMappingContainer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NodeMappingData, __InBuffer);
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

		public bool bHasCustomDefaultEditorCamera
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasCustomDefaultEditorCamera, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasCustomDefaultEditorCamera, __InBuffer);
				}
			}
		}

		public FVector DefaultEditorCameraLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraLocation, __InBuffer);
				}
			}
		}

		public FRotator DefaultEditorCameraRotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraRotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraRotation, __InBuffer);
				}
			}
		}

		public FVector DefaultEditorCameraLookAt
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraLookAt, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraLookAt, __InBuffer);
				}
			}
		}

		public float DefaultEditorCameraOrthoZoom
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraOrthoZoom, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultEditorCameraOrthoZoom, __InBuffer);
				}
			}
		}

		public FPreviewAssetAttachContainer PreviewAttachedAssetContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewAttachedAssetContainer, __ReturnBuffer);

					return *(FPreviewAssetAttachContainer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PreviewAttachedAssetContainer, __InBuffer);
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

		public int RayTracingMinLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingMinLOD, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RayTracingMinLOD, __InBuffer);
				}
			}
		}

		public EClothLODBiasMode ClothLODBiasMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClothLODBiasMode, __ReturnBuffer);

					return *(EClothLODBiasMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClothLODBiasMode, __InBuffer);
				}
			}
		}

		public TArray<UMorphTarget> MorphTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargets, __ReturnBuffer);

					return *(TArray<UMorphTarget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MorphTargets, __InBuffer);
				}
			}
		}

		public float FloorOffset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloorOffset, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloorOffset, __InBuffer);
				}
			}
		}

		public TArray<FTransform> RetargetBasePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RetargetBasePose, __ReturnBuffer);

					return *(TArray<FTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RetargetBasePose, __InBuffer);
				}
			}
		}

		public TSubclassOf<UAnimInstance> PostProcessAnimBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimBlueprint, __ReturnBuffer);

					return *(TSubclassOf<UAnimInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimBlueprint, __InBuffer);
				}
			}
		}

		public int PostProcessAnimBPLODThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimBPLODThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PostProcessAnimBPLODThreshold, __InBuffer);
				}
			}
		}

		public TArray<UClothingAssetBase> MeshClothingAssets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshClothingAssets, __ReturnBuffer);

					return *(TArray<UClothingAssetBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshClothingAssets, __InBuffer);
				}
			}
		}

		public FSkeletalMeshSamplingInfo SamplingInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SamplingInfo, __ReturnBuffer);

					return *(FSkeletalMeshSamplingInfo*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SamplingInfo, __InBuffer);
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

		public TArray<USkeletalMeshSocket> Sockets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Sockets, __ReturnBuffer);

					return *(TArray<USkeletalMeshSocket>*)__ReturnBuffer;
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

		public TArray<FSkinWeightProfileInfo> SkinWeightProfiles
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkinWeightProfiles, __ReturnBuffer);

					return *(TArray<FSkinWeightProfileInfo>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkinWeightProfiles, __InBuffer);
				}
			}
		}

		public UMeshDeformer DefaultMeshDeformer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMeshDeformer, __ReturnBuffer);

					return *(UMeshDeformer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultMeshDeformer, __InBuffer);
				}
			}
		}

		public UMaterialInterface OverlayMaterial
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __ReturnBuffer);

					return *(UMaterialInterface*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterial, __InBuffer);
				}
			}
		}

		public float OverlayMaterialMaxDrawDistance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterialMaxDrawDistance, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverlayMaterialMaxDrawDistance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkeletalMesh");
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

		public virtual void SetSkeleton(USkeleton InSkeleton)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkeleton, __InBuffer);
			}
		}

		public virtual void SetOverlayMaterialMaxDrawDistance(float InMaxDrawDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InMaxDrawDistance;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverlayMaterialMaxDrawDistance, __InBuffer);
			}
		}

		public virtual void SetOverlayMaterial(UMaterialInterface NewOverlayMaterial)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewOverlayMaterial?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOverlayMaterial, __InBuffer);
			}
		}

		public virtual void SetMorphTargets(TArray<UMorphTarget> InMorphTargets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMorphTargets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMorphTargets, __InBuffer);
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

		public virtual void SetMeshClothingAssets(TArray<UClothingAssetBase> InMeshClothingAssets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMeshClothingAssets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMeshClothingAssets, __InBuffer);
			}
		}

		public virtual void SetMaterials(TArray<FSkeletalMaterial> InMaterials)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMaterials?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterials, __InBuffer);
			}
		}

		public virtual void SetLODSettings(USkeletalMeshLODSettings InLODSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InLODSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLODSettings, __InBuffer);
			}
		}

		public virtual void SetDefaultAnimatingRig(TSoftObjectPtr<UObject> InAnimatingRig)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InAnimatingRig?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDefaultAnimatingRig, __InBuffer);
			}
		}

		public virtual int NumSockets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __NumSockets, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The list of morph targets
		/// </returns>
		public virtual TArray<FString> K2_GetAllMorphTargetNames()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __K2_GetAllMorphTargetNames, __ReturnBuffer);

				return *(TArray<FString>*)__ReturnBuffer;
			}
		}

		/// <param name="InSectionIndex">
		/// Index to check
		/// </param>
		/// <param name="bCheckCorrespondingSections">
		/// Whether to check corresponding sections for disabled sections
		/// </param>
		public virtual bool IsSectionUsingCloth(int InSectionIndex, bool bCheckCorrespondingSections = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(int*)(__InBuffer) = InSectionIndex;

				*(bool*)(__InBuffer + 4) = bCheckCorrespondingSections;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSectionUsingCloth, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMeshSocket GetSocketByIndex(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketByIndex, __InBuffer, __ReturnBuffer);

				return *(USkeletalMeshSocket*)__ReturnBuffer;
			}
		}

		public virtual USkeleton GetSkeleton()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeleton, __ReturnBuffer);

				return *(USkeleton*)__ReturnBuffer;
			}
		}

		public virtual UPhysicsAsset GetShadowPhysicsAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetShadowPhysicsAsset, __ReturnBuffer);

				return *(UPhysicsAsset*)__ReturnBuffer;
			}
		}

		public virtual UPhysicsAsset GetPhysicsAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPhysicsAsset, __ReturnBuffer);

				return *(UPhysicsAsset*)__ReturnBuffer;
			}
		}

		public virtual float GetOverlayMaterialMaxDrawDistance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetOverlayMaterialMaxDrawDistance, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual UMaterialInterface GetOverlayMaterial()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetOverlayMaterial, __ReturnBuffer);

				return *(UMaterialInterface*)__ReturnBuffer;
			}
		}

		public virtual TArray<UNodeMappingContainer> GetNodeMappingData()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodeMappingData, __ReturnBuffer);

				return *(TArray<UNodeMappingContainer>*)__ReturnBuffer;
			}
		}

		public virtual UNodeMappingContainer GetNodeMappingContainer(UBlueprint SourceAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SourceAsset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetNodeMappingContainer, __InBuffer, __ReturnBuffer);

				return *(UNodeMappingContainer*)__ReturnBuffer;
			}
		}

		public virtual TArray<UMorphTarget> GetMorphTargetsPtrConv()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMorphTargetsPtrConv, __ReturnBuffer);

				return *(TArray<UMorphTarget>*)__ReturnBuffer;
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

		public virtual TArray<UClothingAssetBase> GetMeshClothingAssets()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMeshClothingAssets, __ReturnBuffer);

				return *(TArray<UClothingAssetBase>*)__ReturnBuffer;
			}
		}

		public virtual TArray<FSkeletalMaterial> GetMaterials()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMaterials, __ReturnBuffer);

				return *(TArray<FSkeletalMaterial>*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMeshLODSettings GetLODSettings()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLODSettings, __ReturnBuffer);

				return *(USkeletalMeshLODSettings*)__ReturnBuffer;
			}
		}

		public virtual FBoxSphereBounds GetImportedBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetImportedBounds, __ReturnBuffer);

				return *(FBoxSphereBounds*)__ReturnBuffer;
			}
		}

		public virtual TSoftObjectPtr<UObject> GetDefaultAnimatingRig()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetDefaultAnimatingRig, __ReturnBuffer);

				return *(TSoftObjectPtr<UObject>*)__ReturnBuffer;
			}
		}

		public virtual FBoxSphereBounds GetBounds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetBounds, __ReturnBuffer);

				return *(FBoxSphereBounds*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMeshSocket FindSocketAndIndex(FName InSocketName, ref int OutIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = OutIndex;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindSocketAndIndex, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutIndex = *(int*)(__OutBuffer);

				return *(USkeletalMeshSocket*)__ReturnBuffer;
			}
		}

		public virtual void AddSocket(USkeletalMeshSocket InSocket, bool bAddToSkeleton = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InSocket?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAddToSkeleton;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddSocket, __InBuffer);
			}
		}

		private static uint __MeshEditorDataObject = 0;

		private static uint __Skeleton = 0;

		private static uint __ImportedBounds = 0;

		private static uint __ExtendedBounds = 0;

		private static uint __PositiveBoundsExtension = 0;

		private static uint __NegativeBoundsExtension = 0;

		private static uint __Materials = 0;

		private static uint __SkelMirrorTable = 0;

		private static uint __LODInfo = 0;

		private static uint __MinQualityLevelLOD = 0;

		private static uint __MinLod = 0;

		private static uint __DisableBelowMinLodStripping = 0;

		private static uint __bOverrideLODStreamingSettings = 0;

		private static uint __bSupportLODStreaming = 0;

		private static uint __MaxNumStreamedLODs = 0;

		private static uint __MaxNumOptionalLODs = 0;

		private static uint __LODSettings = 0;

		private static uint __DefaultAnimatingRig = 0;

		private static uint __SkelMirrorAxis = 0;

		private static uint __SkelMirrorFlipAxis = 0;

		private static uint __bHasBeenSimplified = 0;

		private static uint __bHasVertexColors = 0;

		private static uint __bEnablePerPolyCollision = 0;

		private static uint __VertexColorGuid = 0;

		private static uint __BodySetup = 0;

		private static uint __PhysicsAsset = 0;

		private static uint __ShadowPhysicsAsset = 0;

		private static uint __NodeMappingData = 0;

		private static uint __AssetImportData = 0;

		private static uint __ThumbnailInfo = 0;

		private static uint __bHasCustomDefaultEditorCamera = 0;

		private static uint __DefaultEditorCameraLocation = 0;

		private static uint __DefaultEditorCameraRotation = 0;

		private static uint __DefaultEditorCameraLookAt = 0;

		private static uint __DefaultEditorCameraOrthoZoom = 0;

		private static uint __PreviewAttachedAssetContainer = 0;

		private static uint __bSupportRayTracing = 0;

		private static uint __RayTracingMinLOD = 0;

		private static uint __ClothLODBiasMode = 0;

		private static uint __MorphTargets = 0;

		private static uint __FloorOffset = 0;

		private static uint __RetargetBasePose = 0;

		private static uint __PostProcessAnimBlueprint = 0;

		private static uint __PostProcessAnimBPLODThreshold = 0;

		private static uint __MeshClothingAssets = 0;

		private static uint __SamplingInfo = 0;

		private static uint __AssetUserData = 0;

		private static uint __Sockets = 0;

		private static uint __SkinWeightProfiles = 0;

		private static uint __DefaultMeshDeformer = 0;

		private static uint __OverlayMaterial = 0;

		private static uint __OverlayMaterialMaxDrawDistance = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __SetSkeleton = 0;

		private static uint __SetOverlayMaterialMaxDrawDistance = 0;

		private static uint __SetOverlayMaterial = 0;

		private static uint __SetMorphTargets = 0;

		private static uint __SetMinLODForQualityLevels = 0;

		private static uint __SetMeshClothingAssets = 0;

		private static uint __SetMaterials = 0;

		private static uint __SetLODSettings = 0;

		private static uint __SetDefaultAnimatingRig = 0;

		private static uint __NumSockets = 0;

		private static uint __K2_GetAllMorphTargetNames = 0;

		private static uint __IsSectionUsingCloth = 0;

		private static uint __GetSocketByIndex = 0;

		private static uint __GetSkeleton = 0;

		private static uint __GetShadowPhysicsAsset = 0;

		private static uint __GetPhysicsAsset = 0;

		private static uint __GetOverlayMaterialMaxDrawDistance = 0;

		private static uint __GetOverlayMaterial = 0;

		private static uint __GetNodeMappingData = 0;

		private static uint __GetNodeMappingContainer = 0;

		private static uint __GetMorphTargetsPtrConv = 0;

		private static uint __GetMinLODForQualityLevels = 0;

		private static uint __GetMeshClothingAssets = 0;

		private static uint __GetMaterials = 0;

		private static uint __GetLODSettings = 0;

		private static uint __GetImportedBounds = 0;

		private static uint __GetDefaultAnimatingRig = 0;

		private static uint __GetBounds = 0;

		private static uint __FindSocketAndIndex = 0;

		private static uint __AddSocket = 0;
	}
}
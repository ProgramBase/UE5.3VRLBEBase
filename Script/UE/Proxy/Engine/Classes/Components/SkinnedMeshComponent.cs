using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.SkinnedMeshComponent")]
	public partial class USkinnedMeshComponent : UMeshComponent, IStaticClass, ILODSyncInterface
	{
		public USkeletalMesh SkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkeletalMesh, __InBuffer);
				}
			}
		}

		public USkinnedAsset SkinnedAsset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkinnedAsset, __ReturnBuffer);

					return *(USkinnedAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkinnedAsset, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USkinnedMeshComponent> LeaderPoseComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LeaderPoseComponent, __ReturnBuffer);

					return *(TWeakObjectPtr<USkinnedMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LeaderPoseComponent, __InBuffer);
				}
			}
		}

		public TArray<ESkinCacheUsage> SkinCacheUsage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SkinCacheUsage, __ReturnBuffer);

					return *(TArray<ESkinCacheUsage>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SkinCacheUsage, __InBuffer);
				}
			}
		}

		public bool bSetMeshDeformer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSetMeshDeformer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSetMeshDeformer, __InBuffer);
				}
			}
		}

		public UMeshDeformer MeshDeformer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformer, __ReturnBuffer);

					return *(UMeshDeformer*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformer, __InBuffer);
				}
			}
		}

		public UMeshDeformerInstanceSettings MeshDeformerInstanceSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformerInstanceSettings, __ReturnBuffer);

					return *(UMeshDeformerInstanceSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformerInstanceSettings, __InBuffer);
				}
			}
		}

		public UMeshDeformerInstance MeshDeformerInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformerInstance, __ReturnBuffer);

					return *(UMeshDeformerInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshDeformerInstance, __InBuffer);
				}
			}
		}

		public UPhysicsAsset PhysicsAssetOverride
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsAssetOverride, __ReturnBuffer);

					return *(UPhysicsAsset*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PhysicsAssetOverride, __InBuffer);
				}
			}
		}

		public int ForcedLodModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ForcedLodModel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ForcedLodModel, __InBuffer);
				}
			}
		}

		public int MinLodModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MinLodModel, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MinLodModel, __InBuffer);
				}
			}
		}

		public float StreamingDistanceMultiplier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingDistanceMultiplier, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StreamingDistanceMultiplier, __InBuffer);
				}
			}
		}

		public TArray<FSkelMeshComponentLODInfo> LODInfo
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LODInfo, __ReturnBuffer);

					return *(TArray<FSkelMeshComponentLODInfo>*)__ReturnBuffer;
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

		public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityBasedAnimTickOption, __ReturnBuffer);

					return *(EVisibilityBasedAnimTickOption*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __VisibilityBasedAnimTickOption, __InBuffer);
				}
			}
		}

		public bool bOverrideMinLod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideMinLod, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOverrideMinLod, __InBuffer);
				}
			}
		}

		public bool bUseBoundsFromLeaderPoseComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseBoundsFromLeaderPoseComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseBoundsFromLeaderPoseComponent, __InBuffer);
				}
			}
		}

		public bool bForceWireframe
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceWireframe, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceWireframe, __InBuffer);
				}
			}
		}

		public bool bDisableMorphTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableMorphTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisableMorphTarget, __InBuffer);
				}
			}
		}

		public bool bHideSkin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHideSkin, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHideSkin, __InBuffer);
				}
			}
		}

		public bool bPerBoneMotionBlur
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPerBoneMotionBlur, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPerBoneMotionBlur, __InBuffer);
				}
			}
		}

		public bool bComponentUseFixedSkelBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentUseFixedSkelBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bComponentUseFixedSkelBounds, __InBuffer);
				}
			}
		}

		public bool bConsiderAllBodiesForBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bConsiderAllBodiesForBounds, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bConsiderAllBodiesForBounds, __InBuffer);
				}
			}
		}

		public bool bSyncAttachParentLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSyncAttachParentLOD, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSyncAttachParentLOD, __InBuffer);
				}
			}
		}

		public bool bCanHighlightSelectedSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCanHighlightSelectedSections, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCanHighlightSelectedSections, __InBuffer);
				}
			}
		}

		public bool bRecentlyRendered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRecentlyRendered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRecentlyRendered, __InBuffer);
				}
			}
		}

		public bool bCastCapsuleDirectShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCapsuleDirectShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCapsuleDirectShadow, __InBuffer);
				}
			}
		}

		public bool bCastCapsuleIndirectShadow
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCapsuleIndirectShadow, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCastCapsuleIndirectShadow, __InBuffer);
				}
			}
		}

		public bool bCPUSkinning
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCPUSkinning, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCPUSkinning, __InBuffer);
				}
			}
		}

		public bool bEnableUpdateRateOptimizations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableUpdateRateOptimizations, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableUpdateRateOptimizations, __InBuffer);
				}
			}
		}

		public bool bDisplayDebugUpdateRateOptimizations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDisplayDebugUpdateRateOptimizations, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDisplayDebugUpdateRateOptimizations, __InBuffer);
				}
			}
		}

		public bool bRenderStatic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderStatic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderStatic, __InBuffer);
				}
			}
		}

		public bool bIgnoreLeaderPoseComponentLOD
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreLeaderPoseComponentLOD, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIgnoreLeaderPoseComponentLOD, __InBuffer);
				}
			}
		}

		public bool bCachedLocalBoundsUpToDate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCachedLocalBoundsUpToDate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCachedLocalBoundsUpToDate, __InBuffer);
				}
			}
		}

		public bool bCachedWorldSpaceBoundsUpToDate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCachedWorldSpaceBoundsUpToDate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCachedWorldSpaceBoundsUpToDate, __InBuffer);
				}
			}
		}

		public bool bForceMeshObjectUpdate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMeshObjectUpdate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceMeshObjectUpdate, __InBuffer);
				}
			}
		}

		public bool bForceUpdateDynamicDataImmediately
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceUpdateDynamicDataImmediately, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceUpdateDynamicDataImmediately, __InBuffer);
				}
			}
		}

		public bool bFollowerShouldTickPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFollowerShouldTickPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFollowerShouldTickPose, __InBuffer);
				}
			}
		}

		public float CapsuleIndirectShadowMinVisibility
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleIndirectShadowMinVisibility, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleIndirectShadowMinVisibility, __InBuffer);
				}
			}
		}

		public FBoxSphereBounds CachedWorldOrLocalSpaceBounds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedWorldOrLocalSpaceBounds, __ReturnBuffer);

					return *(FBoxSphereBounds*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedWorldOrLocalSpaceBounds, __InBuffer);
				}
			}
		}

		public FMatrix CachedWorldToLocalTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CachedWorldToLocalTransform, __ReturnBuffer);

					return *(FMatrix*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CachedWorldToLocalTransform, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.SkinnedMeshComponent");
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

		/// <param name="InMeshDeformer">
		/// New mesh deformer to set for this component
		/// </param>
		public virtual void UnsetMeshDeformer()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UnsetMeshDeformer);
			}
		}

		public virtual void UnloadSkinWeightProfile(FName InProfileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InProfileName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnloadSkinWeightProfile, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// Name of bone to unhide
		/// </param>
		public virtual void UnHideBoneByName(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UnHideBoneByName, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// Name of bone
		/// </param>
		/// <param name="InPosition">
		/// Input position
		/// </param>
		/// <param name="InRotation">
		/// Input rotation
		/// </param>
		/// <param name="OutPosition">
		/// (out) Transformed position
		/// </param>
		/// <param name="OutRotation">
		/// (out) Transformed rotation
		/// </param>
		public virtual void TransformToBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __TransformToBoneSpace, __InBuffer, __OutBuffer);

				OutPosition = *(FVector*)(__OutBuffer);

				OutRotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		/// <param name="BoneName">
		/// Name of bone
		/// </param>
		/// <param name="InPosition">
		/// Input position
		/// </param>
		/// <param name="InRotation">
		/// Input rotation
		/// </param>
		/// <param name="OutPosition">
		/// (out) Transformed position
		/// </param>
		/// <param name="OutRotation">
		/// (out) Transformed rotation
		/// </param>
		public virtual void TransformFromBoneSpace(FName BoneName, FVector InPosition, FRotator InRotation, ref FVector OutPosition, ref FRotator OutRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = OutRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __TransformFromBoneSpace, __InBuffer, __OutBuffer);

				OutPosition = *(FVector*)(__OutBuffer);

				OutRotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		/// <param name="MaterialID">
		/// - Index of the material show/hide
		/// </param>
		/// <param name="bShow">
		/// - True to show the material, false to hide it
		/// </param>
		/// <param name="LODIndex">
		/// - Index of the LOD to modify material visibility within
		/// </param>
		public virtual void ShowMaterialSection(int MaterialID, int SectionIndex, bool bShow, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(int*)(__InBuffer) = MaterialID;

				*(int*)(__InBuffer + 4) = SectionIndex;

				*(bool*)(__InBuffer + 8) = bShow;

				*(int*)(__InBuffer + 9) = LODIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowMaterialSection, __InBuffer);
			}
		}

		public virtual void ShowAllMaterialSections(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ShowAllMaterialSections, __InBuffer);
			}
		}

		public virtual void SetVertexOffsetUsage(int LODIndex, int Usage)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = LODIndex;

				*(int*)(__InBuffer + 4) = Usage;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVertexOffsetUsage, __InBuffer);
			}
		}

		public virtual void SetVertexColorOverride_LinearColor(int LODIndex, TArray<FLinearColor> VertexColors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = LODIndex;

				*(nint*)(__InBuffer + 4) = VertexColors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVertexColorOverride_LinearColor, __InBuffer);
			}
		}

		public virtual bool SetSkinWeightProfile(FName InProfileName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InProfileName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSkinWeightProfile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetSkinWeightOverride(int LODIndex, TArray<FSkelMeshSkinWeightInfo> SkinWeights)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = LODIndex;

				*(nint*)(__InBuffer + 4) = SkinWeights?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkinWeightOverride, __InBuffer);
			}
		}

		/// <param name="NewMesh">
		/// New mesh to set for this component
		/// </param>
		/// <param name="bReinitPose">
		/// Whether we should keep current pose or reinitialize.
		/// </param>
		public virtual void SetSkinnedAssetAndUpdate(USkinnedAsset NewMesh, bool bReinitPose = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bReinitPose;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSkinnedAssetAndUpdate, __InBuffer);
			}
		}

		/// <param name="whether">
		/// this skinned mesh should be rendered as static
		/// </param>
		public virtual void SetRenderStatic(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRenderStatic, __InBuffer);
			}
		}

		public virtual void SetPreSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = LODIndex;

				*(nint*)(__InBuffer + 4) = Offsets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPreSkinningOffsets, __InBuffer);
			}
		}

		public virtual void SetPostSkinningOffsets(int LODIndex, TArray<FVector> Offsets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = LODIndex;

				*(nint*)(__InBuffer + 4) = Offsets?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPostSkinningOffsets, __InBuffer);
			}
		}

		/// <param name="NewPhysicsAsset">
		/// New PhysicsAsset
		/// </param>
		/// <param name="bForceReInit">
		/// Force reinitialize
		/// </param>
		public virtual void SetPhysicsAsset(UPhysicsAsset NewPhysicsAsset, bool bForceReInit = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewPhysicsAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceReInit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPhysicsAsset, __InBuffer);
			}
		}

		/// <param name="InNewMinLOD">
		/// Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update. 
		/// </param>
		public virtual void SetMinLOD(int InNewMinLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InNewMinLOD;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMinLOD, __InBuffer);
			}
		}

		/// <param name="InMeshDeformer">
		/// New mesh deformer to set for this component
		/// </param>
		public virtual void SetMeshDeformer(UMeshDeformer InMeshDeformer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InMeshDeformer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMeshDeformer, __InBuffer);
			}
		}

		/// <param name="NewLeaderBoneComponent">
		/// New LeaderPoseComponent
		/// </param>
		/// <param name="bForceUpdate">
		/// If false, the function will be skipped if NewLeaderBoneComponent is the same as currently setup (default)
		/// </param>
		/// <param name="bInFollowerShouldTickPose">
		/// If false, Follower components will not execute TickPose (default)
		/// </param>
		public virtual void SetLeaderPoseComponent(USkinnedMeshComponent NewLeaderBoneComponent, bool bForceUpdate = false, bool bInFollowerShouldTickPose = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = NewLeaderBoneComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForceUpdate;

				*(bool*)(__InBuffer + 9) = bInFollowerShouldTickPose;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLeaderPoseComponent, __InBuffer);
			}
		}

		/// <param name="InNewForcedLOD">
		/// Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update. 
		/// </param>
		public virtual void SetForcedLOD(int InNewForcedLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = InNewForcedLOD;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetForcedLOD, __InBuffer);
			}
		}

		public virtual void SetCastCapsuleIndirectShadow(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastCapsuleIndirectShadow, __InBuffer);
			}
		}

		public virtual void SetCastCapsuleDirectShadow(bool bNewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bNewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCastCapsuleDirectShadow, __InBuffer);
			}
		}

		public virtual void SetCapsuleIndirectShadowMinVisibility(float NewValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewValue;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCapsuleIndirectShadowMinVisibility, __InBuffer);
			}
		}

		public virtual bool IsUsingSkinWeightProfile()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsUsingSkinWeightProfile, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsMaterialSectionShown(int MaterialID, int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(int*)(__InBuffer) = MaterialID;

				*(int*)(__InBuffer + 4) = LODIndex;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsMaterialSectionShown, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of bone to check
		/// </param>
		/// <returns>
		/// true if hidden
		/// </returns>
		public virtual bool IsBoneHiddenByName(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsBoneHiddenByName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of bone to hide
		/// </param>
		/// <param name="PhysBodyOption">
		/// Option for physics bodies that attach to the bones to be hidden
		/// </param>
		public virtual void HideBoneByName(FName BoneName, EPhysBodyOp PhysBodyOption)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)PhysBodyOption;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HideBoneByName, __InBuffer);
			}
		}

		public virtual int GetVertexOffsetUsage(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetVertexOffsetUsage, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone
		/// </param>
		/// <param name="OutTwistAngle">
		/// TwistAngle in degree
		/// </param>
		/// <param name="OutSwingAngle">
		/// SwingAngle in degree
		/// </param>
		/// <returns>
		/// true if succeed. False otherwise. Often due to incorrect bone name. 
		/// </returns>
		public virtual bool GetTwistAndSwingAngleOfDeltaRotationFromRefPose(FName BoneName, ref float OutTwistAngle, ref float OutSwingAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = OutTwistAngle;

				*(float*)(__InBuffer + 12) = OutSwingAngle;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetTwistAndSwingAngleOfDeltaRotationFromRefPose, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutTwistAngle = *(float*)(__OutBuffer);

				OutSwingAngle = *(float*)(__OutBuffer + 4);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bone">
		/// name or socket name
		/// </param>
		/// <returns>
		/// bone name
		/// </returns>
		public virtual FName GetSocketBoneName(FName InSocketName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSocketName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetSocketBoneName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// the SkinnedAsset set to this mesh.
		/// </returns>
		public virtual USkinnedAsset GetSkinnedAsset()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkinnedAsset, __ReturnBuffer);

				return *(USkinnedAsset*)__ReturnBuffer;
			}
		}

		public virtual USkeletalMesh GetSkeletalMesh_DEPRECATED()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSkeletalMesh_DEPRECATED, __ReturnBuffer);

				return *(USkeletalMesh*)__ReturnBuffer;
			}
		}

		/// <param name="BoneIndex">
		/// Index of the bone
		/// </param>
		/// <returns>
		/// Local space reference transform 
		/// </returns>
		public virtual FTransform GetRefPoseTransform(int BoneIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = BoneIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRefPoseTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="BoneIndex">
		/// Index of the bone
		/// </param>
		/// <returns>
		/// Local space reference position 
		/// </returns>
		public virtual FVector GetRefPosePosition(int BoneIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = BoneIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetRefPosePosition, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual int GetPredictedLODLevel()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPredictedLODLevel, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone
		/// </param>
		/// <returns>
		/// the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone 
		/// </returns>
		public virtual FName GetParentBone(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetParentBone, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
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

		public virtual int GetNumBones()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumBones, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UMeshDeformerInstance GetMeshDeformerInstance()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetMeshDeformerInstance, __ReturnBuffer);

				return *(UMeshDeformerInstance*)__ReturnBuffer;
			}
		}

		public virtual int GetForcedLOD()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetForcedLOD, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of the bone
		/// </param>
		/// <param name="BaseName">
		/// Name of the base bone - if none, it will use parent as a base
		/// </param>
		/// <returns>
		/// the delta transform from refpose in that given space (BaseName)
		/// </returns>
		public virtual FTransform GetDeltaTransformFromRefPose(FName BoneName, FName BaseName = null)
		{
			unsafe
			{
				BaseName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDeltaTransformFromRefPose, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		public virtual FName GetCurrentSkinWeightProfileName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetCurrentSkinWeightProfileName, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="InBoneName">
		/// Name of the the bone to get the transform 
		/// </param>
		/// <returns>
		/// Bone transform in world space if bone is found. Otherwise it will return component's transform in world space.
		/// </returns>
		public virtual FTransform GetBoneTransform(FName InBoneName, ERelativeTransformSpace TransformSpace = ERelativeTransformSpace.RTS_World)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)TransformSpace;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="BoneIndex">
		/// Index of the bone
		/// </param>
		/// <returns>
		/// the name of the bone at the specified index 
		/// </returns>
		public virtual FName GetBoneName(int BoneIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = BoneIndex;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetBoneName, __InBuffer, __ReturnBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Name of bone to look up
		/// </param>
		/// <see>
		/// USkeletalMesh::GetBoneIndex.
		/// </see>
		/// <returns>
		/// Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found.
		/// </returns>
		public virtual int GetBoneIndex(FName BoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetBoneIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="TestLocation">
		/// the location to test against
		/// </param>
		/// <param name="BoneLocation">
		/// (optional, out) if specified, set to the world space location of the bone that was found, or (0,0,0) if no bone was found
		/// </param>
		/// <param name="IgnoreScale">
		/// (optional) if specified, only bones with scaling larger than the specified factor are considered
		/// </param>
		/// <param name="bRequirePhysicsAsset">
		/// (optional) if true, only bones with physics will be considered
		/// </param>
		/// <returns>
		/// the name of the bone that was found, or 'None' if no bone was found
		/// </returns>
		public virtual FName FindClosestBone_K2(FVector TestLocation, ref FVector BoneLocation, float IgnoreScale, bool bRequirePhysicsAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = TestLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = IgnoreScale;

				*(bool*)(__InBuffer + 20) = bRequirePhysicsAsset;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __FindClosestBone_K2, __InBuffer, __OutBuffer, __ReturnBuffer);

				BoneLocation = *(FVector*)(__OutBuffer);

				return *(FName*)__ReturnBuffer;
			}
		}

		public virtual void ClearVertexColorOverride(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearVertexColorOverride, __InBuffer);
			}
		}

		public virtual void ClearSkinWeightProfile()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSkinWeightProfile);
			}
		}

		public virtual void ClearSkinWeightOverride(int LODIndex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = LODIndex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ClearSkinWeightOverride, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// Name of the bone
		/// </param>
		/// <param name="ParentBone">
		/// Name to check
		/// </param>
		/// <returns>
		/// true if child (strictly, not same). false otherwise
		/// Note - will return false if ChildBoneIndex is the same as ParentBoneIndex ie. must be strictly a child.
		/// </returns>
		public virtual bool BoneIsChildOf(FName BoneName, FName ParentBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParentBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __BoneIsChildOf, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SkeletalMesh = 0;

		private static uint __SkinnedAsset = 0;

		private static uint __LeaderPoseComponent = 0;

		private static uint __SkinCacheUsage = 0;

		private static uint __bSetMeshDeformer = 0;

		private static uint __MeshDeformer = 0;

		private static uint __MeshDeformerInstanceSettings = 0;

		private static uint __MeshDeformerInstance = 0;

		private static uint __PhysicsAssetOverride = 0;

		private static uint __ForcedLodModel = 0;

		private static uint __MinLodModel = 0;

		private static uint __StreamingDistanceMultiplier = 0;

		private static uint __LODInfo = 0;

		private static uint __VisibilityBasedAnimTickOption = 0;

		private static uint __bOverrideMinLod = 0;

		private static uint __bUseBoundsFromLeaderPoseComponent = 0;

		private static uint __bForceWireframe = 0;

		private static uint __bDisableMorphTarget = 0;

		private static uint __bHideSkin = 0;

		private static uint __bPerBoneMotionBlur = 0;

		private static uint __bComponentUseFixedSkelBounds = 0;

		private static uint __bConsiderAllBodiesForBounds = 0;

		private static uint __bSyncAttachParentLOD = 0;

		private static uint __bCanHighlightSelectedSections = 0;

		private static uint __bRecentlyRendered = 0;

		private static uint __bCastCapsuleDirectShadow = 0;

		private static uint __bCastCapsuleIndirectShadow = 0;

		private static uint __bCPUSkinning = 0;

		private static uint __bEnableUpdateRateOptimizations = 0;

		private static uint __bDisplayDebugUpdateRateOptimizations = 0;

		private static uint __bRenderStatic = 0;

		private static uint __bIgnoreLeaderPoseComponentLOD = 0;

		private static uint __bCachedLocalBoundsUpToDate = 0;

		private static uint __bCachedWorldSpaceBoundsUpToDate = 0;

		private static uint __bForceMeshObjectUpdate = 0;

		private static uint __bForceUpdateDynamicDataImmediately = 0;

		private static uint __bFollowerShouldTickPose = 0;

		private static uint __CapsuleIndirectShadowMinVisibility = 0;

		private static uint __CachedWorldOrLocalSpaceBounds = 0;

		private static uint __CachedWorldToLocalTransform = 0;

		private static uint __ExecuteUbergraph = 0;

		private static uint __UnsetMeshDeformer = 0;

		private static uint __UnloadSkinWeightProfile = 0;

		private static uint __UnHideBoneByName = 0;

		private static uint __TransformToBoneSpace = 0;

		private static uint __TransformFromBoneSpace = 0;

		private static uint __ShowMaterialSection = 0;

		private static uint __ShowAllMaterialSections = 0;

		private static uint __SetVertexOffsetUsage = 0;

		private static uint __SetVertexColorOverride_LinearColor = 0;

		private static uint __SetSkinWeightProfile = 0;

		private static uint __SetSkinWeightOverride = 0;

		private static uint __SetSkinnedAssetAndUpdate = 0;

		private static uint __SetRenderStatic = 0;

		private static uint __SetPreSkinningOffsets = 0;

		private static uint __SetPostSkinningOffsets = 0;

		private static uint __SetPhysicsAsset = 0;

		private static uint __SetMinLOD = 0;

		private static uint __SetMeshDeformer = 0;

		private static uint __SetLeaderPoseComponent = 0;

		private static uint __SetForcedLOD = 0;

		private static uint __SetCastCapsuleIndirectShadow = 0;

		private static uint __SetCastCapsuleDirectShadow = 0;

		private static uint __SetCapsuleIndirectShadowMinVisibility = 0;

		private static uint __IsUsingSkinWeightProfile = 0;

		private static uint __IsMaterialSectionShown = 0;

		private static uint __IsBoneHiddenByName = 0;

		private static uint __HideBoneByName = 0;

		private static uint __GetVertexOffsetUsage = 0;

		private static uint __GetTwistAndSwingAngleOfDeltaRotationFromRefPose = 0;

		private static uint __GetSocketBoneName = 0;

		private static uint __GetSkinnedAsset = 0;

		private static uint __GetSkeletalMesh_DEPRECATED = 0;

		private static uint __GetRefPoseTransform = 0;

		private static uint __GetRefPosePosition = 0;

		private static uint __GetPredictedLODLevel = 0;

		private static uint __GetParentBone = 0;

		private static uint __GetNumLODs = 0;

		private static uint __GetNumBones = 0;

		private static uint __GetMeshDeformerInstance = 0;

		private static uint __GetForcedLOD = 0;

		private static uint __GetDeltaTransformFromRefPose = 0;

		private static uint __GetCurrentSkinWeightProfileName = 0;

		private static uint __GetBoneTransform = 0;

		private static uint __GetBoneName = 0;

		private static uint __GetBoneIndex = 0;

		private static uint __FindClosestBone_K2 = 0;

		private static uint __ClearVertexColorOverride = 0;

		private static uint __ClearSkinWeightProfile = 0;

		private static uint __ClearSkinWeightOverride = 0;

		private static uint __BoneIsChildOf = 0;
	}
}
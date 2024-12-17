﻿using Script.CoreUObject;

namespace Script.Engine
{
	[PathName("/Script/Engine.ESkeletalMeshAsyncProperties")]
	public enum ESkeletalMeshAsyncProperties : long
	{
		None = 0,
		Materials = 1,
		Skeleton = 2,
		RefSkeleton = 4,
		RetargetBasePose = 8,
		RefBasesInvMatrix = 16,
		MeshClothingAssets = 32,
		UseLegacyMeshDerivedDataKey = 64,
		HasActiveClothingAssets = 128,
		LODSettings = 256,
		HasVertexColors = 512,
		VertexColorGuid = 1024,
		MorphTargets = 2048,
		SkeletalMeshRenderData = 4096,
		MeshEditorDataObject = 8192,
		NeverStream = 16384,
		OverrideLODStreamingSettings = 32768,
		SupportLODStreaming = 65536,
		MaxNumStreamedLODs = 131072,
		MaxNumOptionalLODs = 262144,
		ImportedModel = 524288,
		LODInfo = 1048576,
		SkinWeightProfiles = 2097152,
		CachedComposedRefPoseMatrices = 4194304,
		SamplingInfo = 8388608,
		NodeMappingData = 16777216,
		ShadowPhysicsAsset = 33554432,
		SkelMirrorTable = 67108864,
		MinLod = 134217728,
		DisableBelowMinLodStripping = 268435456,
		SkelMirrorAxis = 536870912,
		SkelMirrorFlipAxis = 1073741824,
		DefaultAnimationRig = 2147483648,
		NegativeBoundsExtension = 4294967296,
		PositiveBoundsExtension = 8589934592,
		ExtendedBounds = 17179869184,
		HasBeenSimplified = 34359738368,
		EnablePerPolyCollision = 68719476736,
		BodySetup = 137438953472,
		MorphTargetIndexMap = 274877906944,
		FloorOffset = 549755813888,
		ImportedBounds = 1099511627776,
		PhysicsAsset = 2199023255552,
		AssetImportData = 4398046511104,
		ThumbnailInfo = 8796093022208,
		HasCustomDefaultEditorCamera = 17592186044416,
		DefaultEditorCameraLocation = 35184372088832,
		DefaultEditorCameraRotation = 70368744177664,
		RequiresLODScreenSizeConversion = 140737488355328,
		PostProcessAnimBlueprint = 281474976710656,
		DefaultEditorCameraLookAt = 562949953421312,
		PreviewAttachedAssetContainer = 1125899906842624,
		DefaultEditorCameraOrthoZoom = 2251799813685248,
		RequiresLODHysteresisConversion = 4503599627370496,
		bSupportRayTracing = 9007199254740992,
		RayTracingMinLOD = 18014398509481984,
		ClothLODBiasMode = 36028797018963968,
		DefaultMeshDeformer = 72057594037927936,
		OverlayMaterial = 144115188075855872,
		OverlayMaterialMaxDrawDistance = 288230376151711744,
		All = -1,
	}
}
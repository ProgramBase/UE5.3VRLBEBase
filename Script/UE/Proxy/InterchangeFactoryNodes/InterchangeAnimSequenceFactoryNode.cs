using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;
using Script.InterchangeNodes;

namespace Script.InterchangeFactoryNodes
{
	[PathName("/Script/InterchangeFactoryNodes.InterchangeAnimSequenceFactoryNode")]
	public partial class UInterchangeAnimSequenceFactoryNode : UInterchangeFactoryBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeFactoryNodes.InterchangeAnimSequenceFactoryNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetCustomSkeletonSoftObjectPath(FSoftObjectPath AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSkeletonSoftObjectPath, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomSkeletonFactoryNodeUid(FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomSkeletonFactoryNodeUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomRemoveCurveRedundantKeys(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomRemoveCurveRedundantKeys, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomMaterialDriveParameterOnCustomAttribute(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomMaterialDriveParameterOnCustomAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportBoneTracksSampleRate(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportBoneTracksSampleRate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportBoneTracksRangeStop(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportBoneTracksRangeStop, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportBoneTracksRangeStart(double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportBoneTracksRangeStart, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportBoneTracks(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportBoneTracks, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomImportAttributeCurves(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomImportAttributeCurves, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomDoNotImportCurveWithZero(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomDoNotImportCurveWithZero, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomDeleteExistingNonCurveCustomAttributes(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomDeleteExistingNonCurveCustomAttributes, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomDeleteExistingMorphTargetCurves(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomDeleteExistingMorphTargetCurves, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomDeleteExistingCustomAttributeCurves(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomDeleteExistingCustomAttributeCurves, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAddCurveMetadataToSkeleton(bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAddCurveMetadataToSkeleton, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetAnimationPayloadKeysForSceneNodeUids(TMap<FString, FString> SceneNodeAnimationPayloadKeyUids, TMap<FString, byte> SceneNodeAnimationPayloadKeyTypes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SceneNodeAnimationPayloadKeyUids?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SceneNodeAnimationPayloadKeyTypes?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimationPayloadKeysForSceneNodeUids, __InBuffer);
			}
		}

		public virtual void SetAnimationPayloadKeysForMorphTargetNodeUids(TMap<FString, FString> MorphTargetAnimationPayloadKeyUids, TMap<FString, byte> MorphTargetAnimationPayloadKeyTypes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = MorphTargetAnimationPayloadKeyUids?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MorphTargetAnimationPayloadKeyTypes?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimationPayloadKeysForMorphTargetNodeUids, __InBuffer);
			}
		}

		public virtual bool SetAnimatedMaterialCurveSuffixe(FString MaterialCurveSuffixe)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialCurveSuffixe?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAnimatedMaterialCurveSuffixe, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetAnimatedAttributeStepCurveName(FString AttributeStepCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeStepCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAnimatedAttributeStepCurveName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetAnimatedAttributeCurveName(FString AttributeCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetAnimatedAttributeCurveName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAnimatedMaterialCurveSuffixe(FString MaterialCurveSuffixe)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = MaterialCurveSuffixe?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAnimatedMaterialCurveSuffixe, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAnimatedAttributeStepCurveName(FString AttributeStepCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeStepCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAnimatedAttributeStepCurveName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveAnimatedAttributeCurveName(FString AttributeCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAnimatedAttributeCurveName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="UniqueID">
		/// - The uniqueId for this node
		/// </param>
		/// <param name="DisplayLabel">
		/// - The name of the node
		/// </param>
		public virtual void InitializeAnimSequenceNode(FString UniqueID, FString DisplayLabel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = UniqueID?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DisplayLabel?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitializeAnimSequenceNode, __InBuffer);
			}
		}

		public virtual void GetSceneNodeAnimationPayloadKeys(ref TMap<FString, FInterchangeAnimationPayLoadKey> OutSceneNodeAnimationPayloadKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutSceneNodeAnimationPayloadKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSceneNodeAnimationPayloadKeys, __InBuffer, __OutBuffer);

				OutSceneNodeAnimationPayloadKeys = *(TMap<FString, FInterchangeAnimationPayLoadKey>*)(__OutBuffer);

			}
		}

		public virtual UClass GetObjectClass()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetObjectClass, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		public virtual void GetMorphTargetNodeAnimationPayloadKeys(ref TMap<FString, FInterchangeAnimationPayLoadKey> OutMorphTargetNodeAnimationPayloads)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutMorphTargetNodeAnimationPayloads?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMorphTargetNodeAnimationPayloadKeys, __InBuffer, __OutBuffer);

				OutMorphTargetNodeAnimationPayloads = *(TMap<FString, FInterchangeAnimationPayLoadKey>*)(__OutBuffer);

			}
		}

		public virtual bool GetCustomSkeletonSoftObjectPath(ref FSoftObjectPath AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSkeletonSoftObjectPath, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FSoftObjectPath*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomSkeletonFactoryNodeUid(ref FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomSkeletonFactoryNodeUid, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomRemoveCurveRedundantKeys(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomRemoveCurveRedundantKeys, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomMaterialDriveParameterOnCustomAttribute(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomMaterialDriveParameterOnCustomAttribute, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportBoneTracksSampleRate(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportBoneTracksSampleRate, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportBoneTracksRangeStop(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportBoneTracksRangeStop, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportBoneTracksRangeStart(ref double AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(double*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportBoneTracksRangeStart, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(double*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportBoneTracks(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportBoneTracks, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomImportAttributeCurves(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomImportAttributeCurves, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomDoNotImportCurveWithZero(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomDoNotImportCurveWithZero, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomDeleteExistingNonCurveCustomAttributes(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomDeleteExistingNonCurveCustomAttributes, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomDeleteExistingMorphTargetCurves(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomDeleteExistingMorphTargetCurves, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomDeleteExistingCustomAttributeCurves(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomDeleteExistingCustomAttributeCurves, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAddCurveMetadataToSkeleton(ref bool AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = AttributeValue;

				var __OutBuffer = stackalloc byte[1];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAddCurveMetadataToSkeleton, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(bool*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int GetAnimatedMaterialCurveSuffixesCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimatedMaterialCurveSuffixesCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetAnimatedMaterialCurveSuffixes(ref TArray<FString> OutMaterialCurveSuffixes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutMaterialCurveSuffixes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedMaterialCurveSuffixes, __InBuffer, __OutBuffer);

				OutMaterialCurveSuffixes = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAnimatedMaterialCurveSuffixe(int Index, ref FString OutMaterialCurveSuffixe)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutMaterialCurveSuffixe?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedMaterialCurveSuffixe, __InBuffer, __OutBuffer);

				OutMaterialCurveSuffixe = *(FString*)(__OutBuffer);

			}
		}

		public virtual int GetAnimatedAttributeStepCurveNamesCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimatedAttributeStepCurveNamesCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetAnimatedAttributeStepCurveNames(ref TArray<FString> OutAttributeStepCurveNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAttributeStepCurveNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedAttributeStepCurveNames, __InBuffer, __OutBuffer);

				OutAttributeStepCurveNames = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAnimatedAttributeStepCurveName(int Index, ref FString OutAttributeStepCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutAttributeStepCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedAttributeStepCurveName, __InBuffer, __OutBuffer);

				OutAttributeStepCurveName = *(FString*)(__OutBuffer);

			}
		}

		public virtual int GetAnimatedAttributeCurveNamesCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetAnimatedAttributeCurveNamesCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetAnimatedAttributeCurveNames(ref TArray<FString> OutAttributeCurveNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutAttributeCurveNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedAttributeCurveNames, __InBuffer, __OutBuffer);

				OutAttributeCurveNames = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual void GetAnimatedAttributeCurveName(int Index, ref FString OutAttributeCurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutAttributeCurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetAnimatedAttributeCurveName, __InBuffer, __OutBuffer);

				OutAttributeCurveName = *(FString*)(__OutBuffer);

			}
		}

		private static uint __SetCustomSkeletonSoftObjectPath = 0;

		private static uint __SetCustomSkeletonFactoryNodeUid = 0;

		private static uint __SetCustomRemoveCurveRedundantKeys = 0;

		private static uint __SetCustomMaterialDriveParameterOnCustomAttribute = 0;

		private static uint __SetCustomImportBoneTracksSampleRate = 0;

		private static uint __SetCustomImportBoneTracksRangeStop = 0;

		private static uint __SetCustomImportBoneTracksRangeStart = 0;

		private static uint __SetCustomImportBoneTracks = 0;

		private static uint __SetCustomImportAttributeCurves = 0;

		private static uint __SetCustomDoNotImportCurveWithZero = 0;

		private static uint __SetCustomDeleteExistingNonCurveCustomAttributes = 0;

		private static uint __SetCustomDeleteExistingMorphTargetCurves = 0;

		private static uint __SetCustomDeleteExistingCustomAttributeCurves = 0;

		private static uint __SetCustomAddCurveMetadataToSkeleton = 0;

		private static uint __SetAnimationPayloadKeysForSceneNodeUids = 0;

		private static uint __SetAnimationPayloadKeysForMorphTargetNodeUids = 0;

		private static uint __SetAnimatedMaterialCurveSuffixe = 0;

		private static uint __SetAnimatedAttributeStepCurveName = 0;

		private static uint __SetAnimatedAttributeCurveName = 0;

		private static uint __RemoveAnimatedMaterialCurveSuffixe = 0;

		private static uint __RemoveAnimatedAttributeStepCurveName = 0;

		private static uint __RemoveAnimatedAttributeCurveName = 0;

		private static uint __InitializeAnimSequenceNode = 0;

		private static uint __GetSceneNodeAnimationPayloadKeys = 0;

		private static uint __GetObjectClass = 0;

		private static uint __GetMorphTargetNodeAnimationPayloadKeys = 0;

		private static uint __GetCustomSkeletonSoftObjectPath = 0;

		private static uint __GetCustomSkeletonFactoryNodeUid = 0;

		private static uint __GetCustomRemoveCurveRedundantKeys = 0;

		private static uint __GetCustomMaterialDriveParameterOnCustomAttribute = 0;

		private static uint __GetCustomImportBoneTracksSampleRate = 0;

		private static uint __GetCustomImportBoneTracksRangeStop = 0;

		private static uint __GetCustomImportBoneTracksRangeStart = 0;

		private static uint __GetCustomImportBoneTracks = 0;

		private static uint __GetCustomImportAttributeCurves = 0;

		private static uint __GetCustomDoNotImportCurveWithZero = 0;

		private static uint __GetCustomDeleteExistingNonCurveCustomAttributes = 0;

		private static uint __GetCustomDeleteExistingMorphTargetCurves = 0;

		private static uint __GetCustomDeleteExistingCustomAttributeCurves = 0;

		private static uint __GetCustomAddCurveMetadataToSkeleton = 0;

		private static uint __GetAnimatedMaterialCurveSuffixesCount = 0;

		private static uint __GetAnimatedMaterialCurveSuffixes = 0;

		private static uint __GetAnimatedMaterialCurveSuffixe = 0;

		private static uint __GetAnimatedAttributeStepCurveNamesCount = 0;

		private static uint __GetAnimatedAttributeStepCurveNames = 0;

		private static uint __GetAnimatedAttributeStepCurveName = 0;

		private static uint __GetAnimatedAttributeCurveNamesCount = 0;

		private static uint __GetAnimatedAttributeCurveNames = 0;

		private static uint __GetAnimatedAttributeCurveName = 0;
	}
}
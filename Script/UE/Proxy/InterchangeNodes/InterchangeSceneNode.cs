using Script.CoreUObject;
using Script.InterchangeCore;
using Script.Library;

namespace Script.InterchangeNodes
{
	[PathName("/Script/InterchangeNodes.InterchangeSceneNode")]
	public partial class UInterchangeSceneNode : UInterchangeBaseNode, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InterchangeNodes.InterchangeSceneNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool SetSlotMaterialDependencyUid(FString SlotName, FString MaterialDependencyUid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MaterialDependencyUid?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetSlotMaterialDependencyUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetMorphTargetCurveWeight(FString MorphTargetName, float Weight)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = MorphTargetName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Weight;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetMorphTargetCurveWeight, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomTimeZeroLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform AttributeValue, bool bResetCache = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bResetCache;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomTimeZeroLocalTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform AttributeValue, bool bResetCache = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bResetCache;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomLocalTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomGeometricTransform(FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomGeometricTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomBindPoseLocalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform AttributeValue, bool bResetCache = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bResetCache;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomBindPoseLocalTransform, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAssetInstanceUid(FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAssetInstanceUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SetCustomAnimationAssetUidToPlay(FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCustomAnimationAssetUidToPlay, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveSpecializedType(FString SpecializedType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpecializedType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSpecializedType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool RemoveSlotMaterialDependencyUid(FString SlotName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveSlotMaterialDependencyUid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsSpecializedTypeContains(FString SpecializedType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpecializedType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsSpecializedTypeContains, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetSpecializedTypes(ref TArray<FString> OutSpecializedTypes)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutSpecializedTypes?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSpecializedTypes, __InBuffer, __OutBuffer);

				OutSpecializedTypes = *(TArray<FString>*)(__OutBuffer);

			}
		}

		public virtual int GetSpecializedTypeCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetSpecializedTypeCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual void GetSpecializedType(int Index, ref FString OutSpecializedType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = Index;

				*(nint*)(__InBuffer + 4) = OutSpecializedType?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSpecializedType, __InBuffer, __OutBuffer);

				OutSpecializedType = *(FString*)(__OutBuffer);

			}
		}

		public virtual bool GetSlotMaterialDependencyUid(FString SlotName, ref FString OutMaterialDependency)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SlotName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutMaterialDependency?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetSlotMaterialDependencyUid, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutMaterialDependency = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void GetSlotMaterialDependencies(ref TMap<FString, FString> OutMaterialDependencies)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutMaterialDependencies?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSlotMaterialDependencies, __InBuffer, __OutBuffer);

				OutMaterialDependencies = *(TMap<FString, FString>*)(__OutBuffer);

			}
		}

		public virtual void GetMorphTargetCurveWeights(ref TMap<FString, float> OutMorphTargetCurveWeights)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OutMorphTargetCurveWeights?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetMorphTargetCurveWeights, __InBuffer, __OutBuffer);

				OutMorphTargetCurveWeights = *(TMap<FString, float>*)(__OutBuffer);

			}
		}

		public virtual bool GetCustomTimeZeroLocalTransform(ref FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomTimeZeroLocalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomTimeZeroGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform GlobalOffsetTransform, ref FTransform AttributeValue, bool bForceRecache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GlobalOffsetTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bForceRecache;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomTimeZeroGlobalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomLocalTransform(ref FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomLocalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform GlobalOffsetTransform, ref FTransform AttributeValue, bool bForceRecache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GlobalOffsetTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bForceRecache;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomGlobalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomGeometricTransform(ref FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomGeometricTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomBindPoseLocalTransform(ref FTransform AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomBindPoseLocalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomBindPoseGlobalTransform(UInterchangeBaseNodeContainer BaseNodeContainer, FTransform GlobalOffsetTransform, ref FTransform AttributeValue, bool bForceRecache)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = BaseNodeContainer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = GlobalOffsetTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bForceRecache;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomBindPoseGlobalTransform, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FTransform*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAssetInstanceUid(ref FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAssetInstanceUid, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool GetCustomAnimationAssetUidToPlay(ref FString AttributeValue)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AttributeValue?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(GarbageCollectionHandle, __GetCustomAnimationAssetUidToPlay, __InBuffer, __OutBuffer, __ReturnBuffer);

				AttributeValue = *(FString*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool AddSpecializedType(FString SpecializedType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = SpecializedType?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddSpecializedType, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __SetSlotMaterialDependencyUid = 0;

		private static uint __SetMorphTargetCurveWeight = 0;

		private static uint __SetCustomTimeZeroLocalTransform = 0;

		private static uint __SetCustomLocalTransform = 0;

		private static uint __SetCustomGeometricTransform = 0;

		private static uint __SetCustomBindPoseLocalTransform = 0;

		private static uint __SetCustomAssetInstanceUid = 0;

		private static uint __SetCustomAnimationAssetUidToPlay = 0;

		private static uint __RemoveSpecializedType = 0;

		private static uint __RemoveSlotMaterialDependencyUid = 0;

		private static uint __IsSpecializedTypeContains = 0;

		private static uint __GetSpecializedTypes = 0;

		private static uint __GetSpecializedTypeCount = 0;

		private static uint __GetSpecializedType = 0;

		private static uint __GetSlotMaterialDependencyUid = 0;

		private static uint __GetSlotMaterialDependencies = 0;

		private static uint __GetMorphTargetCurveWeights = 0;

		private static uint __GetCustomTimeZeroLocalTransform = 0;

		private static uint __GetCustomTimeZeroGlobalTransform = 0;

		private static uint __GetCustomLocalTransform = 0;

		private static uint __GetCustomGlobalTransform = 0;

		private static uint __GetCustomGeometricTransform = 0;

		private static uint __GetCustomBindPoseLocalTransform = 0;

		private static uint __GetCustomBindPoseGlobalTransform = 0;

		private static uint __GetCustomAssetInstanceUid = 0;

		private static uint __GetCustomAnimationAssetUidToPlay = 0;

		private static uint __AddSpecializedType = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.AnimGraph;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary")]
	public partial class UAnimationBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.AnimationBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetVariableFrameStrippingSettings(UAnimSequence AnimationSequence, UVariableFrameStrippingSettings VariableFrameStrippingSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariableFrameStrippingSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetVariableFrameStrippingSettings, __InBuffer);
			}
		}

		public static void SetRootMotionLockType(UAnimSequence AnimationSequence, ERootMotionRootLock RootMotionLockType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)RootMotionLockType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRootMotionLockType, __InBuffer);
			}
		}

		public static void SetRootMotionEnabled(UAnimSequence AnimationSequence, bool bEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRootMotionEnabled, __InBuffer);
			}
		}

		public static void SetRateScale(UAnimSequenceBase AnimationSequenceBase, float RateScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = RateScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetRateScale, __InBuffer);
			}
		}

		public static void SetIsRootMotionLockForced(UAnimSequence AnimationSequence, bool bForced)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForced;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetIsRootMotionLockForced, __InBuffer);
			}
		}

		public static void SetCurveCompressionSettings(UAnimSequence AnimationSequence, UAnimCurveCompressionSettings CompressionSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CompressionSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetCurveCompressionSettings, __InBuffer);
			}
		}

		public static void SetBoneCompressionSettings(UAnimSequence AnimationSequence, UAnimBoneCompressionSettings CompressionSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CompressionSettings?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetBoneCompressionSettings, __InBuffer);
			}
		}

		public static void SetAnimationInterpolationType(UAnimSequence AnimationSequence, EAnimInterpolationType InterpolationType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InterpolationType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetAnimationInterpolationType, __InBuffer);
			}
		}

		public static void SetAdditiveBasePoseType(UAnimSequence AnimationSequence, EAdditiveBasePoseType AdditiveBasePoseType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)AdditiveBasePoseType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetAdditiveBasePoseType, __InBuffer);
			}
		}

		public static void SetAdditiveAnimationType(UAnimSequence AnimationSequence, EAdditiveAnimationType AdditiveAnimationType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)AdditiveAnimationType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetAdditiveAnimationType, __InBuffer);
			}
		}

		public static void ReplaceAnimNotifyStates(UAnimSequenceBase AnimationSequenceBase, TSubclassOf<UAnimNotifyState> OldNotifyClass, TSubclassOf<UAnimNotifyState> NewNotifyClass, FOnNotifyStateReplaced OnNotifyStateReplaced)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldNotifyClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewNotifyClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OnNotifyStateReplaced?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceAnimNotifyStates, __InBuffer);
			}
		}

		public static void ReplaceAnimNotifies(UAnimSequenceBase AnimationSequenceBase, TSubclassOf<UAnimNotify> OldNotifyClass, TSubclassOf<UAnimNotify> NewNotifyClass, FOnNotifyReplaced OnNotifyReplaced)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OldNotifyClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = NewNotifyClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OnNotifyReplaced?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ReplaceAnimNotifies, __InBuffer);
			}
		}

		public static void RemoveVirtualBones(UAnimSequence AnimationSequence, TArray<FName> VirtualBoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VirtualBoneNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVirtualBones, __InBuffer);
			}
		}

		public static void RemoveVirtualBone(UAnimSequence AnimationSequence, FName VirtualBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VirtualBoneName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveVirtualBone, __InBuffer);
			}
		}

		public static void RemoveMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveMetaDataOfClass, __InBuffer);
			}
		}

		public static void RemoveMetaData(UAnimationAsset AnimationAsset, UAnimMetaData MetaDataObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveMetaData, __InBuffer);
			}
		}

		public static void RemoveCurve(UAnimSequence AnimationSequence, FName CurveName, bool bRemoveNameFromSkeleton = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bRemoveNameFromSkeleton;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveCurve, __InBuffer);
			}
		}

		/// <param name="AnimationSequence">
		/// : AnimSequence
		/// </param>
		/// <param name="BoneName">
		/// : Name of bone track user wants to remove
		/// </param>
		/// <param name="bIncludeChildren">
		/// : true if user wants to include all children of BoneName
		/// </param>
		/// <param name="bFinalize">
		/// : If you set this to true, it will trigger compression. If you set bFinalize to be false, you'll have to manually trigger Finalize. 
		/// </param>
		public static void RemoveBoneAnimation(UAnimSequence AnimationSequence, FName BoneName, bool bIncludeChildren = true, bool bFinalize = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bIncludeChildren;

				*(bool*)(__InBuffer + 17) = bFinalize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveBoneAnimation, __InBuffer);
			}
		}

		public static int RemoveAnimationSyncMarkersByTrack(UAnimSequence AnimationSequence, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveAnimationSyncMarkersByTrack, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int RemoveAnimationSyncMarkersByName(UAnimSequence AnimationSequence, FName MarkerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveAnimationSyncMarkersByName, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void RemoveAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAnimationNotifyTrack, __InBuffer);
			}
		}

		public static int RemoveAnimationNotifyEventsByTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveAnimationNotifyEventsByTrack, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static int RemoveAnimationNotifyEventsByName(UAnimSequenceBase AnimationSequenceBase, FName NotifyName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __RemoveAnimationNotifyEventsByName, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static void RemoveAllVirtualBones(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllVirtualBones, __InBuffer);
			}
		}

		public static void RemoveAllMetaData(UAnimationAsset AnimationAsset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllMetaData, __InBuffer);
			}
		}

		public static void RemoveAllCurveData(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllCurveData, __InBuffer);
			}
		}

		public static void RemoveAllBoneAnimation(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllBoneAnimation, __InBuffer);
			}
		}

		public static void RemoveAllAnimationSyncMarkers(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllAnimationSyncMarkers, __InBuffer);
			}
		}

		public static void RemoveAllAnimationNotifyTracks(UAnimSequenceBase AnimationSequenceBase)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllAnimationNotifyTracks, __InBuffer);
			}
		}

		public static void IsValidTime(UAnimSequenceBase AnimationSequenceBase, float Time, ref bool IsValid)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(bool*)(__InBuffer + 12) = IsValid;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __IsValidTime, __InBuffer, __OutBuffer);

				IsValid = *(bool*)(__OutBuffer);

			}
		}

		public static bool IsValidRawAnimationTrackName(UAnimSequenceBase AnimationSequenceBase, FName TrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidRawAnimationTrackName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidAnimNotifyTrackName(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidAnimNotifyTrackName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidAnimationSyncMarkerName(UAnimSequence AnimationSequence, FName MarkerName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidAnimationSyncMarkerName, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRootMotionLockForced(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRootMotionLockForced, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsRootMotionEnabled(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsRootMotionEnabled, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void GetVectorKeys(UAnimSequence AnimationSequence, FName CurveName, ref TArray<float> Times, ref TArray<FVector> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetVectorKeys, __InBuffer, __OutBuffer);

				Times = *(TArray<float>*)(__OutBuffer);

				Values = *(TArray<FVector>*)(__OutBuffer + 8);

			}
		}

		public static void GetVariableFrameStrippingSettings(UAnimSequence AnimationSequence, ref UVariableFrameStrippingSettings VariableFrameStrippingSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = VariableFrameStrippingSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetVariableFrameStrippingSettings, __InBuffer, __OutBuffer);

				VariableFrameStrippingSettings = *(UVariableFrameStrippingSettings*)(__OutBuffer);

			}
		}

		public static void GetUniqueMarkerNames(UAnimSequence AnimationSequence, ref TArray<FName> MarkerNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetUniqueMarkerNames, __InBuffer, __OutBuffer);

				MarkerNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetTransformationKeys(UAnimSequence AnimationSequence, FName CurveName, ref TArray<float> Times, ref TArray<FTransform> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetTransformationKeys, __InBuffer, __OutBuffer);

				Times = *(TArray<float>*)(__OutBuffer);

				Values = *(TArray<FTransform>*)(__OutBuffer + 8);

			}
		}

		public static void GetTimeAtFrame(UAnimSequenceBase AnimationSequenceBase, int Frame, ref float Time)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Frame;

				*(float*)(__InBuffer + 12) = Time;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetTimeAtFrame, __InBuffer, __OutBuffer);

				Time = *(float*)(__OutBuffer);

			}
		}

		public static void GetSequenceLength(UAnimSequenceBase AnimationSequenceBase, ref float Length)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Length;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSequenceLength, __InBuffer, __OutBuffer);

				Length = *(float*)(__OutBuffer);

			}
		}

		public static void GetRootMotionLockType(UAnimSequence AnimationSequence, ref ERootMotionRootLock LockType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)LockType;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRootMotionLockType, __InBuffer, __OutBuffer);

				LockType = *(ERootMotionRootLock*)(__OutBuffer);

			}
		}

		public static void GetRawTrackScaleData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, ref TArray<FVector> ScaleData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ScaleData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRawTrackScaleData, __InBuffer, __OutBuffer);

				ScaleData = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public static void GetRawTrackRotationData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, ref TArray<FQuat> RotationData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RotationData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRawTrackRotationData, __InBuffer, __OutBuffer);

				RotationData = *(TArray<FQuat>*)(__OutBuffer);

			}
		}

		public static void GetRawTrackPositionData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, ref TArray<FVector> PositionData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PositionData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRawTrackPositionData, __InBuffer, __OutBuffer);

				PositionData = *(TArray<FVector>*)(__OutBuffer);

			}
		}

		public static void GetRawTrackData(UAnimSequenceBase AnimationSequenceBase, FName TrackName, ref TArray<FVector> PositionKeys, ref TArray<FQuat> RotationKeys, ref TArray<FVector> ScalingKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[40];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = PositionKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = RotationKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = ScalingKeys?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRawTrackData, __InBuffer, __OutBuffer);

				PositionKeys = *(TArray<FVector>*)(__OutBuffer);

				RotationKeys = *(TArray<FQuat>*)(__OutBuffer + 8);

				ScalingKeys = *(TArray<FVector>*)(__OutBuffer + 16);

			}
		}

		public static void GetRateScale(UAnimSequenceBase AnimationSequenceBase, ref float RateScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = RateScale;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetRateScale, __InBuffer, __OutBuffer);

				RateScale = *(float*)(__OutBuffer);

			}
		}

		public static void GetNumKeys(UAnimSequenceBase AnimationSequenceBase, ref int NumKeys)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NumKeys;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetNumKeys, __InBuffer, __OutBuffer);

				NumKeys = *(int*)(__OutBuffer);

			}
		}

		public static void GetNumFrames(UAnimSequenceBase AnimationSequenceBase, ref int NumFrames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = NumFrames;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetNumFrames, __InBuffer, __OutBuffer);

				NumFrames = *(int*)(__OutBuffer);

			}
		}

		public static void GetNodesOfClass(UAnimBlueprint AnimationBlueprint, TSubclassOf<UAnimGraphNode_Base> NodeClass, ref TArray<UAnimGraphNode_Base> GraphNodes, bool bIncludeChildClasses)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = AnimationBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NodeClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GraphNodes?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bIncludeChildClasses;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetNodesOfClass, __InBuffer, __OutBuffer);

				GraphNodes = *(TArray<UAnimGraphNode_Base>*)(__OutBuffer);

			}
		}

		public static void GetMontageSlotNames(UAnimMontage AnimationMontage, ref TArray<FName> SlotNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationMontage?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SlotNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMontageSlotNames, __InBuffer, __OutBuffer);

				SlotNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass, ref TArray<UAnimMetaData> MetaDataOfClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MetaDataOfClass?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMetaDataOfClass, __InBuffer, __OutBuffer);

				MetaDataOfClass = *(TArray<UAnimMetaData>*)(__OutBuffer);

			}
		}

		public static void GetMetaData(UAnimationAsset AnimationAsset, ref TArray<UAnimMetaData> MetaData)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaData?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetMetaData, __InBuffer, __OutBuffer);

				MetaData = *(TArray<UAnimMetaData>*)(__OutBuffer);

			}
		}

		public static void GetFrameAtTime(UAnimSequenceBase AnimationSequenceBase, float Time, ref int Frame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(int*)(__InBuffer + 12) = Frame;

				var __OutBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetFrameAtTime, __InBuffer, __OutBuffer);

				Frame = *(int*)(__OutBuffer);

			}
		}

		public static void GetFloatKeys(UAnimSequence AnimationSequence, FName CurveName, ref TArray<float> Times, ref TArray<float> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetFloatKeys, __InBuffer, __OutBuffer);

				Times = *(TArray<float>*)(__OutBuffer);

				Values = *(TArray<float>*)(__OutBuffer + 8);

			}
		}

		public static void GetCurveCompressionSettings(UAnimSequence AnimationSequence, ref UAnimCurveCompressionSettings CompressionSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CompressionSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetCurveCompressionSettings, __InBuffer, __OutBuffer);

				CompressionSettings = *(UAnimCurveCompressionSettings*)(__OutBuffer);

			}
		}

		public static void GetBonePosesForTime(UAnimSequenceBase AnimationSequenceBase, TArray<FName> BoneNames, float Time, bool bExtractRootMotion, ref TArray<FTransform> Poses, USkeletalMesh PreviewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(bool*)(__InBuffer + 20) = bExtractRootMotion;

				*(nint*)(__InBuffer + 21) = Poses?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 29) = PreviewMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBonePosesForTime, __InBuffer, __OutBuffer);

				Poses = *(TArray<FTransform>*)(__OutBuffer);

			}
		}

		public static void GetBonePosesForFrame(UAnimSequenceBase AnimationSequenceBase, TArray<FName> BoneNames, int Frame, bool bExtractRootMotion, ref TArray<FTransform> Poses, USkeletalMesh PreviewMesh)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Frame;

				*(bool*)(__InBuffer + 20) = bExtractRootMotion;

				*(nint*)(__InBuffer + 21) = Poses?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 29) = PreviewMesh?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBonePosesForFrame, __InBuffer, __OutBuffer);

				Poses = *(TArray<FTransform>*)(__OutBuffer);

			}
		}

		public static void GetBonePoseForTime(UAnimSequenceBase AnimationSequenceBase, FName BoneName, float Time, bool bExtractRootMotion, ref FTransform Pose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(bool*)(__InBuffer + 20) = bExtractRootMotion;

				*(nint*)(__InBuffer + 21) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBonePoseForTime, __InBuffer, __OutBuffer);

				Pose = *(FTransform*)(__OutBuffer);

			}
		}

		public static void GetBonePoseForFrame(UAnimSequenceBase AnimationSequenceBase, FName BoneName, int Frame, bool bExtractRootMotion, ref FTransform Pose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[29];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 16) = Frame;

				*(bool*)(__InBuffer + 20) = bExtractRootMotion;

				*(nint*)(__InBuffer + 21) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBonePoseForFrame, __InBuffer, __OutBuffer);

				Pose = *(FTransform*)(__OutBuffer);

			}
		}

		public static void GetBoneCompressionSettings(UAnimSequence AnimationSequence, ref UAnimBoneCompressionSettings CompressionSettings)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CompressionSettings?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBoneCompressionSettings, __InBuffer, __OutBuffer);

				CompressionSettings = *(UAnimBoneCompressionSettings*)(__OutBuffer);

			}
		}

		public static float GetAnimNotifyEventTriggerTime(FAnimNotifyEvent NotifyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NotifyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimNotifyEventTriggerTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static float GetAnimNotifyEventDuration(FAnimNotifyEvent NotifyEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NotifyEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAnimNotifyEventDuration, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public static void GetAnimationTrackNames(UAnimSequenceBase AnimationSequenceBase, ref TArray<FName> TrackNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationTrackNames, __InBuffer, __OutBuffer);

				TrackNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetAnimationSyncMarkersForTrack(UAnimSequence AnimationSequence, FName NotifyTrackName, ref TArray<FAnimSyncMarker> Markers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Markers?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationSyncMarkersForTrack, __InBuffer, __OutBuffer);

				Markers = *(TArray<FAnimSyncMarker>*)(__OutBuffer);

			}
		}

		public static void GetAnimationSyncMarkers(UAnimSequence AnimationSequence, ref TArray<FAnimSyncMarker> Markers)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Markers?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationSyncMarkers, __InBuffer, __OutBuffer);

				Markers = *(TArray<FAnimSyncMarker>*)(__OutBuffer);

			}
		}

		public static void GetAnimationNotifyTrackNames(UAnimSequenceBase AnimationSequenceBase, ref TArray<FName> TrackNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TrackNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationNotifyTrackNames, __InBuffer, __OutBuffer);

				TrackNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetAnimationNotifyEventsForTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, ref TArray<FAnimNotifyEvent> Events)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Events?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationNotifyEventsForTrack, __InBuffer, __OutBuffer);

				Events = *(TArray<FAnimNotifyEvent>*)(__OutBuffer);

			}
		}

		public static void GetAnimationNotifyEvents(UAnimSequenceBase AnimationSequenceBase, ref TArray<FAnimNotifyEvent> NotifyEvents)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyEvents?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationNotifyEvents, __InBuffer, __OutBuffer);

				NotifyEvents = *(TArray<FAnimNotifyEvent>*)(__OutBuffer);

			}
		}

		public static void GetAnimationNotifyEventNames(UAnimSequenceBase AnimationSequenceBase, ref TArray<FName> EventNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = EventNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationNotifyEventNames, __InBuffer, __OutBuffer);

				EventNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetAnimationInterpolationType(UAnimSequence AnimationSequence, ref EAnimInterpolationType InterpolationType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)InterpolationType;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationInterpolationType, __InBuffer, __OutBuffer);

				InterpolationType = *(EAnimInterpolationType*)(__OutBuffer);

			}
		}

		public static void GetAnimationGraphs(UAnimBlueprint AnimationBlueprint, ref TArray<UAnimationGraph> AnimationGraphs)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimationGraphs?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationGraphs, __InBuffer, __OutBuffer);

				AnimationGraphs = *(TArray<UAnimationGraph>*)(__OutBuffer);

			}
		}

		public static void GetAnimationCurveNames(UAnimSequence AnimationSequence, ERawCurveTrackTypes CurveType, ref TArray<FName> CurveNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)CurveType;

				*(nint*)(__InBuffer + 9) = CurveNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimationCurveNames, __InBuffer, __OutBuffer);

				CurveNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void GetAdditiveBasePoseType(UAnimSequence AnimationSequence, ref EAdditiveBasePoseType AdditiveBasePoseType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)AdditiveBasePoseType;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAdditiveBasePoseType, __InBuffer, __OutBuffer);

				AdditiveBasePoseType = *(EAdditiveBasePoseType*)(__OutBuffer);

			}
		}

		public static void GetAdditiveAnimationType(UAnimSequence AnimationSequence, ref EAdditiveAnimationType AdditiveAnimationType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)AdditiveAnimationType;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAdditiveAnimationType, __InBuffer, __OutBuffer);

				AdditiveAnimationType = *(EAdditiveAnimationType*)(__OutBuffer);

			}
		}

		public static void FindBonePathToRoot(UAnimSequenceBase AnimationSequenceBase, FName BoneName, ref TArray<FName> BonePath)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BonePath?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __FindBonePathToRoot, __InBuffer, __OutBuffer);

				BonePath = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public static void FinalizeBoneAnimation(UAnimSequence AnimationSequence)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __FinalizeBoneAnimation, __InBuffer);
			}
		}

		/// <param name="AnimationSequenceBase">
		/// : Anim sequence for which to evaluate the root bone subframe attribute.
		/// </param>
		/// <param name="EvalTime">
		/// : Time (in seconds) at which to evaluate the subframe timecode bone attribute.
		/// </param>
		/// <param name="OutSubframe">
		/// : Resulting subframe value from evaluation. If no subframe timecode attribute is present
		/// on the bone or if it cannot be evaluated, the output parameter will not be modified.
		/// </param>
		/// <returns>
		/// : true if the root bone had a subframe timecode attribute that could be evaluated and a value was set, or false otherwise.
		/// </returns>
		public static bool EvaluateRootBoneTimecodeSubframeAttributeAtTime(UAnimSequenceBase AnimationSequenceBase, float EvalTime, ref float OutSubframe)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EvalTime;

				*(float*)(__InBuffer + 12) = OutSubframe;

				var __OutBuffer = stackalloc byte[4];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __EvaluateRootBoneTimecodeSubframeAttributeAtTime, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutSubframe = *(float*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AnimationSequenceBase">
		/// : Anim sequence for which to evaluate the root bone attributes.
		/// </param>
		/// <param name="EvalTime">
		/// : Time (in seconds) at which to evaluate the timecode bone attributes.
		/// </param>
		/// <param name="OutQualifiedFrameTime">
		/// : Resulting qualified frame time from evaluation. If the anim sequence has an import file frame rate
		/// set, then that will be used as the frame rate of the qualified frame time. Otherwise, the sampling frame rate of the anim
		/// sequence is used. If no timecode attributes are present on the bone or if none can be evaluated, the passed object will not be modified.
		/// </param>
		/// <returns>
		/// : true if the root bone had timecode attributes that could be evaluated and a qualified frame time was set, or false otherwise.
		/// </returns>
		public static bool EvaluateRootBoneTimecodeAttributesAtTime(UAnimSequenceBase AnimationSequenceBase, float EvalTime, ref FQualifiedFrameTime OutQualifiedFrameTime)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = EvalTime;

				*(nint*)(__InBuffer + 12) = OutQualifiedFrameTime?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __EvaluateRootBoneTimecodeAttributesAtTime, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutQualifiedFrameTime = *(FQualifiedFrameTime*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool DoesCurveExist(UAnimSequence AnimationSequence, FName CurveName, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CurveType;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __DoesCurveExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void DoesBoneNameExist(UAnimSequence AnimationSequence, FName BoneName, ref bool bExists)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bExists;

				var __OutBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __DoesBoneNameExist, __InBuffer, __OutBuffer);

				bExists = *(bool*)(__OutBuffer);

			}
		}

		public static void CopyAnimNotifiesFromSequence(UAnimSequenceBase SourceAnimationSequenceBase, UAnimSequenceBase DestinationAnimationSequenceBase, bool bDeleteExistingNotifies = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = SourceAnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = DestinationAnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bDeleteExistingNotifies;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CopyAnimNotifiesFromSequence, __InBuffer);
			}
		}

		public static void CopyAnimationCurveNamesToSkeleton(USkeleton OldSkeleton, USkeleton NewSkeleton, UAnimSequenceBase SequenceBase, ERawCurveTrackTypes CurveType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = OldSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewSkeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)CurveType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CopyAnimationCurveNamesToSkeleton, __InBuffer);
			}
		}

		public static bool ContainsMetaDataOfClass(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ContainsMetaDataOfClass, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static void AddVirtualBone(UAnimSequence AnimationSequence, FName SourceBoneName, FName TargetBoneName, ref FName VirtualBoneName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TargetBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = VirtualBoneName?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AddVirtualBone, __InBuffer, __OutBuffer);

				VirtualBoneName = *(FName*)(__OutBuffer);

			}
		}

		public static void AddVectorCurveKeys(UAnimSequence AnimationSequence, FName CurveName, TArray<float> Times, TArray<FVector> Vectors)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Vectors?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddVectorCurveKeys, __InBuffer);
			}
		}

		public static void AddVectorCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, FVector Vector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(nint*)(__InBuffer + 20) = Vector?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddVectorCurveKey, __InBuffer);
			}
		}

		public static void AddTransformationCurveKeys(UAnimSequence AnimationSequence, FName CurveName, TArray<float> Times, TArray<FTransform> Transforms)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Transforms?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddTransformationCurveKeys, __InBuffer);
			}
		}

		public static void AddTransformationCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, FTransform Transform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(nint*)(__InBuffer + 20) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddTransformationCurveKey, __InBuffer);
			}
		}

		/// <param name="AnimBlueprint">
		/// The Animation Blueprint to add/set the Override for
		/// </param>
		/// <param name="Target">
		/// The Animation Asset to add an override for (overrides all instances of the asset)
		/// </param>
		/// <param name="Override">
		/// The Animation Asset to used to override the Target with (types have to match)
		/// </param>
		/// <param name="bPrintAppliedOverrides">
		/// Flag whether or not to print the applied overrides
		/// </param>
		public static void AddNodeAssetOverride(UAnimBlueprint AnimBlueprint, UAnimationAsset Target, UAnimationAsset Override, bool bPrintAppliedOverrides = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = AnimBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Override?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bPrintAppliedOverrides;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddNodeAssetOverride, __InBuffer);
			}
		}

		public static void AddMetaDataObject(UAnimationAsset AnimationAsset, UAnimMetaData MetaDataObject)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataObject?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddMetaDataObject, __InBuffer);
			}
		}

		public static void AddMetaData(UAnimationAsset AnimationAsset, TSubclassOf<UAnimMetaData> MetaDataClass, ref UAnimMetaData MetaDataInstance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationAsset?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MetaDataClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MetaDataInstance?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __AddMetaData, __InBuffer, __OutBuffer);

				MetaDataInstance = *(UAnimMetaData*)(__OutBuffer);

			}
		}

		public static void AddFloatCurveKeys(UAnimSequence AnimationSequence, FName CurveName, TArray<float> Times, TArray<float> Values)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Times?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Values?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddFloatCurveKeys, __InBuffer);
			}
		}

		public static void AddFloatCurveKey(UAnimSequence AnimationSequence, FName CurveName, float Time, float Value)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(float*)(__InBuffer + 20) = Value;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddFloatCurveKey, __InBuffer);
			}
		}

		public static void AddCurve(UAnimSequence AnimationSequence, FName CurveName, ERawCurveTrackTypes CurveType = ERawCurveTrackTypes.RCT_Float, bool bMetaDataCurve = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)CurveType;

				*(bool*)(__InBuffer + 17) = bMetaDataCurve;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddCurve, __InBuffer);
			}
		}

		public static void AddAnimationSyncMarker(UAnimSequence AnimationSequence, FName MarkerName, float Time, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = MarkerName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = Time;

				*(nint*)(__InBuffer + 20) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationSyncMarker, __InBuffer);
			}
		}

		public static void AddAnimationNotifyTrack(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, FLinearColor TrackColor = null)
		{
			unsafe
			{
				TrackColor ??= new FLinearColor(1.000000f, 1.000000f, 1.000000f, 1.000000f);

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TrackColor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationNotifyTrack, __InBuffer);
			}
		}

		public static void AddAnimationNotifyStateEventObject(UAnimSequenceBase AnimationSequenceBase, float StartTime, float Duration, UAnimNotifyState NotifyState, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				*(float*)(__InBuffer + 12) = Duration;

				*(nint*)(__InBuffer + 16) = NotifyState?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationNotifyStateEventObject, __InBuffer);
			}
		}

		public static UAnimNotifyState AddAnimationNotifyStateEvent(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, float StartTime, float Duration, TSubclassOf<UAnimNotifyState> NotifyStateClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = StartTime;

				*(float*)(__InBuffer + 20) = Duration;

				*(nint*)(__InBuffer + 24) = NotifyStateClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationNotifyStateEvent, __InBuffer, __ReturnBuffer);

				return *(UAnimNotifyState*)__ReturnBuffer;
			}
		}

		public static void AddAnimationNotifyEventObject(UAnimSequenceBase AnimationSequenceBase, float StartTime, UAnimNotify Notify, FName NotifyTrackName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = StartTime;

				*(nint*)(__InBuffer + 12) = Notify?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationNotifyEventObject, __InBuffer);
			}
		}

		public static UAnimNotify AddAnimationNotifyEvent(UAnimSequenceBase AnimationSequenceBase, FName NotifyTrackName, float StartTime, TSubclassOf<UAnimNotify> NotifyClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NotifyTrackName?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = StartTime;

				*(nint*)(__InBuffer + 20) = NotifyClass?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __AddAnimationNotifyEvent, __InBuffer, __ReturnBuffer);

				return *(UAnimNotify*)__ReturnBuffer;
			}
		}

		private static uint __SetVariableFrameStrippingSettings = 0;

		private static uint __SetRootMotionLockType = 0;

		private static uint __SetRootMotionEnabled = 0;

		private static uint __SetRateScale = 0;

		private static uint __SetIsRootMotionLockForced = 0;

		private static uint __SetCurveCompressionSettings = 0;

		private static uint __SetBoneCompressionSettings = 0;

		private static uint __SetAnimationInterpolationType = 0;

		private static uint __SetAdditiveBasePoseType = 0;

		private static uint __SetAdditiveAnimationType = 0;

		private static uint __ReplaceAnimNotifyStates = 0;

		private static uint __ReplaceAnimNotifies = 0;

		private static uint __RemoveVirtualBones = 0;

		private static uint __RemoveVirtualBone = 0;

		private static uint __RemoveMetaDataOfClass = 0;

		private static uint __RemoveMetaData = 0;

		private static uint __RemoveCurve = 0;

		private static uint __RemoveBoneAnimation = 0;

		private static uint __RemoveAnimationSyncMarkersByTrack = 0;

		private static uint __RemoveAnimationSyncMarkersByName = 0;

		private static uint __RemoveAnimationNotifyTrack = 0;

		private static uint __RemoveAnimationNotifyEventsByTrack = 0;

		private static uint __RemoveAnimationNotifyEventsByName = 0;

		private static uint __RemoveAllVirtualBones = 0;

		private static uint __RemoveAllMetaData = 0;

		private static uint __RemoveAllCurveData = 0;

		private static uint __RemoveAllBoneAnimation = 0;

		private static uint __RemoveAllAnimationSyncMarkers = 0;

		private static uint __RemoveAllAnimationNotifyTracks = 0;

		private static uint __IsValidTime = 0;

		private static uint __IsValidRawAnimationTrackName = 0;

		private static uint __IsValidAnimNotifyTrackName = 0;

		private static uint __IsValidAnimationSyncMarkerName = 0;

		private static uint __IsRootMotionLockForced = 0;

		private static uint __IsRootMotionEnabled = 0;

		private static uint __GetVectorKeys = 0;

		private static uint __GetVariableFrameStrippingSettings = 0;

		private static uint __GetUniqueMarkerNames = 0;

		private static uint __GetTransformationKeys = 0;

		private static uint __GetTimeAtFrame = 0;

		private static uint __GetSequenceLength = 0;

		private static uint __GetRootMotionLockType = 0;

		private static uint __GetRawTrackScaleData = 0;

		private static uint __GetRawTrackRotationData = 0;

		private static uint __GetRawTrackPositionData = 0;

		private static uint __GetRawTrackData = 0;

		private static uint __GetRateScale = 0;

		private static uint __GetNumKeys = 0;

		private static uint __GetNumFrames = 0;

		private static uint __GetNodesOfClass = 0;

		private static uint __GetMontageSlotNames = 0;

		private static uint __GetMetaDataOfClass = 0;

		private static uint __GetMetaData = 0;

		private static uint __GetFrameAtTime = 0;

		private static uint __GetFloatKeys = 0;

		private static uint __GetCurveCompressionSettings = 0;

		private static uint __GetBonePosesForTime = 0;

		private static uint __GetBonePosesForFrame = 0;

		private static uint __GetBonePoseForTime = 0;

		private static uint __GetBonePoseForFrame = 0;

		private static uint __GetBoneCompressionSettings = 0;

		private static uint __GetAnimNotifyEventTriggerTime = 0;

		private static uint __GetAnimNotifyEventDuration = 0;

		private static uint __GetAnimationTrackNames = 0;

		private static uint __GetAnimationSyncMarkersForTrack = 0;

		private static uint __GetAnimationSyncMarkers = 0;

		private static uint __GetAnimationNotifyTrackNames = 0;

		private static uint __GetAnimationNotifyEventsForTrack = 0;

		private static uint __GetAnimationNotifyEvents = 0;

		private static uint __GetAnimationNotifyEventNames = 0;

		private static uint __GetAnimationInterpolationType = 0;

		private static uint __GetAnimationGraphs = 0;

		private static uint __GetAnimationCurveNames = 0;

		private static uint __GetAdditiveBasePoseType = 0;

		private static uint __GetAdditiveAnimationType = 0;

		private static uint __FindBonePathToRoot = 0;

		private static uint __FinalizeBoneAnimation = 0;

		private static uint __EvaluateRootBoneTimecodeSubframeAttributeAtTime = 0;

		private static uint __EvaluateRootBoneTimecodeAttributesAtTime = 0;

		private static uint __DoesCurveExist = 0;

		private static uint __DoesBoneNameExist = 0;

		private static uint __CopyAnimNotifiesFromSequence = 0;

		private static uint __CopyAnimationCurveNamesToSkeleton = 0;

		private static uint __ContainsMetaDataOfClass = 0;

		private static uint __AddVirtualBone = 0;

		private static uint __AddVectorCurveKeys = 0;

		private static uint __AddVectorCurveKey = 0;

		private static uint __AddTransformationCurveKeys = 0;

		private static uint __AddTransformationCurveKey = 0;

		private static uint __AddNodeAssetOverride = 0;

		private static uint __AddMetaDataObject = 0;

		private static uint __AddMetaData = 0;

		private static uint __AddFloatCurveKeys = 0;

		private static uint __AddFloatCurveKey = 0;

		private static uint __AddCurve = 0;

		private static uint __AddAnimationSyncMarker = 0;

		private static uint __AddAnimationNotifyTrack = 0;

		private static uint __AddAnimationNotifyStateEventObject = 0;

		private static uint __AddAnimationNotifyStateEvent = 0;

		private static uint __AddAnimationNotifyEventObject = 0;

		private static uint __AddAnimationNotifyEvent = 0;
	}
}
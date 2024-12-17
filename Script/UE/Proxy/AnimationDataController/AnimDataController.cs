using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationDataController
{
	[PathName("/Script/AnimationDataController.AnimDataController")]
	public partial class UAnimDataController : UObject, IStaticClass, IAnimationDataController
	{
		public TWeakObjectPtr<UAnimDataModel> Model
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Model, __ReturnBuffer);

					return *(TWeakObjectPtr<UAnimDataModel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Model, __InBuffer);
				}
			}
		}

		public TScriptInterface<IAnimationDataModel> ModelInterface
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ModelInterface, __ReturnBuffer);

					return *(TScriptInterface<IAnimationDataModel>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ModelInterface, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationDataController.AnimDataController");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateCurveNamesFromSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Skeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SupportedCurveType;

				*(bool*)(__InBuffer + 9) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateCurveNamesFromSkeleton, __InBuffer);
			}
		}

		/// <param name="CurveId">
		/// Identifier for the transform curve for which the keys are to be set
		/// </param>
		/// <param name="TransformValues">
		/// Transform Values with which the existing values are to be replaced
		/// </param>
		/// <param name="TimeKeys">
		/// Time Keys with which the existing keys are to be replaced
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the transform curve keys were successfully set
		/// </returns>
		public virtual bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId, TArray<FTransform> TransformValues, TArray<float> TimeKeys, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TransformValues?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = TimeKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTransformCurveKeys, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the transform curve for which the key is to be set
		/// </param>
		/// <param name="Time">
		/// Time of the key to be set
		/// </param>
		/// <param name="Value">
		/// Value of the key to be set
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the transform curve key was successfully set
		/// </returns>
		public virtual bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, FTransform Value, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[21];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(nint*)(__InBuffer + 12) = Value?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 20) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetTransformCurveKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void SetPlayLength(float Length, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(float*)(__InBuffer) = Length;

				*(bool*)(__InBuffer + 4) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPlayLength, __InBuffer);
			}
		}

		/// <param name="NewLengthInFrames">
		/// Total new play-able number of frames value (according to frame rate), has to be positive and non-zero
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void SetNumberOfFrames(FFrameNumber NewLengthInFrames, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = NewLengthInFrames?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetNumberOfFrames, __InBuffer);
			}
		}

		/// <param name="InModel">
		/// IAnimationDataModel instance to target
		/// </param>
		public virtual void SetModel(TScriptInterface<IAnimationDataModel> InModel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InModel?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetModel, __InBuffer);
			}
		}

		/// <param name="FrameRate">
		/// The new sampling frame rate, has to be positive and non-zero
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void SetFrameRate(FFrameRate FrameRate, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = FrameRate?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetFrameRate, __InBuffer);
			}
		}

		/// <param name="CurveId">
		/// Identifier for the curve for which the keys are to be replaced
		/// </param>
		/// <param name="CurveKeys">
		/// Keys with which the existing keys are to be replaced
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not replacing curve keys was successful
		/// </returns>
		public virtual bool SetCurveKeys(FAnimationCurveIdentifier CurveId, TArray<FRichCurveKey> CurveKeys, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveKeys, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the curve for which the key is to be set
		/// </param>
		/// <param name="Key">
		/// Key to be set
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve key was successfully set
		/// </returns>
		public virtual bool SetCurveKey(FAnimationCurveIdentifier CurveId, FRichCurveKey Key, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Key?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the curve for which the flag state is to be set
		/// </param>
		/// <param name="Flags">
		/// Flag mask with which the existing flags are to be replaced
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the flag mask was successfully set
		/// </returns>
		public virtual bool SetCurveFlags(FAnimationCurveIdentifier CurveId, int Flags, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = Flags;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveFlags, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the curve for which the flag state is to be set
		/// </param>
		/// <param name="Flag">
		/// Flag for which the state is supposed to be set
		/// </param>
		/// <param name="bState">
		/// State of the flag to be, true=set/false=not set
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the flag state was successfully set
		/// </returns>
		public virtual bool SetCurveFlag(FAnimationCurveIdentifier CurveId, EAnimAssetCurveFlags Flag, bool bState = true, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Flag;

				*(bool*)(__InBuffer + 9) = bState;

				*(bool*)(__InBuffer + 10) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveFlag, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier of the curve to change the color for
		/// </param>
		/// <param name="Color">
		/// Color to which the curve is to be set
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve color was successfully changed
		/// </returns>
		public virtual bool SetCurveColor(FAnimationCurveIdentifier CurveId, FLinearColor Color, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Color?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetCurveColor, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Bone name of the track for which the keys should be set
		/// </param>
		/// <param name="PositionalKeys">
		/// Array of keys for the translation component
		/// </param>
		/// <param name="RotationalKeys">
		/// Array of keys for the rotation component
		/// </param>
		/// <param name="ScalingKeys">
		/// Array of keys for the scale component
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the keys were successfully set
		/// </returns>
		public virtual bool SetBoneTrackKeys(FName BoneName, TArray<FVector> PositionalKeys, TArray<FQuat> RotationalKeys, TArray<FVector> ScalingKeys, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[33];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PositionalKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = RotationalKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = ScalingKeys?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 32) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SetBoneTrackKeys, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier of the curve to scale
		/// </param>
		/// <param name="Origin">
		/// Time to use as the origin when scaling the curve
		/// </param>
		/// <param name="Factor">
		/// Factor with which the curve is supposed to be scaled
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not scaling the curve was successful
		/// </returns>
		public virtual bool ScaleCurve(FAnimationCurveIdentifier CurveId, float Origin, float Factor, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Origin;

				*(float*)(__InBuffer + 12) = Factor;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ScaleCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ResizePlayLength(float NewLength, float T0, float T1, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = NewLength;

				*(float*)(__InBuffer + 4) = T0;

				*(float*)(__InBuffer + 8) = T1;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResizePlayLength, __InBuffer);
			}
		}

		/// <param name="NewLengthInFrames">
		/// Total new play-able number of frames value (according to frame rate), has to be positive and non-zero
		/// </param>
		/// <param name="T0">
		/// Point between 0 and NewLengthInFrames at which the change in length starts
		/// </param>
		/// <param name="T1">
		/// Point between 0 and NewLengthInFrames at which the change in length ends
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void ResizeNumberOfFrames(FFrameNumber NewLengthInFrames, FFrameNumber T0, FFrameNumber T1, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NewLengthInFrames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = T0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = T1?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResizeNumberOfFrames, __InBuffer);
			}
		}

		/// <param name="NewLengthInFrames">
		/// Total new play-able number of frames value (according to frame rate), has to be positive and non-zero
		/// </param>
		/// <param name="T0">
		/// Point between 0 and NewLengthInFrames at which the change in length starts
		/// </param>
		/// <param name="T1">
		/// Point between 0 and NewLengthInFrames at which the change in length ends
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void ResizeInFrames(FFrameNumber NewLengthInFrames, FFrameNumber T0, FFrameNumber T1, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = NewLengthInFrames?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = T0?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = T1?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResizeInFrames, __InBuffer);
			}
		}

		public virtual void Resize(float Length, float T0, float T1, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = Length;

				*(float*)(__InBuffer + 4) = T0;

				*(float*)(__InBuffer + 8) = T1;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Resize, __InBuffer);
			}
		}

		/// <param name="CurveToRenameId">
		/// Identifier for the curve to be renamed
		/// </param>
		/// <param name="NewCurveId">
		/// Time of the key to be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve was successfully renamed
		/// </returns>
		public virtual bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CurveToRenameId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewCurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RenameCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the transform curve for which the key is to be removed
		/// </param>
		/// <param name="Time">
		/// Time of the key to be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the transform curve key was successfully removed
		/// </returns>
		public virtual bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveTransformCurveKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the curve for which the key is to be removed
		/// </param>
		/// <param name="Time">
		/// Time of the key to be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve key was successfully removed
		/// </returns>
		public virtual bool RemoveCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCurveKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="CurveId">
		/// Identifier for the to-be-removed curve
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve was successfully removed
		/// </returns>
		public virtual bool RemoveCurve(FAnimationCurveIdentifier CurveId, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="BoneName">
		/// Bone name of the track which should be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the removal was successful
		/// </returns>
		public virtual bool RemoveBoneTrack(FName BoneName, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveBoneTrack, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AttributeIdentifier">
		/// Identifier for the attribute from which the key is to be removed
		/// </param>
		/// <param name="Time">
		/// Time of the key to be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the attribute key was successfully removed
		/// </returns>
		public virtual bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier, float Time, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = Time;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAttributeKey, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AttributeIdentifier">
		/// Identifier for the to-be-removed attribute
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the attribute was successfully removed
		/// </returns>
		public virtual bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="SupportedCurveType">
		/// Type for which all curves are to be removed
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(byte*)(__InBuffer) = (byte)SupportedCurveType;

				*(bool*)(__InBuffer + 1) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllCurvesOfType, __InBuffer);
			}
		}

		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void RemoveAllBoneTracks(bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RemoveAllBoneTracks, __InBuffer);
			}
		}

		/// <param name="BoneName">
		/// Name of the bone to remove attributes for
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Total number of removes attributes
		/// </returns>
		public virtual int RemoveAllAttributesForBone(FName BoneName, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAllAttributesForBone, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Total number of removes attributes
		/// </returns>
		public virtual int RemoveAllAttributes(bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveAllAttributes, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="InTitle">
		/// Description of the bracket, e.g. "Generating Curve Data"
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void OpenBracket(FText InTitle, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = InTitle?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OpenBracket, __InBuffer);
			}
		}

		public virtual int InsertBoneTrack(FName BoneName, int DesiredIndex, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = DesiredIndex;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __InsertBoneTrack, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The IAnimationDataModel instance this controller is currently targeting
		/// </returns>
		public virtual TScriptInterface<IAnimationDataModel> GetModelInterface()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetModelInterface, __ReturnBuffer);

				return *(TScriptInterface<IAnimationDataModel>*)__ReturnBuffer;
			}
		}

		public virtual void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Skeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)SupportedCurveType;

				*(bool*)(__InBuffer + 9) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FindOrAddCurveNamesOnSkeleton, __InBuffer);
			}
		}

		/// <param name="CopyCurveId">
		/// Identifier for the to-be-duplicated curve
		/// </param>
		/// <param name="NewCurveId">
		/// Identifier for the to-be-added curve
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve was successfully duplicated
		/// </returns>
		public virtual bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = CopyCurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewCurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DuplicateCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AttributeIdentifier">
		/// Identifier for the to-be-duplicated attribute
		/// </param>
		/// <param name="NewAttributeIdentifier">
		/// Identifier for the to-be-added attribute
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the attribute was successfully duplicated
		/// </returns>
		public virtual bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier, FAnimationAttributeIdentifier NewAttributeIdentifier, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewAttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DuplicateAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		public virtual void CloseBracket(bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bShouldTransact;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CloseBracket, __InBuffer);
			}
		}

		/// <param name="CurveId">
		/// Identifier for the to-be-added curve
		/// </param>
		/// <param name="CurveFlags">
		/// Flags to be set for the curve
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the curve was successfully added
		/// </returns>
		public virtual bool AddCurve(FAnimationCurveIdentifier CurveId, int CurveFlags = 4, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = CurveId?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = CurveFlags;

				*(bool*)(__InBuffer + 12) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int AddBoneTrack(FName BoneName, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBoneTrack, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual bool AddBoneCurve(FName BoneName, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddBoneCurve, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="AttributeIdentifier">
		/// Identifier for the to-be-added attribute
		/// </param>
		/// <param name="bShouldTransact">
		/// Whether or not any undo-redo changes should be generated
		/// </param>
		/// <returns>
		/// Whether or not the attribute was successfully added
		/// </returns>
		public virtual bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = AttributeIdentifier?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bShouldTransact;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __AddAttribute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

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

		private static uint __Model = 0;

		private static uint __ModelInterface = 0;

		private static uint __UpdateCurveNamesFromSkeleton = 0;

		private static uint __SetTransformCurveKeys = 0;

		private static uint __SetTransformCurveKey = 0;

		private static uint __SetPlayLength = 0;

		private static uint __SetNumberOfFrames = 0;

		private static uint __SetModel = 0;

		private static uint __SetFrameRate = 0;

		private static uint __SetCurveKeys = 0;

		private static uint __SetCurveKey = 0;

		private static uint __SetCurveFlags = 0;

		private static uint __SetCurveFlag = 0;

		private static uint __SetCurveColor = 0;

		private static uint __SetBoneTrackKeys = 0;

		private static uint __ScaleCurve = 0;

		private static uint __ResizePlayLength = 0;

		private static uint __ResizeNumberOfFrames = 0;

		private static uint __ResizeInFrames = 0;

		private static uint __Resize = 0;

		private static uint __RenameCurve = 0;

		private static uint __RemoveTransformCurveKey = 0;

		private static uint __RemoveCurveKey = 0;

		private static uint __RemoveCurve = 0;

		private static uint __RemoveBoneTrack = 0;

		private static uint __RemoveAttributeKey = 0;

		private static uint __RemoveAttribute = 0;

		private static uint __RemoveAllCurvesOfType = 0;

		private static uint __RemoveAllBoneTracks = 0;

		private static uint __RemoveAllAttributesForBone = 0;

		private static uint __RemoveAllAttributes = 0;

		private static uint __OpenBracket = 0;

		private static uint __InsertBoneTrack = 0;

		private static uint __GetModelInterface = 0;

		private static uint __FindOrAddCurveNamesOnSkeleton = 0;

		private static uint __DuplicateCurve = 0;

		private static uint __DuplicateAttribute = 0;

		private static uint __CloseBracket = 0;

		private static uint __AddCurve = 0;

		private static uint __AddBoneTrack = 0;

		private static uint __AddBoneCurve = 0;

		private static uint __AddAttribute = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}
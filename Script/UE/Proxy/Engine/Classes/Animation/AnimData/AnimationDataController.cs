using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationDataController")]
	public partial class UAnimationDataController : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationDataController");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.AnimationDataController")]
	public interface IAnimationDataController : IInterface
	{
		 void UpdateCurveNamesFromSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

		 bool SetTransformCurveKeys(FAnimationCurveIdentifier CurveId, TArray<FTransform> TransformValues, TArray<float> TimeKeys, bool bShouldTransact = true);

		 bool SetTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, FTransform Value, bool bShouldTransact = true);

		 void SetPlayLength(float Length, bool bShouldTransact = true);

		 void SetNumberOfFrames(FFrameNumber NewLengthInFrames, bool bShouldTransact = true);

		 void SetModel(TScriptInterface<IAnimationDataModel> InModel);

		 void SetFrameRate(FFrameRate FrameRate, bool bShouldTransact = true);

		 bool SetCurveKeys(FAnimationCurveIdentifier CurveId, TArray<FRichCurveKey> CurveKeys, bool bShouldTransact = true);

		 bool SetCurveKey(FAnimationCurveIdentifier CurveId, FRichCurveKey Key, bool bShouldTransact = true);

		 bool SetCurveFlags(FAnimationCurveIdentifier CurveId, int Flags, bool bShouldTransact = true);

		 bool SetCurveFlag(FAnimationCurveIdentifier CurveId, EAnimAssetCurveFlags Flag, bool bState = true, bool bShouldTransact = true);

		 bool SetCurveColor(FAnimationCurveIdentifier CurveId, FLinearColor Color, bool bShouldTransact = true);

		 bool SetBoneTrackKeys(FName BoneName, TArray<FVector> PositionalKeys, TArray<FQuat> RotationalKeys, TArray<FVector> ScalingKeys, bool bShouldTransact = true);

		 bool ScaleCurve(FAnimationCurveIdentifier CurveId, float Origin, float Factor, bool bShouldTransact = true);

		 void ResizePlayLength(float NewLength, float T0, float T1, bool bShouldTransact = true);

		 void ResizeNumberOfFrames(FFrameNumber NewLengthInFrames, FFrameNumber T0, FFrameNumber T1, bool bShouldTransact = true);

		 void ResizeInFrames(FFrameNumber NewLengthInFrames, FFrameNumber T0, FFrameNumber T1, bool bShouldTransact = true);

		 void Resize(float Length, float T0, float T1, bool bShouldTransact = true);

		 bool RenameCurve(FAnimationCurveIdentifier CurveToRenameId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true);

		 bool RemoveTransformCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true);

		 bool RemoveCurveKey(FAnimationCurveIdentifier CurveId, float Time, bool bShouldTransact = true);

		 bool RemoveCurve(FAnimationCurveIdentifier CurveId, bool bShouldTransact = true);

		 bool RemoveBoneTrack(FName BoneName, bool bShouldTransact = true);

		 bool RemoveAttributeKey(FAnimationAttributeIdentifier AttributeIdentifier, float Time, bool bShouldTransact = true);

		 bool RemoveAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true);

		 void RemoveAllCurvesOfType(ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

		 void RemoveAllBoneTracks(bool bShouldTransact = true);

		 int RemoveAllAttributesForBone(FName BoneName, bool bShouldTransact = true);

		 int RemoveAllAttributes(bool bShouldTransact = true);

		 void OpenBracket(FText InTitle, bool bShouldTransact = true);

		 int InsertBoneTrack(FName BoneName, int DesiredIndex, bool bShouldTransact = true);

		 TScriptInterface<IAnimationDataModel> GetModelInterface();

		 void FindOrAddCurveNamesOnSkeleton(USkeleton Skeleton, ERawCurveTrackTypes SupportedCurveType, bool bShouldTransact = true);

		 bool DuplicateCurve(FAnimationCurveIdentifier CopyCurveId, FAnimationCurveIdentifier NewCurveId, bool bShouldTransact = true);

		 bool DuplicateAttribute(FAnimationAttributeIdentifier AttributeIdentifier, FAnimationAttributeIdentifier NewAttributeIdentifier, bool bShouldTransact = true);

		 void CloseBracket(bool bShouldTransact = true);

		 bool AddCurve(FAnimationCurveIdentifier CurveId, int CurveFlags = 4, bool bShouldTransact = true);

		 int AddBoneTrack(FName BoneName, bool bShouldTransact = true);

		 bool AddBoneCurve(FName BoneName, bool bShouldTransact = true);

		 bool AddAttribute(FAnimationAttributeIdentifier AttributeIdentifier, bool bShouldTransact = true);
	}
}
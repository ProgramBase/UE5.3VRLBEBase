using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.AnimationDataModel")]
	public partial class UAnimationDataModel : UInterface, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.AnimationDataModel");
		}

		private static UClass StaticClassSingleton { get; set; }
	}

	[PathName("/Script/Engine.AnimationDataModel")]
	public interface IAnimationDataModel : IInterface
	{
		 bool IsValidBoneTrackName(FName TrackName);

		 bool IsValidBoneTrackIndex(int TrackIndex);

		 double GetPlayLength();

		 int GetNumBoneTracks();

		 int GetNumberOfTransformCurves();

		 int GetNumberOfKeys();

		 int GetNumberOfFrames();

		 int GetNumberOfFloatCurves();

		 FFrameRate GetFrameRate();

		 void GetBoneTrackNames(ref TArray<FName> OutNames);

		 int GetBoneTrackIndexByName(FName TrackName);

		 int GetBoneTrackIndex(FBoneAnimationTrack Track);

		 FBoneAnimationTrack GetBoneTrackByName(FName TrackName);

		 FBoneAnimationTrack GetBoneTrackByIndex(int TrackIndex);

		 TArray<FBoneAnimationTrack> GetBoneAnimationTracks();

		 UAnimSequence GetAnimationSequence();
	}
}
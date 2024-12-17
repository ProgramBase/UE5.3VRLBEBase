using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneSkeletalAnimRootMotionTrackParams")]
	public partial class FMovieSceneSkeletalAnimRootMotionTrackParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneSkeletalAnimRootMotionTrackParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSkeletalAnimRootMotionTrackParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSkeletalAnimRootMotionTrackParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSkeletalAnimRootMotionTrackParams A, FMovieSceneSkeletalAnimRootMotionTrackParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSkeletalAnimRootMotionTrackParams A, FMovieSceneSkeletalAnimRootMotionTrackParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSkeletalAnimRootMotionTrackParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public nint GarbageCollectionHandle { get; set; }
	}
}
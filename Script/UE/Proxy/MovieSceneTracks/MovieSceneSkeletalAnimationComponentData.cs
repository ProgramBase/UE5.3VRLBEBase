using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationComponentData")]
	public partial class FMovieSceneSkeletalAnimationComponentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneSkeletalAnimationComponentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSkeletalAnimationComponentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSkeletalAnimationComponentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSkeletalAnimationComponentData A, FMovieSceneSkeletalAnimationComponentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSkeletalAnimationComponentData A, FMovieSceneSkeletalAnimationComponentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSkeletalAnimationComponentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSkeletalAnimationSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneSkeletalAnimationSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Section, __InBuffer);
				}
			}
		}

		private static uint __Section = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackInstanceInput")]
	public partial class FMovieSceneTrackInstanceInput : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackInstanceInput");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackInstanceInput() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackInstanceInput() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackInstanceInput A, FMovieSceneTrackInstanceInput B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackInstanceInput A, FMovieSceneTrackInstanceInput B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackInstanceInput;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneSection*)__ReturnBuffer;
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
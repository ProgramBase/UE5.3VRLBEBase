using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MediaCompositing
{
	[PathName("/Script/MediaCompositing.MovieSceneMediaSectionTemplate")]
	public partial class FMovieSceneMediaSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MediaCompositing.MovieSceneMediaSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneMediaSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneMediaSectionTemplate A, FMovieSceneMediaSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneMediaSectionTemplate A, FMovieSceneMediaSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneMediaSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneMediaSectionParams Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneMediaSectionParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Params, __InBuffer);
				}
			}
		}

		public UMovieSceneMediaSection MediaSection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MediaSection, __ReturnBuffer);

					return *(UMovieSceneMediaSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MediaSection, __InBuffer);
				}
			}
		}

		private static uint __Params = 0;

		private static uint __MediaSection = 0;

	}
}
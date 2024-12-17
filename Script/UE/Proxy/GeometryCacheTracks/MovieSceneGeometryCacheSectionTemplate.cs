using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.GeometryCacheTracks
{
	[PathName("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplate")]
	public partial class FMovieSceneGeometryCacheSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCacheTracks.MovieSceneGeometryCacheSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneGeometryCacheSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneGeometryCacheSectionTemplate A, FMovieSceneGeometryCacheSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneGeometryCacheSectionTemplate A, FMovieSceneGeometryCacheSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneGeometryCacheSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneGeometryCacheSectionTemplateParameters Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneGeometryCacheSectionTemplateParameters*)__ReturnBuffer;
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

		private static uint __Params = 0;

	}
}
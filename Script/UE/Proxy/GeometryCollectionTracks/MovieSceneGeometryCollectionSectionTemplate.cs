using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.GeometryCollectionTracks
{
	[PathName("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionSectionTemplate")]
	public partial class FMovieSceneGeometryCollectionSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneGeometryCollectionSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneGeometryCollectionSectionTemplate A, FMovieSceneGeometryCollectionSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneGeometryCollectionSectionTemplate A, FMovieSceneGeometryCollectionSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneGeometryCollectionSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneGeometryCollectionSectionTemplateParameters Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneGeometryCollectionSectionTemplateParameters*)__ReturnBuffer;
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
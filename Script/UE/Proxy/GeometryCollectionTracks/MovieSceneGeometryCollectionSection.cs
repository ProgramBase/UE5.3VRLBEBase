using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.GeometryCollectionTracks
{
	[PathName("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionSection")]
	public partial class UMovieSceneGeometryCollectionSection : UMovieSceneSection, IStaticClass
	{
		public FMovieSceneGeometryCollectionParams Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneGeometryCollectionParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Params, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionSection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Params = 0;
	}
}
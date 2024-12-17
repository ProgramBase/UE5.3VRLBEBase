using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneObjectPropertyTemplate")]
	public partial class FMovieSceneObjectPropertyTemplate : FMovieScenePropertySectionTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneObjectPropertyTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneObjectPropertyTemplate()
		{
		}

		public static bool operator ==(FMovieSceneObjectPropertyTemplate A, FMovieSceneObjectPropertyTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneObjectPropertyTemplate A, FMovieSceneObjectPropertyTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneObjectPropertyTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneObjectPathChannel ObjectChannel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectChannel, __ReturnBuffer);

					return *(FMovieSceneObjectPathChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectChannel, __InBuffer);
				}
			}
		}

		private static uint __ObjectChannel = 0;

	}
}
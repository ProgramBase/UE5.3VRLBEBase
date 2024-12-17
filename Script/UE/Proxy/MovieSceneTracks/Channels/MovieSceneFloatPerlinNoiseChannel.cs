using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneFloatPerlinNoiseChannel")]
	public partial class FMovieSceneFloatPerlinNoiseChannel : FMovieSceneChannel, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneFloatPerlinNoiseChannel");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneFloatPerlinNoiseChannel()
		{
		}

		public static bool operator ==(FMovieSceneFloatPerlinNoiseChannel A, FMovieSceneFloatPerlinNoiseChannel B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneFloatPerlinNoiseChannel A, FMovieSceneFloatPerlinNoiseChannel B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneFloatPerlinNoiseChannel;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPerlinNoiseParams PerlinNoiseParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PerlinNoiseParams, __ReturnBuffer);

					return *(FPerlinNoiseParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PerlinNoiseParams, __InBuffer);
				}
			}
		}

		private static uint __PerlinNoiseParams = 0;

	}
}
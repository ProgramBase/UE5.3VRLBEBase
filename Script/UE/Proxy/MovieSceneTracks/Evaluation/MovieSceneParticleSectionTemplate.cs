using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneParticleSectionTemplate")]
	public partial class FMovieSceneParticleSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneParticleSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneParticleSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneParticleSectionTemplate A, FMovieSceneParticleSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneParticleSectionTemplate A, FMovieSceneParticleSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneParticleSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneParticleChannel ParticleKeys
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParticleKeys, __ReturnBuffer);

					return *(FMovieSceneParticleChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParticleKeys, __InBuffer);
				}
			}
		}

		private static uint __ParticleKeys = 0;

	}
}
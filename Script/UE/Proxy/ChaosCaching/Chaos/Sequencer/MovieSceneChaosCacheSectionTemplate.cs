using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.MovieSceneChaosCacheSectionTemplate")]
	public partial class FMovieSceneChaosCacheSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.MovieSceneChaosCacheSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneChaosCacheSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneChaosCacheSectionTemplate A, FMovieSceneChaosCacheSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneChaosCacheSectionTemplate A, FMovieSceneChaosCacheSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneChaosCacheSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneChaosCacheSectionTemplateParameters Params
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Params, __ReturnBuffer);

					return *(FMovieSceneChaosCacheSectionTemplateParameters*)__ReturnBuffer;
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
using Script.CoreUObject;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.MovieSceneChaosCacheSectionTemplateParameters")]
	public partial class FMovieSceneChaosCacheSectionTemplateParameters : FMovieSceneBaseCacheSectionTemplateParameters, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.MovieSceneChaosCacheSectionTemplateParameters");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneChaosCacheSectionTemplateParameters()
		{
		}

		public static bool operator ==(FMovieSceneChaosCacheSectionTemplateParameters A, FMovieSceneChaosCacheSectionTemplateParameters B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneChaosCacheSectionTemplateParameters A, FMovieSceneChaosCacheSectionTemplateParameters B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneChaosCacheSectionTemplateParameters;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneChaosCacheParams ChaosCacheParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChaosCacheParams, __ReturnBuffer);

					return *(FMovieSceneChaosCacheParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChaosCacheParams, __InBuffer);
				}
			}
		}

		private static uint __ChaosCacheParams = 0;

	}
}
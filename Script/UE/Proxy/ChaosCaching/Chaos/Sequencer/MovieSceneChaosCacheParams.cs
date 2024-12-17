using Script.CoreUObject;
using Script.Library;
using Script.MovieSceneTracks;

namespace Script.ChaosCaching
{
	[PathName("/Script/ChaosCaching.MovieSceneChaosCacheParams")]
	public partial class FMovieSceneChaosCacheParams : FMovieSceneBaseCacheParams, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ChaosCaching.MovieSceneChaosCacheParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneChaosCacheParams()
		{
		}

		public static bool operator ==(FMovieSceneChaosCacheParams A, FMovieSceneChaosCacheParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneChaosCacheParams A, FMovieSceneChaosCacheParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneChaosCacheParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UChaosCacheCollection CacheCollection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CacheCollection, __ReturnBuffer);

					return *(UChaosCacheCollection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CacheCollection, __InBuffer);
				}
			}
		}

		private static uint __CacheCollection = 0;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVector3fKeyStruct")]
	public partial class FMovieSceneVector3fKeyStruct : FMovieSceneFloatVectorKeyStructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneVector3fKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneVector3fKeyStruct()
		{
		}

		public static bool operator ==(FMovieSceneVector3fKeyStruct A, FMovieSceneVector3fKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneVector3fKeyStruct A, FMovieSceneVector3fKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneVector3fKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector3f Vector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __ReturnBuffer);

					return *(FVector3f*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __InBuffer);
				}
			}
		}

		private static uint __Vector = 0;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVector2DKeyStruct")]
	public partial class FMovieSceneVector2DKeyStruct : FMovieSceneDoubleVectorKeyStructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneVector2DKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneVector2DKeyStruct()
		{
		}

		public static bool operator ==(FMovieSceneVector2DKeyStruct A, FMovieSceneVector2DKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneVector2DKeyStruct A, FMovieSceneVector2DKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneVector2DKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector2D Vector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __ReturnBuffer);

					return *(FVector2D*)__ReturnBuffer;
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
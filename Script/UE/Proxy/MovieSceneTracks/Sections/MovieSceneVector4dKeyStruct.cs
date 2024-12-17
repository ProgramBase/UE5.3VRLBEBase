using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneVector4dKeyStruct")]
	public partial class FMovieSceneVector4dKeyStruct : FMovieSceneDoubleVectorKeyStructBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneVector4dKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneVector4dKeyStruct()
		{
		}

		public static bool operator ==(FMovieSceneVector4dKeyStruct A, FMovieSceneVector4dKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneVector4dKeyStruct A, FMovieSceneVector4dKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneVector4dKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FVector4d Vector
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Vector, __ReturnBuffer);

					return *(FVector4d*)__ReturnBuffer;
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
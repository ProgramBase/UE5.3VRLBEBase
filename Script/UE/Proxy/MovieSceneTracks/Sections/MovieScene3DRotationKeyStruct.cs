using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieScene3DRotationKeyStruct")]
	public partial class FMovieScene3DRotationKeyStruct : FMovieSceneKeyStruct, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieScene3DRotationKeyStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScene3DRotationKeyStruct()
		{
		}

		public static bool operator ==(FMovieScene3DRotationKeyStruct A, FMovieScene3DRotationKeyStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScene3DRotationKeyStruct A, FMovieScene3DRotationKeyStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScene3DRotationKeyStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FRotator Rotation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __ReturnBuffer);

					return *(FRotator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Rotation, __InBuffer);
				}
			}
		}

		public FFrameNumber Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(FFrameNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Time, __InBuffer);
				}
			}
		}

		private static uint __Rotation = 0;

		private static uint __Time = 0;

	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackLabels")]
	public partial class FMovieSceneTrackLabels : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackLabels");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackLabels() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackLabels() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackLabels A, FMovieSceneTrackLabels B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackLabels A, FMovieSceneTrackLabels B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackLabels;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<FString> Strings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Strings, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Strings, __InBuffer);
				}
			}
		}

		private static uint __Strings = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
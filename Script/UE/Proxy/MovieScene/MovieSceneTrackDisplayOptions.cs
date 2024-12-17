using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackDisplayOptions")]
	public partial class FMovieSceneTrackDisplayOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackDisplayOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackDisplayOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackDisplayOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackDisplayOptions A, FMovieSceneTrackDisplayOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackDisplayOptions A, FMovieSceneTrackDisplayOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackDisplayOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bShowVerticalFrames
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShowVerticalFrames, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShowVerticalFrames, __InBuffer);
				}
			}
		}

		private static uint __bShowVerticalFrames = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
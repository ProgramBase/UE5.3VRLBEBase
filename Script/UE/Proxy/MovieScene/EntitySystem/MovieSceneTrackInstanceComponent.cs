using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackInstanceComponent")]
	public partial class FMovieSceneTrackInstanceComponent : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackInstanceComponent");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackInstanceComponent() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackInstanceComponent() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackInstanceComponent A, FMovieSceneTrackInstanceComponent B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackInstanceComponent A, FMovieSceneTrackInstanceComponent B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackInstanceComponent;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSection Owner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __ReturnBuffer);

					return *(UMovieSceneSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Owner, __InBuffer);
				}
			}
		}

		public TSubclassOf<UMovieSceneTrackInstance> TrackInstanceClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackInstanceClass, __ReturnBuffer);

					return *(TSubclassOf<UMovieSceneTrackInstance>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackInstanceClass, __InBuffer);
				}
			}
		}

		private static uint __Owner = 0;

		private static uint __TrackInstanceClass = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
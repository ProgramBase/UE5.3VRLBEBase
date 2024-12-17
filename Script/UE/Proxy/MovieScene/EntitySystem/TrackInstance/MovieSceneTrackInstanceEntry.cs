using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTrackInstanceEntry")]
	public partial class FMovieSceneTrackInstanceEntry : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTrackInstanceEntry");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTrackInstanceEntry() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTrackInstanceEntry() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTrackInstanceEntry A, FMovieSceneTrackInstanceEntry B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTrackInstanceEntry A, FMovieSceneTrackInstanceEntry B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTrackInstanceEntry;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject BoundObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoundObject, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoundObject, __InBuffer);
				}
			}
		}

		public UMovieSceneTrackInstance TrackInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackInstance, __ReturnBuffer);

					return *(UMovieSceneTrackInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackInstance, __InBuffer);
				}
			}
		}

		private static uint __BoundObject = 0;

		private static uint __TrackInstance = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneAudioComponentData")]
	public partial class FMovieSceneAudioComponentData : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneAudioComponentData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneAudioComponentData() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneAudioComponentData() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneAudioComponentData A, FMovieSceneAudioComponentData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneAudioComponentData A, FMovieSceneAudioComponentData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneAudioComponentData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneAudioSection Section
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Section, __ReturnBuffer);

					return *(UMovieSceneAudioSection*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Section, __InBuffer);
				}
			}
		}

		private static uint __Section = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
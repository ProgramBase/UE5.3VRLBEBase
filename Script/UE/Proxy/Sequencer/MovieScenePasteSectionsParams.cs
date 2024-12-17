using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieScenePasteSectionsParams")]
	public partial class FMovieScenePasteSectionsParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Sequencer.MovieScenePasteSectionsParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePasteSectionsParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePasteSectionsParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePasteSectionsParams A, FMovieScenePasteSectionsParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePasteSectionsParams A, FMovieScenePasteSectionsParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePasteSectionsParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<UMovieSceneTrack> Tracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __ReturnBuffer);

					return *(TArray<UMovieSceneTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __InBuffer);
				}
			}
		}

		public TArray<int> TrackRowIndices
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackRowIndices, __ReturnBuffer);

					return *(TArray<int>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackRowIndices, __InBuffer);
				}
			}
		}

		public FFrameTime Time
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Time, __ReturnBuffer);

					return *(FFrameTime*)__ReturnBuffer;
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

		private static uint __Tracks = 0;

		private static uint __TrackRowIndices = 0;

		private static uint __Time = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
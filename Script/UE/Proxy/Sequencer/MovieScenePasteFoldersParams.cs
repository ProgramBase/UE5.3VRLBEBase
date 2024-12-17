using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieScenePasteFoldersParams")]
	public partial class FMovieScenePasteFoldersParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Sequencer.MovieScenePasteFoldersParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePasteFoldersParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePasteFoldersParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePasteFoldersParams A, FMovieScenePasteFoldersParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePasteFoldersParams A, FMovieScenePasteFoldersParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePasteFoldersParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSequence Sequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __ReturnBuffer);

					return *(UMovieSceneSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __InBuffer);
				}
			}
		}

		public UMovieSceneFolder ParentFolder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentFolder, __ReturnBuffer);

					return *(UMovieSceneFolder*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentFolder, __InBuffer);
				}
			}
		}

		private static uint __Sequence = 0;

		private static uint __ParentFolder = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
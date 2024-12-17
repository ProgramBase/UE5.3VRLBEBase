using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieScenePasteTracksParams")]
	public partial class FMovieScenePasteTracksParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Sequencer.MovieScenePasteTracksParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePasteTracksParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePasteTracksParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePasteTracksParams A, FMovieScenePasteTracksParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePasteTracksParams A, FMovieScenePasteTracksParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePasteTracksParams;

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

		public TArray<FMovieSceneBindingProxy> Bindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Bindings, __ReturnBuffer);

					return *(TArray<FMovieSceneBindingProxy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Bindings, __InBuffer);
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

		public TArray<UMovieSceneFolder> Folders
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Folders, __ReturnBuffer);

					return *(TArray<UMovieSceneFolder>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Folders, __InBuffer);
				}
			}
		}

		private static uint __Sequence = 0;

		private static uint __Bindings = 0;

		private static uint __ParentFolder = 0;

		private static uint __Folders = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.Sequencer
{
	[PathName("/Script/Sequencer.MovieScenePasteBindingsParams")]
	public partial class FMovieScenePasteBindingsParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Sequencer.MovieScenePasteBindingsParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieScenePasteBindingsParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieScenePasteBindingsParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieScenePasteBindingsParams A, FMovieScenePasteBindingsParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieScenePasteBindingsParams A, FMovieScenePasteBindingsParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieScenePasteBindingsParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public bool bDuplicateExistingActors
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bDuplicateExistingActors, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bDuplicateExistingActors, __InBuffer);
				}
			}
		}

		private static uint __Bindings = 0;

		private static uint __ParentFolder = 0;

		private static uint __Folders = 0;

		private static uint __bDuplicateExistingActors = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
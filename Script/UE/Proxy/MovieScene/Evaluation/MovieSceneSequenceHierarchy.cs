using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceHierarchy")]
	public partial class FMovieSceneSequenceHierarchy : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceHierarchy");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceHierarchy() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceHierarchy() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceHierarchy A, FMovieSceneSequenceHierarchy B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceHierarchy A, FMovieSceneSequenceHierarchy B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceHierarchy;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneSequenceHierarchyNode RootNode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootNode, __ReturnBuffer);

					return *(FMovieSceneSequenceHierarchyNode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootNode, __InBuffer);
				}
			}
		}

		public FMovieSceneSubSequenceTree Tree
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tree, __ReturnBuffer);

					return *(FMovieSceneSubSequenceTree*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tree, __InBuffer);
				}
			}
		}

		public TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData> SubSequences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubSequences, __ReturnBuffer);

					return *(TMap<FMovieSceneSequenceID, FMovieSceneSubSequenceData>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubSequences, __InBuffer);
				}
			}
		}

		public TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode> Hierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __ReturnBuffer);

					return *(TMap<FMovieSceneSequenceID, FMovieSceneSequenceHierarchyNode>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Hierarchy, __InBuffer);
				}
			}
		}

		private static uint __RootNode = 0;

		private static uint __Tree = 0;

		private static uint __SubSequences = 0;

		private static uint __Hierarchy = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
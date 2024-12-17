using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceHierarchyNode")]
	public partial class FMovieSceneSequenceHierarchyNode : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceHierarchyNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceHierarchyNode() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceHierarchyNode() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceHierarchyNode A, FMovieSceneSequenceHierarchyNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceHierarchyNode A, FMovieSceneSequenceHierarchyNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceHierarchyNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneSequenceID ParentID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ParentID, __ReturnBuffer);

					return *(FMovieSceneSequenceID*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ParentID, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneSequenceID> Children
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Children, __ReturnBuffer);

					return *(TArray<FMovieSceneSequenceID>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Children, __InBuffer);
				}
			}
		}

		private static uint __ParentID = 0;

		private static uint __Children = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
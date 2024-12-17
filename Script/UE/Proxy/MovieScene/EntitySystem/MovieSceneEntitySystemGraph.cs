using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEntitySystemGraph")]
	public partial class FMovieSceneEntitySystemGraph : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEntitySystemGraph");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEntitySystemGraph() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEntitySystemGraph() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEntitySystemGraph A, FMovieSceneEntitySystemGraph B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEntitySystemGraph A, FMovieSceneEntitySystemGraph B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEntitySystemGraph;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneEntitySystemGraphNodes Nodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __ReturnBuffer);

					return *(FMovieSceneEntitySystemGraphNodes*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Nodes, __InBuffer);
				}
			}
		}

		private static uint __Nodes = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEntitySystemGraphNode")]
	public partial class FMovieSceneEntitySystemGraphNode : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEntitySystemGraphNode");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEntitySystemGraphNode() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEntitySystemGraphNode() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEntitySystemGraphNode A, FMovieSceneEntitySystemGraphNode B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEntitySystemGraphNode A, FMovieSceneEntitySystemGraphNode B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEntitySystemGraphNode;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneEntitySystem System
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __System, __ReturnBuffer);

					return *(UMovieSceneEntitySystem*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __System, __InBuffer);
				}
			}
		}

		private static uint __System = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
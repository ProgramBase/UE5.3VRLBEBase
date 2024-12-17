using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequencePlayToParams")]
	public partial class FMovieSceneSequencePlayToParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequencePlayToParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequencePlayToParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequencePlayToParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequencePlayToParams A, FMovieSceneSequencePlayToParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequencePlayToParams A, FMovieSceneSequencePlayToParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequencePlayToParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bExclusive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bExclusive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bExclusive, __InBuffer);
				}
			}
		}

		private static uint __bExclusive = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
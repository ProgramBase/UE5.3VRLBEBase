using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneWarpCounter")]
	public partial class FMovieSceneWarpCounter : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneWarpCounter");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneWarpCounter() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneWarpCounter() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneWarpCounter A, FMovieSceneWarpCounter B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneWarpCounter A, FMovieSceneWarpCounter B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneWarpCounter;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TArray<uint> WarpCounts
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WarpCounts, __ReturnBuffer);

					return *(TArray<uint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WarpCounts, __InBuffer);
				}
			}
		}

		private static uint __WarpCounts = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
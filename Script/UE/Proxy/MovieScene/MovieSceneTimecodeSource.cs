using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTimecodeSource")]
	public partial class FMovieSceneTimecodeSource : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTimecodeSource");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTimecodeSource() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTimecodeSource() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTimecodeSource A, FMovieSceneTimecodeSource B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTimecodeSource A, FMovieSceneTimecodeSource B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTimecodeSource;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FTimecode Timecode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Timecode, __ReturnBuffer);

					return *(FTimecode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Timecode, __InBuffer);
				}
			}
		}

		private static uint __Timecode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
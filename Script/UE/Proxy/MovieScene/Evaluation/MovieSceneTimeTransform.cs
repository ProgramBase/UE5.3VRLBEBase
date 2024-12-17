using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTimeTransform")]
	public partial class FMovieSceneTimeTransform : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTimeTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTimeTransform() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTimeTransform() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTimeTransform A, FMovieSceneTimeTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTimeTransform A, FMovieSceneTimeTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTimeTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public float TimeScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TimeScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TimeScale, __InBuffer);
				}
			}
		}

		public FFrameTime Offset
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Offset, __ReturnBuffer);

					return *(FFrameTime*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Offset, __InBuffer);
				}
			}
		}

		private static uint __TimeScale = 0;

		private static uint __Offset = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneNestedSequenceTransform")]
	public partial class FMovieSceneNestedSequenceTransform : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneNestedSequenceTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneNestedSequenceTransform() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneNestedSequenceTransform() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneNestedSequenceTransform A, FMovieSceneNestedSequenceTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneNestedSequenceTransform A, FMovieSceneNestedSequenceTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneNestedSequenceTransform;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneTimeTransform LinearTransform
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LinearTransform, __ReturnBuffer);

					return *(FMovieSceneTimeTransform*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LinearTransform, __InBuffer);
				}
			}
		}

		public FMovieSceneTimeWarping Warping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Warping, __ReturnBuffer);

					return *(FMovieSceneTimeWarping*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Warping, __InBuffer);
				}
			}
		}

		private static uint __LinearTransform = 0;

		private static uint __Warping = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
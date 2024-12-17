using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceTransform")]
	public partial class FMovieSceneSequenceTransform : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceTransform");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceTransform() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceTransform() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceTransform A, FMovieSceneSequenceTransform B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceTransform A, FMovieSceneSequenceTransform B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceTransform;

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

		public TArray<FMovieSceneNestedSequenceTransform> NestedTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NestedTransforms, __ReturnBuffer);

					return *(TArray<FMovieSceneNestedSequenceTransform>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NestedTransforms, __InBuffer);
				}
			}
		}

		private static uint __LinearTransform = 0;

		private static uint __NestedTransforms = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
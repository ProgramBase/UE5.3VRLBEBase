using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDynamicBindingContainer")]
	public partial class FMovieSceneDynamicBindingContainer : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneDynamicBindingContainer");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneDynamicBindingContainer() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneDynamicBindingContainer() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneDynamicBindingContainer A, FMovieSceneDynamicBindingContainer B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneDynamicBindingContainer A, FMovieSceneDynamicBindingContainer B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneDynamicBindingContainer;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneDynamicBinding DynamicBinding
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DynamicBinding, __ReturnBuffer);

					return *(FMovieSceneDynamicBinding*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DynamicBinding, __InBuffer);
				}
			}
		}

		private static uint __DynamicBinding = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDynamicBindingResolveResult")]
	public partial class FMovieSceneDynamicBindingResolveResult : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneDynamicBindingResolveResult");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneDynamicBindingResolveResult() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneDynamicBindingResolveResult() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneDynamicBindingResolveResult A, FMovieSceneDynamicBindingResolveResult B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneDynamicBindingResolveResult A, FMovieSceneDynamicBindingResolveResult B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneDynamicBindingResolveResult;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UObject Object
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Object, __ReturnBuffer);

					return *(UObject*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Object, __InBuffer);
				}
			}
		}

		public bool bIsPossessedObject
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIsPossessedObject, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIsPossessedObject, __InBuffer);
				}
			}
		}

		private static uint __Object = 0;

		private static uint __bIsPossessedObject = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
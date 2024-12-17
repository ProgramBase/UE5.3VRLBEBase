using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneDynamicBindingResolveParams")]
	public partial class FMovieSceneDynamicBindingResolveParams : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneDynamicBindingResolveParams");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneDynamicBindingResolveParams() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneDynamicBindingResolveParams() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneDynamicBindingResolveParams A, FMovieSceneDynamicBindingResolveParams B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneDynamicBindingResolveParams A, FMovieSceneDynamicBindingResolveParams B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneDynamicBindingResolveParams;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public UMovieSceneSequence Sequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __ReturnBuffer);

					return *(UMovieSceneSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Sequence, __InBuffer);
				}
			}
		}

		public FGuid ObjectBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __InBuffer);
				}
			}
		}

		public UMovieSceneSequence RootSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RootSequence, __ReturnBuffer);

					return *(UMovieSceneSequence*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RootSequence, __InBuffer);
				}
			}
		}

		private static uint __Sequence = 0;

		private static uint __ObjectBindingID = 0;

		private static uint __RootSequence = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSectionEvalOptions")]
	public partial class FMovieSceneSectionEvalOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSectionEvalOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSectionEvalOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSectionEvalOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSectionEvalOptions A, FMovieSceneSectionEvalOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSectionEvalOptions A, FMovieSceneSectionEvalOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSectionEvalOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bCanEditCompletionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bCanEditCompletionMode, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bCanEditCompletionMode, __InBuffer);
				}
			}
		}

		public EMovieSceneCompletionMode CompletionMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompletionMode, __ReturnBuffer);

					return *(EMovieSceneCompletionMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompletionMode, __InBuffer);
				}
			}
		}

		private static uint __bCanEditCompletionMode = 0;

		private static uint __CompletionMode = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
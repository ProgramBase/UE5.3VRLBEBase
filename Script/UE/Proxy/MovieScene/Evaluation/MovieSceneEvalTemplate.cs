using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvalTemplate")]
	public partial class FMovieSceneEvalTemplate : FMovieSceneEvalTemplateBase, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvalTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvalTemplate()
		{
		}

		public static bool operator ==(FMovieSceneEvalTemplate A, FMovieSceneEvalTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvalTemplate A, FMovieSceneEvalTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvalTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		public TWeakObjectPtr<UMovieSceneSection> SourceSectionPtr
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceSectionPtr, __ReturnBuffer);

					return *(TWeakObjectPtr<UMovieSceneSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceSectionPtr, __InBuffer);
				}
			}
		}

		private static uint __CompletionMode = 0;

		private static uint __SourceSectionPtr = 0;

	}
}
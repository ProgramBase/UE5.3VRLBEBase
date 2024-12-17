using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneRootEvaluationTemplateInstance")]
	public partial class FMovieSceneRootEvaluationTemplateInstance : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneRootEvaluationTemplateInstance");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneRootEvaluationTemplateInstance() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneRootEvaluationTemplateInstance() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneRootEvaluationTemplateInstance A, FMovieSceneRootEvaluationTemplateInstance B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneRootEvaluationTemplateInstance A, FMovieSceneRootEvaluationTemplateInstance B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneRootEvaluationTemplateInstance;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UMovieSceneSequence> WeakRootSequence
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __WeakRootSequence, __ReturnBuffer);

					return *(TWeakObjectPtr<UMovieSceneSequence>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __WeakRootSequence, __InBuffer);
				}
			}
		}

		public UMovieSceneCompiledDataManager CompiledDataManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __CompiledDataManager, __ReturnBuffer);

					return *(UMovieSceneCompiledDataManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __CompiledDataManager, __InBuffer);
				}
			}
		}

		public UMovieSceneEntitySystemLinker EntitySystemLinker
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EntitySystemLinker, __ReturnBuffer);

					return *(UMovieSceneEntitySystemLinker*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EntitySystemLinker, __InBuffer);
				}
			}
		}

		public TMap<FMovieSceneSequenceID, UObject> DirectorInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DirectorInstances, __ReturnBuffer);

					return *(TMap<FMovieSceneSequenceID, UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DirectorInstances, __InBuffer);
				}
			}
		}

		private static uint __WeakRootSequence = 0;

		private static uint __CompiledDataManager = 0;

		private static uint __EntitySystemLinker = 0;

		private static uint __DirectorInstances = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
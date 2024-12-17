using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneCompiledDataManager")]
	public partial class UMovieSceneCompiledDataManager : UObject, IStaticClass
	{
		public TMap<int, FMovieSceneSequenceHierarchy> Hierarchies
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchies, __ReturnBuffer);

					return *(TMap<int, FMovieSceneSequenceHierarchy>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Hierarchies, __InBuffer);
				}
			}
		}

		public TMap<int, FMovieSceneEvaluationTemplate> TrackTemplates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackTemplates, __ReturnBuffer);

					return *(TMap<int, FMovieSceneEvaluationTemplate>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackTemplates, __InBuffer);
				}
			}
		}

		public TMap<int, FMovieSceneEvaluationField> TrackTemplateFields
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TrackTemplateFields, __ReturnBuffer);

					return *(TMap<int, FMovieSceneEvaluationField>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TrackTemplateFields, __InBuffer);
				}
			}
		}

		public TMap<int, FMovieSceneEntityComponentField> EntityComponentFields
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EntityComponentFields, __ReturnBuffer);

					return *(TMap<int, FMovieSceneEntityComponentField>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EntityComponentFields, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneCompiledDataManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Hierarchies = 0;

		private static uint __TrackTemplates = 0;

		private static uint __TrackTemplateFields = 0;

		private static uint __EntityComponentFields = 0;
	}
}
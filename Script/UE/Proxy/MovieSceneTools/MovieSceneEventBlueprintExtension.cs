using Script.CoreUObject;
using Script.Engine;
using Script.MovieSceneTracks;
using Script.Library;

namespace Script.MovieSceneTools
{
	[PathName("/Script/MovieSceneTools.MovieSceneEventBlueprintExtension")]
	public partial class UMovieSceneEventBlueprintExtension : UBlueprintExtension, IStaticClass
	{
		public TArray<TWeakObjectPtr<UMovieSceneEventSectionBase>> EventSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EventSections, __ReturnBuffer);

					return *(TArray<TWeakObjectPtr<UMovieSceneEventSectionBase>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EventSections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieSceneTools.MovieSceneEventBlueprintExtension");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __EventSections = 0;
	}
}
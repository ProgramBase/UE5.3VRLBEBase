using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSectionChannelOverrideRegistry")]
	public partial class UMovieSceneSectionChannelOverrideRegistry : UObject, IStaticClass
	{
		public TMap<FName, UMovieSceneChannelOverrideContainer> Overrides
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Overrides, __ReturnBuffer);

					return *(TMap<FName, UMovieSceneChannelOverrideContainer>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Overrides, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MovieScene.MovieSceneSectionChannelOverrideRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Overrides = 0;
	}
}
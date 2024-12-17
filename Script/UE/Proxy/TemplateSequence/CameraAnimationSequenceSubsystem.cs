using Script.CoreUObject;
using Script.Engine;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.CameraAnimationSequenceSubsystem")]
	public partial class UCameraAnimationSequenceSubsystem : UWorldSubsystem, IStaticClass
	{
		public UMovieSceneEntitySystemLinker Linker
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Linker, __ReturnBuffer);

					return *(UMovieSceneEntitySystemLinker*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Linker, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.CameraAnimationSequenceSubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Linker = 0;
	}
}
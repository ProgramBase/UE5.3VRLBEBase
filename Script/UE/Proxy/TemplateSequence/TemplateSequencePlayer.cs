using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.TemplateSequence
{
	[PathName("/Script/TemplateSequence.TemplateSequencePlayer")]
	public partial class UTemplateSequencePlayer : UMovieSceneSequencePlayer, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/TemplateSequence.TemplateSequencePlayer");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UTemplateSequencePlayer CreateTemplateSequencePlayer(UObject WorldContextObject, UTemplateSequence TemplateSequence, FMovieSceneSequencePlaybackSettings Settings, ref ATemplateSequenceActor OutActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TemplateSequence?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Settings?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutActor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(StaticClass().GarbageCollectionHandle, __CreateTemplateSequencePlayer, __InBuffer, __OutBuffer, __ReturnBuffer);

				OutActor = *(ATemplateSequenceActor*)(__OutBuffer);

				return *(UTemplateSequencePlayer*)__ReturnBuffer;
			}
		}

		private static uint __CreateTemplateSequencePlayer = 0;
	}
}
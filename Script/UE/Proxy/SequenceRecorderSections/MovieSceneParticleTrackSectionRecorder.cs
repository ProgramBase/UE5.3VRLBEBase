using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.SequenceRecorderSections
{
	[PathName("/Script/SequenceRecorderSections.MovieSceneParticleTrackSectionRecorder")]
	public partial class UMovieSceneParticleTrackSectionRecorder : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequenceRecorderSections.MovieSceneParticleTrackSectionRecorder");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnTriggered(UParticleSystemComponent Component, bool bActivating)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bActivating;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnTriggered, __InBuffer);
			}
		}

		private static uint __OnTriggered = 0;
	}
}
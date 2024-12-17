using Script.CoreUObject;
using Script.MovieScene;
using Script.Library;

namespace Script.GeometryCollectionTracks
{
	[PathName("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionTrack")]
	public partial class UMovieSceneGeometryCollectionTrack : UMovieSceneNameableTrack, IStaticClass, IMovieSceneTrackTemplateProducer
	{
		public TArray<UMovieSceneSection> AnimationSections
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationSections, __ReturnBuffer);

					return *(TArray<UMovieSceneSection>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationSections, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GeometryCollectionTracks.MovieSceneGeometryCollectionTrack");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __AnimationSections = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}
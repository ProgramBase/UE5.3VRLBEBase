using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;

namespace Script.MovieSceneTracks
{
	[PathName("/Script/MovieSceneTracks.MovieSceneActorReferenceSectionTemplate")]
	public partial class FMovieSceneActorReferenceSectionTemplate : FMovieSceneEvalTemplate, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieSceneTracks.MovieSceneActorReferenceSectionTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneActorReferenceSectionTemplate()
		{
		}

		public static bool operator ==(FMovieSceneActorReferenceSectionTemplate A, FMovieSceneActorReferenceSectionTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneActorReferenceSectionTemplate A, FMovieSceneActorReferenceSectionTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneActorReferenceSectionTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieScenePropertySectionData PropertyData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyData, __ReturnBuffer);

					return *(FMovieScenePropertySectionData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyData, __InBuffer);
				}
			}
		}

		public FMovieSceneActorReferenceData ActorReferenceData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ActorReferenceData, __ReturnBuffer);

					return *(FMovieSceneActorReferenceData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ActorReferenceData, __InBuffer);
				}
			}
		}

		private static uint __PropertyData = 0;

		private static uint __ActorReferenceData = 0;

	}
}
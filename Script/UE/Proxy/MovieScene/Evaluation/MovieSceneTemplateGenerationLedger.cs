using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneTemplateGenerationLedger")]
	public partial class FMovieSceneTemplateGenerationLedger : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneTemplateGenerationLedger");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneTemplateGenerationLedger() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneTemplateGenerationLedger() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneTemplateGenerationLedger A, FMovieSceneTemplateGenerationLedger B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneTemplateGenerationLedger A, FMovieSceneTemplateGenerationLedger B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneTemplateGenerationLedger;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FMovieSceneTrackIdentifier LastTrackIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LastTrackIdentifier, __ReturnBuffer);

					return *(FMovieSceneTrackIdentifier*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LastTrackIdentifier, __InBuffer);
				}
			}
		}

		public TMap<FGuid, FMovieSceneTrackIdentifier> TrackSignatureToTrackIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackSignatureToTrackIdentifier, __ReturnBuffer);

					return *(TMap<FGuid, FMovieSceneTrackIdentifier>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackSignatureToTrackIdentifier, __InBuffer);
				}
			}
		}

		public TMap<FGuid, FMovieSceneFrameRange> SubSectionRanges
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SubSectionRanges, __ReturnBuffer);

					return *(TMap<FGuid, FMovieSceneFrameRange>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SubSectionRanges, __InBuffer);
				}
			}
		}

		private static uint __LastTrackIdentifier = 0;

		private static uint __TrackSignatureToTrackIdentifier = 0;

		private static uint __SubSectionRanges = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
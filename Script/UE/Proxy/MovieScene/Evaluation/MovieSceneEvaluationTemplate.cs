using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationTemplate")]
	public partial class FMovieSceneEvaluationTemplate : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationTemplate");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationTemplate() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationTemplate() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationTemplate A, FMovieSceneEvaluationTemplate B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationTemplate A, FMovieSceneEvaluationTemplate B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationTemplate;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack> Tracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __ReturnBuffer);

					return *(TMap<FMovieSceneTrackIdentifier, FMovieSceneEvaluationTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Tracks, __InBuffer);
				}
			}
		}

		public FGuid SequenceSignature
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SequenceSignature, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SequenceSignature, __InBuffer);
				}
			}
		}

		public FMovieSceneEvaluationTemplateSerialNumber TemplateSerialNumber
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TemplateSerialNumber, __ReturnBuffer);

					return *(FMovieSceneEvaluationTemplateSerialNumber*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TemplateSerialNumber, __InBuffer);
				}
			}
		}

		public FMovieSceneTemplateGenerationLedger TemplateLedger
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TemplateLedger, __ReturnBuffer);

					return *(FMovieSceneTemplateGenerationLedger*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TemplateLedger, __InBuffer);
				}
			}
		}

		private static uint __Tracks = 0;

		private static uint __SequenceSignature = 0;

		private static uint __TemplateSerialNumber = 0;

		private static uint __TemplateLedger = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
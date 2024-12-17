using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneEvaluationTrack")]
	public partial class FMovieSceneEvaluationTrack : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneEvaluationTrack");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneEvaluationTrack() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneEvaluationTrack() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneEvaluationTrack A, FMovieSceneEvaluationTrack B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneEvaluationTrack A, FMovieSceneEvaluationTrack B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneEvaluationTrack;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FGuid ObjectBindingID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __ReturnBuffer);

					return *(FGuid*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ObjectBindingID, __InBuffer);
				}
			}
		}

		public ushort EvaluationPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[2];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationPriority, __ReturnBuffer);

					return *(ushort*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[2];

					*(ushort*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationPriority, __InBuffer);
				}
			}
		}

		public EEvaluationMethod EvaluationMethod
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationMethod, __ReturnBuffer);

					return *(EEvaluationMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationMethod, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UMovieSceneTrack> SourceTrack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceTrack, __ReturnBuffer);

					return *(TWeakObjectPtr<UMovieSceneTrack>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceTrack, __InBuffer);
				}
			}
		}

		public TArray<FMovieSceneEvalTemplatePtr> ChildTemplates
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ChildTemplates, __ReturnBuffer);

					return *(TArray<FMovieSceneEvalTemplatePtr>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ChildTemplates, __InBuffer);
				}
			}
		}

		public FMovieSceneTrackImplementationPtr TrackTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TrackTemplate, __ReturnBuffer);

					return *(FMovieSceneTrackImplementationPtr*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TrackTemplate, __InBuffer);
				}
			}
		}

		public FName EvaluationGroup
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationGroup, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationGroup, __InBuffer);
				}
			}
		}

		public bool bEvaluateInPreroll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateInPreroll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateInPreroll, __InBuffer);
				}
			}
		}

		public bool bEvaluateInPostroll
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateInPostroll, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateInPostroll, __InBuffer);
				}
			}
		}

		public bool bTearDownPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bTearDownPriority, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bTearDownPriority, __InBuffer);
				}
			}
		}

		private static uint __ObjectBindingID = 0;

		private static uint __EvaluationPriority = 0;

		private static uint __EvaluationMethod = 0;

		private static uint __SourceTrack = 0;

		private static uint __ChildTemplates = 0;

		private static uint __TrackTemplate = 0;

		private static uint __EvaluationGroup = 0;

		private static uint __bEvaluateInPreroll = 0;

		private static uint __bEvaluateInPostroll = 0;

		private static uint __bTearDownPriority = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
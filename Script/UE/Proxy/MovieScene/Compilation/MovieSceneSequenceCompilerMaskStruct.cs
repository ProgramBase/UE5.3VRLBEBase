using Script.CoreUObject;
using Script.Library;

namespace Script.MovieScene
{
	[PathName("/Script/MovieScene.MovieSceneSequenceCompilerMaskStruct")]
	public partial class FMovieSceneSequenceCompilerMaskStruct : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/MovieScene.MovieSceneSequenceCompilerMaskStruct");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneSequenceCompilerMaskStruct() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FMovieSceneSequenceCompilerMaskStruct() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FMovieSceneSequenceCompilerMaskStruct A, FMovieSceneSequenceCompilerMaskStruct B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneSequenceCompilerMaskStruct A, FMovieSceneSequenceCompilerMaskStruct B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneSequenceCompilerMaskStruct;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bHierarchy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bHierarchy, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bHierarchy, __InBuffer);
				}
			}
		}

		public bool bEvaluationTemplate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluationTemplate, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluationTemplate, __InBuffer);
				}
			}
		}

		public bool bEvaluationTemplateField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluationTemplateField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluationTemplateField, __InBuffer);
				}
			}
		}

		public bool bEntityComponentField
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEntityComponentField, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEntityComponentField, __InBuffer);
				}
			}
		}

		private static uint __bHierarchy = 0;

		private static uint __bEvaluationTemplate = 0;

		private static uint __bEvaluationTemplateField = 0;

		private static uint __bEntityComponentField = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions")]
	public partial class FAnimPoseEvaluationOptions : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimationBlueprintLibrary.AnimPoseEvaluationOptions");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimPoseEvaluationOptions() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FAnimPoseEvaluationOptions() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FAnimPoseEvaluationOptions A, FAnimPoseEvaluationOptions B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimPoseEvaluationOptions A, FAnimPoseEvaluationOptions B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimPoseEvaluationOptions;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public EAnimDataEvalType EvaluationType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationType, __ReturnBuffer);

					return *(EAnimDataEvalType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvaluationType, __InBuffer);
				}
			}
		}

		public bool bShouldRetarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bShouldRetarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bShouldRetarget, __InBuffer);
				}
			}
		}

		public bool bExtractRootMotion
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bExtractRootMotion, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bExtractRootMotion, __InBuffer);
				}
			}
		}

		public bool bIncorporateRootMotionIntoPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bIncorporateRootMotionIntoPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bIncorporateRootMotionIntoPose, __InBuffer);
				}
			}
		}

		public USkeletalMesh OptionalSkeletalMesh
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OptionalSkeletalMesh, __ReturnBuffer);

					return *(USkeletalMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OptionalSkeletalMesh, __InBuffer);
				}
			}
		}

		public bool bRetrieveAdditiveAsFullPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bRetrieveAdditiveAsFullPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bRetrieveAdditiveAsFullPose, __InBuffer);
				}
			}
		}

		public bool bEvaluateCurves
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateCurves, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvaluateCurves, __InBuffer);
				}
			}
		}

		private static uint __EvaluationType = 0;

		private static uint __bShouldRetarget = 0;

		private static uint __bExtractRootMotion = 0;

		private static uint __bIncorporateRootMotionIntoPose = 0;

		private static uint __OptionalSkeletalMesh = 0;

		private static uint __bRetrieveAdditiveAsFullPose = 0;

		private static uint __bEvaluateCurves = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
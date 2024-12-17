using Script.CoreUObject;
using Script.Library;
using Script.MovieScene;
using Script.Engine;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.MovieSceneControlRigInstanceData")]
	public partial class FMovieSceneControlRigInstanceData : FMovieSceneSequenceInstanceData, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/ControlRig.MovieSceneControlRigInstanceData");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FMovieSceneControlRigInstanceData()
		{
		}

		public static bool operator ==(FMovieSceneControlRigInstanceData A, FMovieSceneControlRigInstanceData B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FMovieSceneControlRigInstanceData A, FMovieSceneControlRigInstanceData B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FMovieSceneControlRigInstanceData;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool bAdditive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bAdditive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bAdditive, __InBuffer);
				}
			}
		}

		public bool bApplyBoneFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bApplyBoneFilter, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bApplyBoneFilter, __InBuffer);
				}
			}
		}

		public FInputBlendPose BoneFilter
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BoneFilter, __ReturnBuffer);

					return *(FInputBlendPose*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BoneFilter, __InBuffer);
				}
			}
		}

		public FMovieSceneFloatChannel Weight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __ReturnBuffer);

					return *(FMovieSceneFloatChannel*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Weight, __InBuffer);
				}
			}
		}

		public FMovieSceneEvaluationOperand Operand
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operand, __ReturnBuffer);

					return *(FMovieSceneEvaluationOperand*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operand, __InBuffer);
				}
			}
		}

		private static uint __bAdditive = 0;

		private static uint __bApplyBoneFilter = 0;

		private static uint __BoneFilter = 0;

		private static uint __Weight = 0;

		private static uint __Operand = 0;

	}
}
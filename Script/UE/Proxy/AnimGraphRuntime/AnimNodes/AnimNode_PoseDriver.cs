using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.AnimNode_PoseDriver")]
	public partial class FAnimNode_PoseDriver : FAnimNode_PoseHandler, IStaticStruct, IGarbageCollectionHandle
	{
		public new static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AnimGraphRuntime.AnimNode_PoseDriver");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FAnimNode_PoseDriver()
		{
		}

		public static bool operator ==(FAnimNode_PoseDriver A, FAnimNode_PoseDriver B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FAnimNode_PoseDriver A, FAnimNode_PoseDriver B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FAnimNode_PoseDriver;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPoseLink SourcePose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourcePose, __ReturnBuffer);

					return *(FPoseLink*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourcePose, __InBuffer);
				}
			}
		}

		public TArray<FBoneReference> SourceBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SourceBones, __ReturnBuffer);

					return *(TArray<FBoneReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SourceBones, __InBuffer);
				}
			}
		}

		public FBoneReference EvalSpaceBone
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __EvalSpaceBone, __ReturnBuffer);

					return *(FBoneReference*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __EvalSpaceBone, __InBuffer);
				}
			}
		}

		public bool bEvalFromRefPose
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bEvalFromRefPose, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bEvalFromRefPose, __InBuffer);
				}
			}
		}

		public TArray<FBoneReference> OnlyDriveBones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OnlyDriveBones, __ReturnBuffer);

					return *(TArray<FBoneReference>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OnlyDriveBones, __InBuffer);
				}
			}
		}

		public TArray<FPoseDriverTarget> PoseTargets
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PoseTargets, __ReturnBuffer);

					return *(TArray<FPoseDriverTarget>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PoseTargets, __InBuffer);
				}
			}
		}

		public FRBFParams RBFParams
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RBFParams, __ReturnBuffer);

					return *(FRBFParams*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RBFParams, __InBuffer);
				}
			}
		}

		public EPoseDriverSource DriveSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DriveSource, __ReturnBuffer);

					return *(EPoseDriverSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DriveSource, __InBuffer);
				}
			}
		}

		public EPoseDriverOutput DriveOutput
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DriveOutput, __ReturnBuffer);

					return *(EPoseDriverOutput*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DriveOutput, __InBuffer);
				}
			}
		}

		public bool bSoloDrivenOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __bSoloDrivenOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __bSoloDrivenOnly, __InBuffer);
				}
			}
		}

		public int LODThreshold
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LODThreshold, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LODThreshold, __InBuffer);
				}
			}
		}

		private static uint __SourcePose = 0;

		private static uint __SourceBones = 0;

		private static uint __EvalSpaceBone = 0;

		private static uint __bEvalFromRefPose = 0;

		private static uint __OnlyDriveBones = 0;

		private static uint __PoseTargets = 0;

		private static uint __RBFParams = 0;

		private static uint __DriveSource = 0;

		private static uint __DriveOutput = 0;

		private static uint __bSoloDrivenOnly = 0;

		private static uint __LODThreshold = 0;

	}
}
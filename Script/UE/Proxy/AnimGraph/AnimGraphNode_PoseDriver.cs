using Script.CoreUObject;
using Script.AnimGraphRuntime;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraph
{
	[PathName("/Script/AnimGraph.AnimGraphNode_PoseDriver")]
	public partial class UAnimGraphNode_PoseDriver : UAnimGraphNode_PoseHandler, IStaticClass
	{
		public FAnimNode_PoseDriver Node
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __ReturnBuffer);

					return *(FAnimNode_PoseDriver*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Node, __InBuffer);
				}
			}
		}

		public float AxisLength
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AxisLength, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AxisLength, __InBuffer);
				}
			}
		}

		public int ConeSubdivision
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConeSubdivision, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConeSubdivision, __InBuffer);
				}
			}
		}

		public bool bDrawDebugCones
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawDebugCones, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bDrawDebugCones, __InBuffer);
				}
			}
		}

		public USkeletalMeshComponent LastPreviewComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LastPreviewComponent, __ReturnBuffer);

					return *(USkeletalMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LastPreviewComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraph.AnimGraphNode_PoseDriver");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSourceBones(TArray<FName> BoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSourceBones, __InBuffer);
			}
		}

		public virtual void SetRBFParameters(FRBFParams Parameters)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Parameters?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetRBFParameters, __InBuffer);
			}
		}

		public virtual void SetPoseDriverSource(EPoseDriverSource DriverSource)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)DriverSource;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPoseDriverSource, __InBuffer);
			}
		}

		public virtual void SetPoseDriverOutput(EPoseDriverOutput DriverOutput)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)DriverOutput;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPoseDriverOutput, __InBuffer);
			}
		}

		public virtual void SetDrivingBones(TArray<FName> BoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDrivingBones, __InBuffer);
			}
		}

		public virtual void GetSourceBoneNames(ref TArray<FName> BoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetSourceBoneNames, __InBuffer, __OutBuffer);

				BoneNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual FRBFParams GetRBFParameters()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRBFParameters, __ReturnBuffer);

				return *(FRBFParams*)__ReturnBuffer;
			}
		}

		public virtual EPoseDriverSource GetPoseDriverSource()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPoseDriverSource, __ReturnBuffer);

				return *(EPoseDriverSource*)__ReturnBuffer;
			}
		}

		public virtual EPoseDriverOutput GetPoseDriverOutput()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPoseDriverOutput, __ReturnBuffer);

				return *(EPoseDriverOutput*)__ReturnBuffer;
			}
		}

		public virtual void GetDrivingBoneNames(ref TArray<FName> BoneNames)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = BoneNames?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetDrivingBoneNames, __InBuffer, __OutBuffer);

				BoneNames = *(TArray<FName>*)(__OutBuffer);

			}
		}

		public virtual void CopyTargetsFromPoseAsset()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CopyTargetsFromPoseAsset);
			}
		}

		private static uint __Node = 0;

		private static uint __AxisLength = 0;

		private static uint __ConeSubdivision = 0;

		private static uint __bDrawDebugCones = 0;

		private static uint __LastPreviewComponent = 0;

		private static uint __SetSourceBones = 0;

		private static uint __SetRBFParameters = 0;

		private static uint __SetPoseDriverSource = 0;

		private static uint __SetPoseDriverOutput = 0;

		private static uint __SetDrivingBones = 0;

		private static uint __GetSourceBoneNames = 0;

		private static uint __GetRBFParameters = 0;

		private static uint __GetPoseDriverSource = 0;

		private static uint __GetPoseDriverOutput = 0;

		private static uint __GetDrivingBoneNames = 0;

		private static uint __CopyTargetsFromPoseAsset = 0;
	}
}
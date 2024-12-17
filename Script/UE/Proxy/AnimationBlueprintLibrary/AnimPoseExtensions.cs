using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimationBlueprintLibrary
{
	[PathName("/Script/AnimationBlueprintLibrary.AnimPoseExtensions")]
	public partial class UAnimPoseExtensions : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintLibrary.AnimPoseExtensions");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Pose">
		/// Anim Pose to set transform in
		/// </param>
		/// <param name="Transform">
		/// Transform to set the bone to
		/// </param>
		/// <param name="BoneName">
		/// Name of the bone to set
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be set
		/// </param>
		public static void SetBonePose(ref FAnimPose Pose, FTransform Transform, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Transform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Space;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetBonePose, __InBuffer, __OutBuffer);

				Pose = *(FAnimPose*)(__OutBuffer);

			}
		}

		/// <param name="Pose">
		/// Anim Pose to validate
		/// </param>
		/// <returns>
		/// Result of the validation
		/// </returns>
		public static bool IsValid(FAnimPose Pose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValid, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="SocketName">
		/// Name of the socket to retrieve
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetSocketPose(FAnimPose Pose, FName SocketName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetSocketPose, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the names from
		/// </param>
		/// <param name="Sockets">
		/// Array to be populated with the socket names
		/// </param>
		public static void GetSocketNames(FAnimPose Pose, ref TArray<FName> Sockets)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Sockets?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetSocketNames, __InBuffer, __OutBuffer);

				Sockets = *(TArray<FName>*)(__OutBuffer);

			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="FromBoneName">
		/// Name of the bone to retrieve the transform relative from
		/// </param>
		/// <param name="ToBoneName">
		/// Name of the bone to retrieve the transform relative to
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Relative transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetRelativeTransform(FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FromBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ToBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRelativeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="BoneName">
		/// Name of the bone to retrieve the relative transform for
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Relative transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetRelativeToRefPoseTransform(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRelativeToRefPoseTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="FromBoneName">
		/// Name of the bone to retrieve the transform relative from
		/// </param>
		/// <param name="ToBoneName">
		/// Name of the bone to retrieve the transform relative to
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Relative transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetRefPoseRelativeTransform(FAnimPose Pose, FName FromBoneName, FName ToBoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = FromBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ToBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRefPoseRelativeTransform, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Skeleton">
		/// USkeleton object to retrieve the reference pose from
		/// </param>
		/// <param name="OutPose">
		/// Anim pose to hold the reference pose
		/// </param>
		public static void GetReferencePose(USkeleton Skeleton, ref FAnimPose OutPose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Skeleton?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetReferencePose, __InBuffer, __OutBuffer);

				OutPose = *(FAnimPose*)(__OutBuffer);

			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="BoneName">
		/// Name of the bone to retrieve
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetRefBonePose(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetRefBonePose, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the value from
		/// </param>
		/// <param name="CurveName">
		/// Curve to retrieve the weight value for
		/// </param>
		/// <returns>
		/// Curve weight value, if found - 0.f otherwise
		/// </returns>
		public static float GetCurveWeight(FAnimPose Pose, FName CurveName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = CurveName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurveWeight, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the names from
		/// </param>
		/// <param name="Curves">
		/// Array to be populated with the curve names
		/// </param>
		public static void GetCurveNames(FAnimPose Pose, ref TArray<FName> Curves)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Curves?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetCurveNames, __InBuffer, __OutBuffer);

				Curves = *(TArray<FName>*)(__OutBuffer);

			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the transform from
		/// </param>
		/// <param name="BoneName">
		/// Name of the bone to retrieve
		/// </param>
		/// <param name="Space">
		/// Space in which the transform should be retrieved
		/// </param>
		/// <returns>
		/// Transform in requested space for bone if found, otherwise return identity transform
		/// </returns>
		public static FTransform GetBonePose(FAnimPose Pose, FName BoneName, EAnimPoseSpaces Space = EAnimPoseSpaces.Local)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)Space;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBonePose, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="Pose">
		/// Anim Pose to retrieve the names from
		/// </param>
		/// <param name="Bones">
		/// Array to be populated with the bone names
		/// </param>
		public static void GetBoneNames(FAnimPose Pose, ref TArray<FName> Bones)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Bones?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetBoneNames, __InBuffer, __OutBuffer);

				Bones = *(TArray<FName>*)(__OutBuffer);

			}
		}

		/// <param name="AnimationSequenceBase">
		/// Animation sequence base to evaluate the pose from
		/// </param>
		/// <param name="Time">
		/// Time at which the pose should be evaluated
		/// </param>
		/// <param name="EvaluationOptions">
		/// Options determining the way the pose should be evaluated
		/// </param>
		/// <param name="Pose">
		/// Anim Pose to hold the evaluated data
		/// </param>
		public static void GetAnimPoseAtTime(UAnimSequenceBase AnimationSequenceBase, double Time, FAnimPoseEvaluationOptions EvaluationOptions, ref FAnimPose Pose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(double*)(__InBuffer + 8) = Time;

				*(nint*)(__InBuffer + 16) = EvaluationOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimPoseAtTime, __InBuffer, __OutBuffer);

				Pose = *(FAnimPose*)(__OutBuffer);

			}
		}

		/// <param name="AnimationSequenceBase">
		/// Animation sequence base to evaluate the pose from
		/// </param>
		/// <param name="FrameIndex">
		/// Exact frame at which the pose should be evaluated
		/// </param>
		/// <param name="EvaluationOptions">
		/// Options determining the way the pose should be evaluated
		/// </param>
		/// <param name="Pose">
		/// Anim Pose to hold the evaluated data
		/// </param>
		public static void GetAnimPoseAtFrame(UAnimSequenceBase AnimationSequenceBase, int FrameIndex, FAnimPoseEvaluationOptions EvaluationOptions, ref FAnimPose Pose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = AnimationSequenceBase?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 8) = FrameIndex;

				*(nint*)(__InBuffer + 12) = EvaluationOptions?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Pose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAnimPoseAtFrame, __InBuffer, __OutBuffer);

				Pose = *(FAnimPose*)(__OutBuffer);

			}
		}

		/// <param name="InputPose">
		/// Anim Pose used to populate the input pose node value inside of the Animation Blueprint
		/// </param>
		/// <param name="TargetSkeletalMesh">
		/// USkeletalMesh object used as the target skeletal mesh, should have same USkeleton as InputPose and Animation Blueprint
		/// </param>
		/// <param name="AnimationBlueprint">
		/// Animation Blueprint to generate an AnimInstance with, used to evaluate the output Anim Pose
		/// </param>
		/// <param name="OutPose">
		/// Anim pose to hold the data from evaluating the Animation Blueprint instance		
		/// </param>
		public static void EvaluateAnimationBlueprintWithInputPose(FAnimPose InputPose, USkeletalMesh TargetSkeletalMesh, UAnimBlueprint AnimationBlueprint, ref FAnimPose OutPose)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = InputPose?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetSkeletalMesh?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AnimationBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutPose?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __EvaluateAnimationBlueprintWithInputPose, __InBuffer, __OutBuffer);

				OutPose = *(FAnimPose*)(__OutBuffer);

			}
		}

		private static uint __SetBonePose = 0;

		private static uint __IsValid = 0;

		private static uint __GetSocketPose = 0;

		private static uint __GetSocketNames = 0;

		private static uint __GetRelativeTransform = 0;

		private static uint __GetRelativeToRefPoseTransform = 0;

		private static uint __GetRefPoseRelativeTransform = 0;

		private static uint __GetReferencePose = 0;

		private static uint __GetRefBonePose = 0;

		private static uint __GetCurveWeight = 0;

		private static uint __GetCurveNames = 0;

		private static uint __GetBonePose = 0;

		private static uint __GetBoneNames = 0;

		private static uint __GetAnimPoseAtTime = 0;

		private static uint __GetAnimPoseAtFrame = 0;

		private static uint __EvaluateAnimationBlueprintWithInputPose = 0;
	}
}
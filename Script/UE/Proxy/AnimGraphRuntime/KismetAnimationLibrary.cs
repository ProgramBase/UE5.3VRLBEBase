using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AnimGraphRuntime
{
	[PathName("/Script/AnimGraphRuntime.KismetAnimationLibrary")]
	public partial class UKismetAnimationLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimGraphRuntime.KismetAnimationLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="RootPos">
		/// The input root position of the two bone chain
		/// </param>
		/// <param name="JointPos">
		/// The input center (elbow) position of the two bone chain
		/// </param>
		/// <param name="EndPos">
		/// The input end (wrist) position of the two bone chain
		/// </param>
		/// <param name="JointTarget">
		/// The IK target for the write to reach
		/// </param>
		/// <param name="Effector">
		/// The position of the target effector for the IK Chain.
		/// </param>
		/// <param name="OutJointPos">
		/// The resulting position for the center (elbow)
		/// </param>
		/// <param name="OutEndPos">
		/// The resulting position for the end (wrist)
		/// </param>
		/// <param name="bAllowStretching">
		/// If set to true the bones are allowed to stretch
		/// </param>
		/// <param name="StartStretchRatio">
		/// The ratio at which the bones should start to stretch. The higher the value, the later the stretching wil start.
		/// </param>
		/// <param name="MaxStretchScale">
		/// The maximum multiplier for the stretch to reach.
		/// </param>
		public static void K2_TwoBoneIK(FVector RootPos, FVector JointPos, FVector EndPos, FVector JointTarget, FVector Effector, ref FVector OutJointPos, ref FVector OutEndPos, bool bAllowStretching, float StartStretchRatio, float MaxStretchScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[65];

				*(nint*)(__InBuffer) = RootPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = JointPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = EndPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = JointTarget?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Effector?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = OutJointPos?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 48) = OutEndPos?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 56) = bAllowStretching;

				*(float*)(__InBuffer + 57) = StartStretchRatio;

				*(float*)(__InBuffer + 61) = MaxStretchScale;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __K2_TwoBoneIK, __InBuffer, __OutBuffer);

				OutJointPos = *(FVector*)(__OutBuffer);

				OutEndPos = *(FVector*)(__OutBuffer + 8);

			}
		}

		public static void K2_StartProfilingTimer()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __K2_StartProfilingTimer);
			}
		}

		/// <param name="X">
		/// The x component for the input position of the noise
		/// </param>
		/// <param name="Y">
		/// The y component for the input position of the noise
		/// </param>
		/// <param name="Z">
		/// The z component for the input position of the noise
		/// </param>
		/// <param name="RangeOutMinX">
		/// The minimum for the output range for the x component
		/// </param>
		/// <param name="RangeOutMaxX">
		/// The maximum for the output range for the x component
		/// </param>
		/// <param name="RangeOutMinY">
		/// The minimum for the output range for the y component
		/// </param>
		/// <param name="RangeOutMaxY">
		/// The maximum for the output range for the y component
		/// </param>
		/// <param name="RangeOutMinZ">
		/// The minimum for the output range for the z component
		/// </param>
		/// <param name="RangeOutMaxZ">
		/// The maximum for the output range for the z component
		/// </param>
		public static FVector K2_MakePerlinNoiseVectorAndRemap(float X, float Y, float Z, float RangeOutMinX, float RangeOutMaxX, float RangeOutMinY, float RangeOutMaxY, float RangeOutMinZ, float RangeOutMaxZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(float*)(__InBuffer) = X;

				*(float*)(__InBuffer + 4) = Y;

				*(float*)(__InBuffer + 8) = Z;

				*(float*)(__InBuffer + 12) = RangeOutMinX;

				*(float*)(__InBuffer + 16) = RangeOutMaxX;

				*(float*)(__InBuffer + 20) = RangeOutMinY;

				*(float*)(__InBuffer + 24) = RangeOutMaxY;

				*(float*)(__InBuffer + 28) = RangeOutMinZ;

				*(float*)(__InBuffer + 32) = RangeOutMaxZ;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_MakePerlinNoiseVectorAndRemap, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="Value">
		/// The input value for the noise function
		/// </param>
		/// <param name="RangeOutMin">
		/// The minimum for the output range
		/// </param>
		/// <param name="RangeOutMax">
		/// The maximum for the output range
		/// </param>
		public static float K2_MakePerlinNoiseAndRemap(float Value, float RangeOutMin, float RangeOutMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = Value;

				*(float*)(__InBuffer + 4) = RangeOutMin;

				*(float*)(__InBuffer + 8) = RangeOutMax;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_MakePerlinNoiseAndRemap, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="CurrentTransform">
		/// The input transform to modify
		/// </param>
		/// <param name="TargetPosition">
		/// The position this transform should look at
		/// </param>
		/// <param name="LookAtVector">
		/// The local vector to align with the target
		/// </param>
		/// <param name="bUseUpVector">
		/// If set to true the lookat will also perform a twist rotation
		/// </param>
		/// <param name="UpVector">
		/// The position to use for the upvector target (only used is bUseUpVector is turned on)
		/// </param>
		/// <param name="ClampConeInDegree">
		/// A limit for only allowing the lookat to rotate as much as defined by the float value
		/// </param>
		public static FTransform K2_LookAt(FTransform CurrentTransform, FVector TargetPosition, FVector LookAtVector, bool bUseUpVector, FVector UpVector, float ClampConeInDegree)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = CurrentTransform?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetPosition?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = LookAtVector?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bUseUpVector;

				*(nint*)(__InBuffer + 25) = UpVector?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 33) = ClampConeInDegree;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_LookAt, __InBuffer, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		/// <param name="bLog">
		/// If set to true the result is logged to the OutputLog
		/// </param>
		/// <param name="LogPrefix">
		/// A prefix to use for the log
		/// </param>
		/// <result>
		/// The time spent in milliseconds
		/// </result>
		public static float K2_EndProfilingTimer(bool bLog = true, FString LogPrefix = null)
		{
			unsafe
			{
				LogPrefix ??= new FString("");

				var __InBuffer = stackalloc byte[9];

				*(bool*)(__InBuffer) = bLog;

				*(nint*)(__InBuffer + 1) = LogPrefix?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_EndProfilingTimer, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Component">
		/// The skeletal component to look for the sockets / bones within
		/// </param>
		/// <param name="SocketOrBoneNameA">
		/// The name of the first socket / bone
		/// </param>
		/// <param name="SocketSpaceA">
		/// The space for the first socket / bone
		/// </param>
		/// <param name="SocketOrBoneNameB">
		/// The name of the second socket / bone
		/// </param>
		/// <param name="SocketSpaceB">
		/// The space for the second socket / bone
		/// </param>
		/// <param name="bRemapRange">
		/// If set to true, the distance will be remapped using the range parameters
		/// </param>
		/// <param name="InRangeMin">
		/// The minimum for the input range (commonly == 0.0)
		/// </param>
		/// <param name="InRangeMax">
		/// The maximum for the input range (the max expected distance)
		/// </param>
		/// <param name="OutRangeMin">
		/// The minimum for the output range (commonly == 0.0)
		/// </param>
		/// <param name="OutRangeMax">
		/// The maximum for the output range (commonly == 1.0)
		/// </param>
		public static float K2_DistanceBetweenTwoSocketsAndMapRange(USkeletalMeshComponent Component, FName SocketOrBoneNameA, ERelativeTransformSpace SocketSpaceA, FName SocketOrBoneNameB, ERelativeTransformSpace SocketSpaceB, bool bRemapRange, float InRangeMin, float InRangeMax, float OutRangeMin, float OutRangeMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[43];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketOrBoneNameA?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 16) = (byte)SocketSpaceA;

				*(nint*)(__InBuffer + 17) = SocketOrBoneNameB?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 25) = (byte)SocketSpaceB;

				*(bool*)(__InBuffer + 26) = bRemapRange;

				*(float*)(__InBuffer + 27) = InRangeMin;

				*(float*)(__InBuffer + 31) = InRangeMax;

				*(float*)(__InBuffer + 35) = OutRangeMin;

				*(float*)(__InBuffer + 39) = OutRangeMax;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_DistanceBetweenTwoSocketsAndMapRange, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Component">
		/// The skeletal component to look for the sockets / bones within
		/// </param>
		/// <param name="SocketOrBoneNameFrom">
		/// The name of the first socket / bone
		/// </param>
		/// <param name="SocketOrBoneNameTo">
		/// The name of the second socket / bone
		/// </param>
		public static FVector K2_DirectionBetweenSockets(USkeletalMeshComponent Component, FName SocketOrBoneNameFrom, FName SocketOrBoneNameTo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SocketOrBoneNameFrom?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = SocketOrBoneNameTo?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __K2_DirectionBetweenSockets, __InBuffer, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="DeltaSeconds">
		/// The time passed in seconds
		/// </param>
		/// <param name="Component">
		/// The skeletal component to look for the bones / sockets
		/// </param>
		/// <param name="SocketOrBoneName">
		/// The name of the bone / socket to track.
		/// </param>
		/// <param name="ReferenceSocketOrBone">
		/// The name of the bone / socket to use as a frame of reference (or None if no frame of reference == world space).
		/// </param>
		/// <param name="SocketSpace">
		/// The space to use for the two sockets / bones
		/// </param>
		/// <param name="OffsetInBoneSpace">
		/// The relative position in the space of the bone / socket to track over time.
		/// </param>
		/// <param name="History">
		/// The history to use for storage.
		/// </param>
		/// <param name="NumberOfSamples">
		/// The number of samples to use for the history. The higher the number of samples - the smoother the velocity changes.
		/// </param>
		/// <param name="VelocityMin">
		/// The minimum velocity to use for normalization (if both min and max are set to 0, normalization is turned off)
		/// </param>
		/// <param name="VelocityMax">
		/// The maximum velocity to use for normalization (if both min and max are set to 0, normalization is turned off)
		/// </param>
		/// <param name="EasingType">
		/// The easing function to use
		/// </param>
		/// <param name="CustomCurve">
		/// The curve to use if the easing type is "Custom"
		/// </param>
		public static float K2_CalculateVelocityFromSockets(float DeltaSeconds, USkeletalMeshComponent Component, FName SocketOrBoneName, FName ReferenceSocketOrBone, ERelativeTransformSpace SocketSpace, FVector OffsetInBoneSpace, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax, EEasingFuncType EasingType, FRuntimeFloatCurve CustomCurve)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[66];

				*(float*)(__InBuffer) = DeltaSeconds;

				*(nint*)(__InBuffer + 4) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = SocketOrBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = ReferenceSocketOrBone?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 28) = (byte)SocketSpace;

				*(nint*)(__InBuffer + 29) = OffsetInBoneSpace?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 37) = History?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 45) = NumberOfSamples;

				*(float*)(__InBuffer + 49) = VelocityMin;

				*(float*)(__InBuffer + 53) = VelocityMax;

				*(byte*)(__InBuffer + 57) = (byte)EasingType;

				*(nint*)(__InBuffer + 58) = CustomCurve?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_CalculateVelocityFromSockets, __InBuffer, __OutBuffer, __ReturnBuffer);

				History = *(FPositionHistory*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="DeltaSeconds">
		/// The time passed in seconds
		/// </param>
		/// <param name="Position">
		/// The position to track over time.
		/// </param>
		/// <param name="History">
		/// The history to use for storage.
		/// </param>
		/// <param name="NumberOfSamples">
		/// The number of samples to use for the history. The higher the number of samples - the smoother the velocity changes.
		/// </param>
		/// <param name="VelocityMin">
		/// The minimum velocity to use for normalization (if both min and max are set to 0, normalization is turned off)
		/// </param>
		/// <param name="VelocityMax">
		/// The maximum velocity to use for normalization (if both min and max are set to 0, normalization is turned off)
		/// </param>
		public static float K2_CalculateVelocityFromPositionHistory(float DeltaSeconds, FVector Position, ref FPositionHistory History, int NumberOfSamples, float VelocityMin, float VelocityMax)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(float*)(__InBuffer) = DeltaSeconds;

				*(nint*)(__InBuffer + 4) = Position?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = History?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 20) = NumberOfSamples;

				*(float*)(__InBuffer + 24) = VelocityMin;

				*(float*)(__InBuffer + 28) = VelocityMax;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __K2_CalculateVelocityFromPositionHistory, __InBuffer, __OutBuffer, __ReturnBuffer);

				History = *(FPositionHistory*)(__OutBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		/// <param name="Velocity">
		/// The velocity to use as direction relative to BaseRotation
		/// </param>
		/// <param name="BaseRotation">
		/// The base rotation, e.g. of a pawn
		/// </param>
		public static float CalculateDirection(FVector Velocity, FRotator BaseRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Velocity?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BaseRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __CalculateDirection, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __K2_TwoBoneIK = 0;

		private static uint __K2_StartProfilingTimer = 0;

		private static uint __K2_MakePerlinNoiseVectorAndRemap = 0;

		private static uint __K2_MakePerlinNoiseAndRemap = 0;

		private static uint __K2_LookAt = 0;

		private static uint __K2_EndProfilingTimer = 0;

		private static uint __K2_DistanceBetweenTwoSocketsAndMapRange = 0;

		private static uint __K2_DirectionBetweenSockets = 0;

		private static uint __K2_CalculateVelocityFromSockets = 0;

		private static uint __K2_CalculateVelocityFromPositionHistory = 0;

		private static uint __CalculateDirection = 0;
	}
}
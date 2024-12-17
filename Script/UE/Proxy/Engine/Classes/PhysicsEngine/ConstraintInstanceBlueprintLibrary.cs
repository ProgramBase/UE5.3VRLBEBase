using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.ConstraintInstanceBlueprintLibrary")]
	public partial class UConstraintInstanceBlueprintLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ConstraintInstanceBlueprintLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableProjection">
		/// true to enable projection
		/// </param>
		/// <param name="ProjectionLinearAlpha">
		/// how much linear projection to apply in [0,1] range
		/// </param>
		/// <param name="ProjectionAngularAlpha">
		/// how much angular projection to apply in [0,1] range
		/// </param>
		public static void SetProjectionParams(ref FConstraintInstanceAccessor Accessor, bool bEnableProjection, float ProjectionLinearAlpha, float ProjectionAngularAlpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableProjection;

				*(float*)(__InBuffer + 9) = ProjectionLinearAlpha;

				*(float*)(__InBuffer + 13) = ProjectionAngularAlpha;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetProjectionParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bParentDominates">
		/// true to avoid the parent being affected by its child motion
		/// </param>
		public static void SetParentDominates(ref FConstraintInstanceAccessor Accessor, bool bParentDominates)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bParentDominates;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetParentDominates, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public static void SetOrientationDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 9) = bEnableSwingDrive;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetOrientationDriveTwistAndSwing, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableSLERP">
		/// Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public static void SetOrientationDriveSLERP(ref FConstraintInstanceAccessor Accessor, bool bEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableSLERP;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetOrientationDriveSLERP, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <summary>
		/// Enable or disable mass conditioning for the constraint.
		/// </summary>
		public static void SetMassConditioningEnabled(ref FConstraintInstanceAccessor Accessor, bool bEnableMassConditioning)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableMassConditioning;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetMassConditioningEnabled, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="InVelTarget">
		/// Target velocity
		/// </param>
		public static void SetLinearVelocityTarget(ref FConstraintInstanceAccessor Accessor, FVector InVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearVelocityTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableDriveX">
		/// Indicates whether the drive for the X-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveY">
		/// Indicates whether the drive for the Y-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis should be enabled
		/// </param>
		public static void SetLinearVelocityDrive(ref FConstraintInstanceAccessor Accessor, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableDriveX;

				*(bool*)(__InBuffer + 9) = bEnableDriveY;

				*(bool*)(__InBuffer + 10) = bEnableDriveZ;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearVelocityDrive, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bSoftLinearLimit">
		/// True is the linear limit is soft
		/// </param>
		/// <param name="LinearLimitStiffness">
		/// Stiffness of the soft linear limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="LinearLimitDamping">
		/// Damping of the soft linear limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="LinearLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="LinearLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void SetLinearSoftLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftLinearLimit, float LinearLimitStiffness, float LinearLimitDamping, float LinearLimitRestitution, float LinearLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftLinearLimit;

				*(float*)(__InBuffer + 9) = LinearLimitStiffness;

				*(float*)(__InBuffer + 13) = LinearLimitDamping;

				*(float*)(__InBuffer + 17) = LinearLimitRestitution;

				*(float*)(__InBuffer + 21) = LinearLimitContactDistance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearSoftLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="InPosTarget">
		/// Target position
		/// </param>
		public static void SetLinearPositionTarget(ref FConstraintInstanceAccessor Accessor, FVector InPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearPositionTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableDriveX">
		/// Indicates whether the drive for the X-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveY">
		/// Indicates whether the drive for the Y-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis should be enabled
		/// </param>
		public static void SetLinearPositionDrive(ref FConstraintInstanceAccessor Accessor, bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableDriveX;

				*(bool*)(__InBuffer + 9) = bEnableDriveY;

				*(bool*)(__InBuffer + 10) = bEnableDriveZ;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearPositionDrive, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bLinearPlasticity">
		/// Whether it is possible to reset the target position from the linear displacement
		/// </param>
		/// <param name="LinearPlasticityThreshold">
		/// Delta from target needed to reset the target joint
		/// </param>
		public static void SetLinearPlasticity(ref FConstraintInstanceAccessor Accessor, bool bLinearPlasticity, float LinearPlasticityThreshold, EConstraintPlasticityType PlasticityType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLinearPlasticity;

				*(float*)(__InBuffer + 9) = LinearPlasticityThreshold;

				*(byte*)(__InBuffer + 13) = (byte)PlasticityType;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearPlasticity, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="XMotion">
		/// Type of motion along the X axis
		/// </param>
		/// <param name="YMotion">
		/// Type of motion along the Y axis
		/// </param>
		/// <param name="ZMotion">
		/// Type of motion along the Z axis
		/// </param>
		/// <param name="Limit">
		/// linear limit to apply to all axis
		/// </param>
		public static void SetLinearLimits(ref FConstraintInstanceAccessor Accessor, ELinearConstraintMotion XMotion, ELinearConstraintMotion YMotion, ELinearConstraintMotion ZMotion, float Limit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)XMotion;

				*(byte*)(__InBuffer + 9) = (byte)YMotion;

				*(byte*)(__InBuffer + 10) = (byte)ZMotion;

				*(float*)(__InBuffer + 11) = Limit;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearLimits, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="PositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="VelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="InForceLimit">
		/// Max force applied by the drive
		/// </param>
		public static void SetLinearDriveParams(ref FConstraintInstanceAccessor Accessor, float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PositionStrength;

				*(float*)(__InBuffer + 12) = VelocityStrength;

				*(float*)(__InBuffer + 16) = InForceLimit;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearDriveParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bLinearBreakable">
		/// Whether it is possible to break the joint with linear force
		/// </param>
		/// <param name="LinearBreakThreshold">
		/// Force needed to break the joint
		/// </param>
		public static void SetLinearBreakable(ref FConstraintInstanceAccessor Accessor, bool bLinearBreakable, float LinearBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLinearBreakable;

				*(float*)(__InBuffer + 9) = LinearBreakThreshold;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetLinearBreakable, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bDisableCollision">
		/// true to disable collision between constrained bodies
		/// </param>
		public static void SetDisableCollision(ref FConstraintInstanceAccessor Accessor, bool bDisableCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bDisableCollision;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetDisableCollision, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="ContactTransferScale">
		/// Set Contact Transfer Scale onto joints parent
		/// </param>
		public static void SetContactTransferScale(ref FConstraintInstanceAccessor Accessor, float ContactTransferScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ContactTransferScale;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetContactTransferScale, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="InVelTarget">
		/// Target velocity
		/// </param>
		public static void SetAngularVelocityTarget(ref FConstraintInstanceAccessor Accessor, FVector InVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularVelocityTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public static void SetAngularVelocityDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 9) = bEnableSwingDrive;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularVelocityDriveTwistAndSwing, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bEnableSLERP">
		/// Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public static void SetAngularVelocityDriveSLERP(ref FConstraintInstanceAccessor Accessor, bool bEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableSLERP;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularVelocityDriveSLERP, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bSoftTwistLimit">
		/// True is the twist limit is soft
		/// </param>
		/// <param name="TwistLimitStiffness">
		/// Stiffness of the soft Twist limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="TwistLimitDamping">
		/// Damping of the soft Twist limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="TwistLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="TwistLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void SetAngularSoftTwistLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftTwistLimit, float TwistLimitStiffness, float TwistLimitDamping, float TwistLimitRestitution, float TwistLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftTwistLimit;

				*(float*)(__InBuffer + 9) = TwistLimitStiffness;

				*(float*)(__InBuffer + 13) = TwistLimitDamping;

				*(float*)(__InBuffer + 17) = TwistLimitRestitution;

				*(float*)(__InBuffer + 21) = TwistLimitContactDistance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularSoftTwistLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bSoftSwingLimit">
		/// True is the swing limit is soft
		/// </param>
		/// <param name="SwingLimitStiffness">
		/// Stiffness of the soft swing limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="SwingLimitDamping">
		/// Damping of the soft swing limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="SwingLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="SwingLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void SetAngularSoftSwingLimitParams(ref FConstraintInstanceAccessor Accessor, bool bSoftSwingLimit, float SwingLimitStiffness, float SwingLimitDamping, float SwingLimitRestitution, float SwingLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftSwingLimit;

				*(float*)(__InBuffer + 9) = SwingLimitStiffness;

				*(float*)(__InBuffer + 13) = SwingLimitDamping;

				*(float*)(__InBuffer + 17) = SwingLimitRestitution;

				*(float*)(__InBuffer + 21) = SwingLimitContactDistance;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularSoftSwingLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bAngularPlasticity">
		/// Whether it is possible to reset the target angle from the angular displacement
		/// </param>
		/// <param name="AngularPlasticityThreshold">
		/// Degrees needed to reset the rest state of the joint
		/// </param>
		public static void SetAngularPlasticity(ref FConstraintInstanceAccessor Accessor, bool bAngularPlasticity, float AngularPlasticityThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAngularPlasticity;

				*(float*)(__InBuffer + 9) = AngularPlasticityThreshold;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularPlasticity, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="InPosTarget">
		/// Target orientation
		/// </param>
		public static void SetAngularOrientationTarget(ref FConstraintInstanceAccessor Accessor, FRotator InPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularOrientationTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="Swing1MotionType">
		/// Type of swing motion ( first axis )
		/// </param>
		/// <param name="Swing1LimitAngle">
		/// Size of limit in degrees in [0, 180] range
		/// </param>
		/// <param name="Swing2MotionType">
		/// Type of swing motion ( second axis )
		/// </param>
		/// <param name="Swing2LimitAngle">
		/// Size of limit in degrees in [0, 180] range
		/// </param>
		/// <param name="TwistMotionType">
		/// Type of twist motion
		/// </param>
		/// <param name="TwistLimitAngle">
		/// Size of limit in degrees in [0, 180] range	
		/// </param>
		public static void SetAngularLimits(ref FConstraintInstanceAccessor Accessor, EAngularConstraintMotion Swing1MotionType, float Swing1LimitAngle, EAngularConstraintMotion Swing2MotionType, float Swing2LimitAngle, EAngularConstraintMotion TwistMotionType, float TwistLimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[23];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Swing1MotionType;

				*(float*)(__InBuffer + 9) = Swing1LimitAngle;

				*(byte*)(__InBuffer + 13) = (byte)Swing2MotionType;

				*(float*)(__InBuffer + 14) = Swing2LimitAngle;

				*(byte*)(__InBuffer + 18) = (byte)TwistMotionType;

				*(float*)(__InBuffer + 19) = TwistLimitAngle;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularLimits, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="PositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="VelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="InForceLimit">
		/// Max force applied by the drive
		/// </param>
		public static void SetAngularDriveParams(ref FConstraintInstanceAccessor Accessor, float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = PositionStrength;

				*(float*)(__InBuffer + 12) = VelocityStrength;

				*(float*)(__InBuffer + 16) = InForceLimit;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularDriveParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="DriveMode">
		/// The angular drive mode to use. SLERP uses shortest spherical path, but will not work if any angular constraints are locked. Twist and Swing decomposes the path into the different angular degrees of freedom but may experience gimbal lock
		/// </param>
		public static void SetAngularDriveMode(ref FConstraintInstanceAccessor Accessor, EAngularDriveMode DriveMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)DriveMode;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularDriveMode, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to change
		/// </param>
		/// <param name="bAngularBreakable">
		/// Whether it is possible to break the joint with angular force
		/// </param>
		/// <param name="AngularBreakThreshold">
		/// Torque needed to break the joint
		/// </param>
		public static void SetAngularBreakable(ref FConstraintInstanceAccessor Accessor, bool bAngularBreakable, float AngularBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAngularBreakable;

				*(float*)(__InBuffer + 9) = AngularBreakThreshold;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __SetAngularBreakable, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bEnableProjection">
		/// true to enable projection
		/// </param>
		/// <param name="ProjectionLinearAlpha">
		/// how much linear projection to apply in [0,1] range
		/// </param>
		/// <param name="ProjectionAngularAlpha">
		/// how much angular projection to apply in [0,1] range
		/// </param>
		public static void GetProjectionParams(ref FConstraintInstanceAccessor Accessor, ref bool bEnableProjection, ref float ProjectionLinearAlpha, ref float ProjectionAngularAlpha)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bEnableProjection;

				*(float*)(__InBuffer + 9) = ProjectionLinearAlpha;

				*(float*)(__InBuffer + 13) = ProjectionAngularAlpha;

				var __OutBuffer = stackalloc byte[17];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetProjectionParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bEnableProjection = *(bool*)(__OutBuffer + 8);

				ProjectionLinearAlpha = *(float*)(__OutBuffer + 9);

				ProjectionAngularAlpha = *(float*)(__OutBuffer + 13);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		public static bool GetParentDominates(ref FConstraintInstanceAccessor Accessor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetParentDominates, __InBuffer, __OutBuffer, __ReturnBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableTwistDrive">
		/// Indicates whether the drive for the twist axis is enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bOutEnableSwingDrive">
		/// Indicates whether the drive for the swing axis is enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public static void GetOrientationDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableTwistDrive, ref bool bOutEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableTwistDrive;

				*(bool*)(__InBuffer + 9) = bOutEnableSwingDrive;

				var __OutBuffer = stackalloc byte[10];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetOrientationDriveTwistAndSwing, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableTwistDrive = *(bool*)(__OutBuffer + 8);

				bOutEnableSwingDrive = *(bool*)(__OutBuffer + 9);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableSLERP">
		/// Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public static void GetOrientationDriveSLERP(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableSLERP;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetOrientationDriveSLERP, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableSLERP = *(bool*)(__OutBuffer + 8);

			}
		}

		/// <summary>
		/// Gets whether mass conditioning is enabled for the constraint.
		/// </summary>
		public static bool GetMassConditioningEnabled(ref FConstraintInstanceAccessor Accessor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetMassConditioningEnabled, __InBuffer, __OutBuffer, __ReturnBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutVelTarget">
		/// Target velocity
		/// </param>
		public static void GetLinearVelocityTarget(ref FConstraintInstanceAccessor Accessor, ref FVector OutVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearVelocityTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutVelTarget = *(FVector*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableDriveX">
		/// Indicates whether the drive for the X-Axis is enabled
		/// </param>
		/// <param name="bOutEnableDriveY">
		/// Indicates whether the drive for the Y-Axis is enabled
		/// </param>
		/// <param name="bOutEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis is enabled
		/// </param>
		public static void GetLinearVelocityDrive(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableDriveX, ref bool bOutEnableDriveY, ref bool bOutEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableDriveX;

				*(bool*)(__InBuffer + 9) = bOutEnableDriveY;

				*(bool*)(__InBuffer + 10) = bOutEnableDriveZ;

				var __OutBuffer = stackalloc byte[11];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearVelocityDrive, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableDriveX = *(bool*)(__OutBuffer + 8);

				bOutEnableDriveY = *(bool*)(__OutBuffer + 9);

				bOutEnableDriveZ = *(bool*)(__OutBuffer + 10);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bSoftLinearLimit">
		/// True is the Linear limit is soft
		/// </param>
		/// <param name="LinearLimitStiffness">
		/// Stiffness of the soft Linear limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="LinearLimitDamping">
		/// Damping of the soft Linear limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="LinearLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="LinearLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void GetLinearSoftLimitParams(ref FConstraintInstanceAccessor Accessor, ref bool bSoftLinearLimit, ref float LinearLimitStiffness, ref float LinearLimitDamping, ref float LinearLimitRestitution, ref float LinearLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftLinearLimit;

				*(float*)(__InBuffer + 9) = LinearLimitStiffness;

				*(float*)(__InBuffer + 13) = LinearLimitDamping;

				*(float*)(__InBuffer + 17) = LinearLimitRestitution;

				*(float*)(__InBuffer + 21) = LinearLimitContactDistance;

				var __OutBuffer = stackalloc byte[25];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearSoftLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bSoftLinearLimit = *(bool*)(__OutBuffer + 8);

				LinearLimitStiffness = *(float*)(__OutBuffer + 9);

				LinearLimitDamping = *(float*)(__OutBuffer + 13);

				LinearLimitRestitution = *(float*)(__OutBuffer + 17);

				LinearLimitContactDistance = *(float*)(__OutBuffer + 21);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutPosTarget">
		/// Target position
		/// </param>
		public static void GetLinearPositionTarget(ref FConstraintInstanceAccessor Accessor, ref FVector OutPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearPositionTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutPosTarget = *(FVector*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableDriveX">
		/// Indicates whether the drive for the X-Axis is enabled
		/// </param>
		/// <param name="bOutEnableDriveY">
		/// Indicates whether the drive for the Y-Axis is enabled
		/// </param>
		/// <param name="bOutEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis is enabled
		/// </param>
		public static void GetLinearPositionDrive(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableDriveX, ref bool bOutEnableDriveY, ref bool bOutEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[11];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableDriveX;

				*(bool*)(__InBuffer + 9) = bOutEnableDriveY;

				*(bool*)(__InBuffer + 10) = bOutEnableDriveZ;

				var __OutBuffer = stackalloc byte[11];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearPositionDrive, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableDriveX = *(bool*)(__OutBuffer + 8);

				bOutEnableDriveY = *(bool*)(__OutBuffer + 9);

				bOutEnableDriveZ = *(bool*)(__OutBuffer + 10);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bAngularPlasticity">
		/// Whether it is possible to reset the target position from the linear displacement
		/// </param>
		/// <param name="AngularPlasticityThreshold">
		/// Delta from target needed to reset the target joint
		/// </param>
		public static void GetLinearPlasticity(ref FConstraintInstanceAccessor Accessor, ref bool bLinearPlasticity, ref float LinearPlasticityThreshold, ref EConstraintPlasticityType PlasticityType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[14];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLinearPlasticity;

				*(float*)(__InBuffer + 9) = LinearPlasticityThreshold;

				*(byte*)(__InBuffer + 13) = (byte)PlasticityType;

				var __OutBuffer = stackalloc byte[14];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearPlasticity, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bLinearPlasticity = *(bool*)(__OutBuffer + 8);

				LinearPlasticityThreshold = *(float*)(__OutBuffer + 9);

				PlasticityType = *(EConstraintPlasticityType*)(__OutBuffer + 13);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="XMotion">
		/// Type of motion along the X axis
		/// </param>
		/// <param name="YMotion">
		/// Type of motion along the Y axis
		/// </param>
		/// <param name="ZMotion">
		/// Type of motion along the Z axis
		/// </param>
		/// <param name="Limit">
		/// linear limit applied to all axis
		/// </param>
		public static void GetLinearLimits(ref FConstraintInstanceAccessor Accessor, ref ELinearConstraintMotion XMotion, ref ELinearConstraintMotion YMotion, ref ELinearConstraintMotion ZMotion, ref float Limit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[15];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)XMotion;

				*(byte*)(__InBuffer + 9) = (byte)YMotion;

				*(byte*)(__InBuffer + 10) = (byte)ZMotion;

				*(float*)(__InBuffer + 11) = Limit;

				var __OutBuffer = stackalloc byte[15];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearLimits, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				XMotion = *(ELinearConstraintMotion*)(__OutBuffer + 8);

				YMotion = *(ELinearConstraintMotion*)(__OutBuffer + 9);

				ZMotion = *(ELinearConstraintMotion*)(__OutBuffer + 10);

				Limit = *(float*)(__OutBuffer + 11);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutPositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="OutVelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="OutForceLimit">
		/// Max force applied by the drive
		/// </param>
		public static void GetLinearDriveParams(ref FConstraintInstanceAccessor Accessor, ref float OutPositionStrength, ref float OutVelocityStrength, ref float OutForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = OutPositionStrength;

				*(float*)(__InBuffer + 12) = OutVelocityStrength;

				*(float*)(__InBuffer + 16) = OutForceLimit;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearDriveParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutPositionStrength = *(float*)(__OutBuffer + 8);

				OutVelocityStrength = *(float*)(__OutBuffer + 12);

				OutForceLimit = *(float*)(__OutBuffer + 16);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bLinearBreakable">
		/// Whether it is possible to break the joint with linear force
		/// </param>
		/// <param name="LinearBreakThreshold">
		/// Force needed to break the joint
		/// </param>
		public static void GetLinearBreakable(ref FConstraintInstanceAccessor Accessor, ref bool bLinearBreakable, ref float LinearBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLinearBreakable;

				*(float*)(__InBuffer + 9) = LinearBreakThreshold;

				var __OutBuffer = stackalloc byte[13];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLinearBreakable, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bLinearBreakable = *(bool*)(__OutBuffer + 8);

				LinearBreakThreshold = *(float*)(__OutBuffer + 9);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		public static bool GetDisableCollsion(ref FConstraintInstanceAccessor Accessor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall15Implementation(StaticClass().GarbageCollectionHandle, __GetDisableCollsion, __InBuffer, __OutBuffer, __ReturnBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="ContactTransferScale">
		/// Scale for transfer of child energy to parent.
		/// </param>
		public static void GetContactTransferScale(ref FConstraintInstanceAccessor Accessor, ref float ContactTransferScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = ContactTransferScale;

				var __OutBuffer = stackalloc byte[12];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetContactTransferScale, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				ContactTransferScale = *(float*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="ParentBody">
		/// Parent body name of the constraint
		/// </param>
		/// <param name="ChildBody">
		/// Child body name of the constraint
		/// </param>
		public static void GetAttachedBodyNames(ref FConstraintInstanceAccessor Accessor, ref FName ParentBody, ref FName ChildBody)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ParentBody?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = ChildBody?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[24];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAttachedBodyNames, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				ParentBody = *(FName*)(__OutBuffer + 8);

				ChildBody = *(FName*)(__OutBuffer + 16);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutVelTarget">
		/// Target velocity
		/// </param>
		public static void GetAngularVelocityTarget(ref FConstraintInstanceAccessor Accessor, ref FVector OutVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularVelocityTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutVelTarget = *(FVector*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bOutEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public static void GetAngularVelocityDriveTwistAndSwing(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableTwistDrive, ref bool bOutEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableTwistDrive;

				*(bool*)(__InBuffer + 9) = bOutEnableSwingDrive;

				var __OutBuffer = stackalloc byte[10];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularVelocityDriveTwistAndSwing, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableTwistDrive = *(bool*)(__OutBuffer + 8);

				bOutEnableSwingDrive = *(bool*)(__OutBuffer + 9);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bOutEnableSLERP">
		/// Indicates whether the SLERP drive is enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public static void GetAngularVelocityDriveSLERP(ref FConstraintInstanceAccessor Accessor, ref bool bOutEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bOutEnableSLERP;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularVelocityDriveSLERP, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bOutEnableSLERP = *(bool*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bSoftTwistLimit">
		/// True is the Twist limit is soft
		/// </param>
		/// <param name="TwistLimitStiffness">
		/// Stiffness of the soft Twist limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="TwistLimitDamping">
		/// Damping of the soft Twist limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="TwistLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="TwistLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void GetAngularSoftTwistLimitParams(ref FConstraintInstanceAccessor Accessor, ref bool bSoftTwistLimit, ref float TwistLimitStiffness, ref float TwistLimitDamping, ref float TwistLimitRestitution, ref float TwistLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftTwistLimit;

				*(float*)(__InBuffer + 9) = TwistLimitStiffness;

				*(float*)(__InBuffer + 13) = TwistLimitDamping;

				*(float*)(__InBuffer + 17) = TwistLimitRestitution;

				*(float*)(__InBuffer + 21) = TwistLimitContactDistance;

				var __OutBuffer = stackalloc byte[25];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularSoftTwistLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bSoftTwistLimit = *(bool*)(__OutBuffer + 8);

				TwistLimitStiffness = *(float*)(__OutBuffer + 9);

				TwistLimitDamping = *(float*)(__OutBuffer + 13);

				TwistLimitRestitution = *(float*)(__OutBuffer + 17);

				TwistLimitContactDistance = *(float*)(__OutBuffer + 21);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bSoftSwingLimit">
		/// True is the swing limit is soft
		/// </param>
		/// <param name="SwingLimitStiffness">
		/// Stiffness of the soft swing limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="SwingLimitDamping">
		/// Damping of the soft swing limit. Only used when Soft limit is on ( positive value )
		/// </param>
		/// <param name="SwingLimitRestitution">
		/// Controls the amount of bounce when the constraint is violated. A restitution value of 1 will bounce back with the same velocity the limit was hit. A value of 0 will stop dead.
		/// </param>
		/// <param name="SwingLimitContactDistance">
		/// Determines how close to the limit we have to get before turning the joint on. Larger value will be more expensive, but will do a better job not violating constraints. A smaller value will be more efficient, but easier to violate.
		/// </param>
		public static void GetAngularSoftSwingLimitParams(ref FConstraintInstanceAccessor Accessor, ref bool bSoftSwingLimit, ref float SwingLimitStiffness, ref float SwingLimitDamping, ref float SwingLimitRestitution, ref float SwingLimitContactDistance)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bSoftSwingLimit;

				*(float*)(__InBuffer + 9) = SwingLimitStiffness;

				*(float*)(__InBuffer + 13) = SwingLimitDamping;

				*(float*)(__InBuffer + 17) = SwingLimitRestitution;

				*(float*)(__InBuffer + 21) = SwingLimitContactDistance;

				var __OutBuffer = stackalloc byte[25];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularSoftSwingLimitParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bSoftSwingLimit = *(bool*)(__OutBuffer + 8);

				SwingLimitStiffness = *(float*)(__OutBuffer + 9);

				SwingLimitDamping = *(float*)(__OutBuffer + 13);

				SwingLimitRestitution = *(float*)(__OutBuffer + 17);

				SwingLimitContactDistance = *(float*)(__OutBuffer + 21);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bAngularPlasticity">
		/// Whether it is possible to reset the target angle from the angular displacement
		/// </param>
		/// <param name="AngularPlasticityThreshold">
		/// Degrees needed to reset the rest state of the joint
		/// </param>
		public static void GetAngularPlasticity(ref FConstraintInstanceAccessor Accessor, ref bool bAngularPlasticity, ref float AngularPlasticityThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAngularPlasticity;

				*(float*)(__InBuffer + 9) = AngularPlasticityThreshold;

				var __OutBuffer = stackalloc byte[13];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularPlasticity, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bAngularPlasticity = *(bool*)(__OutBuffer + 8);

				AngularPlasticityThreshold = *(float*)(__OutBuffer + 9);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutPosTarget">
		/// Target orientation
		/// </param>
		public static void GetAngularOrientationTarget(ref FConstraintInstanceAccessor Accessor, ref FRotator OutPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularOrientationTarget, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutPosTarget = *(FRotator*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="Swing1MotionType">
		/// Type of swing motion ( first axis )
		/// </param>
		/// <param name="Swing1LimitAngle">
		/// Size of limit in degrees in [0, 180] range
		/// </param>
		/// <param name="Swing2MotionType">
		/// Type of swing motion ( second axis )
		/// </param>
		/// <param name="Swing2LimitAngle">
		/// Size of limit in degrees in [0, 180] range
		/// </param>
		/// <param name="TwistMotionType">
		/// Type of twist motion
		/// </param>
		/// <param name="TwistLimitAngle">
		/// Size of limit in degrees in [0, 180] range
		/// </param>
		public static void GetAngularLimits(ref FConstraintInstanceAccessor Accessor, ref EAngularConstraintMotion Swing1MotionType, ref float Swing1LimitAngle, ref EAngularConstraintMotion Swing2MotionType, ref float Swing2LimitAngle, ref EAngularConstraintMotion TwistMotionType, ref float TwistLimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[23];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)Swing1MotionType;

				*(float*)(__InBuffer + 9) = Swing1LimitAngle;

				*(byte*)(__InBuffer + 13) = (byte)Swing2MotionType;

				*(float*)(__InBuffer + 14) = Swing2LimitAngle;

				*(byte*)(__InBuffer + 18) = (byte)TwistMotionType;

				*(float*)(__InBuffer + 19) = TwistLimitAngle;

				var __OutBuffer = stackalloc byte[23];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularLimits, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				Swing1MotionType = *(EAngularConstraintMotion*)(__OutBuffer + 8);

				Swing1LimitAngle = *(float*)(__OutBuffer + 9);

				Swing2MotionType = *(EAngularConstraintMotion*)(__OutBuffer + 13);

				Swing2LimitAngle = *(float*)(__OutBuffer + 14);

				TwistMotionType = *(EAngularConstraintMotion*)(__OutBuffer + 18);

				TwistLimitAngle = *(float*)(__OutBuffer + 19);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutPositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="OutVelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="OutForceLimit">
		/// Max force applied by the drive
		/// </param>
		public static void GetAngularDriveParams(ref FConstraintInstanceAccessor Accessor, ref float OutPositionStrength, ref float OutVelocityStrength, ref float OutForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[20];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = OutPositionStrength;

				*(float*)(__InBuffer + 12) = OutVelocityStrength;

				*(float*)(__InBuffer + 16) = OutForceLimit;

				var __OutBuffer = stackalloc byte[20];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularDriveParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutPositionStrength = *(float*)(__OutBuffer + 8);

				OutVelocityStrength = *(float*)(__OutBuffer + 12);

				OutForceLimit = *(float*)(__OutBuffer + 16);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="OutDriveMode">
		/// The angular drive mode to use. SLERP uses shortest spherical path, but will not work if any angular constraints are locked. Twist and Swing decomposes the path into the different angular degrees of freedom but may experience gimbal lock
		/// </param>
		public static void GetAngularDriveMode(ref FConstraintInstanceAccessor Accessor, ref EAngularDriveMode OutDriveMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)OutDriveMode;

				var __OutBuffer = stackalloc byte[9];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularDriveMode, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				OutDriveMode = *(EAngularDriveMode*)(__OutBuffer + 8);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to query
		/// </param>
		/// <param name="bAngularBreakable">
		/// Whether it is possible to break the joint with angular force
		/// </param>
		/// <param name="AngularBreakThreshold">
		/// Torque needed to break the joint
		/// </param>
		public static void GetAngularBreakable(ref FConstraintInstanceAccessor Accessor, ref bool bAngularBreakable, ref float AngularBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bAngularBreakable;

				*(float*)(__InBuffer + 9) = AngularBreakThreshold;

				var __OutBuffer = stackalloc byte[13];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetAngularBreakable, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				bAngularBreakable = *(bool*)(__OutBuffer + 8);

				AngularBreakThreshold = *(float*)(__OutBuffer + 9);

			}
		}

		/// <param name="Accessor">
		/// Constraint accessor to write to
		/// </param>
		/// <param name="SourceAccessor">
		/// Constraint accessor to read from
		/// </param>
		/// <param name="bKeepPosition">
		/// Whether to keep original constraint positions
		/// </param>
		/// <param name="bKeepRotation">
		/// Whether to keep original constraint rotations
		/// </param>
		public static void CopyParams(ref FConstraintInstanceAccessor Accessor, ref FConstraintInstanceAccessor SourceAccessor, bool bKeepPosition = true, bool bKeepRotation = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[18];

				*(nint*)(__InBuffer) = Accessor?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SourceAccessor?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bKeepPosition;

				*(bool*)(__InBuffer + 17) = bKeepRotation;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __CopyParams, __InBuffer, __OutBuffer);

				Accessor = *(FConstraintInstanceAccessor*)(__OutBuffer);

				SourceAccessor = *(FConstraintInstanceAccessor*)(__OutBuffer + 8);

			}
		}

		private static uint __SetProjectionParams = 0;

		private static uint __SetParentDominates = 0;

		private static uint __SetOrientationDriveTwistAndSwing = 0;

		private static uint __SetOrientationDriveSLERP = 0;

		private static uint __SetMassConditioningEnabled = 0;

		private static uint __SetLinearVelocityTarget = 0;

		private static uint __SetLinearVelocityDrive = 0;

		private static uint __SetLinearSoftLimitParams = 0;

		private static uint __SetLinearPositionTarget = 0;

		private static uint __SetLinearPositionDrive = 0;

		private static uint __SetLinearPlasticity = 0;

		private static uint __SetLinearLimits = 0;

		private static uint __SetLinearDriveParams = 0;

		private static uint __SetLinearBreakable = 0;

		private static uint __SetDisableCollision = 0;

		private static uint __SetContactTransferScale = 0;

		private static uint __SetAngularVelocityTarget = 0;

		private static uint __SetAngularVelocityDriveTwistAndSwing = 0;

		private static uint __SetAngularVelocityDriveSLERP = 0;

		private static uint __SetAngularSoftTwistLimitParams = 0;

		private static uint __SetAngularSoftSwingLimitParams = 0;

		private static uint __SetAngularPlasticity = 0;

		private static uint __SetAngularOrientationTarget = 0;

		private static uint __SetAngularLimits = 0;

		private static uint __SetAngularDriveParams = 0;

		private static uint __SetAngularDriveMode = 0;

		private static uint __SetAngularBreakable = 0;

		private static uint __GetProjectionParams = 0;

		private static uint __GetParentDominates = 0;

		private static uint __GetOrientationDriveTwistAndSwing = 0;

		private static uint __GetOrientationDriveSLERP = 0;

		private static uint __GetMassConditioningEnabled = 0;

		private static uint __GetLinearVelocityTarget = 0;

		private static uint __GetLinearVelocityDrive = 0;

		private static uint __GetLinearSoftLimitParams = 0;

		private static uint __GetLinearPositionTarget = 0;

		private static uint __GetLinearPositionDrive = 0;

		private static uint __GetLinearPlasticity = 0;

		private static uint __GetLinearLimits = 0;

		private static uint __GetLinearDriveParams = 0;

		private static uint __GetLinearBreakable = 0;

		private static uint __GetDisableCollsion = 0;

		private static uint __GetContactTransferScale = 0;

		private static uint __GetAttachedBodyNames = 0;

		private static uint __GetAngularVelocityTarget = 0;

		private static uint __GetAngularVelocityDriveTwistAndSwing = 0;

		private static uint __GetAngularVelocityDriveSLERP = 0;

		private static uint __GetAngularSoftTwistLimitParams = 0;

		private static uint __GetAngularSoftSwingLimitParams = 0;

		private static uint __GetAngularPlasticity = 0;

		private static uint __GetAngularOrientationTarget = 0;

		private static uint __GetAngularLimits = 0;

		private static uint __GetAngularDriveParams = 0;

		private static uint __GetAngularDriveMode = 0;

		private static uint __GetAngularBreakable = 0;

		private static uint __CopyParams = 0;
	}
}
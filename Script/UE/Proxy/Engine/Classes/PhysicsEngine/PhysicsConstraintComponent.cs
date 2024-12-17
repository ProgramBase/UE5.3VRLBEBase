using Script.CoreUObject;
using Script.Library;
using Script.PhysicsCore;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsConstraintComponent")]
	public partial class UPhysicsConstraintComponent : USceneComponent, IStaticClass
	{
		public AActor ConstraintActor1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintActor1, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintActor1, __InBuffer);
				}
			}
		}

		public FConstrainComponentPropName ComponentName1
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentName1, __ReturnBuffer);

					return *(FConstrainComponentPropName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentName1, __InBuffer);
				}
			}
		}

		public AActor ConstraintActor2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintActor2, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintActor2, __InBuffer);
				}
			}
		}

		public FConstrainComponentPropName ComponentName2
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentName2, __ReturnBuffer);

					return *(FConstrainComponentPropName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ComponentName2, __InBuffer);
				}
			}
		}

		public FConstraintBrokenSignature OnConstraintBroken
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintBroken, __ReturnBuffer);

					return *(FConstraintBrokenSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnConstraintBroken, __InBuffer);
				}
			}
		}

		public FPlasticDeformationEventSignature OnPlasticDeformation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlasticDeformation, __ReturnBuffer);

					return *(FPlasticDeformationEventSignature*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPlasticDeformation, __InBuffer);
				}
			}
		}

		public FConstraintInstance ConstraintInstance
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintInstance, __ReturnBuffer);

					return *(FConstraintInstance*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ConstraintInstance, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsConstraintComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="bEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public virtual void SetOrientationDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 1) = bEnableSwingDrive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrientationDriveTwistAndSwing, __InBuffer);
			}
		}

		/// <param name="bEnableSLERP">
		/// Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public virtual void SetOrientationDriveSLERP(bool bEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnableSLERP;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetOrientationDriveSLERP, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="LimitSize">
		/// Size of limit
		/// </param>
		public virtual void SetLinearZLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)ConstraintType;

				*(float*)(__InBuffer + 1) = LimitSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearZLimit, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="LimitSize">
		/// Size of limit
		/// </param>
		public virtual void SetLinearYLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)ConstraintType;

				*(float*)(__InBuffer + 1) = LimitSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearYLimit, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="LimitSize">
		/// Size of limit
		/// </param>
		public virtual void SetLinearXLimit(ELinearConstraintMotion ConstraintType, float LimitSize)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)ConstraintType;

				*(float*)(__InBuffer + 1) = LimitSize;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearXLimit, __InBuffer);
			}
		}

		/// <param name="InVelTarget">
		/// Target velocity
		/// </param>
		public virtual void SetLinearVelocityTarget(FVector InVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearVelocityTarget, __InBuffer);
			}
		}

		/// <param name="bEnableDriveX">
		/// Indicates whether the drive for the X-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveY">
		/// Indicates whether the drive for the Y-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis should be enabled
		/// </param>
		public virtual void SetLinearVelocityDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bEnableDriveX;

				*(bool*)(__InBuffer + 1) = bEnableDriveY;

				*(bool*)(__InBuffer + 2) = bEnableDriveZ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearVelocityDrive, __InBuffer);
			}
		}

		/// <param name="InPosTarget">
		/// Target position
		/// </param>
		public virtual void SetLinearPositionTarget(FVector InPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearPositionTarget, __InBuffer);
			}
		}

		/// <param name="bEnableDriveX">
		/// Indicates whether the drive for the X-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveY">
		/// Indicates whether the drive for the Y-Axis should be enabled
		/// </param>
		/// <param name="bEnableDriveZ">
		/// Indicates whether the drive for the Z-Axis should be enabled
		/// </param>
		public virtual void SetLinearPositionDrive(bool bEnableDriveX, bool bEnableDriveY, bool bEnableDriveZ)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[3];

				*(bool*)(__InBuffer) = bEnableDriveX;

				*(bool*)(__InBuffer + 1) = bEnableDriveY;

				*(bool*)(__InBuffer + 2) = bEnableDriveZ;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearPositionDrive, __InBuffer);
			}
		}

		/// <param name="bLinearPlasticity">
		/// Whether it is possible to reset the target angle from the Linear displacement
		/// </param>
		/// <param name="LinearPlasticityThreshold">
		/// Percent deformation needed to reset the rest length of the joint
		/// </param>
		public virtual void SetLinearPlasticity(bool bLinearPlasticity, float LinearPlasticityThreshold, EConstraintPlasticityType PlasticityType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(bool*)(__InBuffer) = bLinearPlasticity;

				*(float*)(__InBuffer + 1) = LinearPlasticityThreshold;

				*(byte*)(__InBuffer + 5) = (byte)PlasticityType;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearPlasticity, __InBuffer);
			}
		}

		/// <param name="PositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="VelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="InForceLimit">
		/// Max force applied by the drive
		/// </param>
		public virtual void SetLinearDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = PositionStrength;

				*(float*)(__InBuffer + 4) = VelocityStrength;

				*(float*)(__InBuffer + 8) = InForceLimit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearDriveParams, __InBuffer);
			}
		}

		/// <param name="bLinearBreakable">
		/// Whether it is possible to break the joint with linear force
		/// </param>
		/// <param name="LinearBreakThreshold">
		/// Force needed to break the joint
		/// </param>
		public virtual void SetLinearBreakable(bool bLinearBreakable, float LinearBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bLinearBreakable;

				*(float*)(__InBuffer + 1) = LinearBreakThreshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearBreakable, __InBuffer);
			}
		}

		public virtual void SetDisableCollision(bool bDisableCollision)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bDisableCollision;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDisableCollision, __InBuffer);
			}
		}

		/// <param name="ContactTransferScale">
		/// Set the contact transfer scale for the parent of the joint
		/// </param>
		public virtual void SetContactTransferScale(float ContactTransferScale)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = ContactTransferScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetContactTransferScale, __InBuffer);
			}
		}

		public virtual void SetConstraintReferencePosition(EConstraintFrame Frame, FVector RefPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Frame;

				*(nint*)(__InBuffer + 1) = RefPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintReferencePosition, __InBuffer);
			}
		}

		public virtual void SetConstraintReferenceOrientation(EConstraintFrame Frame, FVector PriAxis, FVector SecAxis)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(byte*)(__InBuffer) = (byte)Frame;

				*(nint*)(__InBuffer + 1) = PriAxis?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 9) = SecAxis?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintReferenceOrientation, __InBuffer);
			}
		}

		public virtual void SetConstraintReferenceFrame(EConstraintFrame Frame, FTransform RefFrame)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Frame;

				*(nint*)(__InBuffer + 1) = RefFrame?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstraintReferenceFrame, __InBuffer);
			}
		}

		public virtual void SetConstrainedComponents(UPrimitiveComponent Component1, FName BoneName1, UPrimitiveComponent Component2, FName BoneName2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Component1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Component2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = BoneName2?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetConstrainedComponents, __InBuffer);
			}
		}

		/// <param name="InVelTarget">
		/// Target velocity
		/// </param>
		public virtual void SetAngularVelocityTarget(FVector InVelTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InVelTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularVelocityTarget, __InBuffer);
			}
		}

		/// <param name="bEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public virtual void SetAngularVelocityDriveTwistAndSwing(bool bEnableTwistDrive, bool bEnableSwingDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnableTwistDrive;

				*(bool*)(__InBuffer + 1) = bEnableSwingDrive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularVelocityDriveTwistAndSwing, __InBuffer);
			}
		}

		/// <param name="bEnableSLERP">
		/// Indicates whether the SLERP drive should be enabled. Only relevant if the AngularDriveMode is set to SLERP
		/// </param>
		public virtual void SetAngularVelocityDriveSLERP(bool bEnableSLERP)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnableSLERP;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularVelocityDriveSLERP, __InBuffer);
			}
		}

		public virtual void SetAngularVelocityDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnableSwingDrive;

				*(bool*)(__InBuffer + 1) = bEnableTwistDrive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularVelocityDrive, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="TwistLimitAngle">
		/// Size of limit in degrees
		/// </param>
		public virtual void SetAngularTwistLimit(EAngularConstraintMotion ConstraintType, float TwistLimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)ConstraintType;

				*(float*)(__InBuffer + 1) = TwistLimitAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularTwistLimit, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="Swing2LimitAngle">
		/// Size of limit in degrees
		/// </param>
		public virtual void SetAngularSwing2Limit(EAngularConstraintMotion MotionType, float Swing2LimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)MotionType;

				*(float*)(__InBuffer + 1) = Swing2LimitAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularSwing2Limit, __InBuffer);
			}
		}

		/// <param name="ConstraintType">
		/// New Constraint Type
		/// </param>
		/// <param name="Swing1LimitAngle">
		/// Size of limit in degrees
		/// </param>
		public virtual void SetAngularSwing1Limit(EAngularConstraintMotion MotionType, float Swing1LimitAngle)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(byte*)(__InBuffer) = (byte)MotionType;

				*(float*)(__InBuffer + 1) = Swing1LimitAngle;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularSwing1Limit, __InBuffer);
			}
		}

		/// <param name="bAngularPlasticity">
		/// Whether it is possible to reset the target angle from the angular displacement
		/// </param>
		/// <param name="AngularPlasticityThreshold">
		/// Degrees needed to reset the rest state of the joint
		/// </param>
		public virtual void SetAngularPlasticity(bool bAngularPlasticity, float AngularPlasticityThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bAngularPlasticity;

				*(float*)(__InBuffer + 1) = AngularPlasticityThreshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularPlasticity, __InBuffer);
			}
		}

		/// <param name="InPosTarget">
		/// Target orientation
		/// </param>
		public virtual void SetAngularOrientationTarget(FRotator InPosTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InPosTarget?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularOrientationTarget, __InBuffer);
			}
		}

		/// <param name="bEnableSwingDrive">
		/// Indicates whether the drive for the swing axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		/// <param name="bEnableTwistDrive">
		/// Indicates whether the drive for the twist axis should be enabled. Only relevant if the AngularDriveMode is set to Twist and Swing
		/// </param>
		public virtual void SetAngularOrientationDrive(bool bEnableSwingDrive, bool bEnableTwistDrive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bEnableSwingDrive;

				*(bool*)(__InBuffer + 1) = bEnableTwistDrive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularOrientationDrive, __InBuffer);
			}
		}

		/// <param name="PositionStrength">
		/// Positional strength for the drive (stiffness)
		/// </param>
		/// <param name="VelocityStrength">
		/// Velocity strength of the drive (damping)
		/// </param>
		/// <param name="InForceLimit">
		/// Max force applied by the drive
		/// </param>
		public virtual void SetAngularDriveParams(float PositionStrength, float VelocityStrength, float InForceLimit)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = PositionStrength;

				*(float*)(__InBuffer + 4) = VelocityStrength;

				*(float*)(__InBuffer + 8) = InForceLimit;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularDriveParams, __InBuffer);
			}
		}

		/// <param name="DriveMode">
		/// The angular drive mode to use. SLERP uses shortest spherical path, but will not work if any angular constraints are locked. Twist and Swing decomposes the path into the different angular degrees of freedom but may experience gimbal lock
		/// </param>
		public virtual void SetAngularDriveMode(EAngularDriveMode DriveMode)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)DriveMode;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularDriveMode, __InBuffer);
			}
		}

		/// <param name="bAngularBreakable">
		/// Whether it is possible to break the joint with angular force
		/// </param>
		/// <param name="AngularBreakThreshold">
		/// Torque needed to break the joint
		/// </param>
		public virtual void SetAngularBreakable(bool bAngularBreakable, float AngularBreakThreshold)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[5];

				*(bool*)(__InBuffer) = bAngularBreakable;

				*(float*)(__InBuffer + 1) = AngularBreakThreshold;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularBreakable, __InBuffer);
			}
		}

		public virtual bool IsBroken()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsBroken, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentTwist()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentTwist, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentSwing2()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentSwing2, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetCurrentSwing1()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCurrentSwing1, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual void GetConstraintForce(ref FVector OutLinearForce, ref FVector OutAngularForce)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OutLinearForce?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutAngularForce?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetConstraintForce, __InBuffer, __OutBuffer);

				OutLinearForce = *(FVector*)(__OutBuffer);

				OutAngularForce = *(FVector*)(__OutBuffer + 8);

			}
		}

		public virtual FConstraintInstanceAccessor GetConstraint()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetConstraint, __ReturnBuffer);

				return *(FConstraintInstanceAccessor*)__ReturnBuffer;
			}
		}

		public virtual void GetConstrainedComponents(ref UPrimitiveComponent OutComponent1, ref FName OutBoneName1, ref UPrimitiveComponent OutComponent2, ref FName OutBoneName2)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = OutComponent1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OutBoneName1?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OutComponent2?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = OutBoneName2?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[32];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetConstrainedComponents, __InBuffer, __OutBuffer);

				OutComponent1 = *(UPrimitiveComponent*)(__OutBuffer);

				OutBoneName1 = *(FName*)(__OutBuffer + 8);

				OutComponent2 = *(UPrimitiveComponent*)(__OutBuffer + 16);

				OutBoneName2 = *(FName*)(__OutBuffer + 24);

			}
		}

		public virtual void BreakConstraint()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __BreakConstraint);
			}
		}

		private static uint __ConstraintActor1 = 0;

		private static uint __ComponentName1 = 0;

		private static uint __ConstraintActor2 = 0;

		private static uint __ComponentName2 = 0;

		private static uint __OnConstraintBroken = 0;

		private static uint __OnPlasticDeformation = 0;

		private static uint __ConstraintInstance = 0;

		private static uint __SetOrientationDriveTwistAndSwing = 0;

		private static uint __SetOrientationDriveSLERP = 0;

		private static uint __SetLinearZLimit = 0;

		private static uint __SetLinearYLimit = 0;

		private static uint __SetLinearXLimit = 0;

		private static uint __SetLinearVelocityTarget = 0;

		private static uint __SetLinearVelocityDrive = 0;

		private static uint __SetLinearPositionTarget = 0;

		private static uint __SetLinearPositionDrive = 0;

		private static uint __SetLinearPlasticity = 0;

		private static uint __SetLinearDriveParams = 0;

		private static uint __SetLinearBreakable = 0;

		private static uint __SetDisableCollision = 0;

		private static uint __SetContactTransferScale = 0;

		private static uint __SetConstraintReferencePosition = 0;

		private static uint __SetConstraintReferenceOrientation = 0;

		private static uint __SetConstraintReferenceFrame = 0;

		private static uint __SetConstrainedComponents = 0;

		private static uint __SetAngularVelocityTarget = 0;

		private static uint __SetAngularVelocityDriveTwistAndSwing = 0;

		private static uint __SetAngularVelocityDriveSLERP = 0;

		private static uint __SetAngularVelocityDrive = 0;

		private static uint __SetAngularTwistLimit = 0;

		private static uint __SetAngularSwing2Limit = 0;

		private static uint __SetAngularSwing1Limit = 0;

		private static uint __SetAngularPlasticity = 0;

		private static uint __SetAngularOrientationTarget = 0;

		private static uint __SetAngularOrientationDrive = 0;

		private static uint __SetAngularDriveParams = 0;

		private static uint __SetAngularDriveMode = 0;

		private static uint __SetAngularBreakable = 0;

		private static uint __IsBroken = 0;

		private static uint __GetCurrentTwist = 0;

		private static uint __GetCurrentSwing2 = 0;

		private static uint __GetCurrentSwing1 = 0;

		private static uint __GetConstraintForce = 0;

		private static uint __GetConstraint = 0;

		private static uint __GetConstrainedComponents = 0;

		private static uint __BreakConstraint = 0;
	}
}
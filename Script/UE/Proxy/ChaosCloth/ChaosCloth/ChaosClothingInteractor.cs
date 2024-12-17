using Script.CoreUObject;
using Script.ClothingSystemRuntimeInterface;
using Script.Library;

namespace Script.ChaosCloth
{
	[PathName("/Script/ChaosCloth.ChaosClothingInteractor")]
	public partial class UChaosClothingInteractor : UClothingInteractor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosCloth.ChaosClothingInteractor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetWind(FVector2D Drag = null, FVector2D Lift = null, float AirDensity = 0.000001f, FVector WindVelocity = null)
		{
			unsafe
			{
				Drag ??= new FVector2D(0.070000, 0.500000);

				Lift ??= new FVector2D(0.070000, 0.500000);

				WindVelocity ??= new FVector(0.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[28];

				*(nint*)(__InBuffer) = Drag?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Lift?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 16) = AirDensity;

				*(nint*)(__InBuffer + 20) = WindVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetWind, __InBuffer);
			}
		}

		public virtual void SetVelocityScale(FVector LinearVelocityScale = null, float AngularVelocityScale = 0.750000f, float FictitiousAngularScale = 1.000000f)
		{
			unsafe
			{
				LinearVelocityScale ??= new FVector(0.750000, 0.750000, 0.750000);

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = LinearVelocityScale?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = AngularVelocityScale;

				*(float*)(__InBuffer + 12) = FictitiousAngularScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetVelocityScale, __InBuffer);
			}
		}

		public virtual void SetPressure(FVector2D Pressure = null)
		{
			unsafe
			{
				Pressure ??= new FVector2D(0.000000, 1.000000);

				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Pressure?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetPressure, __InBuffer);
			}
		}

		public virtual void SetMaterialLinear(float EdgeStiffness = 1.000000f, float BendingStiffness = 1.000000f, float AreaStiffness = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(float*)(__InBuffer) = EdgeStiffness;

				*(float*)(__InBuffer + 4) = BendingStiffness;

				*(float*)(__InBuffer + 8) = AreaStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterialLinear, __InBuffer);
			}
		}

		public virtual void SetMaterial(FVector2D EdgeStiffness = null, FVector2D BendingStiffness = null, FVector2D AreaStiffness = null)
		{
			unsafe
			{
				EdgeStiffness ??= new FVector2D(1.000000, 1.000000);

				BendingStiffness ??= new FVector2D(1.000000, 1.000000);

				AreaStiffness ??= new FVector2D(1.000000, 1.000000);

				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = EdgeStiffness?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BendingStiffness?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = AreaStiffness?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetMaterial, __InBuffer);
			}
		}

		public virtual void SetLongRangeAttachmentLinear(float TetherStiffness = 1.000000f, float TetherScale = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = TetherStiffness;

				*(float*)(__InBuffer + 4) = TetherScale;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLongRangeAttachmentLinear, __InBuffer);
			}
		}

		public virtual void SetLongRangeAttachment(FVector2D TetherStiffness = null, FVector2D TetherScale = null)
		{
			unsafe
			{
				TetherStiffness ??= new FVector2D(1.000000, 1.000000);

				TetherScale ??= new FVector2D(1.000000, 1.000000);

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TetherStiffness?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TetherScale?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLongRangeAttachment, __InBuffer);
			}
		}

		public virtual void SetGravity(float GravityScale = 1.000000f, bool bIsGravityOverridden = false, FVector GravityOverride = null)
		{
			unsafe
			{
				GravityOverride ??= new FVector(0.000000, 0.000000, -981.000000);

				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = GravityScale;

				*(bool*)(__InBuffer + 4) = bIsGravityOverridden;

				*(nint*)(__InBuffer + 5) = GravityOverride?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGravity, __InBuffer);
			}
		}

		public virtual void SetDamping(float DampingCoefficient = 0.010000f, float LocalDampingCoefficient = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = DampingCoefficient;

				*(float*)(__InBuffer + 4) = LocalDampingCoefficient;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetDamping, __InBuffer);
			}
		}

		public virtual void SetCollision(float CollisionThickness = 1.000000f, float FrictionCoefficient = 0.800000f, bool bUseCCD = false, float SelfCollisionThickness = 2.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(float*)(__InBuffer) = CollisionThickness;

				*(float*)(__InBuffer + 4) = FrictionCoefficient;

				*(bool*)(__InBuffer + 8) = bUseCCD;

				*(float*)(__InBuffer + 9) = SelfCollisionThickness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetCollision, __InBuffer);
			}
		}

		public virtual void SetBackstop(bool bEnabled = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetBackstop, __InBuffer);
			}
		}

		public virtual void SetAnimDriveLinear(float AnimDriveStiffness = 0.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = AnimDriveStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimDriveLinear, __InBuffer);
			}
		}

		public virtual void SetAnimDrive(FVector2D AnimDriveStiffness = null, FVector2D AnimDriveDamping = null)
		{
			unsafe
			{
				AnimDriveStiffness ??= new FVector2D(0.000000, 1.000000);

				AnimDriveDamping ??= new FVector2D(0.000000, 1.000000);

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = AnimDriveStiffness?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = AnimDriveDamping?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAnimDrive, __InBuffer);
			}
		}

		public virtual void SetAerodynamics(float DragCoefficient = 0.070000f, float LiftCoefficient = 0.035000f, FVector WindVelocity = null)
		{
			unsafe
			{
				WindVelocity ??= new FVector(0.000000, 0.000000, 0.000000);

				var __InBuffer = stackalloc byte[16];

				*(float*)(__InBuffer) = DragCoefficient;

				*(float*)(__InBuffer + 4) = LiftCoefficient;

				*(nint*)(__InBuffer + 8) = WindVelocity?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAerodynamics, __InBuffer);
			}
		}

		public virtual void ResetAndTeleport(bool bReset = false, bool bTeleport = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bReset;

				*(bool*)(__InBuffer + 1) = bTeleport;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ResetAndTeleport, __InBuffer);
			}
		}

		private static uint __SetWind = 0;

		private static uint __SetVelocityScale = 0;

		private static uint __SetPressure = 0;

		private static uint __SetMaterialLinear = 0;

		private static uint __SetMaterial = 0;

		private static uint __SetLongRangeAttachmentLinear = 0;

		private static uint __SetLongRangeAttachment = 0;

		private static uint __SetGravity = 0;

		private static uint __SetDamping = 0;

		private static uint __SetCollision = 0;

		private static uint __SetBackstop = 0;

		private static uint __SetAnimDriveLinear = 0;

		private static uint __SetAnimDrive = 0;

		private static uint __SetAerodynamics = 0;

		private static uint __ResetAndTeleport = 0;
	}
}
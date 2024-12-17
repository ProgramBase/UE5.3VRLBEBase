using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PhysicsHandleComponent")]
	public partial class UPhysicsHandleComponent : UActorComponent, IStaticClass
	{
		public UPrimitiveComponent GrabbedComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GrabbedComponent, __ReturnBuffer);

					return *(UPrimitiveComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GrabbedComponent, __InBuffer);
				}
			}
		}

		public bool bSoftAngularConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSoftAngularConstraint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSoftAngularConstraint, __InBuffer);
				}
			}
		}

		public bool bSoftLinearConstraint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSoftLinearConstraint, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSoftLinearConstraint, __InBuffer);
				}
			}
		}

		public bool bInterpolateTarget
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bInterpolateTarget, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bInterpolateTarget, __InBuffer);
				}
			}
		}

		public float LinearDamping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinearDamping, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinearDamping, __InBuffer);
				}
			}
		}

		public float LinearStiffness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LinearStiffness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LinearStiffness, __InBuffer);
				}
			}
		}

		public float AngularDamping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AngularDamping, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AngularDamping, __InBuffer);
				}
			}
		}

		public float AngularStiffness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AngularStiffness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AngularStiffness, __InBuffer);
				}
			}
		}

		public float InterpolationSpeed
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InterpolationSpeed, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InterpolationSpeed, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PhysicsHandleComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetTargetRotation(FRotator NewRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTargetRotation, __InBuffer);
			}
		}

		public virtual void SetTargetLocationAndRotation(FVector NewLocation, FRotator NewRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewRotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTargetLocationAndRotation, __InBuffer);
			}
		}

		public virtual void SetTargetLocation(FVector NewLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetTargetLocation, __InBuffer);
			}
		}

		public virtual void SetLinearStiffness(float NewLinearStiffness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLinearStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearStiffness, __InBuffer);
			}
		}

		public virtual void SetLinearDamping(float NewLinearDamping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewLinearDamping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetLinearDamping, __InBuffer);
			}
		}

		public virtual void SetInterpolationSpeed(float NewInterpolationSpeed)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewInterpolationSpeed;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetInterpolationSpeed, __InBuffer);
			}
		}

		public virtual void SetAngularStiffness(float NewAngularStiffness)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewAngularStiffness;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularStiffness, __InBuffer);
			}
		}

		public virtual void SetAngularDamping(float NewAngularDamping)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewAngularDamping;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetAngularDamping, __InBuffer);
			}
		}

		public virtual void ReleaseComponent()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReleaseComponent);
			}
		}

		public virtual void GrabComponentAtLocationWithRotation(UPrimitiveComponent Component, FName InBoneName, FVector Location, FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __GrabComponentAtLocationWithRotation, __InBuffer);
			}
		}

		public virtual void GrabComponentAtLocation(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GrabLocation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __GrabComponentAtLocation, __InBuffer);
			}
		}

		public virtual void GrabComponent(UPrimitiveComponent Component, FName InBoneName, FVector GrabLocation, bool bConstrainRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Component?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InBoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GrabLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bConstrainRotation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __GrabComponent, __InBuffer);
			}
		}

		public virtual void GetTargetLocationAndRotation(ref FVector TargetLocation, ref FRotator TargetRotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = TargetLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TargetRotation?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __GetTargetLocationAndRotation, __InBuffer, __OutBuffer);

				TargetLocation = *(FVector*)(__OutBuffer);

				TargetRotation = *(FRotator*)(__OutBuffer + 8);

			}
		}

		public virtual UPrimitiveComponent GetGrabbedComponent()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGrabbedComponent, __ReturnBuffer);

				return *(UPrimitiveComponent*)__ReturnBuffer;
			}
		}

		private static uint __GrabbedComponent = 0;

		private static uint __bSoftAngularConstraint = 0;

		private static uint __bSoftLinearConstraint = 0;

		private static uint __bInterpolateTarget = 0;

		private static uint __LinearDamping = 0;

		private static uint __LinearStiffness = 0;

		private static uint __AngularDamping = 0;

		private static uint __AngularStiffness = 0;

		private static uint __InterpolationSpeed = 0;

		private static uint __SetTargetRotation = 0;

		private static uint __SetTargetLocationAndRotation = 0;

		private static uint __SetTargetLocation = 0;

		private static uint __SetLinearStiffness = 0;

		private static uint __SetLinearDamping = 0;

		private static uint __SetInterpolationSpeed = 0;

		private static uint __SetAngularStiffness = 0;

		private static uint __SetAngularDamping = 0;

		private static uint __ReleaseComponent = 0;

		private static uint __GrabComponentAtLocationWithRotation = 0;

		private static uint __GrabComponentAtLocation = 0;

		private static uint __GrabComponent = 0;

		private static uint __GetTargetLocationAndRotation = 0;

		private static uint __GetGrabbedComponent = 0;
	}
}
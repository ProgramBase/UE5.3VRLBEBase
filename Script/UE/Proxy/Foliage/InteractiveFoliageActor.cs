using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.InteractiveFoliageActor")]
	public partial class AInteractiveFoliageActor : AStaticMeshActor, IStaticClass
	{
		public UCapsuleComponent CapsuleComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleComponent, __ReturnBuffer);

					return *(UCapsuleComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CapsuleComponent, __InBuffer);
				}
			}
		}

		public FVector TouchingActorEntryPosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TouchingActorEntryPosition, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TouchingActorEntryPosition, __InBuffer);
				}
			}
		}

		public FVector FoliageVelocity
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageVelocity, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageVelocity, __InBuffer);
				}
			}
		}

		public FVector FoliageForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageForce, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageForce, __InBuffer);
				}
			}
		}

		public FVector FoliagePosition
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliagePosition, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliagePosition, __InBuffer);
				}
			}
		}

		public float FoliageDamageImpulseScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageDamageImpulseScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageDamageImpulseScale, __InBuffer);
				}
			}
		}

		public float FoliageTouchImpulseScale
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageTouchImpulseScale, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageTouchImpulseScale, __InBuffer);
				}
			}
		}

		public float FoliageStiffness
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageStiffness, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageStiffness, __InBuffer);
				}
			}
		}

		public float FoliageStiffnessQuadratic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageStiffnessQuadratic, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageStiffnessQuadratic, __InBuffer);
				}
			}
		}

		public float FoliageDamping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageDamping, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FoliageDamping, __InBuffer);
				}
			}
		}

		public float MaxDamageImpulse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDamageImpulse, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxDamageImpulse, __InBuffer);
				}
			}
		}

		public float MaxTouchImpulse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTouchImpulse, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxTouchImpulse, __InBuffer);
				}
			}
		}

		public float MaxForce
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxForce, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxForce, __InBuffer);
				}
			}
		}

		public float Mass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Mass, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Mass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.InteractiveFoliageActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void CapsuleTouched(UPrimitiveComponent OverlappedComp, AActor Other, UPrimitiveComponent OtherComp, int OtherBodyIndex, bool bFromSweep, FHitResult OverlapInfo)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = OverlappedComp?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Other?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = OtherComp?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 24) = OtherBodyIndex;

				*(bool*)(__InBuffer + 28) = bFromSweep;

				*(nint*)(__InBuffer + 29) = OverlapInfo?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CapsuleTouched, __InBuffer);
			}
		}

		private static uint __CapsuleComponent = 0;

		private static uint __TouchingActorEntryPosition = 0;

		private static uint __FoliageVelocity = 0;

		private static uint __FoliageForce = 0;

		private static uint __FoliagePosition = 0;

		private static uint __FoliageDamageImpulseScale = 0;

		private static uint __FoliageTouchImpulseScale = 0;

		private static uint __FoliageStiffness = 0;

		private static uint __FoliageStiffnessQuadratic = 0;

		private static uint __FoliageDamping = 0;

		private static uint __MaxDamageImpulse = 0;

		private static uint __MaxTouchImpulse = 0;

		private static uint __MaxForce = 0;

		private static uint __Mass = 0;

		private static uint __CapsuleTouched = 0;
	}
}
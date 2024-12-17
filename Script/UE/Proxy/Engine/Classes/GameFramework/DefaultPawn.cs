using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.DefaultPawn")]
	public partial class ADefaultPawn : APawn, IStaticClass
	{
		public float BaseTurnRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTurnRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseTurnRate, __InBuffer);
				}
			}
		}

		public float BaseLookUpRate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseLookUpRate, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseLookUpRate, __InBuffer);
				}
			}
		}

		public UPawnMovementComponent MovementComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MovementComponent, __ReturnBuffer);

					return *(UPawnMovementComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MovementComponent, __InBuffer);
				}
			}
		}

		public USphereComponent CollisionComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionComponent, __ReturnBuffer);

					return *(USphereComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CollisionComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent MeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MeshComponent, __InBuffer);
				}
			}
		}

		public bool bAddDefaultMovementBindings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAddDefaultMovementBindings, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAddDefaultMovementBindings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.DefaultPawn");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="Rate">
		/// This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
		/// </param>
		public virtual void TurnAtRate(float Rate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Rate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __TurnAtRate, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount of movement in the world up direction (or down if negative).
		/// </param>
		/// <see>
		/// APawn::AddMovementInput()
		/// </see>
		public virtual void MoveUp_World(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MoveUp_World, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount of movement in the right direction (or left if negative).
		/// </param>
		/// <see>
		/// APawn::AddMovementInput()
		/// </see>
		public virtual void MoveRight(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MoveRight, __InBuffer);
			}
		}

		/// <param name="Val">
		/// Amount of movement in the forward direction (or backward if negative).
		/// </param>
		/// <see>
		/// APawn::AddMovementInput()
		/// </see>
		public virtual void MoveForward(float Val)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Val;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __MoveForward, __InBuffer);
			}
		}

		/// <param name="Rate">
		/// This is a normalized rate, i.e. 1.0 means 100% of desired turn rate
		/// </param>
		public virtual void LookUpAtRate(float Rate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Rate;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __LookUpAtRate, __InBuffer);
			}
		}

		private static uint __BaseTurnRate = 0;

		private static uint __BaseLookUpRate = 0;

		private static uint __MovementComponent = 0;

		private static uint __CollisionComponent = 0;

		private static uint __MeshComponent = 0;

		private static uint __bAddDefaultMovementBindings = 0;

		private static uint __TurnAtRate = 0;

		private static uint __MoveUp_World = 0;

		private static uint __MoveRight = 0;

		private static uint __MoveForward = 0;

		private static uint __LookUpAtRate = 0;
	}
}
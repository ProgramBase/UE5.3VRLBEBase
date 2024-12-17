using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PawnMovementComponent")]
	public partial class UPawnMovementComponent : UNavMovementComponent, IStaticClass
	{
		public APawn PawnOwner
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PawnOwner, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PawnOwner, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PawnMovementComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ServerAsyncPhysicsStateAction(UPrimitiveComponent ActionComponent, FName BoneName, FAsyncPhysicsTimestamp Timestamp, EPhysicsStateAction ActionType, FVector ActionDatas, FVector ActionPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = ActionComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Timestamp?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)ActionType;

				*(nint*)(__InBuffer + 25) = ActionDatas?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = ActionPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerAsyncPhysicsStateAction, __InBuffer);
			}
		}

		public virtual void MulticastAsyncPhysicsStateAction(UPrimitiveComponent ActionComponent, FName BoneName, FAsyncPhysicsTimestamp Timestamp, EPhysicsStateAction ActionType, FVector ActionDatas, FVector ActionPosition)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = ActionComponent?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = BoneName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Timestamp?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 24) = (byte)ActionType;

				*(nint*)(__InBuffer + 25) = ActionDatas?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = ActionPosition?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __MulticastAsyncPhysicsStateAction, __InBuffer);
			}
		}

		public virtual bool IsMoveInputIgnored()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsMoveInputIgnored, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <see>
		/// AddInputVector(), ConsumeInputVector(), GetLastInputVector()
		/// </see>
		/// <returns>
		/// The pending input vector in world space.
		/// </returns>
		public virtual FVector GetPendingInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPendingInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		public virtual APawn GetPawnOwner()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPawnOwner, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <see>
		/// AddInputVector(), ConsumeInputVector(), GetPendingInputVector()
		/// </see>
		/// <returns>
		/// The last input vector in world space that was processed by ConsumeInputVector().
		/// </returns>
		public virtual FVector GetLastInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetLastInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// The pending input vector.
		/// </returns>
		public virtual FVector ConsumeInputVector()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __ConsumeInputVector, __ReturnBuffer);

				return *(FVector*)__ReturnBuffer;
			}
		}

		/// <param name="WorldVector">
		/// Direction in world space to apply input
		/// </param>
		/// <param name="bForce">
		/// If true always add the input, ignoring the result of IsMoveInputIgnored().
		/// </param>
		/// <see>
		/// APawn::AddMovementInput()
		/// </see>
		public virtual void AddInputVector(FVector WorldVector, bool bForce = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = WorldVector?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bForce;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddInputVector, __InBuffer);
			}
		}

		private static uint __PawnOwner = 0;

		private static uint __ServerAsyncPhysicsStateAction = 0;

		private static uint __MulticastAsyncPhysicsStateAction = 0;

		private static uint __IsMoveInputIgnored = 0;

		private static uint __GetPendingInputVector = 0;

		private static uint __GetPawnOwner = 0;

		private static uint __GetLastInputVector = 0;

		private static uint __ConsumeInputVector = 0;

		private static uint __AddInputVector = 0;
	}
}
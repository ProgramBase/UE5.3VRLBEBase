using Script.CoreUObject;
using Script.Engine.InterpToMovementComponent;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.InterpToMovementComponent")]
	public partial class UInterpToMovementComponent : UMovementComponent, IStaticClass
	{
		public float Duration
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Duration, __InBuffer);
				}
			}
		}

		public bool bPauseOnImpact
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseOnImpact, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseOnImpact, __InBuffer);
				}
			}
		}

		public bool bSweep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSweep, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSweep, __InBuffer);
				}
			}
		}

		public ETeleportType TeleportType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportType, __ReturnBuffer);

					return *(ETeleportType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TeleportType, __InBuffer);
				}
			}
		}

		public EInterpToBehaviourType BehaviourType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BehaviourType, __ReturnBuffer);

					return *(EInterpToBehaviourType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BehaviourType, __InBuffer);
				}
			}
		}

		public bool bCheckIfStillInWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCheckIfStillInWorld, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCheckIfStillInWorld, __InBuffer);
				}
			}
		}

		public bool bForceSubStepping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSubStepping, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceSubStepping, __InBuffer);
				}
			}
		}

		public FOnInterpToReverseDelegate OnInterpToReverse
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterpToReverse, __ReturnBuffer);

					return *(FOnInterpToReverseDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterpToReverse, __InBuffer);
				}
			}
		}

		public FOnInterpToStopDelegate OnInterpToStop
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterpToStop, __ReturnBuffer);

					return *(FOnInterpToStopDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnInterpToStop, __InBuffer);
				}
			}
		}

		public FOnInterpToWaitBeginDelegate OnWaitBeginDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnWaitBeginDelegate, __ReturnBuffer);

					return *(FOnInterpToWaitBeginDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnWaitBeginDelegate, __InBuffer);
				}
			}
		}

		public FOnInterpToWaitEndDelegate OnWaitEndDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnWaitEndDelegate, __ReturnBuffer);

					return *(FOnInterpToWaitEndDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnWaitEndDelegate, __InBuffer);
				}
			}
		}

		public FOnInterpToResetDelegate OnResetDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnResetDelegate, __ReturnBuffer);

					return *(FOnInterpToResetDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnResetDelegate, __InBuffer);
				}
			}
		}

		public float MaxSimulationTimeStep
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationTimeStep, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationTimeStep, __InBuffer);
				}
			}
		}

		public int MaxSimulationIterations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationIterations, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __MaxSimulationIterations, __InBuffer);
				}
			}
		}

		public TArray<FInterpControlPoint> ControlPoints
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlPoints, __ReturnBuffer);

					return *(TArray<FInterpControlPoint>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlPoints, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.InterpToMovementComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StopSimulating(FHitResult HitResult)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = HitResult?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StopSimulating, __InBuffer);
			}
		}

		public virtual void RestartMovement(float InitialDirection = 1.000000f)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = InitialDirection;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RestartMovement, __InBuffer);
			}
		}

		public virtual void ResetControlPoints()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetControlPoints);
			}
		}

		public virtual void FinaliseControlPoints()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FinaliseControlPoints);
			}
		}

		public virtual void AddControlPointPosition(FVector Pos, bool bPositionIsRelative = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Pos?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bPositionIsRelative;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __AddControlPointPosition, __InBuffer);
			}
		}

		private static uint __Duration = 0;

		private static uint __bPauseOnImpact = 0;

		private static uint __bSweep = 0;

		private static uint __TeleportType = 0;

		private static uint __BehaviourType = 0;

		private static uint __bCheckIfStillInWorld = 0;

		private static uint __bForceSubStepping = 0;

		private static uint __OnInterpToReverse = 0;

		private static uint __OnInterpToStop = 0;

		private static uint __OnWaitBeginDelegate = 0;

		private static uint __OnWaitEndDelegate = 0;

		private static uint __OnResetDelegate = 0;

		private static uint __MaxSimulationTimeStep = 0;

		private static uint __MaxSimulationIterations = 0;

		private static uint __ControlPoints = 0;

		private static uint __StopSimulating = 0;

		private static uint __RestartMovement = 0;

		private static uint __ResetControlPoints = 0;

		private static uint __FinaliseControlPoints = 0;

		private static uint __AddControlPointPosition = 0;
	}
}
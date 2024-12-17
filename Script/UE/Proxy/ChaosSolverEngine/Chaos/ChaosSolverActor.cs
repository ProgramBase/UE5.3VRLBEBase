using Script.CoreUObject;
using Script.Engine;
using Script.Chaos;
using Script.Library;

namespace Script.ChaosSolverEngine
{
	[PathName("/Script/ChaosSolverEngine.ChaosSolverActor")]
	public partial class AChaosSolverActor : AActor, IStaticClass
	{
		public FChaosSolverConfiguration Properties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __ReturnBuffer);

					return *(FChaosSolverConfiguration*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Properties, __InBuffer);
				}
			}
		}

		public bool bHasFloor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHasFloor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHasFloor, __InBuffer);
				}
			}
		}

		public float FloorHeight
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __FloorHeight, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __FloorHeight, __InBuffer);
				}
			}
		}

		public FChaosDebugSubstepControl ChaosDebugSubstepControl
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosDebugSubstepControl, __ReturnBuffer);

					return *(FChaosDebugSubstepControl*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ChaosDebugSubstepControl, __InBuffer);
				}
			}
		}

		public UBillboardComponent SpriteComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __ReturnBuffer);

					return *(UBillboardComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpriteComponent, __InBuffer);
				}
			}
		}

		public UChaosGameplayEventDispatcher GameplayEventDispatcherComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayEventDispatcherComponent, __ReturnBuffer);

					return *(UChaosGameplayEventDispatcher*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameplayEventDispatcherComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ChaosSolverEngine.ChaosSolverActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSolverActive(bool bActive)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bActive;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSolverActive, __InBuffer);
			}
		}

		public virtual void SetAsCurrentWorldSolver()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetAsCurrentWorldSolver);
			}
		}

		private static uint __Properties = 0;

		private static uint __bHasFloor = 0;

		private static uint __FloorHeight = 0;

		private static uint __ChaosDebugSubstepControl = 0;

		private static uint __SpriteComponent = 0;

		private static uint __GameplayEventDispatcherComponent = 0;

		private static uint __SetSolverActive = 0;

		private static uint __SetAsCurrentWorldSolver = 0;
	}
}
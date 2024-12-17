using Script.CoreUObject;
using Script.Engine;
using Script.Library;
using Script.NavigationSystem;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AIBlueprintHelperLibrary")]
	public partial class UAIBlueprintHelperLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AIBlueprintHelperLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void UnlockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bUnlockMovement, bool UnlockAILogic)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = AnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bUnlockMovement;

				*(bool*)(__InBuffer + 9) = UnlockAILogic;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __UnlockAIResourcesWithAnimation, __InBuffer);
			}
		}

		/// <param name="BehaviorTree">
		/// if set, and the function has successfully spawned 
		/// and AI controller, this BehaviorTree asset will be assigned to the AI 
		/// controller, and run.
		/// </param>
		/// <param name="Owner">
		/// lets you spawn the AI in a sublevel rather than in the 
		/// persistent level (which is the default behavior).
		/// </param>
		public static APawn SpawnAIFromClass(UObject WorldContextObject, TSubclassOf<APawn> PawnClass, UBehaviorTree BehaviorTree, FVector Location, FRotator Rotation = null, bool bNoCollisionFail = false, AActor Owner = null)
		{
			unsafe
			{
				Rotation ??= new FRotator();

				var __InBuffer = stackalloc byte[49];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = PawnClass?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = BehaviorTree?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Location?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 40) = bNoCollisionFail;

				*(nint*)(__InBuffer + 41) = Owner?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __SpawnAIFromClass, __InBuffer, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		public static void SimpleMoveToLocation(AController Controller, FVector Goal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Goal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SimpleMoveToLocation, __InBuffer);
			}
		}

		public static void SimpleMoveToActor(AController Controller, AActor Goal)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Goal?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SimpleMoveToActor, __InBuffer);
			}
		}

		public static void SendAIMessage(APawn Target, FName Message, UObject MessageSource, bool bSuccess = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[25];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Message?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = MessageSource?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 24) = bSuccess;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SendAIMessage, __InBuffer);
			}
		}

		public static void LockAIResourcesWithAnimation(UAnimInstance AnimInstance, bool bLockMovement, bool LockAILogic)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[10];

				*(nint*)(__InBuffer) = AnimInstance?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = bLockMovement;

				*(bool*)(__InBuffer + 9) = LockAILogic;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __LockAIResourcesWithAnimation, __InBuffer);
			}
		}

		public static bool IsValidAIRotation(FRotator Rotation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Rotation?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidAIRotation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidAILocation(FVector Location)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Location?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidAILocation, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool IsValidAIDirection(FVector DirectionVector)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DirectionVector?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsValidAIDirection, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static int GetNextNavLinkIndex(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetNextNavLinkIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static TArray<FVector> GetCurrentPathPoints(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentPathPoints, __InBuffer, __ReturnBuffer);

				return *(TArray<FVector>*)__ReturnBuffer;
			}
		}

		public static int GetCurrentPathIndex(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentPathIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public static UNavigationPath GetCurrentPath(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetCurrentPath, __InBuffer, __ReturnBuffer);

				return *(UNavigationPath*)__ReturnBuffer;
			}
		}

		public static UBlackboardComponent GetBlackboard(AActor Target)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Target?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetBlackboard, __InBuffer, __ReturnBuffer);

				return *(UBlackboardComponent*)__ReturnBuffer;
			}
		}

		public static AAIController GetAIController(AActor ControlledActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ControlledActor?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __GetAIController, __InBuffer, __ReturnBuffer);

				return *(AAIController*)__ReturnBuffer;
			}
		}

		public static UAIAsyncTaskBlueprintProxy CreateMoveToProxyObject(UObject WorldContextObject, APawn Pawn, FVector Destination, AActor TargetActor = null, float AcceptanceRadius = 5.000000f, bool bStopOnOverlap = false)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[37];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Pawn?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Destination?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = TargetActor?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 32) = AcceptanceRadius;

				*(bool*)(__InBuffer + 36) = bStopOnOverlap;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __CreateMoveToProxyObject, __InBuffer, __ReturnBuffer);

				return *(UAIAsyncTaskBlueprintProxy*)__ReturnBuffer;
			}
		}

		private static uint __UnlockAIResourcesWithAnimation = 0;

		private static uint __SpawnAIFromClass = 0;

		private static uint __SimpleMoveToLocation = 0;

		private static uint __SimpleMoveToActor = 0;

		private static uint __SendAIMessage = 0;

		private static uint __LockAIResourcesWithAnimation = 0;

		private static uint __IsValidAIRotation = 0;

		private static uint __IsValidAILocation = 0;

		private static uint __IsValidAIDirection = 0;

		private static uint __GetNextNavLinkIndex = 0;

		private static uint __GetCurrentPathPoints = 0;

		private static uint __GetCurrentPathIndex = 0;

		private static uint __GetCurrentPath = 0;

		private static uint __GetBlackboard = 0;

		private static uint __GetAIController = 0;

		private static uint __CreateMoveToProxyObject = 0;
	}
}
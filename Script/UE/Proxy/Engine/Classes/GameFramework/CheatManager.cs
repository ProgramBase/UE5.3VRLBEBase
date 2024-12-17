using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.CheatManager")]
	public partial class UCheatManager : UObject, IStaticClass
	{
		public ADebugCameraController DebugCameraControllerRef
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCameraControllerRef, __ReturnBuffer);

					return *(ADebugCameraController*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCameraControllerRef, __InBuffer);
				}
			}
		}

		public TSubclassOf<ADebugCameraController> DebugCameraControllerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCameraControllerClass, __ReturnBuffer);

					return *(TSubclassOf<ADebugCameraController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DebugCameraControllerClass, __InBuffer);
				}
			}
		}

		public TArray<UCheatManagerExtension> CheatManagerExtensions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CheatManagerExtensions, __ReturnBuffer);

					return *(TArray<UCheatManagerExtension>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CheatManagerExtensions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.CheatManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Walk()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Walk);
			}
		}

		public virtual void ViewSelf()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ViewSelf);
			}
		}

		public virtual void ViewPlayer(FString S)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = S?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ViewPlayer, __InBuffer);
			}
		}

		public virtual void ViewClass(TSubclassOf<AActor> DesiredClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DesiredClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ViewClass, __InBuffer);
			}
		}

		public virtual void ViewActor(FName ActorName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ViewActor, __InBuffer);
			}
		}

		public virtual void UpdateSafeArea()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __UpdateSafeArea);
			}
		}

		public virtual void ToggleServerStatReplicatorUpdateStatNet()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleServerStatReplicatorUpdateStatNet);
			}
		}

		public virtual void ToggleServerStatReplicatorClientOverwrite()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleServerStatReplicatorClientOverwrite);
			}
		}

		public virtual void ToggleDebugCamera()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleDebugCamera);
			}
		}

		public virtual void ToggleAILogging()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ToggleAILogging);
			}
		}

		public virtual void TestCollisionDistance()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __TestCollisionDistance);
			}
		}

		public virtual void Teleport()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Teleport);
			}
		}

		public virtual void Summon(FString ClassName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ClassName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Summon, __InBuffer);
			}
		}

		public virtual void StreamLevelOut(FName PackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StreamLevelOut, __InBuffer);
			}
		}

		public virtual void StreamLevelIn(FName PackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __StreamLevelIn, __InBuffer);
			}
		}

		public virtual void SpawnServerStatReplicator()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SpawnServerStatReplicator);
			}
		}

		public virtual void Slomo(float NewTimeDilation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = NewTimeDilation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __Slomo, __InBuffer);
			}
		}

		public virtual void SetWorldOrigin()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetWorldOrigin);
			}
		}

		public virtual void SetMouseSensitivityToDefault()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SetMouseSensitivityToDefault);
			}
		}

		public virtual void ServerToggleAILogging()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ServerToggleAILogging);
			}
		}

		public virtual void ReceiveInitCheatManager()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveInitCheatManager);
			}
		}

		public virtual void ReceiveEndPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall0Implementation(GarbageCollectionHandle, __ReceiveEndPlay);
			}
		}

		public virtual void PlayersOnly()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __PlayersOnly);
			}
		}

		public virtual void OnPlayerEndPlayed(AActor Player, EEndPlayReason EndPlayReason)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(byte*)(__InBuffer + 8) = (byte)EndPlayReason;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPlayerEndPlayed, __InBuffer);
			}
		}

		public virtual void OnlyLoadLevel(FName PackageName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PackageName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnlyLoadLevel, __InBuffer);
			}
		}

		public virtual void LogLoc()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __LogLoc);
			}
		}

		public virtual void InvertMouse()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __InvertMouse);
			}
		}

		public virtual void God()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __God);
			}
		}

		public virtual void Ghost()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Ghost);
			}
		}

		public virtual APlayerController GetPlayerController()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerController, __ReturnBuffer);

				return *(APlayerController*)__ReturnBuffer;
			}
		}

		public virtual void FreezeFrame(float Delay)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = Delay;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __FreezeFrame, __InBuffer);
			}
		}

		public virtual void Fly()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Fly);
			}
		}

		public virtual void FlushLog()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __FlushLog);
			}
		}

		public virtual void EnableDebugCamera()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __EnableDebugCamera);
			}
		}

		public virtual void DumpVoiceMutingState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DumpVoiceMutingState);
			}
		}

		public virtual void DumpPartyState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DumpPartyState);
			}
		}

		public virtual void DumpOnlineSessionState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DumpOnlineSessionState);
			}
		}

		public virtual void DumpChatState()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DumpChatState);
			}
		}

		public virtual void DisableDebugCamera()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DisableDebugCamera);
			}
		}

		public virtual void DestroyTarget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DestroyTarget);
			}
		}

		public virtual void DestroyServerStatReplicator()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DestroyServerStatReplicator);
			}
		}

		public virtual void DestroyPawns(TSubclassOf<APawn> aClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = aClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DestroyPawns, __InBuffer);
			}
		}

		public virtual void DestroyAllPawnsExceptTarget()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DestroyAllPawnsExceptTarget);
			}
		}

		public virtual void DestroyAll(TSubclassOf<AActor> aClass)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = aClass?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DestroyAll, __InBuffer);
			}
		}

		public virtual void DebugCapsuleSweepSize(float HalfHeight, float Radius)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(float*)(__InBuffer) = HalfHeight;

				*(float*)(__InBuffer + 4) = Radius;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DebugCapsuleSweepSize, __InBuffer);
			}
		}

		public virtual void DebugCapsuleSweepPawn()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DebugCapsuleSweepPawn);
			}
		}

		public virtual void DebugCapsuleSweepComplex(bool bTraceComplex)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bTraceComplex;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DebugCapsuleSweepComplex, __InBuffer);
			}
		}

		public virtual void DebugCapsuleSweepClear()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DebugCapsuleSweepClear);
			}
		}

		public virtual void DebugCapsuleSweepChannel(ECollisionChannel Channel)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Channel;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DebugCapsuleSweepChannel, __InBuffer);
			}
		}

		public virtual void DebugCapsuleSweepCapture()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DebugCapsuleSweepCapture);
			}
		}

		public virtual void DebugCapsuleSweep()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DebugCapsuleSweep);
			}
		}

		public virtual void DamageTarget(float DamageAmount)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = DamageAmount;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __DamageTarget, __InBuffer);
			}
		}

		public virtual void CheatScript(FString ScriptName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ScriptName?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __CheatScript, __InBuffer);
			}
		}

		public virtual void ChangeSize(float F)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(float*)(__InBuffer) = F;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ChangeSize, __InBuffer);
			}
		}

		public virtual void BugItStringCreator(FVector ViewLocation, FRotator ViewRotation, ref FString GoString, ref FString LocString)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[32];

				*(nint*)(__InBuffer) = ViewLocation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ViewRotation?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = GoString?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = LocString?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[16];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __BugItStringCreator, __InBuffer, __OutBuffer);

				GoString = *(FString*)(__OutBuffer);

				LocString = *(FString*)(__OutBuffer + 8);

			}
		}

		public virtual void BugItGo(float X, float Y, float Z, float Pitch, float Yaw, float Roll)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(float*)(__InBuffer) = X;

				*(float*)(__InBuffer + 4) = Y;

				*(float*)(__InBuffer + 8) = Z;

				*(float*)(__InBuffer + 12) = Pitch;

				*(float*)(__InBuffer + 16) = Yaw;

				*(float*)(__InBuffer + 20) = Roll;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BugItGo, __InBuffer);
			}
		}

		public virtual void BugIt(FString ScreenShotDescription)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ScreenShotDescription?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __BugIt, __InBuffer);
			}
		}

		private static uint __DebugCameraControllerRef = 0;

		private static uint __DebugCameraControllerClass = 0;

		private static uint __CheatManagerExtensions = 0;

		private static uint __Walk = 0;

		private static uint __ViewSelf = 0;

		private static uint __ViewPlayer = 0;

		private static uint __ViewClass = 0;

		private static uint __ViewActor = 0;

		private static uint __UpdateSafeArea = 0;

		private static uint __ToggleServerStatReplicatorUpdateStatNet = 0;

		private static uint __ToggleServerStatReplicatorClientOverwrite = 0;

		private static uint __ToggleDebugCamera = 0;

		private static uint __ToggleAILogging = 0;

		private static uint __TestCollisionDistance = 0;

		private static uint __Teleport = 0;

		private static uint __Summon = 0;

		private static uint __StreamLevelOut = 0;

		private static uint __StreamLevelIn = 0;

		private static uint __SpawnServerStatReplicator = 0;

		private static uint __Slomo = 0;

		private static uint __SetWorldOrigin = 0;

		private static uint __SetMouseSensitivityToDefault = 0;

		private static uint __ServerToggleAILogging = 0;

		private static uint __ReceiveInitCheatManager = 0;

		private static uint __ReceiveEndPlay = 0;

		private static uint __PlayersOnly = 0;

		private static uint __OnPlayerEndPlayed = 0;

		private static uint __OnlyLoadLevel = 0;

		private static uint __LogLoc = 0;

		private static uint __InvertMouse = 0;

		private static uint __God = 0;

		private static uint __Ghost = 0;

		private static uint __GetPlayerController = 0;

		private static uint __FreezeFrame = 0;

		private static uint __Fly = 0;

		private static uint __FlushLog = 0;

		private static uint __EnableDebugCamera = 0;

		private static uint __DumpVoiceMutingState = 0;

		private static uint __DumpPartyState = 0;

		private static uint __DumpOnlineSessionState = 0;

		private static uint __DumpChatState = 0;

		private static uint __DisableDebugCamera = 0;

		private static uint __DestroyTarget = 0;

		private static uint __DestroyServerStatReplicator = 0;

		private static uint __DestroyPawns = 0;

		private static uint __DestroyAllPawnsExceptTarget = 0;

		private static uint __DestroyAll = 0;

		private static uint __DebugCapsuleSweepSize = 0;

		private static uint __DebugCapsuleSweepPawn = 0;

		private static uint __DebugCapsuleSweepComplex = 0;

		private static uint __DebugCapsuleSweepClear = 0;

		private static uint __DebugCapsuleSweepChannel = 0;

		private static uint __DebugCapsuleSweepCapture = 0;

		private static uint __DebugCapsuleSweep = 0;

		private static uint __DamageTarget = 0;

		private static uint __CheatScript = 0;

		private static uint __ChangeSize = 0;

		private static uint __BugItStringCreator = 0;

		private static uint __BugItGo = 0;

		private static uint __BugIt = 0;
	}
}
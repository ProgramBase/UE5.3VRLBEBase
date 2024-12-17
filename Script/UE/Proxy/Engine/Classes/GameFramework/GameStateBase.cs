using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameStateBase")]
	public partial class AGameStateBase : AInfo, IStaticClass
	{
		public TSubclassOf<AGameModeBase> GameModeClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeClass, __ReturnBuffer);

					return *(TSubclassOf<AGameModeBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameModeClass, __InBuffer);
				}
			}
		}

		public AGameModeBase AuthorityGameMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AuthorityGameMode, __ReturnBuffer);

					return *(AGameModeBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AuthorityGameMode, __InBuffer);
				}
			}
		}

		public TSubclassOf<ASpectatorPawn> SpectatorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorClass, __ReturnBuffer);

					return *(TSubclassOf<ASpectatorPawn>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SpectatorClass, __InBuffer);
				}
			}
		}

		public TArray<APlayerState> PlayerArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerArray, __ReturnBuffer);

					return *(TArray<APlayerState>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerArray, __InBuffer);
				}
			}
		}

		public bool bReplicatedHasBegunPlay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatedHasBegunPlay, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bReplicatedHasBegunPlay, __InBuffer);
				}
			}
		}

		public float ReplicatedWorldTimeSeconds
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedWorldTimeSeconds, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedWorldTimeSeconds, __InBuffer);
				}
			}
		}

		public double ReplicatedWorldTimeSecondsDouble
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedWorldTimeSecondsDouble, __ReturnBuffer);

					return *(double*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(double*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplicatedWorldTimeSecondsDouble, __InBuffer);
				}
			}
		}

		public float ServerWorldTimeSecondsDelta
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerWorldTimeSecondsDelta, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerWorldTimeSecondsDelta, __InBuffer);
				}
			}
		}

		public float ServerWorldTimeSecondsUpdateFrequency
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerWorldTimeSecondsUpdateFrequency, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerWorldTimeSecondsUpdateFrequency, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameStateBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void OnRep_SpectatorClass()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_SpectatorClass);
			}
		}

		public virtual void OnRep_ReplicatedWorldTimeSecondsDouble()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedWorldTimeSecondsDouble);
			}
		}

		public virtual void OnRep_ReplicatedWorldTimeSeconds()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedWorldTimeSeconds);
			}
		}

		public virtual void OnRep_ReplicatedHasBegunPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_ReplicatedHasBegunPlay);
			}
		}

		public virtual void OnRep_GameModeClass()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_GameModeClass);
			}
		}

		public virtual bool HasMatchStarted()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasMatchStarted, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasMatchEnded()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasMatchEnded, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasBegunPlay()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasBegunPlay, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual double GetServerWorldTimeSeconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetServerWorldTimeSeconds, __ReturnBuffer);

				return *(double*)__ReturnBuffer;
			}
		}

		public virtual float GetPlayerStartTime(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetPlayerStartTime, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual float GetPlayerRespawnDelay(AController Controller)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetPlayerRespawnDelay, __InBuffer, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		private static uint __GameModeClass = 0;

		private static uint __AuthorityGameMode = 0;

		private static uint __SpectatorClass = 0;

		private static uint __PlayerArray = 0;

		private static uint __bReplicatedHasBegunPlay = 0;

		private static uint __ReplicatedWorldTimeSeconds = 0;

		private static uint __ReplicatedWorldTimeSecondsDouble = 0;

		private static uint __ServerWorldTimeSecondsDelta = 0;

		private static uint __ServerWorldTimeSecondsUpdateFrequency = 0;

		private static uint __OnRep_SpectatorClass = 0;

		private static uint __OnRep_ReplicatedWorldTimeSecondsDouble = 0;

		private static uint __OnRep_ReplicatedWorldTimeSeconds = 0;

		private static uint __OnRep_ReplicatedHasBegunPlay = 0;

		private static uint __OnRep_GameModeClass = 0;

		private static uint __HasMatchStarted = 0;

		private static uint __HasMatchEnded = 0;

		private static uint __HasBegunPlay = 0;

		private static uint __GetServerWorldTimeSeconds = 0;

		private static uint __GetPlayerStartTime = 0;

		private static uint __GetPlayerRespawnDelay = 0;
	}
}
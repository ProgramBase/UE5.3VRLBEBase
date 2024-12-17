using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.GameModeBase")]
	public partial class AGameModeBase : AInfo, IStaticClass
	{
		public FString OptionsString
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OptionsString, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OptionsString, __InBuffer);
				}
			}
		}

		public TSubclassOf<AGameSession> GameSessionClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameSessionClass, __ReturnBuffer);

					return *(TSubclassOf<AGameSession>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameSessionClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<AGameStateBase> GameStateClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameStateClass, __ReturnBuffer);

					return *(TSubclassOf<AGameStateBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameStateClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<APlayerController> PlayerControllerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerControllerClass, __ReturnBuffer);

					return *(TSubclassOf<APlayerController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerControllerClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<APlayerState> PlayerStateClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerStateClass, __ReturnBuffer);

					return *(TSubclassOf<APlayerState>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerStateClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<AHUD> HUDClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HUDClass, __ReturnBuffer);

					return *(TSubclassOf<AHUD>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HUDClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<APawn> DefaultPawnClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPawnClass, __ReturnBuffer);

					return *(TSubclassOf<APawn>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPawnClass, __InBuffer);
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

		public TSubclassOf<APlayerController> ReplaySpectatorPlayerControllerClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplaySpectatorPlayerControllerClass, __ReturnBuffer);

					return *(TSubclassOf<APlayerController>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplaySpectatorPlayerControllerClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<AServerStatReplicator> ServerStatReplicatorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStatReplicatorClass, __ReturnBuffer);

					return *(TSubclassOf<AServerStatReplicator>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStatReplicatorClass, __InBuffer);
				}
			}
		}

		public AGameSession GameSession
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameSession, __ReturnBuffer);

					return *(AGameSession*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameSession, __InBuffer);
				}
			}
		}

		public AGameStateBase GameState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GameState, __ReturnBuffer);

					return *(AGameStateBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GameState, __InBuffer);
				}
			}
		}

		public AServerStatReplicator ServerStatReplicator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStatReplicator, __ReturnBuffer);

					return *(AServerStatReplicator*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ServerStatReplicator, __InBuffer);
				}
			}
		}

		public FText DefaultPlayerName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerName, __ReturnBuffer);

					return *(FText*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultPlayerName, __InBuffer);
				}
			}
		}

		public bool bUseSeamlessTravel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeamlessTravel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseSeamlessTravel, __InBuffer);
				}
			}
		}

		public bool bStartPlayersAsSpectators
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStartPlayersAsSpectators, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStartPlayersAsSpectators, __InBuffer);
				}
			}
		}

		public bool bPauseable
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseable, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPauseable, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.GameModeBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void StartPlay()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __StartPlay);
			}
		}

		/// <param name="NewPlayer">
		/// - Controller for whom this pawn is spawned
		/// </param>
		/// <param name="StartSpot">
		/// - Actor at which to spawn pawn
		/// </param>
		/// <returns>
		/// a pawn of the default pawn class
		/// </returns>
		public virtual APawn SpawnDefaultPawnFor(AController NewPlayer, AActor StartSpot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartSpot?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnDefaultPawnFor, __InBuffer, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <param name="NewPlayer">
		/// - Controller for whom this pawn is spawned
		/// </param>
		/// <param name="SpawnTransform">
		/// - Transform at which to spawn pawn
		/// </param>
		/// <returns>
		/// a pawn of the default pawn class
		/// </returns>
		public virtual APawn SpawnDefaultPawnAtTransform(AController NewPlayer, FTransform SpawnTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnTransform?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnDefaultPawnAtTransform, __InBuffer, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		/// <param name="ActorToReset">
		/// The actor to make a determination for
		/// </param>
		/// <returns>
		/// true if ActorToReset should have Reset() called on it while restarting the game,
		/// false if the GameMode will manually reset it or if the actor does not need to be reset
		/// </returns>
		public virtual bool ShouldReset(AActor ActorToReset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActorToReset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __ShouldReset, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void ReturnToMainMenuHost()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ReturnToMainMenuHost);
			}
		}

		public virtual void RestartPlayerAtTransform(AController NewPlayer, FTransform SpawnTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SpawnTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RestartPlayerAtTransform, __InBuffer);
			}
		}

		public virtual void RestartPlayerAtPlayerStart(AController NewPlayer, AActor StartSpot)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = StartSpot?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RestartPlayerAtPlayerStart, __InBuffer);
			}
		}

		public virtual void RestartPlayer(AController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RestartPlayer, __InBuffer);
			}
		}

		public virtual void ResetLevel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetLevel);
			}
		}

		public virtual bool PlayerCanRestart(APlayerController Player)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __PlayerCanRestart, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool MustSpectate(APlayerController NewPlayerController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayerController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __MustSpectate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void K2_PostLogin(APlayerController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_PostLogin, __InBuffer);
			}
		}

		public virtual void K2_OnSwapPlayerControllers(APlayerController OldPC, APlayerController NewPC)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = OldPC?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPC?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnSwapPlayerControllers, __InBuffer);
			}
		}

		public virtual void K2_OnRestartPlayer(AController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnRestartPlayer, __InBuffer);
			}
		}

		public virtual void K2_OnLogout(AController ExitingController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ExitingController?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnLogout, __InBuffer);
			}
		}

		/// <param name="Controller">
		/// The controller of the player to change the name of
		/// </param>
		/// <param name="NewName">
		/// The name to set the player to
		/// </param>
		/// <param name="bNameChange">
		/// Whether the name is changing or if this is the first time it has been set
		/// </param>
		public virtual void K2_OnChangeName(AController Other, FString NewName, bool bNameChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Other?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bNameChange;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __K2_OnChangeName, __InBuffer);
			}
		}

		/// <param name="Player">
		/// The AController for whom we are choosing a Player Start
		/// </param>
		/// <param name="IncomingName">
		/// Specifies the tag of a Player Start to use
		/// </param>
		/// <returns>
		/// Actor chosen as player start (usually a PlayerStart)
		/// </returns>
		public virtual AActor K2_FindPlayerStart(AController Player, FString IncomingName = null)
		{
			unsafe
			{
				IncomingName ??= new FString("");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = IncomingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __K2_FindPlayerStart, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		public virtual void InitStartSpot(AActor StartSpot, AController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = StartSpot?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitStartSpot, __InBuffer);
			}
		}

		public virtual void InitializeHUDForPlayer(APlayerController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitializeHUDForPlayer, __InBuffer);
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

		public virtual void HandleStartingNewPlayer(APlayerController NewPlayer)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayer?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __HandleStartingNewPlayer, __InBuffer);
			}
		}

		public virtual int GetNumSpectators()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumSpectators, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetNumPlayers()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetNumPlayers, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual UClass GetDefaultPawnClassForController(AController InController)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InController?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetDefaultPawnClassForController, __InBuffer, __ReturnBuffer);

				return *(UClass*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// The AController for whom we are choosing a Player Start
		/// </param>
		/// <param name="IncomingName">
		/// Specifies the tag of a Player Start to use
		/// </param>
		/// <returns>
		/// Actor chosen as player start (usually a PlayerStart)
		/// </returns>
		public virtual AActor FindPlayerStart(AController Player, FString IncomingName)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = IncomingName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindPlayerStart, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="Player">
		/// is the controller for whom we are choosing a playerstart
		/// </param>
		/// <returns>
		/// AActor chosen as player start (usually a PlayerStart)
		/// </returns>
		public virtual AActor ChoosePlayerStart(AController Player)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Player?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __ChoosePlayerStart, __InBuffer, __ReturnBuffer);

				return *(AActor*)__ReturnBuffer;
			}
		}

		/// <param name="Controller">
		/// The controller of the player to change the name of
		/// </param>
		/// <param name="NewName">
		/// The name to set the player to
		/// </param>
		/// <param name="bNameChange">
		/// Whether the name is changing or if this is the first time it has been set
		/// </param>
		public virtual void ChangeName(AController Controller, FString NewName, bool bNameChange)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewName?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 16) = bNameChange;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ChangeName, __InBuffer);
			}
		}

		public virtual bool CanSpectate(APlayerController Viewer, APlayerState ViewTarget)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Viewer?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ViewTarget?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanSpectate, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __OptionsString = 0;

		private static uint __GameSessionClass = 0;

		private static uint __GameStateClass = 0;

		private static uint __PlayerControllerClass = 0;

		private static uint __PlayerStateClass = 0;

		private static uint __HUDClass = 0;

		private static uint __DefaultPawnClass = 0;

		private static uint __SpectatorClass = 0;

		private static uint __ReplaySpectatorPlayerControllerClass = 0;

		private static uint __ServerStatReplicatorClass = 0;

		private static uint __GameSession = 0;

		private static uint __GameState = 0;

		private static uint __ServerStatReplicator = 0;

		private static uint __DefaultPlayerName = 0;

		private static uint __bUseSeamlessTravel = 0;

		private static uint __bStartPlayersAsSpectators = 0;

		private static uint __bPauseable = 0;

		private static uint __StartPlay = 0;

		private static uint __SpawnDefaultPawnFor = 0;

		private static uint __SpawnDefaultPawnAtTransform = 0;

		private static uint __ShouldReset = 0;

		private static uint __ReturnToMainMenuHost = 0;

		private static uint __RestartPlayerAtTransform = 0;

		private static uint __RestartPlayerAtPlayerStart = 0;

		private static uint __RestartPlayer = 0;

		private static uint __ResetLevel = 0;

		private static uint __PlayerCanRestart = 0;

		private static uint __MustSpectate = 0;

		private static uint __K2_PostLogin = 0;

		private static uint __K2_OnSwapPlayerControllers = 0;

		private static uint __K2_OnRestartPlayer = 0;

		private static uint __K2_OnLogout = 0;

		private static uint __K2_OnChangeName = 0;

		private static uint __K2_FindPlayerStart = 0;

		private static uint __InitStartSpot = 0;

		private static uint __InitializeHUDForPlayer = 0;

		private static uint __HasMatchStarted = 0;

		private static uint __HasMatchEnded = 0;

		private static uint __HandleStartingNewPlayer = 0;

		private static uint __GetNumSpectators = 0;

		private static uint __GetNumPlayers = 0;

		private static uint __GetDefaultPawnClassForController = 0;

		private static uint __FindPlayerStart = 0;

		private static uint __ChoosePlayerStart = 0;

		private static uint __ChangeName = 0;

		private static uint __CanSpectate = 0;
	}
}
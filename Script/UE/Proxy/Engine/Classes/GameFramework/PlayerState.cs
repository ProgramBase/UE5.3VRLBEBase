using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlayerState")]
	public partial class APlayerState : AInfo, IStaticClass
	{
		public float Score
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Score, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Score, __InBuffer);
				}
			}
		}

		public int PlayerId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerId, __InBuffer);
				}
			}
		}

		public byte CompressedPing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CompressedPing, __ReturnBuffer);

					return *(byte*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CompressedPing, __InBuffer);
				}
			}
		}

		public bool bShouldUpdateReplicatedPing
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldUpdateReplicatedPing, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldUpdateReplicatedPing, __InBuffer);
				}
			}
		}

		public bool bIsSpectator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsSpectator, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsSpectator, __InBuffer);
				}
			}
		}

		public bool bOnlySpectator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySpectator, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOnlySpectator, __InBuffer);
				}
			}
		}

		public bool bIsABot
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsABot, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsABot, __InBuffer);
				}
			}
		}

		public bool bIsInactive
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInactive, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bIsInactive, __InBuffer);
				}
			}
		}

		public bool bFromPreviousLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bFromPreviousLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bFromPreviousLevel, __InBuffer);
				}
			}
		}

		public int StartTime
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartTime, __InBuffer);
				}
			}
		}

		public TSubclassOf<ULocalMessage> EngineMessageClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EngineMessageClass, __ReturnBuffer);

					return *(TSubclassOf<ULocalMessage>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EngineMessageClass, __InBuffer);
				}
			}
		}

		public FString SavedNetworkAddress
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SavedNetworkAddress, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SavedNetworkAddress, __InBuffer);
				}
			}
		}

		public FUniqueNetIdRepl UniqueId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UniqueId, __ReturnBuffer);

					return *(FUniqueNetIdRepl*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UniqueId, __InBuffer);
				}
			}
		}

		public FOnPlayerStatePawnSet OnPawnSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnPawnSet, __ReturnBuffer);

					return *(FOnPlayerStatePawnSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnPawnSet, __InBuffer);
				}
			}
		}

		public APawn PawnPrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PawnPrivate, __ReturnBuffer);

					return *(APawn*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PawnPrivate, __InBuffer);
				}
			}
		}

		public FString PlayerNamePrivate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerNamePrivate, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PlayerNamePrivate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlayerState");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="OldPlayerState">
		/// Old PlayerState, which we use to fill the new one with
		/// </param>
		public virtual void ReceiveOverrideWith(APlayerState OldPlayerState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = OldPlayerState?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveOverrideWith, __InBuffer);
			}
		}

		/// <param name="NewPlayerState">
		/// New PlayerState, which we fill with the current properties
		/// </param>
		public virtual void ReceiveCopyProperties(APlayerState NewPlayerState)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewPlayerState?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ReceiveCopyProperties, __InBuffer);
			}
		}

		public virtual void OnRep_UniqueId()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_UniqueId);
			}
		}

		public virtual void OnRep_Score()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_Score);
			}
		}

		public virtual void OnRep_PlayerName()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_PlayerName);
			}
		}

		public virtual void OnRep_PlayerId()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_PlayerId);
			}
		}

		public virtual void OnRep_bIsInactive()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __OnRep_bIsInactive);
			}
		}

		public virtual void OnPawnPrivateDestroyed(AActor InActor)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InActor?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __OnPawnPrivateDestroyed, __InBuffer);
			}
		}

		public virtual bool IsSpectator()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSpectator, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsOnlyASpectator()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsOnlyASpectator, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsABot()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsABot, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual float GetScore()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetScore, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual FString GetPlayerName()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPlayerName, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		public virtual int GetPlayerId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPlayerId, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
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

		public virtual float GetPingInMilliseconds()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetPingInMilliseconds, __ReturnBuffer);

				return *(float*)__ReturnBuffer;
			}
		}

		public virtual APawn GetPawn()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetPawn, __ReturnBuffer);

				return *(APawn*)__ReturnBuffer;
			}
		}

		public virtual byte GetCompressedPing()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetCompressedPing, __ReturnBuffer);

				return *(byte*)__ReturnBuffer;
			}
		}

		public virtual FUniqueNetIdRepl BP_GetUniqueId()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __BP_GetUniqueId, __ReturnBuffer);

				return *(FUniqueNetIdRepl*)__ReturnBuffer;
			}
		}

		private static uint __Score = 0;

		private static uint __PlayerId = 0;

		private static uint __CompressedPing = 0;

		private static uint __bShouldUpdateReplicatedPing = 0;

		private static uint __bIsSpectator = 0;

		private static uint __bOnlySpectator = 0;

		private static uint __bIsABot = 0;

		private static uint __bIsInactive = 0;

		private static uint __bFromPreviousLevel = 0;

		private static uint __StartTime = 0;

		private static uint __EngineMessageClass = 0;

		private static uint __SavedNetworkAddress = 0;

		private static uint __UniqueId = 0;

		private static uint __OnPawnSet = 0;

		private static uint __PawnPrivate = 0;

		private static uint __PlayerNamePrivate = 0;

		private static uint __ReceiveOverrideWith = 0;

		private static uint __ReceiveCopyProperties = 0;

		private static uint __OnRep_UniqueId = 0;

		private static uint __OnRep_Score = 0;

		private static uint __OnRep_PlayerName = 0;

		private static uint __OnRep_PlayerId = 0;

		private static uint __OnRep_bIsInactive = 0;

		private static uint __OnPawnPrivateDestroyed = 0;

		private static uint __IsSpectator = 0;

		private static uint __IsOnlyASpectator = 0;

		private static uint __IsABot = 0;

		private static uint __GetScore = 0;

		private static uint __GetPlayerName = 0;

		private static uint __GetPlayerId = 0;

		private static uint __GetPlayerController = 0;

		private static uint __GetPingInMilliseconds = 0;

		private static uint __GetPawn = 0;

		private static uint __GetCompressedPing = 0;

		private static uint __BP_GetUniqueId = 0;
	}
}
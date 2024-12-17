using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.PartyBeaconClient")]
	public partial class APartyBeaconClient : AOnlineBeaconClient, IStaticClass
	{
		public FString DestSessionId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DestSessionId, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DestSessionId, __InBuffer);
				}
			}
		}

		public FPartyReservation PendingReservation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PendingReservation, __ReturnBuffer);

					return *(FPartyReservation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PendingReservation, __InBuffer);
				}
			}
		}

		public EClientRequestType RequestType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RequestType, __ReturnBuffer);

					return *(EClientRequestType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RequestType, __InBuffer);
				}
			}
		}

		public bool bPendingReservationSent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPendingReservationSent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPendingReservationSent, __InBuffer);
				}
			}
		}

		public bool bCancelReservation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelReservation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCancelReservation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/OnlineSubsystemUtils.PartyBeaconClient");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="SessionId">
		/// expected session id on the other end (must match)
		/// </param>
		/// <param name="ReservationUpdate">
		/// pending reservation request to make with server
		/// </param>
		public virtual void ServerUpdateReservationRequest(FString SessionId, FPartyReservation ReservationUpdate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SessionId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReservationUpdate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerUpdateReservationRequest, __InBuffer);
			}
		}

		/// <param name="SessionId">
		/// expected session id on the other end (must match)
		/// </param>
		/// <param name="Reservation">
		/// pending reservation request to make with server
		/// </param>
		public virtual void ServerReservationRequest(FString SessionId, FPartyReservation Reservation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SessionId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Reservation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerReservationRequest, __InBuffer);
			}
		}

		/// <param name="SessionId">
		/// expected session id on the other end (must match)
		/// </param>
		/// <param name="ReservationUpdate">
		/// pending reservation request to make with server
		/// </param>
		public virtual void ServerRemoveMemberFromReservationRequest(FString SessionId, FPartyReservation ReservationUpdate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SessionId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = ReservationUpdate?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerRemoveMemberFromReservationRequest, __InBuffer);
			}
		}

		/// <param name="PartyLeader">
		/// id of the party leader for the reservation to cancel
		/// </param>
		public virtual void ServerCancelReservationRequest(FUniqueNetIdRepl PartyLeader)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = PartyLeader?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerCancelReservationRequest, __InBuffer);
			}
		}

		/// <param name="SessionId">
		/// expected session id on the other end (must match)
		/// </param>
		/// <param name="ReservationUpdate">
		/// pending reservation request to make with server
		/// </param>
		public virtual void ServerAddOrUpdateReservationRequest(FString SessionId, FPartyReservation Reservation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = SessionId?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Reservation?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ServerAddOrUpdateReservationRequest, __InBuffer);
			}
		}

		/// <param name="NumRemainingReservations">
		/// number of slots remaining until a full session
		/// </param>
		public virtual void ClientSendReservationUpdates(int NumRemainingReservations)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NumRemainingReservations;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientSendReservationUpdates, __InBuffer);
			}
		}

		public virtual void ClientSendReservationFull()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall24Implementation(GarbageCollectionHandle, __ClientSendReservationFull);
			}
		}

		/// <param name="ReservationResponse">
		/// response from server
		/// </param>
		public virtual void ClientReservationResponse(EPartyReservationResult ReservationResponse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ReservationResponse;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientReservationResponse, __InBuffer);
			}
		}

		/// <param name="ReservationResponse">
		/// response from server
		/// </param>
		public virtual void ClientCancelReservationResponse(EPartyReservationResult ReservationResponse)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)ReservationResponse;

				FFunctionImplementation.FFunction_GenericCall26Implementation(GarbageCollectionHandle, __ClientCancelReservationResponse, __InBuffer);
			}
		}

		private static uint __DestSessionId = 0;

		private static uint __PendingReservation = 0;

		private static uint __RequestType = 0;

		private static uint __bPendingReservationSent = 0;

		private static uint __bCancelReservation = 0;

		private static uint __ServerUpdateReservationRequest = 0;

		private static uint __ServerReservationRequest = 0;

		private static uint __ServerRemoveMemberFromReservationRequest = 0;

		private static uint __ServerCancelReservationRequest = 0;

		private static uint __ServerAddOrUpdateReservationRequest = 0;

		private static uint __ClientSendReservationUpdates = 0;

		private static uint __ClientSendReservationFull = 0;

		private static uint __ClientReservationResponse = 0;

		private static uint __ClientCancelReservationResponse = 0;
	}
}
using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.PartyReservation")]
	public partial class FPartyReservation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystemUtils.PartyReservation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPartyReservation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPartyReservation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPartyReservation A, FPartyReservation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPartyReservation A, FPartyReservation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPartyReservation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public int TeamNum
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __TeamNum, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __TeamNum, __InBuffer);
				}
			}
		}

		public FUniqueNetIdRepl PartyLeader
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PartyLeader, __ReturnBuffer);

					return *(FUniqueNetIdRepl*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PartyLeader, __InBuffer);
				}
			}
		}

		public TArray<FPlayerReservation> PartyMembers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PartyMembers, __ReturnBuffer);

					return *(TArray<FPlayerReservation>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PartyMembers, __InBuffer);
				}
			}
		}

		public TArray<FPlayerReservation> RemovedPartyMembers
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __RemovedPartyMembers, __ReturnBuffer);

					return *(TArray<FPlayerReservation>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __RemovedPartyMembers, __InBuffer);
				}
			}
		}

		private static uint __TeamNum = 0;

		private static uint __PartyLeader = 0;

		private static uint __PartyMembers = 0;

		private static uint __RemovedPartyMembers = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
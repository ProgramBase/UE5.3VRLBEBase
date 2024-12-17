using Script.CoreUObject;
using Script.Library;
using Script.Engine;

namespace Script.OnlineSubsystemUtils
{
	[PathName("/Script/OnlineSubsystemUtils.SpectatorReservation")]
	public partial class FSpectatorReservation : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/OnlineSubsystemUtils.SpectatorReservation");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FSpectatorReservation() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FSpectatorReservation() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FSpectatorReservation A, FSpectatorReservation B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FSpectatorReservation A, FSpectatorReservation B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FSpectatorReservation;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FUniqueNetIdRepl SpectatorId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SpectatorId, __ReturnBuffer);

					return *(FUniqueNetIdRepl*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SpectatorId, __InBuffer);
				}
			}
		}

		public FPlayerReservation Spectator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Spectator, __ReturnBuffer);

					return *(FPlayerReservation*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Spectator, __InBuffer);
				}
			}
		}

		private static uint __SpectatorId = 0;

		private static uint __Spectator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
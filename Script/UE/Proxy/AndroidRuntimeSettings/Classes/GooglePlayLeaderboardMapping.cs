using Script.CoreUObject;
using Script.Library;

namespace Script.AndroidRuntimeSettings
{
	[PathName("/Script/AndroidRuntimeSettings.GooglePlayLeaderboardMapping")]
	public partial class FGooglePlayLeaderboardMapping : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/AndroidRuntimeSettings.GooglePlayLeaderboardMapping");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FGooglePlayLeaderboardMapping() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FGooglePlayLeaderboardMapping() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FGooglePlayLeaderboardMapping A, FGooglePlayLeaderboardMapping B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FGooglePlayLeaderboardMapping A, FGooglePlayLeaderboardMapping B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FGooglePlayLeaderboardMapping;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Name
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Name, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Name, __InBuffer);
				}
			}
		}

		public FString LeaderboardID
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __LeaderboardID, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __LeaderboardID, __InBuffer);
				}
			}
		}

		private static uint __Name = 0;

		private static uint __LeaderboardID = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
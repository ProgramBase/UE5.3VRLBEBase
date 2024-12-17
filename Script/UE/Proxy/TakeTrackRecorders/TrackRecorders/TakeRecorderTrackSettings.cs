using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.TakeRecorderTrackSettings")]
	public partial class FTakeRecorderTrackSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TakeTrackRecorders.TakeRecorderTrackSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTakeRecorderTrackSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTakeRecorderTrackSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTakeRecorderTrackSettings A, FTakeRecorderTrackSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTakeRecorderTrackSettings A, FTakeRecorderTrackSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTakeRecorderTrackSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FSoftClassPath MatchingActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MatchingActorClass, __ReturnBuffer);

					return *(FSoftClassPath*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MatchingActorClass, __InBuffer);
				}
			}
		}

		public TArray<FTakeRecorderPropertyTrackSettings> DefaultPropertyTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPropertyTracks, __ReturnBuffer);

					return *(TArray<FTakeRecorderPropertyTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DefaultPropertyTracks, __InBuffer);
				}
			}
		}

		public TArray<FTakeRecorderPropertyTrackSettings> ExcludePropertyTracks
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ExcludePropertyTracks, __ReturnBuffer);

					return *(TArray<FTakeRecorderPropertyTrackSettings>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ExcludePropertyTracks, __InBuffer);
				}
			}
		}

		private static uint __MatchingActorClass = 0;

		private static uint __DefaultPropertyTracks = 0;

		private static uint __ExcludePropertyTracks = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
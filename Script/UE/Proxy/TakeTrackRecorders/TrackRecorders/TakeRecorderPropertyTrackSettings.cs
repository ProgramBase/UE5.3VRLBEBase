using Script.CoreUObject;
using Script.Library;

namespace Script.TakeTrackRecorders
{
	[PathName("/Script/TakeTrackRecorders.TakeRecorderPropertyTrackSettings")]
	public partial class FTakeRecorderPropertyTrackSettings : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TakeTrackRecorders.TakeRecorderPropertyTrackSettings");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTakeRecorderPropertyTrackSettings() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTakeRecorderPropertyTrackSettings() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTakeRecorderPropertyTrackSettings A, FTakeRecorderPropertyTrackSettings B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTakeRecorderPropertyTrackSettings A, FTakeRecorderPropertyTrackSettings B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTakeRecorderPropertyTrackSettings;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString ComponentPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ComponentPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ComponentPath, __InBuffer);
				}
			}
		}

		public FString PropertyPath
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PropertyPath, __InBuffer);
				}
			}
		}

		private static uint __ComponentPath = 0;

		private static uint __PropertyPath = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
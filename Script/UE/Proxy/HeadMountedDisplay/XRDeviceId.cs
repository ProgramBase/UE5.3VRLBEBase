using Script.CoreUObject;
using Script.Library;

namespace Script.HeadMountedDisplay
{
	[PathName("/Script/HeadMountedDisplay.XRDeviceId")]
	public partial class FXRDeviceId : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/HeadMountedDisplay.XRDeviceId");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FXRDeviceId() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FXRDeviceId() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FXRDeviceId A, FXRDeviceId B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FXRDeviceId A, FXRDeviceId B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FXRDeviceId;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName SystemName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SystemName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SystemName, __InBuffer);
				}
			}
		}

		public int DeviceId
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceId, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceId, __InBuffer);
				}
			}
		}

		private static uint __SystemName = 0;

		private static uint __DeviceId = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
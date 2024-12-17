using Script.Library;

namespace Script.CoreUObject
{
	[PathName("/Script/CoreUObject.PlatformInputDeviceState")]
	public partial class FPlatformInputDeviceState : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/CoreUObject.PlatformInputDeviceState");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPlatformInputDeviceState() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPlatformInputDeviceState() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPlatformInputDeviceState A, FPlatformInputDeviceState B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPlatformInputDeviceState A, FPlatformInputDeviceState B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPlatformInputDeviceState;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FPlatformUserId OwningPlatformUser
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __OwningPlatformUser, __ReturnBuffer);

					return *(FPlatformUserId*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __OwningPlatformUser, __InBuffer);
				}
			}
		}

		public EInputDeviceConnectionState ConnectionState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __ConnectionState, __ReturnBuffer);

					return *(EInputDeviceConnectionState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __ConnectionState, __InBuffer);
				}
			}
		}

		private static uint __OwningPlatformUser = 0;

		private static uint __ConnectionState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
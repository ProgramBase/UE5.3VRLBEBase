using Script.CoreUObject;
using Script.Library;

namespace Script.TargetDeviceServices
{
	[PathName("/Script/TargetDeviceServices.TargetDeviceClaimDenied")]
	public partial class FTargetDeviceClaimDenied : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TargetDeviceServices.TargetDeviceClaimDenied");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetDeviceClaimDenied() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetDeviceClaimDenied() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetDeviceClaimDenied A, FTargetDeviceClaimDenied B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetDeviceClaimDenied A, FTargetDeviceClaimDenied B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetDeviceClaimDenied;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DeviceName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceName, __InBuffer);
				}
			}
		}

		public FString HostName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HostName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HostName, __InBuffer);
				}
			}
		}

		public FString HostUser
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HostUser, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HostUser, __InBuffer);
				}
			}
		}

		private static uint __DeviceName = 0;

		private static uint __HostName = 0;

		private static uint __HostUser = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
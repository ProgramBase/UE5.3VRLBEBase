using Script.CoreUObject;
using Script.Library;

namespace Script.TargetDeviceServices
{
	[PathName("/Script/TargetDeviceServices.TargetDeviceServicePing")]
	public partial class FTargetDeviceServicePing : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TargetDeviceServices.TargetDeviceServicePing");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetDeviceServicePing() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetDeviceServicePing() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetDeviceServicePing A, FTargetDeviceServicePing B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetDeviceServicePing A, FTargetDeviceServicePing B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetDeviceServicePing;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

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

		private static uint __HostUser = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
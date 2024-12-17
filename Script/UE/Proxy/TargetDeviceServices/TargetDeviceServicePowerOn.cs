using Script.CoreUObject;
using Script.Library;

namespace Script.TargetDeviceServices
{
	[PathName("/Script/TargetDeviceServices.TargetDeviceServicePowerOn")]
	public partial class FTargetDeviceServicePowerOn : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TargetDeviceServices.TargetDeviceServicePowerOn");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetDeviceServicePowerOn() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetDeviceServicePowerOn() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetDeviceServicePowerOn A, FTargetDeviceServicePowerOn B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetDeviceServicePowerOn A, FTargetDeviceServicePowerOn B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetDeviceServicePowerOn;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString Operator
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Operator, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Operator, __InBuffer);
				}
			}
		}

		private static uint __Operator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
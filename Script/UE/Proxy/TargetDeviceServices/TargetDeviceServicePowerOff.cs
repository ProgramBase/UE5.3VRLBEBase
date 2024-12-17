using Script.CoreUObject;
using Script.Library;

namespace Script.TargetDeviceServices
{
	[PathName("/Script/TargetDeviceServices.TargetDeviceServicePowerOff")]
	public partial class FTargetDeviceServicePowerOff : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/TargetDeviceServices.TargetDeviceServicePowerOff");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FTargetDeviceServicePowerOff() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FTargetDeviceServicePowerOff() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FTargetDeviceServicePowerOff A, FTargetDeviceServicePowerOff B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FTargetDeviceServicePowerOff A, FTargetDeviceServicePowerOff B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FTargetDeviceServicePowerOff;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Force
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Force, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Force, __InBuffer);
				}
			}
		}

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

		private static uint __Force = 0;

		private static uint __Operator = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
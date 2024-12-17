using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.PIEIOSDeviceProperties")]
	public partial class FPIEIOSDeviceProperties : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceSpecification.PIEIOSDeviceProperties");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIEIOSDeviceProperties() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPIEIOSDeviceProperties() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPIEIOSDeviceProperties A, FPIEIOSDeviceProperties B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIEIOSDeviceProperties A, FPIEIOSDeviceProperties B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIEIOSDeviceProperties;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DeviceModel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceModel, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceModel, __InBuffer);
				}
			}
		}

		public float NativeScaleFactor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __NativeScaleFactor, __ReturnBuffer);

					return *(float*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(float*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __NativeScaleFactor, __InBuffer);
				}
			}
		}

		public FPIERHIOverrideState MetalRHIState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __MetalRHIState, __ReturnBuffer);

					return *(FPIERHIOverrideState*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __MetalRHIState, __InBuffer);
				}
			}
		}

		private static uint __DeviceModel = 0;

		private static uint __NativeScaleFactor = 0;

		private static uint __MetalRHIState = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
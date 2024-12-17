using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.PIEBezelProperties")]
	public partial class FPIEBezelProperties : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceSpecification.PIEBezelProperties");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIEBezelProperties() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPIEBezelProperties() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPIEBezelProperties A, FPIEBezelProperties B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIEBezelProperties A, FPIEBezelProperties B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIEBezelProperties;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FString DeviceBezelFile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __DeviceBezelFile, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __DeviceBezelFile, __InBuffer);
				}
			}
		}

		public FPIEPreviewDeviceBezelViewportRect BezelViewportRect
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __BezelViewportRect, __ReturnBuffer);

					return *(FPIEPreviewDeviceBezelViewportRect*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __BezelViewportRect, __InBuffer);
				}
			}
		}

		private static uint __DeviceBezelFile = 0;

		private static uint __BezelViewportRect = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
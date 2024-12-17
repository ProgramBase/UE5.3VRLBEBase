using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.HardwareDeviceIdentifier")]
	public partial class FHardwareDeviceIdentifier : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.HardwareDeviceIdentifier");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FHardwareDeviceIdentifier() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FHardwareDeviceIdentifier() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FHardwareDeviceIdentifier A, FHardwareDeviceIdentifier B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FHardwareDeviceIdentifier A, FHardwareDeviceIdentifier B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FHardwareDeviceIdentifier;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public FName InputClassName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __InputClassName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __InputClassName, __InBuffer);
				}
			}
		}

		public FName HardwareDeviceIdentifier
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __HardwareDeviceIdentifier, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __HardwareDeviceIdentifier, __InBuffer);
				}
			}
		}

		public EHardwareDevicePrimaryType PrimaryDeviceType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryDeviceType, __ReturnBuffer);

					return *(EHardwareDevicePrimaryType*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __PrimaryDeviceType, __InBuffer);
				}
			}
		}

		public int SupportedFeaturesMask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __SupportedFeaturesMask, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __SupportedFeaturesMask, __InBuffer);
				}
			}
		}

		private static uint __InputClassName = 0;

		private static uint __HardwareDeviceIdentifier = 0;

		private static uint __PrimaryDeviceType = 0;

		private static uint __SupportedFeaturesMask = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
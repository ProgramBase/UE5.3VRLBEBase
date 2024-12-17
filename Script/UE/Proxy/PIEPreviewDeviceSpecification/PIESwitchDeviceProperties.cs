using Script.CoreUObject;
using Script.Library;

namespace Script.PIEPreviewDeviceSpecification
{
	[PathName("/Script/PIEPreviewDeviceSpecification.PIESwitchDeviceProperties")]
	public partial class FPIESwitchDeviceProperties : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/PIEPreviewDeviceSpecification.PIESwitchDeviceProperties");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FPIESwitchDeviceProperties() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FPIESwitchDeviceProperties() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FPIESwitchDeviceProperties A, FPIESwitchDeviceProperties B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FPIESwitchDeviceProperties A, FPIESwitchDeviceProperties B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FPIESwitchDeviceProperties;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public bool Docked
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Docked, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Docked, __InBuffer);
				}
			}
		}

		private static uint __Docked = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
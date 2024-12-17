using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ActiveDeviceProperty")]
	public partial class FActiveDeviceProperty : IStaticStruct, IGarbageCollectionHandle
	{
		public static UScriptStruct StaticStruct()
		{
			return StaticStructSingleton ??= UStructImplementation.UStruct_StaticStructImplementation("/Script/Engine.ActiveDeviceProperty");
		}

		private static UScriptStruct StaticStructSingleton { get; set; }

		public FActiveDeviceProperty() => UStructImplementation.UStruct_RegisterImplementation(this, Utils.GetPathName(GetType()));

		~FActiveDeviceProperty() => UStructImplementation.UStruct_UnRegisterImplementation(GarbageCollectionHandle);

		public static bool operator ==(FActiveDeviceProperty A, FActiveDeviceProperty B) => Utils.EqualsTo(A, B, UStructImplementation.UStruct_IdenticalImplementation);

		public static bool operator !=(FActiveDeviceProperty A, FActiveDeviceProperty B) => !(A == B);

		public override bool Equals(object Other) => this == Other as FActiveDeviceProperty;

		public override int GetHashCode() => (int)GarbageCollectionHandle;

		public TWeakObjectPtr<UInputDeviceProperty> Property
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetStructPropertyImplementation(GarbageCollectionHandle, __Property, __ReturnBuffer);

					return *(TWeakObjectPtr<UInputDeviceProperty>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetStructPropertyImplementation(GarbageCollectionHandle, __Property, __InBuffer);
				}
			}
		}

		private static uint __Property = 0;

		public nint GarbageCollectionHandle { get; set; }
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.LocationServicesBPLibrary
{
	[PathName("/Script/LocationServicesBPLibrary.LocationServicesImpl")]
	public partial class ULocationServicesImpl : UObject, IStaticClass
	{
		public FLocationServicesData_OnLocationChanged OnLocationChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLocationChanged, __ReturnBuffer);

					return *(FLocationServicesData_OnLocationChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLocationChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LocationServicesBPLibrary.LocationServicesImpl");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __OnLocationChanged = 0;
	}
}
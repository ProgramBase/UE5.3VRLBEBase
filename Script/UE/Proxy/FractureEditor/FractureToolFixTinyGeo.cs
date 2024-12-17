using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolFixTinyGeo")]
	public partial class UFractureToolFixTinyGeo : UFractureToolCutterBase, IStaticClass
	{
		public UFractureTinyGeoSettings TinyGeoSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __TinyGeoSettings, __ReturnBuffer);

					return *(UFractureTinyGeoSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __TinyGeoSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolFixTinyGeo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __TinyGeoSettings = 0;
	}
}
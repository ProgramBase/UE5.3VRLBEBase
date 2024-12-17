using Script.CoreUObject;
using Script.AudioExtensions;
using Script.Library;

namespace Script.SoundFields
{
	[PathName("/Script/SoundFields.AmbisonicsEncodingSettings")]
	public partial class UAmbisonicsEncodingSettings : USoundfieldEncodingSettingsBase, IStaticClass
	{
		public int AmbisonicsOrder
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AmbisonicsOrder, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AmbisonicsOrder, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SoundFields.AmbisonicsEncodingSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AmbisonicsOrder = 0;
	}
}
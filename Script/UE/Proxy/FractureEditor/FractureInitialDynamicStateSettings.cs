using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureInitialDynamicStateSettings")]
	public partial class UFractureInitialDynamicStateSettings : UFractureToolSettings, IStaticClass
	{
		public EDynamicStateOverrideEnum InitialDynamicState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDynamicState, __ReturnBuffer);

					return *(EDynamicStateOverrideEnum*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __InitialDynamicState, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureInitialDynamicStateSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __InitialDynamicState = 0;
	}
}
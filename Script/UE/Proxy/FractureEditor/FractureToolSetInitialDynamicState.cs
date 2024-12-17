using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSetInitialDynamicState")]
	public partial class UFractureToolSetInitialDynamicState : UFractureModalTool, IStaticClass
	{
		public UFractureInitialDynamicStateSettings StateSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StateSettings, __ReturnBuffer);

					return *(UFractureInitialDynamicStateSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StateSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSetInitialDynamicState");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __StateSettings = 0;
	}
}
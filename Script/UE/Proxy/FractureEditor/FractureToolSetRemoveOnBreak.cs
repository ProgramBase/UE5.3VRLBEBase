using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSetRemoveOnBreak")]
	public partial class UFractureToolSetRemoveOnBreak : UFractureModalTool, IStaticClass
	{
		public UFractureRemoveOnBreakSettings RemoveOnBreakSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RemoveOnBreakSettings, __ReturnBuffer);

					return *(UFractureRemoveOnBreakSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RemoveOnBreakSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSetRemoveOnBreak");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __RemoveOnBreakSettings = 0;
	}
}
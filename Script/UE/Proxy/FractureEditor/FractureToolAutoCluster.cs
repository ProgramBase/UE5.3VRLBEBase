using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolAutoCluster")]
	public partial class UFractureToolAutoCluster : UFractureModalTool, IStaticClass
	{
		public UFractureAutoClusterSettings AutoClusterSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutoClusterSettings, __ReturnBuffer);

					return *(UFractureAutoClusterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutoClusterSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolAutoCluster");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AutoClusterSettings = 0;
	}
}
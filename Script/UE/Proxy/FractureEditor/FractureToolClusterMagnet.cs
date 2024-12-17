using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolClusterMagnet")]
	public partial class UFractureToolClusterMagnet : UFractureModalTool, IStaticClass
	{
		public UFractureClusterMagnetSettings ClusterMagnetSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterMagnetSettings, __ReturnBuffer);

					return *(UFractureClusterMagnetSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterMagnetSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolClusterMagnet");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ClusterMagnetSettings = 0;
	}
}
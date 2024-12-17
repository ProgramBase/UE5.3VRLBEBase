using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolClusterCutter")]
	public partial class UFractureToolClusterCutter : UFractureToolVoronoiCutterBase, IStaticClass
	{
		public UFractureClusterCutterSettings ClusterSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterSettings, __ReturnBuffer);

					return *(UFractureClusterCutterSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ClusterSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolClusterCutter");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ClusterSettings = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureUniformSettings")]
	public partial class UFractureUniformSettings : UFractureToolSettings, IStaticClass
	{
		public int NumberVoronoiSitesMin
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumberVoronoiSitesMin, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumberVoronoiSitesMin, __InBuffer);
				}
			}
		}

		public int NumberVoronoiSitesMax
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NumberVoronoiSitesMax, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NumberVoronoiSitesMax, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureUniformSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __NumberVoronoiSitesMin = 0;

		private static uint __NumberVoronoiSitesMax = 0;
	}
}
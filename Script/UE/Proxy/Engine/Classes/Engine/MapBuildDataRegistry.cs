using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.MapBuildDataRegistry")]
	public partial class UMapBuildDataRegistry : UObject, IStaticClass
	{
		public ELightingBuildQuality LevelLightingQuality
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LevelLightingQuality, __ReturnBuffer);

					return *(ELightingBuildQuality*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LevelLightingQuality, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.MapBuildDataRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __LevelLightingQuality = 0;
	}
}
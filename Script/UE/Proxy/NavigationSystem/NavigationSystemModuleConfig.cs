using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.NavigationSystem
{
	[PathName("/Script/NavigationSystem.NavigationSystemModuleConfig")]
	public partial class UNavigationSystemModuleConfig : UNavigationSystemConfig, IStaticClass
	{
		public bool bStrictlyStatic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStrictlyStatic, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStrictlyStatic, __InBuffer);
				}
			}
		}

		public bool bCreateOnClient
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateOnClient, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateOnClient, __InBuffer);
				}
			}
		}

		public bool bAutoSpawnMissingNavData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoSpawnMissingNavData, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bAutoSpawnMissingNavData, __InBuffer);
				}
			}
		}

		public bool bSpawnNavDataInNavBoundsLevel
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSpawnNavDataInNavBoundsLevel, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSpawnNavDataInNavBoundsLevel, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/NavigationSystem.NavigationSystemModuleConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bStrictlyStatic = 0;

		private static uint __bCreateOnClient = 0;

		private static uint __bAutoSpawnMissingNavData = 0;

		private static uint __bSpawnNavDataInNavBoundsLevel = 0;
	}
}
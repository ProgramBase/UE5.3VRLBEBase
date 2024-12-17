using Script.CoreUObject;
using Script.Engine.ApplicationLifecycleComponent;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ApplicationLifecycleComponent")]
	public partial class UApplicationLifecycleComponent : UActorComponent, IStaticClass
	{
		public FApplicationLifetimeDelegate ApplicationWillDeactivateDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillDeactivateDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillDeactivateDelegate, __InBuffer);
				}
			}
		}

		public FApplicationLifetimeDelegate ApplicationHasReactivatedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasReactivatedDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasReactivatedDelegate, __InBuffer);
				}
			}
		}

		public FApplicationLifetimeDelegate ApplicationWillEnterBackgroundDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillEnterBackgroundDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillEnterBackgroundDelegate, __InBuffer);
				}
			}
		}

		public FApplicationLifetimeDelegate ApplicationHasEnteredForegroundDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasEnteredForegroundDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasEnteredForegroundDelegate, __InBuffer);
				}
			}
		}

		public FApplicationLifetimeDelegate ApplicationWillTerminateDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillTerminateDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillTerminateDelegate, __InBuffer);
				}
			}
		}

		public FApplicationLifetimeDelegate ApplicationShouldUnloadResourcesDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationShouldUnloadResourcesDelegate, __ReturnBuffer);

					return *(FApplicationLifetimeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationShouldUnloadResourcesDelegate, __InBuffer);
				}
			}
		}

		public FApplicationStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedStartupArgumentsDelegate, __ReturnBuffer);

					return *(FApplicationStartupArgumentsDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedStartupArgumentsDelegate, __InBuffer);
				}
			}
		}

		public FOnTemperatureChangeDelegate OnTemperatureChangeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnTemperatureChangeDelegate, __ReturnBuffer);

					return *(FOnTemperatureChangeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnTemperatureChangeDelegate, __InBuffer);
				}
			}
		}

		public FOnLowPowerModeDelegate OnLowPowerModeDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnLowPowerModeDelegate, __ReturnBuffer);

					return *(FOnLowPowerModeDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnLowPowerModeDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ApplicationLifecycleComponent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ApplicationWillDeactivateDelegate = 0;

		private static uint __ApplicationHasReactivatedDelegate = 0;

		private static uint __ApplicationWillEnterBackgroundDelegate = 0;

		private static uint __ApplicationHasEnteredForegroundDelegate = 0;

		private static uint __ApplicationWillTerminateDelegate = 0;

		private static uint __ApplicationShouldUnloadResourcesDelegate = 0;

		private static uint __ApplicationReceivedStartupArgumentsDelegate = 0;

		private static uint __OnTemperatureChangeDelegate = 0;

		private static uint __OnLowPowerModeDelegate = 0;
	}
}
using Script.CoreUObject;
using Script.Engine.PlatformGameInstance;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.PlatformGameInstance")]
	public partial class UPlatformGameInstance : UGameInstance, IStaticClass
	{
		public FPlatformDelegate ApplicationWillDeactivateDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillDeactivateDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformDelegate ApplicationHasReactivatedDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasReactivatedDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformDelegate ApplicationWillEnterBackgroundDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillEnterBackgroundDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformDelegate ApplicationHasEnteredForegroundDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationHasEnteredForegroundDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformDelegate ApplicationWillTerminateDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationWillTerminateDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformDelegate ApplicationShouldUnloadResourcesDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationShouldUnloadResourcesDelegate, __ReturnBuffer);

					return *(FPlatformDelegate*)__ReturnBuffer;
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

		public FPlatformStartupArgumentsDelegate ApplicationReceivedStartupArgumentsDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedStartupArgumentsDelegate, __ReturnBuffer);

					return *(FPlatformStartupArgumentsDelegate*)__ReturnBuffer;
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

		public FPlatformRegisteredForRemoteNotificationsDelegate ApplicationRegisteredForRemoteNotificationsDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationRegisteredForRemoteNotificationsDelegate, __ReturnBuffer);

					return *(FPlatformRegisteredForRemoteNotificationsDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationRegisteredForRemoteNotificationsDelegate, __InBuffer);
				}
			}
		}

		public FPlatformRegisteredForUserNotificationsDelegate ApplicationRegisteredForUserNotificationsDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationRegisteredForUserNotificationsDelegate, __ReturnBuffer);

					return *(FPlatformRegisteredForUserNotificationsDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationRegisteredForUserNotificationsDelegate, __InBuffer);
				}
			}
		}

		public FPlatformFailedToRegisterForRemoteNotificationsDelegate ApplicationFailedToRegisterForRemoteNotificationsDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationFailedToRegisterForRemoteNotificationsDelegate, __ReturnBuffer);

					return *(FPlatformFailedToRegisterForRemoteNotificationsDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationFailedToRegisterForRemoteNotificationsDelegate, __InBuffer);
				}
			}
		}

		public FPlatformReceivedRemoteNotificationDelegate ApplicationReceivedRemoteNotificationDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedRemoteNotificationDelegate, __ReturnBuffer);

					return *(FPlatformReceivedRemoteNotificationDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedRemoteNotificationDelegate, __InBuffer);
				}
			}
		}

		public FPlatformReceivedLocalNotificationDelegate ApplicationReceivedLocalNotificationDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedLocalNotificationDelegate, __ReturnBuffer);

					return *(FPlatformReceivedLocalNotificationDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedLocalNotificationDelegate, __InBuffer);
				}
			}
		}

		public FPlatformScreenOrientationChangedDelegate ApplicationReceivedScreenOrientationChangedNotificationDelegate
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedScreenOrientationChangedNotificationDelegate, __ReturnBuffer);

					return *(FPlatformScreenOrientationChangedDelegate*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ApplicationReceivedScreenOrientationChangedNotificationDelegate, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.PlatformGameInstance");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ApplicationWillDeactivateDelegate = 0;

		private static uint __ApplicationHasReactivatedDelegate = 0;

		private static uint __ApplicationWillEnterBackgroundDelegate = 0;

		private static uint __ApplicationHasEnteredForegroundDelegate = 0;

		private static uint __ApplicationWillTerminateDelegate = 0;

		private static uint __ApplicationShouldUnloadResourcesDelegate = 0;

		private static uint __ApplicationReceivedStartupArgumentsDelegate = 0;

		private static uint __ApplicationRegisteredForRemoteNotificationsDelegate = 0;

		private static uint __ApplicationRegisteredForUserNotificationsDelegate = 0;

		private static uint __ApplicationFailedToRegisterForRemoteNotificationsDelegate = 0;

		private static uint __ApplicationReceivedRemoteNotificationDelegate = 0;

		private static uint __ApplicationReceivedLocalNotificationDelegate = 0;

		private static uint __ApplicationReceivedScreenOrientationChangedNotificationDelegate = 0;
	}
}
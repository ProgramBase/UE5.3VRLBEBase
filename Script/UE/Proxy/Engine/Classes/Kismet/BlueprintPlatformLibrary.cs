using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.BlueprintPlatformLibrary")]
	public partial class UBlueprintPlatformLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.BlueprintPlatformLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void SetAllowedDeviceOrientation(EScreenOrientation NewAllowedDeviceOrientation)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)NewAllowedDeviceOrientation;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __SetAllowedDeviceOrientation, __InBuffer);
			}
		}

		/// <param name="inSecondsFromNow">
		/// The seconds until the notification should fire
		/// </param>
		/// <param name="LocalTime">
		/// If true the provided time is in the local timezone, if false it is in UTC
		/// </param>
		/// <param name="Title">
		/// The title of the notification
		/// </param>
		/// <param name="Body">
		/// The more detailed description of the notification
		/// </param>
		/// <param name="Action">
		/// The text to be displayed on the slider controller
		/// </param>
		/// <param name="ActivationEvent">
		/// A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </param>
		public static int ScheduleLocalNotificationFromNow(int inSecondsFromNow, FText Title, FText Body, FText Action, FString ActivationEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[36];

				*(int*)(__InBuffer) = inSecondsFromNow;

				*(nint*)(__InBuffer + 4) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 12) = Body?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 20) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 28) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ScheduleLocalNotificationFromNow, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="inSecondsFromNow">
		/// The seconds until the notification should fire
		/// </param>
		/// <param name="ActivationEvent">
		/// A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </param>
		public static void ScheduleLocalNotificationBadgeFromNow(int inSecondsFromNow, FString ActivationEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(int*)(__InBuffer) = inSecondsFromNow;

				*(nint*)(__InBuffer + 4) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __ScheduleLocalNotificationBadgeFromNow, __InBuffer);
			}
		}

		/// <param name="FireDateTime">
		/// The time at which to fire the local notification
		/// </param>
		/// <param name="LocalTime">
		/// If true the provided time is in the local timezone, if false it is in UTC
		/// </param>
		/// <param name="ActivationEvent">
		/// A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </param>
		public static int ScheduleLocalNotificationBadgeAtTime(FDateTime FireDateTime, bool LocalTime, FString ActivationEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[17];

				*(nint*)(__InBuffer) = FireDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = LocalTime;

				*(nint*)(__InBuffer + 9) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ScheduleLocalNotificationBadgeAtTime, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="FireDateTime">
		/// The time at which to fire the local notification
		/// </param>
		/// <param name="LocalTime">
		/// If true the provided time is in the local timezone, if false it is in UTC
		/// </param>
		/// <param name="Title">
		/// The title of the notification
		/// </param>
		/// <param name="Body">
		/// The more detailed description of the notification
		/// </param>
		/// <param name="Action">
		/// The text to be displayed on the slider controller
		/// </param>
		/// <param name="ActivationEvent">
		/// A string that is passed in the delegate callback when the app is brought into the foreground from the user activating the notification
		/// </param>
		public static int ScheduleLocalNotificationAtTime(FDateTime FireDateTime, bool LocalTime, FText Title, FText Body, FText Action, FString ActivationEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[41];

				*(nint*)(__InBuffer) = FireDateTime?.GarbageCollectionHandle ?? nint.Zero;

				*(bool*)(__InBuffer + 8) = LocalTime;

				*(nint*)(__InBuffer + 9) = Title?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 17) = Body?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 25) = Action?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 33) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __ScheduleLocalNotificationAtTime, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="NotificationLaunchedApp">
		/// Return true if a notification was used to launch the app
		/// </param>
		/// <param name="ActivationEvent">
		/// Returns the name of the ActivationEvent if a notification was used to launch the app
		/// </param>
		/// <param name="FireDate">
		/// Returns the time the notification was activated
		/// </param>
		public static void GetLaunchNotification(ref bool NotificationLaunchedApp, ref FString ActivationEvent, ref int FireDate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[13];

				*(bool*)(__InBuffer) = NotificationLaunchedApp;

				*(nint*)(__InBuffer + 1) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				*(int*)(__InBuffer + 9) = FireDate;

				var __OutBuffer = stackalloc byte[13];

				FFunctionImplementation.FFunction_GenericCall14Implementation(StaticClass().GarbageCollectionHandle, __GetLaunchNotification, __InBuffer, __OutBuffer);

				NotificationLaunchedApp = *(bool*)(__OutBuffer);

				ActivationEvent = *(FString*)(__OutBuffer + 1);

				FireDate = *(int*)(__OutBuffer + 9);

			}
		}

		/// <returns>
		/// An EDeviceScreenOrientation value.
		/// </returns>
		public static EScreenOrientation GetDeviceOrientation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetDeviceOrientation, __ReturnBuffer);

				return *(EScreenOrientation*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// An EDeviceScreenOrientation value.
		/// </returns>
		public static EScreenOrientation GetAllowedDeviceOrientation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __GetAllowedDeviceOrientation, __ReturnBuffer);

				return *(EScreenOrientation*)__ReturnBuffer;
			}
		}

		public static void ClearAllLocalNotifications()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(StaticClass().GarbageCollectionHandle, __ClearAllLocalNotifications);
			}
		}

		/// <param name="NotificationId">
		/// The Id returned from one of the ScheduleLocalNotification* functions
		/// </param>
		public static void CancelLocalNotificationById(int NotificationId)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = NotificationId;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CancelLocalNotificationById, __InBuffer);
			}
		}

		/// <param name="ActivationEvent">
		/// The string passed into the Schedule call for the notification to be cancelled
		/// </param>
		public static void CancelLocalNotification(FString ActivationEvent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = ActivationEvent?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __CancelLocalNotification, __InBuffer);
			}
		}

		private static uint __SetAllowedDeviceOrientation = 0;

		private static uint __ScheduleLocalNotificationFromNow = 0;

		private static uint __ScheduleLocalNotificationBadgeFromNow = 0;

		private static uint __ScheduleLocalNotificationBadgeAtTime = 0;

		private static uint __ScheduleLocalNotificationAtTime = 0;

		private static uint __GetLaunchNotification = 0;

		private static uint __GetDeviceOrientation = 0;

		private static uint __GetAllowedDeviceOrientation = 0;

		private static uint __ClearAllLocalNotifications = 0;

		private static uint __CancelLocalNotificationById = 0;

		private static uint __CancelLocalNotification = 0;
	}
}
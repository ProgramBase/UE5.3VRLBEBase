using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.LocationServicesBPLibrary
{
	[PathName("/Script/LocationServicesBPLibrary.LocationServices")]
	public partial class ULocationServices : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LocationServicesBPLibrary.LocationServices");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <returns>
		/// - true if stop is successful
		/// </returns>
		public static bool StopLocationServices()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StopLocationServices, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// - true if startup successful
		/// </returns>
		public static bool StartLocationServices()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __StartLocationServices, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Accuracy">
		/// - the accuracy to check
		/// </param>
		/// <returns>
		/// - true if the mobile device can support the Accuracy, false if it will use a different accuracy
		/// </returns>
		public static bool IsLocationAccuracyAvailable(ELocationAccuracy Accuracy)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(byte*)(__InBuffer) = (byte)Accuracy;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __IsLocationAccuracyAvailable, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <param name="Accuracy">
		/// - as seen in the enum above
		/// </param>
		/// <param name="UpdateFrequency">
		/// - in milliseconds. (Android only)
		/// </param>
		/// <param name="MinDistance">
		/// - minDistance before a location update, in meters. 0 here means "update asap"
		/// </param>
		/// <returns>
		/// - true if Initialization was succesful
		/// </returns>
		public static bool InitLocationServices(ELocationAccuracy Accuracy, float UpdateFrequency, float MinDistanceFilter)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[9];

				*(byte*)(__InBuffer) = (byte)Accuracy;

				*(float*)(__InBuffer + 1) = UpdateFrequency;

				*(float*)(__InBuffer + 5) = MinDistanceFilter;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __InitLocationServices, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// - the Android or IOS impl object
		/// </returns>
		public static ULocationServicesImpl GetLocationServicesImpl()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetLocationServicesImpl, __ReturnBuffer);

				return *(ULocationServicesImpl*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// - the last known location from updates 
		/// </returns>
		public static FLocationServicesData GetLastKnownLocation()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(StaticClass().GarbageCollectionHandle, __GetLastKnownLocation, __ReturnBuffer);

				return *(FLocationServicesData*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// - true if the mobile device has enabled the appropriate service for the app 
		/// </returns>
		public static bool AreLocationServicesEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __AreLocationServicesEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __StopLocationServices = 0;

		private static uint __StartLocationServices = 0;

		private static uint __IsLocationAccuracyAvailable = 0;

		private static uint __InitLocationServices = 0;

		private static uint __GetLocationServicesImpl = 0;

		private static uint __GetLastKnownLocation = 0;

		private static uint __AreLocationServicesEnabled = 0;
	}
}
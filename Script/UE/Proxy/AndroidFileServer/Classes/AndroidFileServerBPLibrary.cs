using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.AndroidFileServer
{
	[PathName("/Script/AndroidFileServer.AndroidFileServerBPLibrary")]
	public partial class UAndroidFileServerBPLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AndroidFileServer.AndroidFileServerBPLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static bool StopFileServer(bool bUSB = true, bool bNetwork = true)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[2];

				*(bool*)(__InBuffer) = bUSB;

				*(bool*)(__InBuffer + 1) = bNetwork;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StopFileServer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static bool StartFileServer(bool bUSB = true, bool bNetwork = false, int Port = 57099)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[6];

				*(bool*)(__InBuffer) = bUSB;

				*(bool*)(__InBuffer + 1) = bNetwork;

				*(int*)(__InBuffer + 2) = Port;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(StaticClass().GarbageCollectionHandle, __StartFileServer, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public static EAFSActiveType IsFileServerRunning()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(StaticClass().GarbageCollectionHandle, __IsFileServerRunning, __ReturnBuffer);

				return *(EAFSActiveType*)__ReturnBuffer;
			}
		}

		private static uint __StopFileServer = 0;

		private static uint __StartFileServer = 0;

		private static uint __IsFileServerRunning = 0;
	}
}
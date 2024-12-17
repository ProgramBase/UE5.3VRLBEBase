using Script.CoreUObject;
using Script.Library;

namespace Script.Bridge
{
	[PathName("/Script/Bridge.NodePort")]
	public partial class UNodePort : UObject, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Bridge.NodePort");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool IsNodeRunning()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsNodeRunning, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FString GetNodePort()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetNodePort, __ReturnBuffer);

				return *(FString*)__ReturnBuffer;
			}
		}

		private static uint __IsNodeRunning = 0;

		private static uint __GetNodePort = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.AIModule
{
	[PathName("/Script/AIModule.AITask_RunEQS")]
	public partial class UAITask_RunEQS : UAITask, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AIModule.AITask_RunEQS");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static UAITask_RunEQS RunEQS(AAIController Controller, UEnvQuery QueryTemplate)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Controller?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = QueryTemplate?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(StaticClass().GarbageCollectionHandle, __RunEQS, __InBuffer, __ReturnBuffer);

				return *(UAITask_RunEQS*)__ReturnBuffer;
			}
		}

		private static uint __RunEQS = 0;
	}
}
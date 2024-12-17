using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.WorldPartitionDestructibleInHLODSupportLibrary")]
	public partial class UWorldPartitionDestructibleInHLODSupportLibrary : UBlueprintFunctionLibrary, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.WorldPartitionDestructibleInHLODSupportLibrary");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void DestroyInHLOD(TScriptInterface<IWorldPartitionDestructibleInHLODInterface> DestructibleInHLOD)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = DestructibleInHLOD?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DestroyInHLOD, __InBuffer);
			}
		}

		public static void DamageInHLOD(TScriptInterface<IWorldPartitionDestructibleInHLODInterface> DestructibleInHLOD, float DamagePercent)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[12];

				*(nint*)(__InBuffer) = DestructibleInHLOD?.GarbageCollectionHandle ?? nint.Zero;

				*(float*)(__InBuffer + 8) = DamagePercent;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __DamageInHLOD, __InBuffer);
			}
		}

		private static uint __DestroyInHLOD = 0;

		private static uint __DamageInHLOD = 0;
	}
}
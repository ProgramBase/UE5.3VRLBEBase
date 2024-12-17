using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.InstancedFoliageActor")]
	public partial class AInstancedFoliageActor : AISMPartitionActor, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.InstancedFoliageActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public static void RemoveAllInstances(UObject WorldContextObject, UFoliageType InFoliageType)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFoliageType?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __RemoveAllInstances, __InBuffer);
			}
		}

		public static void AddInstances(UObject WorldContextObject, UFoliageType InFoliageType, TArray<FTransform> InTransforms)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = WorldContextObject?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InFoliageType?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = InTransforms?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(StaticClass().GarbageCollectionHandle, __AddInstances, __InBuffer);
			}
		}

		private static uint __RemoveAllInstances = 0;

		private static uint __AddInstances = 0;
	}
}
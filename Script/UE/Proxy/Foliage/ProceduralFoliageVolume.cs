using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.ProceduralFoliageVolume")]
	public partial class AProceduralFoliageVolume : AVolume, IStaticClass, IWorldPartitionActorLoaderInterface
	{
		public UProceduralFoliageComponent ProceduralComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ProceduralComponent, __ReturnBuffer);

					return *(UProceduralFoliageComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ProceduralComponent, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.ProceduralFoliageVolume");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __ProceduralComponent = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}
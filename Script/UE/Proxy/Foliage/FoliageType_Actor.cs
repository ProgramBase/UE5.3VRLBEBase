using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Foliage
{
	[PathName("/Script/Foliage.FoliageType_Actor")]
	public partial class UFoliageType_Actor : UFoliageType, IStaticClass
	{
		public TSubclassOf<AActor> ActorClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorClass, __ReturnBuffer);

					return *(TSubclassOf<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorClass, __InBuffer);
				}
			}
		}

		public bool bShouldAttachToBaseComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldAttachToBaseComponent, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShouldAttachToBaseComponent, __InBuffer);
				}
			}
		}

		public bool bStaticMeshOnly
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshOnly, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bStaticMeshOnly, __InBuffer);
				}
			}
		}

		public TSubclassOf<UFoliageInstancedStaticMeshComponent> StaticMeshOnlyComponentClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshOnlyComponentClass, __ReturnBuffer);

					return *(TSubclassOf<UFoliageInstancedStaticMeshComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshOnlyComponentClass, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Foliage.FoliageType_Actor");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ActorClass = 0;

		private static uint __bShouldAttachToBaseComponent = 0;

		private static uint __bStaticMeshOnly = 0;

		private static uint __StaticMeshOnlyComponentClass = 0;
	}
}
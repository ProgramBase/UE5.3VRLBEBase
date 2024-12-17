using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimeHashExternalStreamingObjectBase")]
	public partial class URuntimeHashExternalStreamingObjectBase : UObject, IStaticClass
	{
		public TMap<FName, FName> SubObjectsToCellRemapping
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SubObjectsToCellRemapping, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SubObjectsToCellRemapping, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UWorld> OwningWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OwningWorld, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OwningWorld, __InBuffer);
				}
			}
		}

		public TSoftObjectPtr<UWorld> OuterWorld
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OuterWorld, __ReturnBuffer);

					return *(TSoftObjectPtr<UWorld>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OuterWorld, __InBuffer);
				}
			}
		}

		public TMap<FName, FName> CellToLevelStreamingPackage
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CellToLevelStreamingPackage, __ReturnBuffer);

					return *(TMap<FName, FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CellToLevelStreamingPackage, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimeHashExternalStreamingObjectBase");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SubObjectsToCellRemapping = 0;

		private static uint __OwningWorld = 0;

		private static uint __OuterWorld = 0;

		private static uint __CellToLevelStreamingPackage = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.WorldPartitionRenameDuplicateBuilder")]
	public partial class UWorldPartitionRenameDuplicateBuilder : UWorldPartitionBuilder, IStaticClass
	{
		public TMap<UObject, UObject> DuplicatedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DuplicatedObjects, __ReturnBuffer);

					return *(TMap<UObject, UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DuplicatedObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.WorldPartitionRenameDuplicateBuilder");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DuplicatedObjects = 0;
	}
}
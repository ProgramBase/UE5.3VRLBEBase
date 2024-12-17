using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.ChunkDependencyInfo")]
	public partial class UChunkDependencyInfo : UObject, IStaticClass
	{
		public TArray<FChunkDependency> DependencyArray
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DependencyArray, __ReturnBuffer);

					return *(TArray<FChunkDependency>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DependencyArray, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.ChunkDependencyInfo");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __DependencyArray = 0;
	}
}
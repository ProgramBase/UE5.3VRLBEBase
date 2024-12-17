using Script.CoreUObject;
using Script.Library;

namespace Script.AssetDefinition
{
	[PathName("/Script/AssetDefinition.AssetDefinitionRegistry")]
	public partial class UAssetDefinitionRegistry : UObject, IStaticClass
	{
		public TMap<TSoftClassPtr<UObject>, UAssetDefinition> AssetDefinitions
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetDefinitions, __ReturnBuffer);

					return *(TMap<TSoftClassPtr<UObject>, UAssetDefinition>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetDefinitions, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AssetDefinition.AssetDefinitionRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __AssetDefinitions = 0;
	}
}
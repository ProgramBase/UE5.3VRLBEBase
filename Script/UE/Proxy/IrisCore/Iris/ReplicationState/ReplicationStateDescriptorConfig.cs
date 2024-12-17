using Script.CoreUObject;
using Script.Library;

namespace Script.IrisCore
{
	[PathName("/Script/IrisCore.ReplicationStateDescriptorConfig")]
	public partial class UReplicationStateDescriptorConfig : UObject, IStaticClass
	{
		public TArray<FSupportsStructNetSerializerConfig> SupportsStructNetSerializerList
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportsStructNetSerializerList, __ReturnBuffer);

					return *(TArray<FSupportsStructNetSerializerConfig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportsStructNetSerializerList, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/IrisCore.ReplicationStateDescriptorConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SupportsStructNetSerializerList = 0;
	}
}
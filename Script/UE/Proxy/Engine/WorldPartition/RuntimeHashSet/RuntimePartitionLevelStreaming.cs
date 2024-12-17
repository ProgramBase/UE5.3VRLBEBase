using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RuntimePartitionLevelStreaming")]
	public partial class URuntimePartitionLevelStreaming : URuntimePartition, IStaticClass
	{
		public bool bOneLevelPerActorContainer
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bOneLevelPerActorContainer, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bOneLevelPerActorContainer, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RuntimePartitionLevelStreaming");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bOneLevelPerActorContainer = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.PacketHandler
{
	[PathName("/Script/PacketHandler.PacketHandlerProfileConfig")]
	public partial class UPacketHandlerProfileConfig : UObject, IStaticClass
	{
		public TArray<FString> Components
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Components, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Components, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/PacketHandler.PacketHandlerProfileConfig");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Components = 0;
	}
}
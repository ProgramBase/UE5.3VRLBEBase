using Script.CoreUObject;
using Script.Library;

namespace Script.GameProjectGeneration
{
	[PathName("/Script/GameProjectGeneration.PluginClassTemplate")]
	public partial class UPluginClassTemplate : UClassTemplate, IStaticClass
	{
		public FString PluginName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PluginName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PluginName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/GameProjectGeneration.PluginClassTemplate");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __PluginName = 0;
	}
}
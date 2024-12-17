using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.RendererOverrideSettings")]
	public partial class URendererOverrideSettings : UDeveloperSettings, IStaticClass
	{
		public bool bSupportAllShaderPermutations
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportAllShaderPermutations, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSupportAllShaderPermutations, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.RendererOverrideSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bSupportAllShaderPermutations = 0;
	}
}
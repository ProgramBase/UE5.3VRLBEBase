using Script.CoreUObject;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.OnAcceptHandleSourcesProperties")]
	public partial class UOnAcceptHandleSourcesProperties : UOnAcceptHandleSourcesPropertiesBase, IStaticClass
	{
		public EHandleSourcesMethod HandleInputs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HandleInputs, __ReturnBuffer);

					return *(EHandleSourcesMethod*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HandleInputs, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.OnAcceptHandleSourcesProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __HandleInputs = 0;
	}
}
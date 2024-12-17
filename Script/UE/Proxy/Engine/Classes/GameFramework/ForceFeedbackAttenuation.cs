using Script.CoreUObject;
using Script.Library;

namespace Script.Engine
{
	[PathName("/Script/Engine.ForceFeedbackAttenuation")]
	public partial class UForceFeedbackAttenuation : UObject, IStaticClass
	{
		public FForceFeedbackAttenuationSettings Attenuation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Attenuation, __ReturnBuffer);

					return *(FForceFeedbackAttenuationSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Attenuation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Engine.ForceFeedbackAttenuation");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Attenuation = 0;
	}
}
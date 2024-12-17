using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaPreviewSceneAnimationController")]
	public partial class UPersonaPreviewSceneAnimationController : UPersonaPreviewSceneController, IStaticClass
	{
		public TSoftObjectPtr<UAnimationAsset> Animation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Animation, __ReturnBuffer);

					return *(TSoftObjectPtr<UAnimationAsset>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Animation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaPreviewSceneAnimationController");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Animation = 0;
	}
}
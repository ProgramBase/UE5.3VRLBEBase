using Script.CoreUObject;
using Script.Library;

namespace Script.Persona
{
	[PathName("/Script/Persona.PersonaPreviewSceneRefPoseController")]
	public partial class UPersonaPreviewSceneRefPoseController : UPersonaPreviewSceneController, IStaticClass
	{
		public bool bResetBoneTransforms
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bResetBoneTransforms, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bResetBoneTransforms, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Persona.PersonaPreviewSceneRefPoseController");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bResetBoneTransforms = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.AnimationBlueprintEditor
{
	[PathName("/Script/AnimationBlueprintEditor.AnimationBlueprintEditorSettings")]
	public partial class UAnimationBlueprintEditorSettings : UObject, IStaticClass
	{
		public bool bPoseWatchSelectedNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bPoseWatchSelectedNodes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bPoseWatchSelectedNodes, __InBuffer);
				}
			}
		}

		public bool bShowGraphCornerText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bShowGraphCornerText, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bShowGraphCornerText, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/AnimationBlueprintEditor.AnimationBlueprintEditorSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bPoseWatchSelectedNodes = 0;

		private static uint __bShowGraphCornerText = 0;
	}
}
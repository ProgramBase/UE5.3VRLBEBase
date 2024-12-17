using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.AnimationBlueprintEditorOptions")]
	public partial class UAnimationBlueprintEditorOptions : UObject, IStaticClass
	{
		public bool bHideUnrelatedNodes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHideUnrelatedNodes, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHideUnrelatedNodes, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.AnimationBlueprintEditorOptions");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bHideUnrelatedNodes = 0;
	}
}
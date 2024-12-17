using Script.CoreUObject;
using Script.BlueprintGraph;
using Script.UMG;
using Script.Library;

namespace Script.UMGEditor
{
	[PathName("/Script/UMGEditor.K2Node_WidgetAnimationEvent")]
	public partial class UK2Node_WidgetAnimationEvent : UK2Node_Event, IStaticClass
	{
		public EWidgetAnimationEvent Action
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Action, __ReturnBuffer);

					return *(EWidgetAnimationEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Action, __InBuffer);
				}
			}
		}

		public FName AnimationPropertyName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationPropertyName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AnimationPropertyName, __InBuffer);
				}
			}
		}

		public FName UserTag
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UserTag, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UserTag, __InBuffer);
				}
			}
		}

		public UWidgetBlueprint SourceWidgetBlueprint
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SourceWidgetBlueprint, __ReturnBuffer);

					return *(UWidgetBlueprint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SourceWidgetBlueprint, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMGEditor.K2Node_WidgetAnimationEvent");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __Action = 0;

		private static uint __AnimationPropertyName = 0;

		private static uint __UserTag = 0;

		private static uint __SourceWidgetBlueprint = 0;
	}
}
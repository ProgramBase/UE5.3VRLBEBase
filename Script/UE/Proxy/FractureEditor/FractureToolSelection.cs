using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.FractureEditor
{
	[PathName("/Script/FractureEditor.FractureToolSelection")]
	public partial class UFractureToolSelection : UFractureToolCutterBase, IStaticClass
	{
		public UInputBehaviorSet SelectionBehaviorSet
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionBehaviorSet, __ReturnBuffer);

					return *(UInputBehaviorSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionBehaviorSet, __InBuffer);
				}
			}
		}

		public ULocalInputBehaviorSource SelectionBehaviorSource
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionBehaviorSource, __ReturnBuffer);

					return *(ULocalInputBehaviorSource*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionBehaviorSource, __InBuffer);
				}
			}
		}

		public URectangleMarqueeManager RectangleMarqueeManager
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __RectangleMarqueeManager, __ReturnBuffer);

					return *(URectangleMarqueeManager*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __RectangleMarqueeManager, __InBuffer);
				}
			}
		}

		public UInteractiveToolsContext UsedToolsContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __UsedToolsContext, __ReturnBuffer);

					return *(UInteractiveToolsContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __UsedToolsContext, __InBuffer);
				}
			}
		}

		public UFractureSelectionSettings SelectionSettings
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionSettings, __ReturnBuffer);

					return *(UFractureSelectionSettings*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionSettings, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/FractureEditor.FractureToolSelection");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __SelectionBehaviorSet = 0;

		private static uint __SelectionBehaviorSource = 0;

		private static uint __RectangleMarqueeManager = 0;

		private static uint __UsedToolsContext = 0;

		private static uint __SelectionSettings = 0;
	}
}
﻿using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.ModelingComponents
{
	[PathName("/Script/ModelingComponents.PersistentMeshSelectionManager")]
	public partial class UDEPRECATED_PersistentMeshSelectionManager : UObject, IStaticClass
	{
		public UInteractiveToolsContext ParentContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ParentContext, __ReturnBuffer);

					return *(UInteractiveToolsContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ParentContext, __InBuffer);
				}
			}
		}

		public UPreviewGeometry SelectionDisplay
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionDisplay, __ReturnBuffer);

					return *(UPreviewGeometry*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectionDisplay, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ModelingComponents.PersistentMeshSelectionManager");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ParentContext = 0;

		private static uint __SelectionDisplay = 0;
	}
}
using Script.CoreUObject;
using Script.Library;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoRegistry")]
	public partial class UEditorInteractiveGizmoRegistry : UObject, IStaticClass
	{
		public TMap<EEditorGizmoCategory, UEditorGizmoRegistryCategoryEntry> GizmoCategoryMap
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoCategoryMap, __ReturnBuffer);

					return *(TMap<EEditorGizmoCategory, UEditorGizmoRegistryCategoryEntry>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoCategoryMap, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorInteractiveGizmoRegistry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GizmoCategoryMap = 0;
	}
}
using Script.CoreUObject;
using Script.Library;
using Script.InteractiveToolsFramework;

namespace Script.EditorInteractiveToolsFramework
{
	[PathName("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry")]
	public partial class UEditorGizmoRegistryCategoryEntry : UObject, IStaticClass
	{
		public TArray<UInteractiveGizmoBuilder> GizmoTypes
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoTypes, __ReturnBuffer);

					return *(TArray<UInteractiveGizmoBuilder>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoTypes, __InBuffer);
				}
			}
		}

		public FString CategoryName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CategoryName, __ReturnBuffer);

					return *(FString*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CategoryName, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/EditorInteractiveToolsFramework.EditorGizmoRegistryCategoryEntry");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __GizmoTypes = 0;

		private static uint __CategoryName = 0;
	}
}
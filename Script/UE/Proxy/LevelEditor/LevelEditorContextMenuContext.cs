using Script.CoreUObject;
using Script.TypedElementRuntime;
using Script.TypedElementFramework;
using Script.Engine;
using Script.Library;

namespace Script.LevelEditor
{
	[PathName("/Script/LevelEditor.LevelEditorContextMenuContext")]
	public partial class ULevelEditorContextMenuContext : UObject, IStaticClass
	{
		public ELevelEditorMenuContext ContextType
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContextType, __ReturnBuffer);

					return *(ELevelEditorMenuContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContextType, __InBuffer);
				}
			}
		}

		public UTypedElementSelectionSet CurrentSelection
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSelection, __ReturnBuffer);

					return *(UTypedElementSelectionSet*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CurrentSelection, __InBuffer);
				}
			}
		}

		public FVector CursorWorldLocation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __CursorWorldLocation, __ReturnBuffer);

					return *(FVector*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __CursorWorldLocation, __InBuffer);
				}
			}
		}

		public TArray<UActorComponent> SelectedComponents
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedComponents, __ReturnBuffer);

					return *(TArray<UActorComponent>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SelectedComponents, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<AActor> HitProxyActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __HitProxyActor, __ReturnBuffer);

					return *(TWeakObjectPtr<AActor>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __HitProxyActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/LevelEditor.LevelEditorContextMenuContext");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual FScriptTypedElementHandle GetScriptHitProxyElement()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetScriptHitProxyElement, __ReturnBuffer);

				return *(FScriptTypedElementHandle*)__ReturnBuffer;
			}
		}

		private static uint __ContextType = 0;

		private static uint __CurrentSelection = 0;

		private static uint __CursorWorldLocation = 0;

		private static uint __SelectedComponents = 0;

		private static uint __HitProxyActor = 0;

		private static uint __GetScriptHitProxyElement = 0;
	}
}
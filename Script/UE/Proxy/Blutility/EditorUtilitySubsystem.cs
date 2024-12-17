using Script.CoreUObject;
using Script.EditorSubsystem;
using Script.Library;

namespace Script.Blutility
{
	[PathName("/Script/Blutility.EditorUtilitySubsystem")]
	public partial class UEditorUtilitySubsystem : UEditorSubsystem, IStaticClass
	{
		public TArray<FSoftObjectPath> LoadedUIs
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedUIs, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __LoadedUIs, __InBuffer);
				}
			}
		}

		public TArray<FSoftObjectPath> StartupObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StartupObjects, __ReturnBuffer);

					return *(TArray<FSoftObjectPath>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StartupObjects, __InBuffer);
				}
			}
		}

		public FOnEditorUtilityPIEEvent OnBeginPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginPIE, __ReturnBuffer);

					return *(FOnEditorUtilityPIEEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnBeginPIE, __InBuffer);
				}
			}
		}

		public FOnEditorUtilityPIEEvent OnEndPIE
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndPIE, __ReturnBuffer);

					return *(FOnEditorUtilityPIEEvent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnEndPIE, __InBuffer);
				}
			}
		}

		public TMap<UObject, UObject> ObjectInstances
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectInstances, __ReturnBuffer);

					return *(TMap<UObject, UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ObjectInstances, __InBuffer);
				}
			}
		}

		public TArray<UEditorUtilityTask> ActiveTaskStack
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveTaskStack, __ReturnBuffer);

					return *(TArray<UEditorUtilityTask>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActiveTaskStack, __InBuffer);
				}
			}
		}

		public TSet<UObject> ReferencedObjects
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __ReturnBuffer);

					return *(TSet<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReferencedObjects, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/Blutility.EditorUtilitySubsystem");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool UnregisterTabByID(FName TabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = TabID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __UnregisterTabByID, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool TryRun(UObject Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __TryRun, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool SpawnRegisteredTabByID(FName NewTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __SpawnRegisteredTabByID, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual UEditorUtilityWidget SpawnAndRegisterTabWithId(UEditorUtilityWidgetBlueprint InBlueprint, FName InTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = InTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnAndRegisterTabWithId, __InBuffer, __ReturnBuffer);

				return *(UEditorUtilityWidget*)__ReturnBuffer;
			}
		}

		public virtual UEditorUtilityWidget SpawnAndRegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint, ref FName NewTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall15Implementation(GarbageCollectionHandle, __SpawnAndRegisterTabAndGetID, __InBuffer, __OutBuffer, __ReturnBuffer);

				NewTabID = *(FName*)(__OutBuffer);

				return *(UEditorUtilityWidget*)__ReturnBuffer;
			}
		}

		public virtual UEditorUtilityWidget SpawnAndRegisterTab(UEditorUtilityWidgetBlueprint InBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __SpawnAndRegisterTab, __InBuffer, __ReturnBuffer);

				return *(UEditorUtilityWidget*)__ReturnBuffer;
			}
		}

		public virtual void ReleaseInstanceOfAsset(UObject Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __ReleaseInstanceOfAsset, __InBuffer);
			}
		}

		public virtual void RegisterTabAndGetID(UEditorUtilityWidgetBlueprint InBlueprint, ref FName NewTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = InBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = NewTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __OutBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_GenericCall14Implementation(GarbageCollectionHandle, __RegisterTabAndGetID, __InBuffer, __OutBuffer);

				NewTabID = *(FName*)(__OutBuffer);

			}
		}

		public virtual void RegisterAndExecuteTask(UEditorUtilityTask NewTask, UEditorUtilityTask OptionalParentTask = null)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = NewTask?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = OptionalParentTask?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __RegisterAndExecuteTask, __InBuffer);
			}
		}

		public virtual UEditorUtilityWidget FindUtilityWidgetFromBlueprint(UEditorUtilityWidgetBlueprint InBlueprint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InBlueprint?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __FindUtilityWidgetFromBlueprint, __InBuffer, __ReturnBuffer);

				return *(UEditorUtilityWidget*)__ReturnBuffer;
			}
		}

		public virtual bool DoesTabExist(FName NewTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __DoesTabExist, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CloseTabByID(FName NewTabID)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTabID?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CloseTabByID, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool CanRun(UObject Asset)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Asset?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanRun, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __LoadedUIs = 0;

		private static uint __StartupObjects = 0;

		private static uint __OnBeginPIE = 0;

		private static uint __OnEndPIE = 0;

		private static uint __ObjectInstances = 0;

		private static uint __ActiveTaskStack = 0;

		private static uint __ReferencedObjects = 0;

		private static uint __UnregisterTabByID = 0;

		private static uint __TryRun = 0;

		private static uint __SpawnRegisteredTabByID = 0;

		private static uint __SpawnAndRegisterTabWithId = 0;

		private static uint __SpawnAndRegisterTabAndGetID = 0;

		private static uint __SpawnAndRegisterTab = 0;

		private static uint __ReleaseInstanceOfAsset = 0;

		private static uint __RegisterTabAndGetID = 0;

		private static uint __RegisterAndExecuteTask = 0;

		private static uint __FindUtilityWidgetFromBlueprint = 0;

		private static uint __DoesTabExist = 0;

		private static uint __CloseTabByID = 0;

		private static uint __CanRun = 0;
	}
}
using Script.CoreUObject;
using Script.DeveloperSettings;
using Script.Engine;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.BlueprintEditorProjectSettings")]
	public partial class UBlueprintEditorProjectSettings : UDeveloperSettings, IStaticClass
	{
		public bool bForceAllDependenciesToRecompile
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bForceAllDependenciesToRecompile, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bForceAllDependenciesToRecompile, __InBuffer);
				}
			}
		}

		public bool bValidateUnloadedSoftActorReferences
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateUnloadedSoftActorReferences, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bValidateUnloadedSoftActorReferences, __InBuffer);
				}
			}
		}

		public bool bEnableChildActorExpansionInTreeView
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableChildActorExpansionInTreeView, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEnableChildActorExpansionInTreeView, __InBuffer);
				}
			}
		}

		public EChildActorComponentTreeViewVisualizationMode DefaultChildActorTreeViewMode
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultChildActorTreeViewMode, __ReturnBuffer);

					return *(EChildActorComponentTreeViewVisualizationMode*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(byte*)__InBuffer = (byte)value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DefaultChildActorTreeViewMode, __InBuffer);
				}
			}
		}

		public TArray<FString> NamespacesToAlwaysInclude
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __NamespacesToAlwaysInclude, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __NamespacesToAlwaysInclude, __InBuffer);
				}
			}
		}

		public TArray<FName> DisabledCompilerMessagesExceptEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledCompilerMessagesExceptEditor, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledCompilerMessagesExceptEditor, __InBuffer);
				}
			}
		}

		public TArray<FName> DisabledCompilerMessages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledCompilerMessages, __ReturnBuffer);

					return *(TArray<FName>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __DisabledCompilerMessages, __InBuffer);
				}
			}
		}

		public TArray<FString> SuppressedDeprecationMessages
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SuppressedDeprecationMessages, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SuppressedDeprecationMessages, __InBuffer);
				}
			}
		}

		public TArray<TSoftClassPtr<UObject>> BaseClassesToAllowRecompilingDuringPlayInEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __BaseClassesToAllowRecompilingDuringPlayInEditor, __ReturnBuffer);

					return *(TArray<TSoftClassPtr<UObject>>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __BaseClassesToAllowRecompilingDuringPlayInEditor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.BlueprintEditorProjectSettings");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bForceAllDependenciesToRecompile = 0;

		private static uint __bValidateUnloadedSoftActorReferences = 0;

		private static uint __bEnableChildActorExpansionInTreeView = 0;

		private static uint __DefaultChildActorTreeViewMode = 0;

		private static uint __NamespacesToAlwaysInclude = 0;

		private static uint __DisabledCompilerMessagesExceptEditor = 0;

		private static uint __DisabledCompilerMessages = 0;

		private static uint __SuppressedDeprecationMessages = 0;

		private static uint __BaseClassesToAllowRecompilingDuringPlayInEditor = 0;
	}
}
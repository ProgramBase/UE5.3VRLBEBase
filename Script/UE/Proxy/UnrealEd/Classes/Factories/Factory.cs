using Script.CoreUObject;
using Script.Library;

namespace Script.UnrealEd
{
	[PathName("/Script/UnrealEd.Factory")]
	public partial class UFactory : UObject, IStaticClass
	{
		public bool bCreateNew
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateNew, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bCreateNew, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> SupportedClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __SupportedClass, __InBuffer);
				}
			}
		}

		public TSubclassOf<UObject> ContextClass
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ContextClass, __ReturnBuffer);

					return *(TSubclassOf<UObject>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ContextClass, __InBuffer);
				}
			}
		}

		public TArray<FString> Formats
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Formats, __ReturnBuffer);

					return *(TArray<FString>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Formats, __InBuffer);
				}
			}
		}

		public bool bEditAfterNew
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditAfterNew, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditAfterNew, __InBuffer);
				}
			}
		}

		public bool bEditorImport
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bEditorImport, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bEditorImport, __InBuffer);
				}
			}
		}

		public bool bText
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bText, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bText, __InBuffer);
				}
			}
		}

		public int ImportPriority
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ImportPriority, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ImportPriority, __InBuffer);
				}
			}
		}

		public UAutomatedAssetImportData AutomatedImportData
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AutomatedImportData, __ReturnBuffer);

					return *(UAutomatedAssetImportData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AutomatedImportData, __InBuffer);
				}
			}
		}

		public UAssetImportTask AssetImportTask
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportTask, __ReturnBuffer);

					return *(UAssetImportTask*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __AssetImportTask, __InBuffer);
				}
			}
		}

		public int OverwriteYesOrNoToAllState
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OverwriteYesOrNoToAllState, __ReturnBuffer);

					return *(int*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(int*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OverwriteYesOrNoToAllState, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UnrealEd.Factory");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="InTask">
		/// </param>
		/// <returns>
		/// True if script implements
		/// </returns>
		public virtual bool ScriptFactoryCreateFile(UAssetImportTask InTask)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTask?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __ScriptFactoryCreateFile, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the file is supported, false otherwise.
		/// </returns>
		public virtual bool ScriptFactoryCanImport(FString Filename)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Filename?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall3Implementation(GarbageCollectionHandle, __ScriptFactoryCanImport, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __bCreateNew = 0;

		private static uint __SupportedClass = 0;

		private static uint __ContextClass = 0;

		private static uint __Formats = 0;

		private static uint __bEditAfterNew = 0;

		private static uint __bEditorImport = 0;

		private static uint __bText = 0;

		private static uint __ImportPriority = 0;

		private static uint __AutomatedImportData = 0;

		private static uint __AssetImportTask = 0;

		private static uint __OverwriteYesOrNoToAllState = 0;

		private static uint __ScriptFactoryCreateFile = 0;

		private static uint __ScriptFactoryCanImport = 0;
	}
}
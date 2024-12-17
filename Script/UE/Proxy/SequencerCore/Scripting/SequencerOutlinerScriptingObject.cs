using Script.CoreUObject;
using Script.Library;

namespace Script.SequencerCore
{
	[PathName("/Script/SequencerCore.SequencerOutlinerScriptingObject")]
	public partial class USequencerOutlinerScriptingObject : UObject, IStaticClass
	{
		public FSequencerOutlinerSelectionChanged OnSelectionChanged
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __OnSelectionChanged, __ReturnBuffer);

					return *(FSequencerOutlinerSelectionChanged*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __OnSelectionChanged, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/SequencerCore.SequencerOutlinerScriptingObject");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSelection(TArray<FSequencerViewModelScriptingStruct> InSelection)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InSelection?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelection, __InBuffer);
			}
		}

		public virtual TArray<FSequencerViewModelScriptingStruct> GetSelection()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetSelection, __ReturnBuffer);

				return *(TArray<FSequencerViewModelScriptingStruct>*)__ReturnBuffer;
			}
		}

		public virtual FSequencerViewModelScriptingStruct GetRootNode()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetRootNode, __ReturnBuffer);

				return *(FSequencerViewModelScriptingStruct*)__ReturnBuffer;
			}
		}

		public virtual TArray<FSequencerViewModelScriptingStruct> GetChildren(FSequencerViewModelScriptingStruct Node, FName TypeName = null)
		{
			unsafe
			{
				TypeName ??= new FName("None");

				var __InBuffer = stackalloc byte[16];

				*(nint*)(__InBuffer) = Node?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = TypeName?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetChildren, __InBuffer, __ReturnBuffer);

				return *(TArray<FSequencerViewModelScriptingStruct>*)__ReturnBuffer;
			}
		}

		private static uint __OnSelectionChanged = 0;

		private static uint __SetSelection = 0;

		private static uint __GetSelection = 0;

		private static uint __GetRootNode = 0;

		private static uint __GetChildren = 0;
	}
}
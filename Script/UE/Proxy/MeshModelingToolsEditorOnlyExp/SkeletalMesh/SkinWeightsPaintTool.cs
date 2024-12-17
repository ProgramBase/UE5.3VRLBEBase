using Script.CoreUObject;
using Script.MeshModelingToolsExp;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.SkinWeightsPaintTool")]
	public partial class USkinWeightsPaintTool : UDynamicMeshBrushTool, IStaticClass, ISkeletalMeshEditingInterface
	{
		public USkinWeightsPaintToolProperties WeightToolProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __WeightToolProperties, __ReturnBuffer);

					return *(USkinWeightsPaintToolProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __WeightToolProperties, __InBuffer);
				}
			}
		}

		public UPolygonSelectionMechanic PolygonSelectionMechanic
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __PolygonSelectionMechanic, __ReturnBuffer);

					return *(UPolygonSelectionMechanic*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __PolygonSelectionMechanic, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<USkeletalMeshEditorContextObjectBase> EditorContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __EditorContext, __ReturnBuffer);

					return *(TWeakObjectPtr<USkeletalMeshEditorContextObjectBase>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __EditorContext, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.SkinWeightsPaintTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __WeightToolProperties = 0;

		private static uint __PolygonSelectionMechanic = 0;

		private static uint __EditorContext = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}
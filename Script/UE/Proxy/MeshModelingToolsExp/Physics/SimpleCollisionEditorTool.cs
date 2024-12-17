using Script.CoreUObject;
using Script.ModelingComponents;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SimpleCollisionEditorTool")]
	public partial class USimpleCollisionEditorTool : USingleSelectionMeshEditingTool, IStaticClass
	{
		public USimpleCollisionEditorToolActionProperties ActionProperties
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActionProperties, __ReturnBuffer);

					return *(USimpleCollisionEditorToolActionProperties*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActionProperties, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SimpleCollisionEditorTool");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __ActionProperties = 0;
	}
}
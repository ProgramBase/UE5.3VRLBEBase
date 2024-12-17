using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.DataflowEngine
{
	[PathName("/Script/DataflowEngine.DataflowEdNode")]
	public partial class UDataflowEdNode : UEdGraphNode, IStaticClass
	{
		public bool bRenderInAssetEditor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInAssetEditor, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bRenderInAssetEditor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/DataflowEngine.DataflowEdNode");
		}

		private static UClass StaticClassSingleton { get; set; }

		private static uint __bRenderInAssetEditor = 0;
	}
}
using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolReplacePropertySet")]
	public partial class UISMEditorToolReplacePropertySet : UISMEditorToolActionPropertySetBase, IStaticClass
	{
		public UStaticMesh ReplaceWith
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ReplaceWith, __ReturnBuffer);

					return *(UStaticMesh*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ReplaceWith, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolReplacePropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Replace()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Replace);
			}
		}

		private static uint __ReplaceWith = 0;

		private static uint __Replace = 0;
	}
}
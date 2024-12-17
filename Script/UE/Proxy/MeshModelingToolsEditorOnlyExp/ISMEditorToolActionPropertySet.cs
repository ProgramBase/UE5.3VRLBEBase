using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolActionPropertySet")]
	public partial class UISMEditorToolActionPropertySet : UISMEditorToolActionPropertySetBase, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.ISMEditorToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Duplicate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Duplicate);
			}
		}

		public virtual void Delete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Delete);
			}
		}

		public virtual void ClearSelection()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearSelection);
			}
		}

		private static uint __Duplicate = 0;

		private static uint __Delete = 0;

		private static uint __ClearSelection = 0;
	}
}
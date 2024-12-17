using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.BspConversionToolActionPropertySet")]
	public partial class UBspConversionToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.BspConversionToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SelectAllValidBrushes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SelectAllValidBrushes);
			}
		}

		public virtual void DeselectVolumes()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DeselectVolumes);
			}
		}

		public virtual void DeselectNonValid()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DeselectNonValid);
			}
		}

		private static uint __SelectAllValidBrushes = 0;

		private static uint __DeselectVolumes = 0;

		private static uint __DeselectNonValid = 0;
	}
}
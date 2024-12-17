using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingToolsEditorOnlyExp
{
	[PathName("/Script/MeshModelingToolsEditorOnlyExp.AttributeEditorNormalsActions")]
	public partial class UAttributeEditorNormalsActions : UAttributeEditorActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsEditorOnlyExp.AttributeEditorNormalsActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void ResetHardNormals()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetHardNormals);
			}
		}

		public virtual void DiscardTangents()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DiscardTangents);
			}
		}

		private static uint __ResetHardNormals = 0;

		private static uint __DiscardTangents = 0;
	}
}
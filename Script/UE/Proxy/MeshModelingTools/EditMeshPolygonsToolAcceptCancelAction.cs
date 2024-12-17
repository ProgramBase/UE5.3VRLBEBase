using Script.CoreUObject;
using Script.Library;

namespace Script.MeshModelingTools
{
	[PathName("/Script/MeshModelingTools.EditMeshPolygonsToolAcceptCancelAction")]
	public partial class UEditMeshPolygonsToolAcceptCancelAction : UEditMeshPolygonsToolActionPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingTools.EditMeshPolygonsToolAcceptCancelAction");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Cancel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Cancel);
			}
		}

		public virtual void Apply()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Apply);
			}
		}

		private static uint __Cancel = 0;

		private static uint __Apply = 0;
	}
}
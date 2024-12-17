using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.SimpleCollisionEditorToolActionProperties")]
	public partial class USimpleCollisionEditorToolActionProperties : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.SimpleCollisionEditorToolActionProperties");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Duplicate()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Duplicate);
			}
		}

		public virtual void DeleteAll()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __DeleteAll);
			}
		}

		public virtual void Delete()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Delete);
			}
		}

		public virtual void AddSphere()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AddSphere);
			}
		}

		public virtual void AddCapsule()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AddCapsule);
			}
		}

		public virtual void AddBox()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __AddBox);
			}
		}

		private static uint __Duplicate = 0;

		private static uint __DeleteAll = 0;

		private static uint __Delete = 0;

		private static uint __AddSphere = 0;

		private static uint __AddCapsule = 0;

		private static uint __AddBox = 0;
	}
}
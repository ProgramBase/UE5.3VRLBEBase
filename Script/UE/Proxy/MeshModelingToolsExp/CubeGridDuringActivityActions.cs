using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.CubeGridDuringActivityActions")]
	public partial class UCubeGridDuringActivityActions : UInteractiveToolPropertySet, IStaticClass
	{
		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.CubeGridDuringActivityActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Done()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Done);
			}
		}

		public virtual void Cancel()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Cancel);
			}
		}

		private static uint __Done = 0;

		private static uint __Cancel = 0;
	}
}
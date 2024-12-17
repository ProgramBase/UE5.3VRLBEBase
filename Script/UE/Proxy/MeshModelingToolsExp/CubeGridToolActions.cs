using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Engine;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.CubeGridToolActions")]
	public partial class UCubeGridToolActions : UInteractiveToolPropertySet, IStaticClass
	{
		public AActor GridSourceActor
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GridSourceActor, __ReturnBuffer);

					return *(AActor*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GridSourceActor, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.CubeGridToolActions");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SlideForward()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SlideForward);
			}
		}

		public virtual void SlideBack()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __SlideBack);
			}
		}

		public virtual void ResetGridFromActor()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ResetGridFromActor);
			}
		}

		public virtual void Push()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Push);
			}
		}

		public virtual void Pull()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Pull);
			}
		}

		public virtual void Flip()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Flip);
			}
		}

		public virtual void CornerMode()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __CornerMode);
			}
		}

		private static uint __GridSourceActor = 0;

		private static uint __SlideForward = 0;

		private static uint __SlideBack = 0;

		private static uint __ResetGridFromActor = 0;

		private static uint __Push = 0;

		private static uint __Pull = 0;

		private static uint __Flip = 0;

		private static uint __CornerMode = 0;
	}
}
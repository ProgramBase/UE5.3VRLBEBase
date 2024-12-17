using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.EditPivotToolActionPropertySet")]
	public partial class UEditPivotToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public bool bUseWorldBox
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bUseWorldBox, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bUseWorldBox, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.EditPivotToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void WorldOrigin()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __WorldOrigin);
			}
		}

		public virtual void Top()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Top);
			}
		}

		public virtual void Right()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Right);
			}
		}

		public virtual void Left()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Left);
			}
		}

		public virtual void Front()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Front);
			}
		}

		public virtual void Center()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Center);
			}
		}

		public virtual void Bottom()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Bottom);
			}
		}

		public virtual void Back()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Back);
			}
		}

		private static uint __bUseWorldBox = 0;

		private static uint __WorldOrigin = 0;

		private static uint __Top = 0;

		private static uint __Right = 0;

		private static uint __Left = 0;

		private static uint __Front = 0;

		private static uint __Center = 0;

		private static uint __Bottom = 0;

		private static uint __Back = 0;
	}
}
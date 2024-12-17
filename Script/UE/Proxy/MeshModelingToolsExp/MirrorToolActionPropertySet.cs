using Script.CoreUObject;
using Script.InteractiveToolsFramework;
using Script.Library;

namespace Script.MeshModelingToolsExp
{
	[PathName("/Script/MeshModelingToolsExp.MirrorToolActionPropertySet")]
	public partial class UMirrorToolActionPropertySet : UInteractiveToolPropertySet, IStaticClass
	{
		public bool bButtonsOnlyChangeOrientation
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bButtonsOnlyChangeOrientation, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bButtonsOnlyChangeOrientation, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/MeshModelingToolsExp.MirrorToolActionPropertySet");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void Up()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Up);
			}
		}

		public virtual void ShiftToCenter()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ShiftToCenter);
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

		public virtual void Forward()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Forward);
			}
		}

		public virtual void Down()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Down);
			}
		}

		public virtual void Backward()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __Backward);
			}
		}

		private static uint __bButtonsOnlyChangeOrientation = 0;

		private static uint __Up = 0;

		private static uint __ShiftToCenter = 0;

		private static uint __Right = 0;

		private static uint __Left = 0;

		private static uint __Forward = 0;

		private static uint __Down = 0;

		private static uint __Backward = 0;
	}
}
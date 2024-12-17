using Script.CoreUObject;
using Script.Engine;
using Script.Library;

namespace Script.ControlRig
{
	[PathName("/Script/ControlRig.ControlRigShapeActor")]
	public partial class AControlRigShapeActor : AActor, IStaticClass
	{
		public USceneComponent ActorRootComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ActorRootComponent, __ReturnBuffer);

					return *(USceneComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ActorRootComponent, __InBuffer);
				}
			}
		}

		public UStaticMeshComponent StaticMeshComponent
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __ReturnBuffer);

					return *(UStaticMeshComponent*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __StaticMeshComponent, __InBuffer);
				}
			}
		}

		public uint ControlRigIndex
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[4];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigIndex, __ReturnBuffer);

					return *(uint*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[4];

					*(uint*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRigIndex, __InBuffer);
				}
			}
		}

		public TWeakObjectPtr<UControlRig> ControlRig
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRig, __ReturnBuffer);

					return *(TWeakObjectPtr<UControlRig>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlRig, __InBuffer);
				}
			}
		}

		public FName ControlName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ControlName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ControlName, __InBuffer);
				}
			}
		}

		public FName ShapeName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ShapeName, __InBuffer);
				}
			}
		}

		public FName ColorParameterName
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __ColorParameterName, __ReturnBuffer);

					return *(FName*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __ColorParameterName, __InBuffer);
				}
			}
		}

		public bool bSelected
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bSelected, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bSelected, __InBuffer);
				}
			}
		}

		public bool bHovered
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[1];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __bHovered, __ReturnBuffer);

					return *(bool*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[1];

					*(bool*)__InBuffer = value;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __bHovered, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ControlRig.ControlRigShapeActor");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void SetSelected(bool bInSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInSelected;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelected, __InBuffer);
			}
		}

		public virtual void SetSelectable(bool bInSelectable)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInSelectable;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetSelectable, __InBuffer);
			}
		}

		public virtual void SetHovered(bool bInHovered)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInHovered;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetHovered, __InBuffer);
			}
		}

		public virtual void SetGlobalTransform(FTransform InTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = InTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetGlobalTransform, __InBuffer);
			}
		}

		public virtual void SetEnabled(bool bInEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInEnabled;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __SetEnabled, __InBuffer);
			}
		}

		public virtual void OnTransformChanged(FTransform NewTransform)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = NewTransform?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnTransformChanged, __InBuffer);
			}
		}

		public virtual void OnSelectionChanged(bool bIsSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsSelected;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnSelectionChanged, __InBuffer);
			}
		}

		public virtual void OnManipulatingChanged(bool bIsManipulating)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsManipulating;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnManipulatingChanged, __InBuffer);
			}
		}

		public virtual void OnHoveredChanged(bool bIsSelected)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsSelected;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnHoveredChanged, __InBuffer);
			}
		}

		public virtual void OnEnabledChanged(bool bIsEnabled)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bIsEnabled;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __OnEnabledChanged, __InBuffer);
			}
		}

		public virtual bool IsSelectedInEditor()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsSelectedInEditor, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsHovered()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsHovered, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool IsEnabled()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __IsEnabled, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual FTransform GetGlobalTransform()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetGlobalTransform, __ReturnBuffer);

				return *(FTransform*)__ReturnBuffer;
			}
		}

		private static uint __ActorRootComponent = 0;

		private static uint __StaticMeshComponent = 0;

		private static uint __ControlRigIndex = 0;

		private static uint __ControlRig = 0;

		private static uint __ControlName = 0;

		private static uint __ShapeName = 0;

		private static uint __ColorParameterName = 0;

		private static uint __bSelected = 0;

		private static uint __bHovered = 0;

		private static uint __SetSelected = 0;

		private static uint __SetSelectable = 0;

		private static uint __SetHovered = 0;

		private static uint __SetGlobalTransform = 0;

		private static uint __SetEnabled = 0;

		private static uint __OnTransformChanged = 0;

		private static uint __OnSelectionChanged = 0;

		private static uint __OnManipulatingChanged = 0;

		private static uint __OnHoveredChanged = 0;

		private static uint __OnEnabledChanged = 0;

		private static uint __IsSelectedInEditor = 0;

		private static uint __IsHovered = 0;

		private static uint __IsEnabled = 0;

		private static uint __GetGlobalTransform = 0;
	}
}
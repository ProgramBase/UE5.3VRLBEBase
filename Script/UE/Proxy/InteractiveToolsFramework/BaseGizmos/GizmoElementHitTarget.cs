using Script.CoreUObject;
using Script.Library;

namespace Script.InteractiveToolsFramework
{
	[PathName("/Script/InteractiveToolsFramework.GizmoElementHitTarget")]
	public partial class UGizmoElementHitTarget : UObject, IStaticClass, IGizmoClickTarget
	{
		public UGizmoElementBase GizmoElement
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoElement, __ReturnBuffer);

					return *(UGizmoElementBase*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoElement, __InBuffer);
				}
			}
		}

		public UGizmoViewContext GizmoViewContext
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoViewContext, __ReturnBuffer);

					return *(UGizmoViewContext*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoViewContext, __InBuffer);
				}
			}
		}

		public UTransformProxy GizmoTransformProxy
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoTransformProxy, __ReturnBuffer);

					return *(UTransformProxy*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __GizmoTransformProxy, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/InteractiveToolsFramework.GizmoElementHitTarget");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void UpdateInteractingState(bool bInteracting)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bInteracting;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateInteractingState, __InBuffer);
			}
		}

		public virtual void UpdateHoverState(bool bHovering)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[1];

				*(bool*)(__InBuffer) = bHovering;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __UpdateHoverState, __InBuffer);
			}
		}

		/// <param name="EntryPoint">
		/// The entry point to start code execution at.
		/// </param>
		public override void ExecuteUbergraph(int EntryPoint)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = EntryPoint;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ExecuteUbergraph, __InBuffer);
			}
		}

		private static uint __GizmoElement = 0;

		private static uint __GizmoViewContext = 0;

		private static uint __GizmoTransformProxy = 0;

		private static uint __UpdateInteractingState = 0;

		private static uint __UpdateHoverState = 0;

		private static uint __ExecuteUbergraph = 0;
	}
}
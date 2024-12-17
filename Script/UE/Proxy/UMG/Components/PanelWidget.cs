using Script.CoreUObject;
using Script.Library;

namespace Script.UMG
{
	[PathName("/Script/UMG.PanelWidget")]
	public partial class UPanelWidget : UWidget, IStaticClass
	{
		public TArray<UPanelSlot> Slots
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Slots, __ReturnBuffer);

					return *(TArray<UPanelSlot>*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Slots, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/UMG.PanelWidget");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual bool RemoveChildAt(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveChildAt, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		/// <returns>
		/// true if the widget was found and removed.
		/// </returns>
		public virtual bool RemoveChild(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __RemoveChild, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasChild(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __HasChild, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual bool HasAnyChildren()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __HasAnyChildren, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual int GetChildrenCount()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall9Implementation(GarbageCollectionHandle, __GetChildrenCount, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		public virtual int GetChildIndex(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[4];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetChildIndex, __InBuffer, __ReturnBuffer);

				return *(int*)__ReturnBuffer;
			}
		}

		/// <param name="Index">
		/// The index of the widget.
		/// </param>
		/// <returns>
		/// The widget at the given index, or nothing if there is no widget there.
		/// </returns>
		public virtual UWidget GetChildAt(int Index)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[4];

				*(int*)(__InBuffer) = Index;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetChildAt, __InBuffer, __ReturnBuffer);

				return *(UWidget*)__ReturnBuffer;
			}
		}

		public virtual TArray<UWidget> GetAllChildren()
		{
			unsafe
			{
				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall9Implementation(GarbageCollectionHandle, __GetAllChildren, __ReturnBuffer);

				return *(TArray<UWidget>*)__ReturnBuffer;
			}
		}

		public virtual void ClearChildren()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __ClearChildren);
			}
		}

		public virtual UPanelSlot AddChild(UWidget Content)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Content?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __AddChild, __InBuffer, __ReturnBuffer);

				return *(UPanelSlot*)__ReturnBuffer;
			}
		}

		private static uint __Slots = 0;

		private static uint __RemoveChildAt = 0;

		private static uint __RemoveChild = 0;

		private static uint __HasChild = 0;

		private static uint __HasAnyChildren = 0;

		private static uint __GetChildrenCount = 0;

		private static uint __GetChildIndex = 0;

		private static uint __GetChildAt = 0;

		private static uint __GetAllChildren = 0;

		private static uint __ClearChildren = 0;

		private static uint __AddChild = 0;
	}
}
using Script.CoreUObject;
using Script.Library;
using Script.SlateCore;

namespace Script.ToolMenus
{
	[PathName("/Script/ToolMenus.ToolMenuEntryScript")]
	public partial class UToolMenuEntryScript : UObject, IStaticClass
	{
		public FToolMenuEntryScriptData Data
		{
			get
			{
				unsafe
				{
					var __ReturnBuffer = stackalloc byte[8];

					FPropertyImplementation.FProperty_GetObjectPropertyImplementation(GarbageCollectionHandle, __Data, __ReturnBuffer);

					return *(FToolMenuEntryScriptData*)__ReturnBuffer;
				}
			}

			set
			{
				unsafe
				{
					var __InBuffer = stackalloc byte[8];

					*(nint*)__InBuffer = value?.GarbageCollectionHandle ?? nint.Zero;

					FPropertyImplementation.FProperty_SetObjectPropertyImplementation(GarbageCollectionHandle, __Data, __InBuffer);
				}
			}
		}

		public new static UClass StaticClass()
		{
			return StaticClassSingleton ??= UObjectImplementation.UObject_StaticClassImplementation("/Script/ToolMenus.ToolMenuEntryScript");
		}

		private static UClass StaticClassSingleton { get; set; }

		public virtual void RegisterMenuEntry()
		{
			unsafe
			{
				FFunctionImplementation.FFunction_GenericCall8Implementation(GarbageCollectionHandle, __RegisterMenuEntry);
			}
		}

		public virtual bool IsVisible(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __IsVisible, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		public virtual void InitEntry(FName OwnerName, FName Menu, FName Section, FName Name, FText Label = null, FText ToolTip = null)
		{
			unsafe
			{
				Label ??= new FText("");

				ToolTip ??= new FText("");

				var __InBuffer = stackalloc byte[48];

				*(nint*)(__InBuffer) = OwnerName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = Menu?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Section?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 24) = Name?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 32) = Label?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 40) = ToolTip?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall10Implementation(GarbageCollectionHandle, __InitEntry, __InBuffer);
			}
		}

		public virtual FText GetToolTip(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetToolTip, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual FText GetLabel(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetLabel, __InBuffer, __ReturnBuffer);

				return *(FText*)__ReturnBuffer;
			}
		}

		public virtual FScriptSlateIcon GetIcon(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[8];

				FFunctionImplementation.FFunction_CompoundCall11Implementation(GarbageCollectionHandle, __GetIcon, __InBuffer, __ReturnBuffer);

				return *(FScriptSlateIcon*)__ReturnBuffer;
			}
		}

		public virtual ECheckBoxState GetCheckState(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __GetCheckState, __InBuffer, __ReturnBuffer);

				return *(ECheckBoxState*)__ReturnBuffer;
			}
		}

		public virtual void Execute(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __Execute, __InBuffer);
			}
		}

		public virtual void ConstructMenuEntry(UToolMenu Menu, FName SectionName, FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[24];

				*(nint*)(__InBuffer) = Menu?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 8) = SectionName?.GarbageCollectionHandle ?? nint.Zero;

				*(nint*)(__InBuffer + 16) = Context?.GarbageCollectionHandle ?? nint.Zero;

				FFunctionImplementation.FFunction_GenericCall2Implementation(GarbageCollectionHandle, __ConstructMenuEntry, __InBuffer);
			}
		}

		public virtual bool CanExecute(FToolMenuContext Context)
		{
			unsafe
			{
				var __InBuffer = stackalloc byte[8];

				*(nint*)(__InBuffer) = Context?.GarbageCollectionHandle ?? nint.Zero;

				var __ReturnBuffer = stackalloc byte[1];

				FFunctionImplementation.FFunction_PrimitiveCall11Implementation(GarbageCollectionHandle, __CanExecute, __InBuffer, __ReturnBuffer);

				return *(bool*)__ReturnBuffer;
			}
		}

		private static uint __Data = 0;

		private static uint __RegisterMenuEntry = 0;

		private static uint __IsVisible = 0;

		private static uint __InitEntry = 0;

		private static uint __GetToolTip = 0;

		private static uint __GetLabel = 0;

		private static uint __GetIcon = 0;

		private static uint __GetCheckState = 0;

		private static uint __Execute = 0;

		private static uint __ConstructMenuEntry = 0;

		private static uint __CanExecute = 0;
	}
}